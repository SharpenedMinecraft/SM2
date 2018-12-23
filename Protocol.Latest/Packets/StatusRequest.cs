using Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using static Server.RemoteClient;

namespace Protocol.Latest.Packets
{
    public class StatusRequest : IPacket
    {
        public Int32 Id => 0x00;

        public RemoteClient.ConnectionState DesiredState => ConnectionState.Status;

        public Task Handle(Byte[] data, RemoteClient client)
        {
            Console.WriteLine("Status Request");
            // no fields, so no reading

            // answer with response
            return client.Write(stream =>
            {
                NetworkUtils.WriteVarInt(stream, 0x00);
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
            });
        }
    }
}
