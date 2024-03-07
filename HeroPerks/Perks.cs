using System;

namespace HeroPerks
{
    [Flags]
    enum Perks
    {
        None = 0,
        WaterBreathing = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    }
}
