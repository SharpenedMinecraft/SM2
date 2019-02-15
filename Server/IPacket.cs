using System.IO;
using System.Threading.Tasks;
using Base;
using static Server.RemoteClient;

namespace Server
{
    public interface IPacket
    {
        int Id { get; }

        ConnectionState DesiredState { get; }

        bool Clientbound { get; }

        void Read(Stream stream, RemoteClient client);

        void Write(Stream stream, RemoteClient client);
    }
}