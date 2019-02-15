using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Buffers.Native;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Server
{
    public static class NetworkUtils
    {
        [ThreadStatic]
        private static byte[] _oneByteArray;

        public static void WriteArray<T>(Stream stream, T[] val, Action<Stream, T> action)
        {
            foreach (T v in val)
                action(stream, v);
        }

        public static void WriteVarInt(Stream stream, int val)
        {
            var size = 0;
            var v = val;
            while ((v & -0x80) != 0)
            {
                if (size > 5)
                    throw new IOException("VarInt too long, its just, i can't handle that");

                WriteByte(stream, (byte)((v & 0x7F) | 0x80));
                v = (int)(((uint)v) >> 7);
                size++;
            }

            WriteByte(stream, (byte)v);
        }

        public static void WriteString(Stream stream, string val)
        {
            var bytes = Encoding.UTF8.GetBytes(val);
            WriteVarInt(stream, bytes.Length);
            if (bytes.Length > 0)
                stream.Write(bytes, 0, bytes.Length);
        }

        public static void WriteBool(Stream stream, bool val)
            => WriteByte(stream, val ? (byte)0x01 : (byte)0x00);

        public static void WriteByte(Stream stream, byte val)
        {
            stream.WriteByte(val);
        }

        public static void WriteUShort(Stream stream, ushort val)
        {
            const int size = sizeof(ushort);
            Span<byte> buff = stackalloc byte[size];
            BinaryPrimitives.WriteUInt16BigEndian(buff, val);
            stream.Write(buff);
        }

        public static void WriteInt(Stream stream, int val)
        {
            const int size = sizeof(int);
            Span<byte> buff = stackalloc byte[size];
            BinaryPrimitives.WriteInt32BigEndian(buff, val);
            stream.Write(buff);
        }

        public static void WriteULong(Stream stream, ulong val)
        {
            const int size = sizeof(ulong);
            Span<byte> buff = stackalloc byte[size];
            BinaryPrimitives.WriteUInt64BigEndian(buff, val);
            stream.Write(buff);
        }

        public static void WriteLong(Stream stream, long val)
        {
            const int size = sizeof(long);
            Span<byte> buff = stackalloc byte[size];
            BinaryPrimitives.WriteInt64BigEndian(buff, val);
            stream.Write(buff);
        }

        public static void WriteBlockPosition(Stream stream, BlockPosition pos)
            => WriteLong(
                stream,
                ((((long)pos.X) & 0x3FFFFFF) << 38) | ((((long)pos.Y) & 0xFFF) << 26) | (((long)pos.Z) & 0x3FFFFFF));

        public static void WriteFloat(Stream stream, float val)
        {
            var v = BitConverter.SingleToInt32Bits(val);
            WriteInt(stream, v);
        }

        public static void WriteDouble(Stream stream, double val)
        {
            var v = BitConverter.DoubleToInt64Bits(val);
            WriteLong(stream, v);
        }

        public static int ReadVarInt(Stream stream)
        {
            var val = 0;
            int size = 0;
            int readData;
            while (((readData = ReadByte(stream)) & 0x80) == 0x80)
            {
                val |= (readData & 0x7F) << (size++ * 7);
                if (size > 5)
                    throw new IOException("VarInt too long. Hehe that's punny.");
            }

            return val | ((readData & 0x7F) << (size * 0x7));
        }

        public static string ReadString(Stream stream)
        {
            var length = ReadVarInt(stream);
            Span<byte> buff = stackalloc byte[length];
            stream.Read(buff);
            return Encoding.UTF8.GetString(buff);
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
            if (_oneByteArray is null)
                _oneByteArray = new byte[sizeof(byte)];

            if (stream.Read(_oneByteArray, 0, sizeof(byte)) != 1)
                throw new EndOfStreamException();
            return _oneByteArray[0];
        }

        public static ushort ReadUShort(Stream stream)
        {
            const int size = sizeof(ushort);
            Span<byte> buff = stackalloc byte[size];
            if (stream.Read(buff) != size)
                throw new EndOfStreamException();

            return BinaryPrimitives.ReadUInt16BigEndian(buff);
        }

        public static int ReadInt(Stream stream)
        {
            const int size = sizeof(int);
            Span<byte> buff = stackalloc byte[size];
            if (stream.Read(buff) != size)
                throw new EndOfStreamException();

            return BinaryPrimitives.ReadInt32BigEndian(buff);
        }

        public static ulong ReadULong(Stream stream)
        {
            const int size = sizeof(ulong);
            Span<byte> buff = stackalloc byte[size];
            if (stream.Read(buff) != size)
                throw new EndOfStreamException();

            return BinaryPrimitives.ReadUInt64BigEndian(buff);
        }

        public static long ReadLong(Stream stream)
        {
            const int size = sizeof(long);
            Span<byte> buff = stackalloc byte[size];
            if (stream.Read(buff) != size)
                throw new EndOfStreamException();

            return BinaryPrimitives.ReadInt64BigEndian(buff);
        }

        public static BlockPosition ReadBlockPosition(Stream stream)
        {
            var val = ReadLong(stream);

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

        public static float ReadFloat(Stream stream)
        {
            var v = ReadInt(stream);
            return BitConverter.Int32BitsToSingle(v);
        }

        public static double ReadDouble(Stream stream)
        {
            var v = ReadLong(stream);
            return BitConverter.Int64BitsToDouble(v);
        }
    }
}