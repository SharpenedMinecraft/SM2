namespace Server
{
    public interface IProtocol
    {
        IPacket GetPacket(int id, bool clientBound, RemoteClient client);

        int GetProtocolId();
        string GetLabel();
        string GetUserFriendlyVersion();
    }
}