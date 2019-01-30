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
    public class ByteTests
    {
        [Property]
        public bool Read(byte x)
        {
            using (var stream = new MemoryStream(new byte[] { x }))
                return x == NetworkUtils.ReadByte(stream);
        }

        [Property]
        public bool Write(byte x)
        {
            using (var stream = new MemoryStream(1))
            {
                NetworkUtils.WriteByte(stream, x);
                var a = stream.Position == 1;
                stream.Position = 0;
                return a && x == stream.ReadByte();
            }
        }

        [Test]
        public void EndOfStreamRead()
        {
            using (var stream = new MemoryStream(0))
            {
                Assert.Throws<EndOfStreamException>(() => NetworkUtils.ReadByte(stream));
            }
        }
    }
}
