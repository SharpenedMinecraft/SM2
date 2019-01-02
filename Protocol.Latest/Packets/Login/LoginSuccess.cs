using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Serilog;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class LoginSuccess : IPacket
    {
        public int Id => 0x02;

        public ConnectionState DesiredState => ConnectionState.Login;

        public bool Clientbound => true;

        public Task Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public async Task Write(Stream stream, RemoteClient client)
        {
            client.Player.UUID = await GetUUID(client.Player);

            await NetworkUtils.WriteString(stream, client.Player.UUID.ToString());
            await NetworkUtils.WriteString(stream, client.Player.Username);

            client.State = ConnectionState.Play;

            LatestProtocol.QueueLoginSequence(client);
        }

        private async Task<Guid> GetUUID(Player p)
        {
            Guid u;

            using (var wc = new HttpClient())
            {
                var requestResult = await wc.PostAsync(
                    $"https://api.mojang.com/profiles/minecraft",
                    new StringContent("[ \"" + p.Username + "\"]", Encoding.UTF8, "application/json"));
                if (!requestResult.IsSuccessStatusCode)
                    throw new Exception(requestResult.ReasonPhrase);
                var fullResult = await requestResult.Content.ReadAsStringAsync();
                var result = fullResult.Split('"');
                if (result.Length > 1)
                {
                    var uuid = result[3];
                    u = new Guid(uuid);
                }
                else
                {
                    Log.Error($"Coudnt get UUID for {p.Username}");
                    u = Guid.NewGuid();
                }
            }

            return u;
        }
    }
}
