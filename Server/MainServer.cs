using Base;
using Entities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class MainServer : IDisposable
    {
        public World World { get; }

        private readonly TcpListener _listener;
        private readonly CancellationTokenSource _cts;
        private readonly IProtocol _protocol;
        private Task _listenerTask;
        private List<RemoteClient> _clients = new List<RemoteClient>();

        public MainServer(IProtocol protocol, IPAddress filter, int port) 
        {
            _protocol = protocol;
            _listener = new TcpListener(filter, port);
            _cts = new CancellationTokenSource();
            World = new World();
            World.Dimensions[0] = new Dimension(); // Overworld
            World.Dimensions[1] = new Dimension(); // Nether
            World.Dimensions[-1] = new Dimension(); // End
        }

        public void Start()
        {
            _clients.Clear();
            _listener.Start();
            _listenerTask = Task.Run(Listen);
        }

        private async Task Listen()
        {
            while (!_cts.IsCancellationRequested)
            {
                try
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    var player = World.Overworld.CreateEntity<Player>();
                    var remote = new RemoteClient(client, _protocol, _cts.Token);
                    remote.Player = player;
                    _clients.Add(remote);
                    Console.WriteLine("Accepted new Client");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception while Listening: ");
                    Console.WriteLine(ex);
                }
            }
        }

        public void Dispose()
        {
            _cts.Cancel();
            _cts.Dispose();
            _listenerTask.Dispose();
            _listener.Server.Dispose();
        }
    }
}