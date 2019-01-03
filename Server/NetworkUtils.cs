using System;
using System.Buffers.Binary;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Server
{
    public static class NetworkUtils
    {
        public static void WriteVarInt(Stream stream, int val)
        {
            var size = 0;
            var v = val;
            while ((v & -0x80) != 0)
            {
                if (size > 5)
                    throw new IOException("VarInt too long, its just, i can't handle that");

                stream.WriteByte((byte)(v & 0x7F | 0x80));
                v = (int)(((uint)v) >> 7);
                size++;
            }

            stream.WriteByte((byte)v);
        }

        public static async ValueTask WriteString(Stream stream, string val)
        {
            var bytes = Encoding.UTF8.GetBytes(val);
            WriteVarInt(stream, bytes.Length);
            if (bytes.Length > 0)
                await stream.WriteAsync(bytes, 0, bytes.Length);
        }

        public static void WriteBool(Stream stream, bool val)
            => WriteByte(stream, val ? (byte)0x01 : (byte)0x00);

        public static void WriteByte(Stream stream, byte val)
        {
            stream.WriteByte(val);
        }

        public static async ValueTask WriteUShort(Stream stream, ushort val)
        {
            Memory<byte> buff = new byte[2];
            BinaryPrimitives.WriteUInt16BigEndian(buff.Span, val);
            await stream.WriteAsync(buff);
        }

        public static async ValueTask WriteInt(Stream stream, int val)
        {
            Memory<byte> buff = new byte[4];
            BinaryPrimitives.WriteInt32BigEndian(buff.Span, val);
            await stream.WriteAsync(buff);
        }

        public static async ValueTask WriteLong(Stream stream, long val)
        {
            Memory<byte> buff = new byte[8];
            BinaryPrimitives.WriteInt64BigEndian(buff.Span, val);
            await stream.WriteAsync(buff);
        }

        public static ValueTask WriteBlockPosition(Stream stream, BlockPosition pos)
            => WriteLong(stream, ((((long)pos.X) & 0x3FFFFFF) << 38) | ((((long)pos.Y) & 0xFFF) << 26) | (((long)pos.Z) & 0x3FFFFFF));

        public static ValueTask WriteFloat(Stream stream, float val)
        {
            var v = BitConverter.SingleToInt32Bits(val);
            if (BitConverter.IsLittleEndian)
                v = BinaryPrimitives.ReverseEndianness(v);
            return WriteInt(stream, v);
        }

        public static int ReadVarInt(Stream stream)
        {
            var val = 0;
            var size = 0;
            int readData;
            while (((readData = stream.ReadByte()) & 0x80) == 0x80)
            {
                if (readData == -1)
                    throw new EndOfStreamException();

                val |= (readData & 0x7F) << (size++ * 7);
                if (size > 5)
                {
                    throw new IOException("VarInt too long. Hehe that's punny.");
                }
            }

            return val | ((readData & 0x7F) << (size * 0x7));
        }

        public static async ValueTask<string> ReadString(Stream stream)
        {
            var length = ReadVarInt(stream);
            Memory<byte> buff = new byte[length];
            await stream.ReadAsync(buff);
            return Encoding.UTF8.GetString(buff.Span);
        }

        public static bool ReadBool(Stream stream)
        {
            var b = ReadByte(stream);
            if (b == 0x01)
                return true;
            if (b == 0x00)
                return false;
            throw new InvalidDataException("boolean can only be 0x00 or 0x01");
        }

        public static byte ReadByte(Stream stream)
        {
            var i = stream.ReadByte();
            if (i == -1)
                throw new EndOfStreamException();
            return (byte)i;
        }

        public static async ValueTask<ushort> ReadUShort(Stream stream)
        {
            Memory<byte> buff = new byte[2];
            await stream.ReadAsync(buff);
            return BinaryPrimitives.ReadUInt16BigEndian(buff.Span);
        }

        public static async ValueTask<int> ReadInt(Stream stream)
        {
            Memory<byte> buff = new byte[4];
            await stream.ReadAsync(buff);
            return BinaryPrimitives.ReadInt32BigEndian(buff.Span);
        }

        public static async ValueTask<long> ReadLong(Stream stream)
        {
            Memory<byte> buff = new byte[8];
            await stream.ReadAsync(buff);
            return BinaryPrimitives.ReadInt64BigEndian(buff.Span);
        }

        public static async ValueTask<ulong> ReadULong(Stream stream)
        {
            Memory<byte> buff = new byte[8];
            await stream.ReadAsync(buff);
            return BinaryPrimitives.ReadUInt64BigEndian(buff.Span);
        }

        public static async ValueTask<BlockPosition> ReadBlockPosition(Stream stream)
        {
            var val = await ReadLong(stream);

            var x = val >> 38;
            var y = (val >> 26) & 0xFFF;
            var z = val << 38 >> 38;
            return new BlockPosition()
            {
                X = (int)x,
                Y = (int)y,
                Z = (int)z,
            };
        }

        public static async ValueTask<float> ReadFloat(Stream stream)
        {
            var v = await ReadInt(stream);
            if (BitConverter.IsLittleEndian)
                v = BinaryPrimitives.ReverseEndianness(v);
            return BitConverter.Int32BitsToSingle(v);
        }

        internal static int ReadVarIntWithLegacyCheck(Stream stream)
        {
            var val = 0;
            var size = 0;
            int readData;
            while (((readData = stream.ReadByte()) & 0x80) == 0x80)
            {
                if (readData == -1)
                    throw new EndOfStreamException();

                if (size == 0 && readData == 0xFE)
                    throw new LegacyServerListPingException();

                val |= (readData & 0x7F) << (size++ * 7);
                if (size > 5)
                {
                    throw new IOException("VarInt too long. Hehe that's punny.");
                }
            }

            return val | ((readData & 0x7F) << (size * 0x7));
        }
    }
}