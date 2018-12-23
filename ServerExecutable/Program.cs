using Protocol.Latest;
using Server;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ServerExecutable
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var server = new MainServer(IPAddress.Any, 25565))
            {
                Console.WriteLine("Welcome! Starting Server!");

                server.AddExtension(new LatestProtocol());
                server.Start();
                await Task.Delay(-1);
            }
        }
    }
}
