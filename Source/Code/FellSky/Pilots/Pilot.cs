using Duality;
using FellSky.Perks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Pilots
{
    public class Pilot
    {
        private List<ContentRef<PerkDef>> perks = new List<ContentRef<PerkDef>>();

        public List<ContentRef<PerkDef>> Perks { get => perks; set => perks = value; }
    }
}
