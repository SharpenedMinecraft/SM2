using System;
using System.Net;
using System.Threading.Tasks;
using Protocol.Latest;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using Server;

namespace ServerExecutable
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
#if DEBUG
                .MinimumLevel.Debug()
#else
                .MinimumLevel.Information()
#endif
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
