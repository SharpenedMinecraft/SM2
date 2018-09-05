using SM2.Core.BaseTypes;
using System.Threading.Tasks;

namespace SM2.Core.BaseTypes.Abstractions
{
    public interface IPacket
    {
        ConnectionState RequiredState { get; }
        ConnectionSide WritingSide { get; }
        VarInt Id { get; }

        Task PreWrite();
        Task PostWrite();

        Task PreRead();
        Task PostRead();
    }
}