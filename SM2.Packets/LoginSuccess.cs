using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Enums;
using SM2.Core.Server;
using SM2.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;
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
                Dimension = _ctx.Player.Dimension.DimensionId,
                EntityID = _ctx.Player.EntityID,
                Gamemode = _ctx.Player.GameMode,
                LevelType = _ctx.Player.Dimension.Type, // Others
                MaxPlayers = _ctx.Server.MaxPlayers,
                ReducedDebugInfo = false
            });
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
            DoTheChunks();
            _ctx.Client.Write(new PlayerPositionAndLookServer()
            {
                X = _ctx.Player.Position.X,
                Y = _ctx.Player.Position.Y,
                Z = _ctx.Player.Position.Z,
                Yaw = _ctx.Player.Rotation.Yaw,
                Pitch = _ctx.Player.Rotation.Pitch,
                Flags = TransformFlags.NONE,
                TeleportID = TeleportManager.CreateTP(_ctx.Player)
            });

            SpawnOthers();
            _ctx.Client.Write(new PlayerListItem() { Action = PlayerListAction.AddPlayer, Player = _ctx.Player });
            _ctx.Client.Broadcast(new PlayerListItem() { Action = PlayerListAction.AddPlayer, Player = _ctx.Player });
            _ctx.Client.Broadcast(new SpawnPlayer(_ctx.Player));
            _ctx.Client.Write(new KeepAliveClient());

            await base.PostWrite();
        }

        private void SpawnOthers()
        {
            foreach (var player in _ctx.Player.Dimension.GetEntities().Where(x => x.GetType() == typeof(Player)).Select(x => (Player)x))
            {
                if (player.EntityID != _ctx.Player.EntityID)
                {
                    _ctx.Client.Write(new PlayerListItem() { Action = PlayerListAction.AddPlayer, Player = player });
                    _ctx.Client.Write(new SpawnPlayer(player));
                }
            }
        }

        private void DoTheChunks()
        {
            var baseChunk = ((Position)_ctx.Player.Position).WorldToChunk(out Position _);
            for (int x = -3; x <= 4; x++)
            {
                for (int z = -3; z <= 4; z++)
                {
                    // Console.WriteLine($"Enquing {x + baseChunk.X},{z + baseChunk.Z}");
                    _ctx.Client.Write(new ChunkData()
                    {
                        ChunkX = (int)(x + baseChunk.X),
                        ChunkZ = (int)(z + baseChunk.Z),
                        GroundUpContinous = true
                    });
                }
            }
        }
    }
}
