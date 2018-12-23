using Server;
using System.Threading.Tasks;

namespace Protocol.Latest
{
    public interface IPacket
    {
        int Id { get; }
        Server.RemoteClient.ConnectionState DesiredState { get; }
        Task Handle(byte[] data, RemoteClient client);
    }
}