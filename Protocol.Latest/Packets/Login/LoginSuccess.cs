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
        public Int32 Id => 0x02;
        public RemoteClient.ConnectionState DesiredState => RemoteClient.ConnectionState.Login;
        public Boolean Clientbound => true;

        public Task Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public async Task Write(Stream stream, RemoteClient client)
        {
            client.Player.UUID = await GetUUID(client.Player);

            await NetworkUtils.WriteString(stream, client.Player.UUID.ToString());
            await NetworkUtils.WriteString(stream, client.Player.Username);

            client.State = RemoteClient.ConnectionState.Play;

            client.Write(new JoinGame());
        }

        private async Task<Guid> GetUUID(Player p)
        {
            Guid u;

            using (var wc = new HttpClient())
            {
                var result = await wc.PostAsync($"https://api.mojang.com/profiles/minecraft",
                    new StringContent("[ \"" + p.Username + "\"]", Encoding.UTF8, "application/json"));
                if (!result.IsSuccessStatusCode)
                    throw new Exception(result.ReasonPhrase);
                var Sresult = await result.Content.ReadAsStringAsync();
                var _result = Sresult.Split('"');
                if (_result.Length > 1)
                {
                    var uuid = _result[3];
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
