using Base;
using Entities;
using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    internal class MainServer : IDisposable
    {
        private readonly TcpListener _listener;
        private readonly CancellationTokenSource _cts;
        private Task _listenTask;
        public World World { get; }

        public MainServer(IPAddress filter, int port)
        {
            _listener = new TcpListener(filter, port);
            _cts = new CancellationTokenSource();
            World = new World();
            World.Dimensions[0] = new Dimension(); // Overworld
            World.Dimensions[1] = new Dimension(); // Nether
            World.Dimensions[-1] = new Dimension(); // End
        }

        public void Start()
        {
            _listener.Start();
            _listenTask = Listen();
        }

        private async Task Listen()
        {
            while (!_cts.IsCancellationRequested)
            {
                var client = await _listener.AcceptTcpClientAsync();
                HandleClient(client);
            }
        }

        private void HandleClient(TcpClient client)
        {
            Console.WriteLine("Accepted new Connection");
            var player = World.Overworld.CreateEntity<Player>();
            var remote = new RemoteClient(client, _cts.Token);
            remote.Player = player;
        }

        public void Dispose()
        {
            _cts.Cancel();
            _cts.Dispose();
            _listenTask?.Dispose();
        }
    }
}