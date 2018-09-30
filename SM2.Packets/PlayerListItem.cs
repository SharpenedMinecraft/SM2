using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Enums;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace SM2.Packets
{
    public class PlayerListItem : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Server;
        public override VarInt Id { get; } = 0x30;

        public Player Player;

        [AutoSerialize(0)]
        public PlayerListAction Action;
        [AutoSerialize(1)]
        [NoLength]
        public byte[] Data;

        public override async Task PreWrite()
        {
            await base.PreWrite();
            using (var mem = new MemoryStream())
            {
                var VarInt = _ctx.Provider.GetService<ITypeAccessor<VarInt>>();
                var String = _ctx.Provider.GetService<ITypeAccessor<String>>();
                var Bool = _ctx.Provider.GetService<ITypeAccessor<Boolean>>();
                VarInt.Write(mem, 1);
                _ctx.Provider.GetService<ITypeAccessor<Guid>>().Write(mem, Player.UUID);
                switch (Action)
                {
                    case PlayerListAction.AddPlayer:
                        String.Write(mem, Player.Username);
                        if (Player.Profile != null)
                        {
                            VarInt.Write(mem, Player.Profile.Properties.Count);
                            foreach (var v in Player.Profile.Properties)
                            {
                                String.Write(mem, v.Name);
                                String.Write(mem, v.Value);
                                if (!string.IsNullOrEmpty(v.Signature))
                                {
                                    Bool.Write(mem, true);
                                    String.Write(mem, v.Signature);
                                }
                                else
                                    Bool.Write(mem, false);
                            }
                        }
                        else
                            VarInt.Write(mem, 0);
                        VarInt.Write(mem, (int)Player.GameMode);
                        VarInt.Write(mem, Player.ClientLatency);
                        Bool.Write(mem, false);
                        break;
                    case PlayerListAction.RemovePlayer:
                        break;
                    case PlayerListAction.UpdateDisplayName:
                        Bool.Write(mem, false);
                        break;
                    case PlayerListAction.UpdateGamemode:
                        VarInt.Write(mem, (int)Player.GameMode);
                        break;
                    case PlayerListAction.UpdateLatency:
                        VarInt.Write(mem, Player.ClientLatency);
                        break;
                }
                Data = mem.ToArray();
            }
        }
    }
}
