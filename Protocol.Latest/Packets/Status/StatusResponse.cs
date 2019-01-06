using System;
using System.IO;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class StatusResponse : IPacket
    {
        public int Id => 0x00;

        public ConnectionState DesiredState => ConnectionState.Status;

        public bool Clientbound => true;

        public Task Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public async Task Write(Stream stream, RemoteClient client)
        {
            await NetworkUtils.WriteString(
                stream,
#pragma warning disable SA1118 // Parameter must not span multiple lines
"{" +
"\"version\": {" +
$"\"name\":\"{LatestProtocol.UserFriendlyVersion}\"," +
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
#pragma warning restore SA1118 // Parameter must not span multiple lines
        }
    }
}