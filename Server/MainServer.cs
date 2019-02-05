﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Base;
using Entities;
using Serilog;

namespace Server
{
    public sealed class MainServer : IDisposable
    {
        private readonly TcpListener _listener;
        private readonly CancellationTokenSource _cts;
        private readonly IProtocol _protocol;
        private Task _listenerTask;

        public MainServer(IProtocol protocol, IPAddress filter, int port)
        {
            _protocol = protocol;
            _listener = new TcpListener(filter, port);
            _cts = new CancellationTokenSource();
            World = new World();
            World.OnDimensionCreated += OnDimensionCreated;
            foreach (var dim in World.Dimensions)
                OnDimensionCreated(this, dim);
        }

        public List<RemoteClient> Clients { get; } = new List<RemoteClient>();

        public World World { get; }

        public CancellationToken Token => _cts.Token;

        public void Start()
        {
            Clients.Clear();
            _listener.Start();
            _listenerTask = Task.Run(Listen);
        }

        public void Dispose()
        {
            _cts.Cancel();
            _cts.Dispose();
            _listenerTask.Dispose();
            _listener.Server.Dispose();
        }

        internal void RemoveClient(RemoteClient client)
            => Clients.Remove(client);

        private void OnDimensionCreated(object sender, Dimension e)
        {
            foreach (var system in _protocol.Systems)
            {
                Task.Run(async () =>
                {
                    while (!_cts.IsCancellationRequested)
                    {
                        try
                        {
                            await system.Tick(e, this);
                            await Task.Delay((int)((1f / system.TimesPerSecond) * 1000));
                        }
                        catch (Exception ex)
                        {
                            Log.Error($"System {system.Name} threw Exception: \n{ex.Message}");
                        }
                    }
                });
            }
        }

        private async Task Listen()
        {
            while (!_cts.IsCancellationRequested)
            {
                try
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    var player = World.Overworld.CreateEntity<Player>(new EntityTransform()
                    {
                        OnGround = true,
                        X = 0,
                        Y = 10,
                        Z = 0,
                        Yaw = 0,
                        Pitch = 0
                    });
                    var remote = new RemoteClient(client, _protocol, this)
                    {
                        Player = player
                    };
                    remote.StartProcessing();
                    Clients.Add(remote);
                    Log.Information("Accepted new Client");
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Exception while Listening");
                }
            }
        }
    }
}