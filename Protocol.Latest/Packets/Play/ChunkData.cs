using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Base;
using Serilog;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class ChunkData : IPacket
    {
        public const byte FULL_SIZE_BITS_PER_BLOCK = 14;
        private const int SectionHeight = ChunkSection.Height;
        private const int SectionWidth = ChunkSection.Width;
        private const int SectionDepth = ChunkSection.Depth;

        private readonly Chunk _chunk;

        public ChunkData() { }

        public ChunkData(Chunk chunk)
        {
            _chunk = chunk;
        }

        public int Id => 0x22;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => true;

        public void Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public void Write(Stream stream, RemoteClient client)
        {
            // Log.Debug($"Writing ChunkData {_chunk.Position.X}, {_chunk.Position.Z}");
            NetworkUtils.WriteInt(stream, _chunk.Position.X);
            NetworkUtils.WriteInt(stream, _chunk.Position.Z);
            NetworkUtils.WriteBool(stream, true);

            using (var data = new MemoryStream())
            {
                int mask = 0;
                for (int sectionY = 0; sectionY < SectionHeight; sectionY++)
                {
                    var v = _chunk[sectionY];
                    if (!v.IsEmpty())
                    {
                        // Log.Debug("Writing Section " + sectionY);

                        // Mask
                        mask |= 1 << sectionY;

                        // Actual Chunk Section Writing
                        WriteChunkSection(v, data);
                    }
                }

                int[] biomes = new int[256];
                for (int z = 0; z < SectionWidth; z++)
                {
                    for (int x = 0; x < SectionWidth; x++)
                    {
                        biomes[z * 16 | x] = 127;
                    }
                }

                NetworkUtils.WriteArray(data, biomes, NetworkUtils.WriteInt);

                NetworkUtils.WriteVarInt(stream, mask);

                NetworkUtils.WriteVarInt(stream, (int)data.Position);
                data.Position = 0;
                data.CopyTo(stream);
            }

            // Block Entities
            NetworkUtils.WriteVarInt(stream, 0);
        }

        private void WriteChunkSection(ChunkSection section, MemoryStream stream)
        {
            NetworkUtils.WriteByte(stream, FULL_SIZE_BITS_PER_BLOCK);

            // A bitmask that contains bitsPerBlock set bits
            const ulong individualValueMask = (1 << FULL_SIZE_BITS_PER_BLOCK) - 1;

            const int ulongBitSize = 64;

            int dataLength = (SectionHeight * SectionWidth * SectionDepth) * FULL_SIZE_BITS_PER_BLOCK / ulongBitSize;
            ulong[] dataArray = new ulong[dataLength];

            for (int y = 0; y < SectionHeight; y++)
            {
                for (int z = 0; z < SectionWidth; z++)
                {
                    for (int x = 0; x < SectionWidth; x++)
                    {
                        int blockNumber = (((y * SectionHeight) + z) * SectionWidth) + x;
                        int startLong = (blockNumber * FULL_SIZE_BITS_PER_BLOCK) / ulongBitSize;
                        int startOffset = (blockNumber * FULL_SIZE_BITS_PER_BLOCK) % ulongBitSize;
                        int endLong = (((blockNumber + 1) * FULL_SIZE_BITS_PER_BLOCK) - 1) / ulongBitSize;

                        // C# Still limits the Byte Size to uint if this is a uint,
                        // even after byteshifting into a ulong
                        ulong value = (ulong)section.GetStateId(x, y, z);
                        value &= individualValueMask;

                        dataArray[startLong] |= value << startOffset;

                        if (startLong != endLong)
                        {
                            dataArray[endLong] = value >> (ulongBitSize - startOffset);
                        }
                    }
                }
            }

            // Log.Debug($"Data Array was {dataArray.Length}/{dataLength} long");
            NetworkUtils.WriteVarInt(stream, dataLength);
            NetworkUtils.WriteArray(stream, dataArray, NetworkUtils.WriteULong);

            for (int y = 0; y < SectionHeight; y++)
            {
                for (int z = 0; z < SectionWidth; z++)
                {
                    for (int x = 0; x < SectionWidth; x += 2)
                    {
                        // Note: x += 2 above; we read 2 values along x each time
                        byte blocklight1 = (byte)section.GetBlockLight(x, y, z);

                        byte blocklight2 = (byte)(section.GetBlockLight(x + 1, y, z) << 4);
                        byte value = (byte)(blocklight1 | blocklight2);
                        NetworkUtils.WriteByte(stream, value);
                    }
                }
            }

            if (_chunk.Dimension.HasSkylight)
            {
                for (int y = 0; y < SectionHeight; y++)
                {
                    for (int z = 0; z < SectionWidth; z++)
                    {
                        for (int x = 0; x < SectionWidth; x += 2)
                        {
                            // Note: x += 2 above; we read 2 values along x each time
                            byte blocklight1 = (byte)section.GetSkyLight(x, y, z);

                            byte blocklight2 = (byte)(section.GetSkyLight(x + 1, y, z) << 4);
                            byte value = (byte)(blocklight1 | blocklight2);
                            NetworkUtils.WriteByte(stream, value);
                        }
                    }
                }
            }
        }
    }
}
