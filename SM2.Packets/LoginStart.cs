using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    class LoginStart : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Login;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Client;
        public override VarInt Id { get; } = 0x00;

        [AutoSerialize(0)]
        public string Name;

        public override async Task PostRead()
        {
            _ctx.Player.Username = Name;
            if (_ctx.Server.OnlineMode)
            {
                /*if (Client.Encryption)
                   Player.UUID = Utils.GetUUID(Player,
                       Utils.GetHash(Utils.BaseServerHash,
                       Client.Crypto.Key,
                       PacketCryptography.PublicKeyToAsn1(Utils.ServerKey)))
                       .Result;
                else*/
                _ctx.Player.UUID = Utils.GetUUID(_ctx.Player).Result;
            }
            else
                _ctx.Player.UUID = Utils.NameGuidFromBytes(Encoding.UTF8.GetBytes($"OfflinePlayer:{_ctx.Player.Username}"));
            
            _ctx.Client.Write(new LoginSuccess()
            {
                Username = _ctx.Player.Username,
                UUID = _ctx.Player.UUID.ToString(),
            });

            await base.PostRead();
            Console.WriteLine($"Hello {_ctx.Player.Username} ({_ctx.Player.UUID})");
        }
    }
}
