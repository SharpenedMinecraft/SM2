﻿using System;
using System.IO;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class Pong : IPacket
    {

        public Int32 Id => 0x01;
        public RemoteClient.ConnectionState DesiredState => RemoteClient.ConnectionState.Status;
        public Boolean Clientbound => true;

        private readonly Int64 _toWrite;


        public Pong(long writeId)
        {
            _toWrite = writeId;
        }

        public Pong() { }

        public Task Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public async Task Write(Stream stream, RemoteClient client)
        {
            await NetworkUtils.WriteLong(stream, _toWrite);
        }
    }
}