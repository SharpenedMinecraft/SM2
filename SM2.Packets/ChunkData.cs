using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.Server;
using SM2.Dimensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using System.IO;
using SM2.Blocks;

namespace SM2.Packets
{
    public class ChunkData : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;

        public override ConnectionSide WritingSide { get; } = ConnectionSide.Server;

        public override VarInt Id { get; } = 0x22;

        [AutoSerialize(0)]
        public int ChunkX;
        [AutoSerialize(1)]
        public int ChunkZ;
        [AutoSerialize(2)]
        public bool GroundUpContinous;
        [AutoSerialize(4)]
        [NoLength]
        public byte[] Data;
        // TODO: Implement NBT Entities

        const int CHUNK_HEIGHT = Chunk.ChunkSizeY;
        const int SECTION_HEIGHT = Chunk.SectionHeight;
        const int SECTION_WIDTH = Chunk.ChunkSizeX; // or ChunkSizeZ it doesnt matter
        const int SECTION_DEPTH = Chunk.ChunkSizeZ;
        public override async Task PreWrite()
        {
            if (!GroundUpContinous)
                throw new NotImplementedException("Ouuh, pls no");

            var chunkPos = new Vector2(ChunkX, ChunkZ);
            logger.Debug($"Writing ChunkData {ChunkX}, {ChunkZ}");
            var uByte = _ctx.Provider.GetService<ITypeAccessor<Byte>>();
            var VarInt = _ctx.Provider.GetService<ITypeAccessor<VarInt>>();
            var Int = _ctx.Provider.GetService<ITypeAccessor<int>>();
            var chunk = _ctx.Player.Dimension.GetChunk(chunkPos);

            using (var output = new MemoryStream())
            {
                var data = new MemoryStream();
                int mask = 0;
                for (int sectionY = 0; sectionY < SECTION_HEIGHT; sectionY++)
                {
                    var v = chunk[sectionY];
                    if (v.AnyOther<Air>())
                    {
                        // Mask
                        mask |= (1 << sectionY);

                        // Actual Chunk Section Writing
                        WriteChunkSection(v, ref data);
                        // Log($"Wrote {ChunkX}, {sectionY}, {ChunkZ} Section");
                    }
                    else; 
                        // Log($"Section {ChunkX}, {sectionY}, {ChunkZ} Was Empty");
                }

                int[] biomes = new int[256];
                if (GroundUpContinous) //Also write Biomes
                {
                    for (int z = 0; z < SECTION_WIDTH; z++)
                    {
                        for (int x = 0; x < SECTION_WIDTH; x++)
                        {
                            biomes[z * 16 | x] = 127;
                        }
                    }
                }
                Int.WriteArray(data, biomes);

                VarInt.Write(output, mask);
                var dataBytes = data.ToArray();
                // Console.WriteLine("Total Data: " + data.Length + "/" + dataBytes.Length);
                data.Dispose();
                VarInt.Write(output, dataBytes.Length);
                uByte.WriteArray(output, dataBytes);

                // TODO: Support Block Entities
                VarInt.Write(output, 0); //We dont Support Block Entities yet

                Data = output.ToArray();
            }
        }
        public const byte FULL_SIZE_BITS_PER_BLOCK = 14;
        private void WriteChunkSection(ChunkSection section, ref MemoryStream stream)
        {
            var uByte = _ctx.Provider.GetService<ITypeAccessor<Byte>>();
            var VarInt = _ctx.Provider.GetService<ITypeAccessor<VarInt>>();
            var Int = _ctx.Provider.GetService<ITypeAccessor<int>>();
            var ULong = _ctx.Provider.GetService<ITypeAccessor<ulong>>();

            #region Section
            byte bitsPerBlock = FULL_SIZE_BITS_PER_BLOCK;

            uByte.Write(stream, bitsPerBlock);

            // A bitmask that contains bitsPerBlock set bits
            uint individualValueMask = (uint)((1 << bitsPerBlock) - 1);

            int dataLength = (SECTION_HEIGHT * SECTION_WIDTH * SECTION_DEPTH) * bitsPerBlock / 64;
            UInt64[] DataArray = new UInt64[dataLength];

            for (int y = 0; y < SECTION_HEIGHT; y++)
            {
                for (int z = 0; z < SECTION_WIDTH; z++)
                {
                    for (int x = 0; x < SECTION_WIDTH; x++)
                    {
                        var blockPos = new Position(x, y, z);

                        int blockNumber = ((((int)blockPos.Y * SECTION_HEIGHT) + (int)blockPos.Z) * SECTION_WIDTH) + (int)blockPos.X;
                        int startLong = (blockNumber * bitsPerBlock) / 64;
                        int startOffset = (blockNumber * bitsPerBlock) % 64;
                        int endLong = ((blockNumber + 1) * bitsPerBlock - 1) / 64;

                        var state = section[blockPos];

                        // C# Still limits the Byte Size to uint if this is a uint,
                        // even after byteshifting into a ulong
                        ulong value = (ulong)state.GetState();
                        value &= individualValueMask;

                        DataArray[startLong] |= (value << startOffset);

                        if (startLong != endLong)
                        {
                            DataArray[endLong] = (value >> (64 - startOffset));
                        }
                    }
                }
            }

            // Console.WriteLine($"Data Array was {DataArray.Length} long");
            VarInt.Write(stream, dataLength);
            ULong.WriteArray(stream, DataArray);

            List<byte> BlockLightData = new List<byte>();
            for (int y = 0; y < SECTION_HEIGHT; y++)
            {
                for (int z = 0; z < SECTION_WIDTH; z++)
                {
                    for (int x = 0; x < SECTION_WIDTH; x += 2)
                    {
                        // Note: x += 2 above; we read 2 values along x each time
                        byte blocklight1 = /*(byte)(section[new Position(x, y, z)].BlockLight*/12/*)*/;
                        //this only works because 16 is even
                        byte blocklight2 = /*(byte)(section[new Position(x + 1, y, z)].BlockLight*/12 << 4/*)*/;
                        byte value = (byte)(blocklight1 | blocklight2);
                        BlockLightData.Add(value);
                    }
                }
            }
            // Console.WriteLine($"BlockLight was {BlockLightData.Count} Long");
            uByte.WriteArray(stream, BlockLightData.ToArray());

            List<byte> SkyLightData = new List<byte>();
            if (/* section.HasSkylight */ true)
            { // => current dimension is overworld / 0
                for (int y = 0; y < SECTION_HEIGHT; y++)
                {
                    for (int z = 0; z < SECTION_WIDTH; z++)
                    {
                        for (int x = 0; x < SECTION_WIDTH; x += 2)
                        {
                            // Note: x += 2 above; we read 2 values along x each time
                            byte blocklight1 = /*(byte)(section[new Position(x, y, z)].BlockLight*/12/*)*/;
                            //this only works because 16 is even
                            byte blocklight2 = /*(byte)(section[new Position(x + 1, y, z)].BlockLight*/12 << 4/*)*/;
                            byte value = (byte)(blocklight1 | blocklight2);
                            SkyLightData.Add(value);
                        }
                    }
                }
            }
            // Console.WriteLine($"SkyLight was {SkyLightData.Count} Long");
            uByte.WriteArray(stream, SkyLightData.ToArray());
            #endregion
        }
    }
}
