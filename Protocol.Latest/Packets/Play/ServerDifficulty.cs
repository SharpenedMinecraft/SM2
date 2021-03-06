﻿using System;
using System.IO;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class ServerDifficulty : IPacket
    {
        public int Id => 0x0D;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => true;

        public Task Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            NetworkUtils.WriteByte(stream, (byte)client.Player.Dimension.Difficulty);
            return Task.CompletedTask;
        }
    }
}
