﻿using System;
using System.IO;
using System.Threading.Tasks;
using Base;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class TeleportConfirm : IPacket
    {
        public int Id => 0x00;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => false;

        public void Read(Stream stream, RemoteClient client)
        {
            var id = NetworkUtils.ReadVarInt(stream);
            TeleportManager.AcceptId(client.Player, id);
        }

        public void Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
