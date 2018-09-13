using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Enums;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    public class LoginSuccess : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Login;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Server;
        public override VarInt Id { get; } = 0x02;

        [AutoSerialize(0)]
        public string UUID;
        [AutoSerialize(1)]
        public string Username;

        public override async Task PostWrite()
        {
            _ctx.Client.SetState(ConnectionState.Play);
            _ctx.Client.Write(new JoinGame()
            {
                //TODO: Propper World Stuff
                Difficulty = Difficulty.Easy, // also send in ServerDifficulty Packet
                Dimension = Dimension.Overworld.DimensionId, // Will this work?
                EntityID = _ctx.Player.EntityID,
                Gamemode = Gamemode.Creative, // Please fill with propper
                LevelType = Dimension.Overworld.Type, // Others
                MaxPlayers = _ctx.Server.MaxPlayers,
                ReducedDebugInfo = false
            });

            await base.PostWrite();
        }
    }
}
