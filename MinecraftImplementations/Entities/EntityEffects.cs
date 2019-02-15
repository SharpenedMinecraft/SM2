using System;

namespace Entities
{
    [Flags]
    public enum EntityEffects
    {
        OnFire = 0x01,
        Crouched = 0x02,
        UNUSED = 0x04,
        Sprinting = 0x08,
        Swimming = 0x10,
        Invisible = 0x20,
        GlowingEffect = 0x40,
        FlyingElytra = 0x80,
    }
}
