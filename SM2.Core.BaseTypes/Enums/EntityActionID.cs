using AutoSerialize;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes.Enums
{
    [AutoSerializeAs(typeof(VarInt))]
    public enum EntityActionID
    {
        StartSneaking = 0,
        StopSneaking = 1,
        LeaveBed = 2,
        StartSprinting = 3,
        StopSprinting = 4,
        StartJumpHorse = 5,
        StopJumpHorse = 6,
        OpenHorseInventory = 7,
        StartFlyingElytra = 8
    }
}
