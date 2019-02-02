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
        public enum DisplayedSkinPartsFlags : byte
        {
            None = 0x00,
            Cape = 0x01,
            Jacket = 0x02,
            LeftSleeve = 0x04,
            RightSleeve = 0x08,
            LeftPantsLeg = 0x10,
            RightPantsLeg = 0x20,
            Hat = 0x40,
        }

        [Flags]
        public enum Ability : byte
        {
            None = 0x00,
            Invulnerable = 0x01,
            Flying = 0x02,
            AllowFlying = 0x04,
            CreativeMode = 0x08
        }

        public PlayerInventory Inventory { get; set; } = new PlayerInventory();

        public Ability Abilities { get; set; } = Ability.AllowFlying | Ability.Invulnerable | Ability.Flying | Ability.CreativeMode;

        public bool IsCreativeMode => (Abilities & Ability.CreativeMode) != 0;

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

        public override string ToString()
        {
            var finalName = IsCustomNameVisible ? CustomName.Value.ToString() : Username;
            return $"{finalName} ({UUID}) ({Enum.GetName(typeof(Ability), Abilities)})";
        }
    }
}
