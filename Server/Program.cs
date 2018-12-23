using System;
using System.Net;
using System.Threading.Tasks;

namespace Server
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome! Starting Server");

            using (var server = new MainServer(IPAddress.Any, 25565))
            {
                server.Start();
                await Task.Delay(-1);
            }
        }
    }
}
