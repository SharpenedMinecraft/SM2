using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;
using Protocol.Latest.Packets;
using Server;

namespace Protocol.Latest.Systems
{
    // TODO: Does this really belong here? (Systems)
    // Or should it go into a new Project?
    public class BlockBatchingSystem : ITickSystem
    {
        public string Name => "Block Batching System";

        public float TimesPerSecond => 20f;

        public Task Tick(Dimension dimension, MainServer server)
            => Task.Run(() => TickSync(dimension, server));

        private void TickSync(Dimension dimension, MainServer server)
        {
            var groups =
            from client1 in server.Clients.ToArray()
            where client1.State == ConnectionState.Play
            from chunk1 in client1.LoadedChunks
            group client1 by chunk1 into g
            select g;

            foreach (var chunk in dimension.Chunks)
            {
                if (!chunk.Sections.Any(x => x.DirtyBlocks.Count > 0))
                    continue;

                var dirtyBlocks = chunk.Sections.SelectMany((section, i)
                    => section.DirtyBlocks.Select((block)
                        => Tuple.Create(block, i)));
                foreach (var(dirtyBlock, section) in dirtyBlocks)
                {
                    // note, these are relative to the *chunk section*
                    var pos = new BlockPosition(
                        (chunk.Position.X * 16) + dirtyBlock.Position.X,
                        (section * 16) + dirtyBlock.Position.Y,
                        (chunk.Position.Z * 16) + dirtyBlock.Position.Z);
                    groups.FirstOrDefault(x => x.Key == chunk)?.Broadcast(new BlockChange()
                    {
                        GlobalPosition = pos,
                        NewState = dirtyBlock.NewState
                    });
                }

                // clear DirtyBlocks
                foreach (var section in chunk.Sections)
                    section.DirtyBlocks.Clear();
            }
        }
    }
}
