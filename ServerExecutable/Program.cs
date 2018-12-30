using Protocol.Latest;
using Serilog;
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
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.RollingFile("./logs/{Date}.log")
                .CreateLogger();
            using (var server = new MainServer(new LatestProtocol(), IPAddress.Any, 25565))
            {
                Log.Information("Welcome! Starting Server!");
                
                server.Start();
                await Task.Delay(-1);
            }
        }
    }
}
