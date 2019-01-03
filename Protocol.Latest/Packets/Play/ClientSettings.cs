using System;
using System.IO;
using System.Threading.Tasks;
using Entities;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class ClientSettings : IPacket
    {
        public int Id => 0x04;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => false;

        public async Task Read(Stream stream, RemoteClient client)
        {
            client.Player.Settings = new PlayerSettings(
                await NetworkUtils.ReadString(stream),
                NetworkUtils.ReadByte(stream),
                (ChatMode)NetworkUtils.ReadVarInt(stream),
                NetworkUtils.ReadBool(stream),
                (DisplayedSkinParts)NetworkUtils.ReadByte(stream),
                (MainHand)NetworkUtils.ReadVarInt(stream));

            if (client.IsPerformingLoginSequence)
                LatestProtocol.QueueLoginSequencePart2(cleint);
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
