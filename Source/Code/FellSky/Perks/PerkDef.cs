using Duality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Perks
{
    public class PerkDef : Resource
    {
        private Ability[] abilities;

        public Ability[] Abilities { get => abilities; set => abilities = value; }
    }
}
