using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using Base;
using Blocks;
using Protocol.Latest;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using Server;
using WorldGenerators;

namespace ServerExecutable
{
    public static class Program
    {
#pragma warning disable RCS1163 // Unused parameter.
        public static async Task Main(string[] args)
#pragma warning restore RCS1163 // Unused parameter.
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
            World.BlockManager = new BlockManager();
            using (var server = new MainServer(new LatestProtocol(), IPAddress.Any, 25565))
            {
                Log.Information("Loading World...");
                server.World.AttachDimension(PrepareNether(), -1);
                server.World.AttachDimension(PrepareOverworld(), 0);
                server.World.AttachDimension(PrepareEnd(), 1);
                Log.Information("Loaded World!");

                Log.Information("Welcome! Starting Server!");

                server.Start();
                await Task.Delay(-1).ConfigureAwait(false);
            }
        }

        private static Dimension PrepareNether()
        {
            var v = new Dimension(new VoidWorldGenerator());

            Log.Information("Preparing Chunks in Nether");
            var stopwatch = Stopwatch.StartNew();
            PreGenerateDimensions(v);
            stopwatch.Stop();
            Log.Information($"Prepared Nether in {stopwatch.ElapsedMilliseconds}ms");

            return v;
        }

        private static Dimension PrepareEnd()
        {
            var v = new Dimension(new VoidWorldGenerator());

            Log.Information("Preparing Chunks in End");
            var stopwatch = Stopwatch.StartNew();
            PreGenerateDimensions(v);
            stopwatch.Stop();
            Log.Information($"Prepared End in {stopwatch.ElapsedMilliseconds}ms");

            return v;
        }

        private static Dimension PrepareOverworld()
        {
            var v = new Dimension(new VoidWorldGenerator());
            v.HasSkylight = true;

            Log.Information("Preparing Chunks in Overworld");
            var stopwatch = Stopwatch.StartNew();
            PreGenerateDimensions(v);
            stopwatch.Stop();
            Log.Information($"Prepared Overworld in {stopwatch.ElapsedMilliseconds}ms");

            return v;
        }

        private static void PreGenerateDimensions(Dimension v)
        {
            for (int x = -3; x < 3; x++)
            {
                for (int z = -3; z < 3; z++)
                {
                    Log.Information($"Generating Chunk at {x}, {z}");
                    v[new ChunkPosition(x, z)].ToString(); // This will pre-generate the Chunk.
                }
            }
        }
    }
}
