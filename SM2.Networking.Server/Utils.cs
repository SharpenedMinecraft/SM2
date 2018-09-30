using NLog;
using SM2.Core.Server;
using SM2.MojangAPI;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Core.BaseTypes
{
    public static class Utils
    {
        // From Craft.Net: https://github.com/SirCmpwn/Craft.Net

        public static async Task<MojangPlayerProfile> GetProfileAsync(this Player p)
        {
            using (var wc = new HttpClient())
            {
                var result = await wc.GetAsync($"https://sessionserver.mojang.com/session/minecraft/profile/{p.UUID.ToString().Replace("-", "")}");
                if (!result.IsSuccessStatusCode)
                    throw new Exception(result.ReasonPhrase);
                var c = await result.Content.ReadAsStringAsync();
                return MojangPlayerProfile.FromJson(c);
            }
        }

        /// <summary>
        /// Creates a Java-style SHA-1 hash.
        /// </summary>
        public static string JavaHexDigest(byte[] hash)
        {
            bool negative = (hash[0] & 0x80) == 0x80;
            if (negative) // check for negative hashes
                hash = TwosCompliment(hash);
            // Create the string and trim away the zeroes
            string digest = GetHexString(hash).TrimStart('0');
            if (negative)
                digest = "-" + digest;
            return digest;
        }

        private static string GetHexString(byte[] p)
        {
            string result = "";
            for (int i = 0; i < p.Length; i++)
                result += p[i].ToString("X2");
            return result;
        }
        private static byte[] TwosCompliment(byte[] p) // little endian
        {
            int i;
            bool carry = true;
            for (i = p.Length - 1; i >= 0; i--)
            {
                p[i] = unchecked((byte)~p[i]);
                if (carry)
                {
                    carry = p[i] == 0xFF;
                    p[i]++;
                }
            }
            return p;
        }

        public static string GetHash(string baseHash, byte[] sharedSecret, byte[] publicKey)
        {
            //sha1:= Sha1()
            //sha1.update(ASCII encoding of the server id string from Encryption Request)
            //sha1.update(shared secret)
            //sha1.update(server's encoded public key from Encryption Request) 
            //hash:= sha1.hexdigest()  # String of hex characters
            string res;
            var ASCIIBaseHash = Encoding.ASCII.GetBytes(baseHash);
            SHA1 sha1 = SHA1.Create();
            sha1.TransformBlock(ASCIIBaseHash, 0, ASCIIBaseHash.Length, ASCIIBaseHash, 0);
            sha1.TransformBlock(sharedSecret, 0, sharedSecret.Length, sharedSecret, 0);
            sha1.TransformFinalBlock(publicKey, 0, publicKey.Length);
            byte[] hash = sha1.Hash;
            res = Utils.JavaHexDigest(hash);
            sha1.Dispose();
            return res;
        }

        public static async Task<Guid> GetUUID(Player p)
        {
            Guid u;

            using (var wc = new HttpClient())
            {
                var result = await wc.PostAsync($"https://api.mojang.com/profiles/minecraft",
                    new StringContent("[ \"" + p.Username + "\"]", Encoding.UTF8, "application/json"));
                if (!result.IsSuccessStatusCode)
                    throw new Exception(result.ReasonPhrase);
                var Sresult = await result.Content.ReadAsStringAsync();
                var _result = Sresult.Split('"');
                if (_result.Length > 1)
                {
                    var uuid = _result[3];
                    u = new Guid(uuid);
                }
                else
                {
                    LogManager.GetCurrentClassLogger().Info($"Coudnt get UUID for {p.Username}");
                    u = Guid.NewGuid();
                }
            }

            return u;
        }

        public static Guid NameGuidFromBytes(byte[] input)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(input);
            hash[6] &= 0x0f;
            hash[6] |= 0x30;
            hash[8] &= 0x3f;
            hash[8] |= 0x80;

            byte temp = hash[6];
            hash[6] = hash[7];
            hash[7] = temp;

            temp = hash[4];
            hash[4] = hash[5];
            hash[5] = temp;

            temp = hash[0];
            hash[0] = hash[3];
            hash[3] = temp;

            temp = hash[1];
            hash[1] = hash[2];
            hash[2] = temp;
            return new Guid(hash);
        }
    }
}
