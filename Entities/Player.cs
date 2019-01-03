using System;
using System.Collections.Generic;
using System.Text;
using Base;
using SpecialTypes;

namespace Entities
{
    public sealed class Player : Living
    {
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

        public override EntitySpawnMethod SpawnMethod => EntitySpawnMethod.Special;

        public override string Name => "Player";

        public override Bounds BoundingBox => throw new NotSupportedException();

        public PlayerSettings Settings { get; set; }

        public override string ID => "minecraft:player";

        public override int Type => 92;

        public override int? ObjectID => null;

        public string Username { get; set; }

        public Guid UUID { get; set; }

        public float AdditionalHearts { get; set; }

        public int Score { get; set; } // VarInt

        public DisplayedSkinPartsFlags DisplayedSkinParts { get; set; }

        public MainHand MainHand { get; set; }

        public NBT LeftShoulderData { get; set; }

        public NBT RightShoulderData { get; set; }
    }
}
