using System;
using System.Collections.Generic;
using System.Text;
using SpecialTypes;

namespace Entities
{
    public abstract class Living : BaseEntity
    {
        [Flags]
        public enum HandStateFlags
        {
            IsHandActive = 0x01,

            /// <summary>
            /// 0 = main hand, 1 = offhand
            /// </summary>
            ActiveHand = 0x02,
            IsSpinnAttack = 0x04,
        }

        public HandStateFlags HandState { get; set; }

        public float Health { get; set; }

        public int PotionEffectColor { get; set; } // VarInt

        public bool IsPotionAmbientEffect { get; set; }

        public int ArrowsInEntity { get; set; } // VarInt
    }
}
