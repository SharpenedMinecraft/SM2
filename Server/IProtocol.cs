using System.Threading.Tasks;
using Base;

namespace Server
{
    public interface IProtocol
    {
        IPacket GetPacket(int id, bool clientBound, RemoteClient client);

        int GetProtocolId();

        string GetLabel();

        string GetUserFriendlyVersion();

        Task GetKeepAliveTask(RemoteClient client);

        IPacket GetLoadChunkPacket(Chunk c);
    }
}