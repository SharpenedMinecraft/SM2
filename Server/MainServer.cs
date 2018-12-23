using Base;
using Entities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class MainServer : IDisposable
    {
        public World World { get; }

        public IObservable<RemoteClient> ConnectionAcceptedObservable { get; private set; }

        private readonly TcpListener _listener;
        private readonly CancellationTokenSource _cts;
        private readonly List<ServerExtension> _extensions;
        private bool _started;

        public MainServer(IPAddress filter, int port)
        {
            _listener = new TcpListener(filter, port);
            _cts = new CancellationTokenSource();
            _extensions = new List<ServerExtension>();
            World = new World();
            World.Dimensions[0] = new Dimension(); // Overworld
            World.Dimensions[1] = new Dimension(); // Nether
            World.Dimensions[-1] = new Dimension(); // End
        }

        public void Start()
        {
            _listener.Start();
            ConnectionAcceptedObservable = Observable.Create<RemoteClient>(Listen).ObserveOn(Scheduler.Default).Publish().RefCount();
            _extensions.ForEach((extension) => extension.OnStarted(this));
            _started = true;
        }

        public void AddExtension(ServerExtension extension)
        {
            if (_started) throw new InvalidOperationException("Cannot add new extension after start");

            extension.OnCreated(this);
            _extensions.Add(extension);
        }

        private async Task Listen(IObserver<RemoteClient> observer)
        {
            while (!_cts.IsCancellationRequested)
            {
                try
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    var player = World.Overworld.CreateEntity<Player>();
                    var remote = new RemoteClient(client, _cts.Token);
                    remote.Player = player;
                    observer.OnNext(remote);
                }
                catch (Exception ex)
                {
                    observer.OnError(ex);
                }
            }
            observer.OnCompleted();
        }

        public void Dispose()
        {
            _cts.Cancel();
            _cts.Dispose();
        }
    }
}