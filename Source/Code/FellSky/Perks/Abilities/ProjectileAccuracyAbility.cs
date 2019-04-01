using Duality;
using FellSky.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Perks.Abilities
{
    public class ProjectileAccuracyAbility : Ability
    {
        private ProjectileType type;

        public ProjectileType Type { get => type; set => type = value; }

        public override void Apply(GameObject obj)
        {
            
        }

        public override void Unapply(GameObject obj)
        {
            
        }
    }
}
