﻿using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Enums;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    public class JoinGame : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Server;
        public override VarInt Id { get; } = 0x25;

        [AutoSerialize(0)]
        public int EntityID;
        [AutoSerialize(1)]
        public Gamemode Gamemode;
        [AutoSerialize(2)]
        public int Dimension;
        [AutoSerialize(3)]
        public Difficulty Difficulty;
        [AutoSerialize(4)]
        public byte MaxPlayers;
        [AutoSerialize(5)]
        public string LevelType;
        [AutoSerialize(6)]
        public bool ReducedDebugInfo;

        public override async Task PostWrite()
        {
            _ctx.Client.Write(new PluginMessageServer()
            {
                ChannelID = "minecraft:brand"
            });
            _ctx.Client.Write(new ServerDifficulty()
            {
                Difficulty = Difficulty.Easy
            });
            _ctx.Client.Write(new SpawnPosition()
            {
                SpawnPos = _ctx.Player.SpawnPosition
            });
            _ctx.Client.Write(new PlayerAbilities()
            {
                FieldOfViewModifier = 1f,
                Flags = PlayerFlags.AllowFlying | PlayerFlags.CreativeMode | PlayerFlags.Flying | PlayerFlags.Invulnerable,
                FlyingSpeed = 1f,
            });

            await base.PostWrite();
        }
    }
}
