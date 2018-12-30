﻿using System;
using System.IO;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public class StatusResponse : IPacket
    {
        public System.Int32 Id => 0x00;

        public RemoteClient.ConnectionState DesiredState => RemoteClient.ConnectionState.Status;

        public System.Boolean ClientBound => true;

        public Task Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            NetworkUtils.WriteString(stream,
"{" +
"\"version\": {" +
"\"name\":\"SM2\"," +
$"\"protocol\": {LatestProtocol.ProtocolID}" +
$"}}," +
$"\"players\": {{" +
$"\"max\": {100}," +
$"\"online\": {0}," +
$"\"sample\":[]" +
$"}}," +
$"\"description\": {{" +
$"\"text\": \"Powered by SM2 Alpha; expect bugs!\"" +
$"}}" +
$"}}");
            return Task.CompletedTask;
        }
    }
}