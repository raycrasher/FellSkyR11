using Duality;
using FellSky.Combat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky
{
    public class FellSkyGame : CorePlugin
    {

        public static CombatMap CombatMap { get; private set; }
        public const float CombatHexRadius = 16;
    }
}
