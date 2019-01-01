using System;
using System.Buffers.Binary;
using System.IO;
using System.Text;

namespace Server
{
    public static class NetworkUtils
    {
        public static void WriteVarInt(Stream stream, int val)
        {
            var size = 0;
            var v = (int)val;
            while ((v & -0x80) != 0)
            {
                if (size > 5)
                    throw new IOException("VarInt too long, its just, i can't handle that");

                stream.WriteByte((byte)(v & 0x7F | 0x80));
                v = (int)(((uint)v) >> 7);
                size++;
            }
            stream.WriteByte((byte)(v));
        }
        public static void WriteString(Stream stream, string val)
        {
            var bytes = Encoding.UTF8.GetBytes(val);
            WriteVarInt(stream, bytes.Length);
            if (bytes.Length > 0)
                stream.Write(bytes, 0, bytes.Length);
        }
        public static void WriteShort(Stream stream, short val)
        {
            Span<byte> buff = new byte[2];
            BinaryPrimitives.WriteInt16BigEndian(buff, val);
            stream.Write(buff);
        }
        public static void WriteInt(Stream stream, int val)
        {
            Span<byte> buff = new byte[4];
            BinaryPrimitives.WriteInt32BigEndian(buff, val);
            stream.Write(buff);
        }
        public static void WriteLong(Stream stream, long val)
        {
            Span<byte> buff = new byte[8];
            BinaryPrimitives.WriteInt64BigEndian(buff, val);
            stream.Write(buff);
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
            return (val | ((readData & 0x7F) << (size * 0x7)));
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
            return (val | ((readData & 0x7F) << (size * 0x7)));
        }

        public static string ReadString(Stream stream)
        {
            var length = ReadVarInt(stream);
            Span<byte> buff = new byte[length];
            stream.Read(buff);
            return Encoding.UTF8.GetString(buff);
        }

        public static ushort ReadUShort(Stream stream)
        {
            Span<byte> buff = new byte[2];
            stream.Read(buff);
            return BinaryPrimitives.ReadUInt16BigEndian(buff);
        }

        public static long ReadInt(Stream stream)
        {
            Span<byte> buff = new byte[4];
            stream.Read(buff);
            return BinaryPrimitives.ReadInt32BigEndian(buff);
        }

        public static long ReadLong(Stream stream)
        {

            Span<byte> buff = new byte[8];
            stream.Read(buff);
            return BinaryPrimitives.ReadInt64BigEndian(buff);
        }
    }
}