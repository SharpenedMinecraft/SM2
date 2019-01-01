using Base;
using System.IO;
using System.Threading.Tasks;
using static Server.RemoteClient;

namespace Server
{
    public interface IPacket
    {
        int Id { get; }
        ConnectionState DesiredState { get; }

        bool Clientbound { get; }

        Task Read(Stream stream, RemoteClient client);
        Task Write(Stream stream, RemoteClient client);
    }
}