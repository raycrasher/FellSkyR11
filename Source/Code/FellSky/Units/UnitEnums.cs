using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Units
{
    [Flags]
    public enum MoveTypes
    {
        None = 0x0,
        // ground movement
        Tracked = 0x1,          // + uneven ground, + soft ground
        Wheeled = 0x2,          // + flat ground, - soft ground

        // ground/water
        Hover = 0x4,            // ++ flat terrain/water, --on uneven, use energy to move

        // water movement
        Water = 0x8,            // no penalties in water
        Submarine = 0x10,       // hide while submerged

        // air/space
        Rocket = 0x20,          // ignore ground/water, use more energy to move

        // air movement
        Aero = 0x40,            // ignore ground/water, use energy to move

        // legs
        Bipedal = 0x80,         // + forests, ++ city, --soft ground
        Quad = 0x100,           // ++ uneven, -soft ground

        Subterranean = 0x200,
        Teleport = 0x400,       // teleport to all hexes within move range no penalties whatsoever
        Boost = 0x8000,         // Like teleport but with move animation
        LegJump = 0x1000,       // Like boost, but needs solid surface initially.        

        // note: For space terrain, only rocket/jump/teleport can be used.

        All = 0xFFFFFFF
    }

    public enum ProjectileType
    {
        Beam, Bolt, Kinetic, Shell,
    }

    public enum DamageArea
    {
        Blast, Impact, Pierce, 
    }

    public enum DamageType
    {
        Kinetic, Laser, Thermal, EM, Chemical, Nanotech, Gravitic, Dark
    }
}
