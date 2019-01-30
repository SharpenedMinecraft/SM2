using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FsCheck;
using FsCheck.NUnit;
using NUnit.Framework;
using Server;
using PropertyAttribute = FsCheck.NUnit.PropertyAttribute;

namespace Tests.NetworkUtilsTests
{
    public class BoolTests
    {
        [Property]
        public bool Read(bool x)
        {
            using (var stream = new MemoryStream(new byte[] { x ? (byte)0x01 : (byte)0x00 }))
                return x == NetworkUtils.ReadBool(stream);
        }

        [Property]
        public bool Write(bool x)
        {
            using (var stream = new MemoryStream(1))
            {
                NetworkUtils.WriteBool(stream, x);
                var a = stream.Position == 1;
                if (a == false)
                    return false;
                stream.Position = 0;
                var b = (byte)stream.ReadByte();
                return a && IsValid(b) && x == (b == 0x01);
            }
        }

        private bool IsValid(byte b)
            => b == 0x01 || b == 0x00;
    }
}
