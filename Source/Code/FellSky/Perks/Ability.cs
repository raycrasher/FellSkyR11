using Duality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Perks
{
    public abstract class Ability
    {
        private float value;

        public float Value { get => value; set => this.value = value; }
        public abstract void Apply(GameObject obj);
        public abstract void Unapply(GameObject obj);
    }
}
