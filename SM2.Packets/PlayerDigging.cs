using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using AutoSerialize;
using System.Threading.Tasks;
using SM2.Core.BaseTypes.Abstractions;
using SM2.Blocks;
using SM2.Core.BaseTypes.Enums;

namespace SM2.Packets
{
    [AutoSerializeAs(typeof(VarInt))]
    public enum DiggingStatus : int
    {
        StartDigging = 0,
        CancelledDigging = 1,
        FinishedDigging = 2,
        DropItemStack = 3,
        DropItem = 4,
        ShootArrowORFinishEating = 5,
        SwapItemInHand = 6,
    }

    public enum BlockFace : byte
    {
        Bottom = 0,
        Top = 1,
        North = 2,
        South = 3,
        West = 4,
        East = 5,
    }

    public class PlayerDigging : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;

        public override ConnectionSide WritingSide { get; } = ConnectionSide.Client;

        public override VarInt Id { get; } = 0x18;

        [AutoSerialize(0)]
        public DiggingStatus Status;
        [AutoSerialize(1)]
        public Position Location;
        [AutoSerialize(2)]
        public BlockFace Face;

        public override Task PostRead()
        {
            var WithFacePos = Location;
            switch (Face)
            {
                case BlockFace.Bottom:
                    WithFacePos += new Position(0, -1, 0);
                    break;
                case BlockFace.Top:
                    WithFacePos += new Position(0, 1, 0);
                    break;
                case BlockFace.North:
                    WithFacePos += new Position(0, 0, -1);
                    break;
                case BlockFace.South:
                    WithFacePos += new Position(0, 0, 1);
                    break;
                case BlockFace.West:
                    WithFacePos += new Position(-1, 0, 0);
                    break;
                case BlockFace.East:
                    WithFacePos += new Position(1, 0, 0);
                    break;
            }

            switch (Status)
            {
                case DiggingStatus.StartDigging:
                    if (_ctx.Player.GameMode != Gamemode.Creative)
                        // do other processing
                        break;
                    else // so if the player is in Creative.
                        goto case DiggingStatus.FinishedDigging;
                case DiggingStatus.FinishedDigging:
                    var v = Block.Factory.GetBlock<Air>();
                    _ctx.Player.Dimension[WithFacePos] = v;
                    _ctx.Client.Broadcast(new BlockChange(v, WithFacePos));
                    break;
            }
            logger.Info(Enum.GetName(typeof(DiggingStatus), Status));

            return base.PostRead();
        }
    }
}
