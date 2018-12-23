using SpecialTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public abstract class Living : BaseEntity
    {
        public Living.HandStateFlags HandState { get; set; }
        public float Health { get; set; }
        /// <summary>
        /// The Potion Effect Color
        /// 0 for none
        /// </summary>
        public VarInt PotionEffectColor { get; set; }
        public bool IsPotionAmbientEffect { get; set; }
        public VarInt ArrowsInEntity { get; set; }

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
    }
}
