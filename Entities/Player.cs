using System;
using System.Collections.Generic;
using System.Text;
using Base;
using SpecialTypes;

namespace Entities
{
    public sealed class Player : Living
    {
        public override EntitySpawnMethod SpawnMethod => EntitySpawnMethod.Special;
        public override String Name => "Player";
        public override Bounds BoundingBox
        {
            get
            {
                throw new NotSupportedException();
            }
        }
        public override String ID => "minecraft:player";
        public override Int32 Type => 92;
        public override Int32? ObjectID => null;

        public string Username { get; set; }
        public Guid UUID { get; set; }

        public float AdditionalHearts { get; set; }
        public Int32 Score { get; set; } // VarInt
        public Player.DisplayedSkinPartsFlags DisplayedSkinParts { get; set; }
        public Player.MainHandFlags MainHand { get; set; }
        public NBT LeftShoulderData { get; set; }
        public NBT RightShoulderData { get; set; }

        [Flags]
        public enum DisplayedSkinPartsFlags
        {
            Cape = 0x01,
            Jacket = 0x02,
            LeftSleeve = 0x04,
            RightSleeve = 0x08,
            LeftPantsLeg = 0x10,
            RightPantsLeg = 0x20,
            Hat = 0x40,
        }

        [Flags]
        public enum MainHandFlags : byte
        {
            Left = 0,
            Right = 1,
        }
    }
}
