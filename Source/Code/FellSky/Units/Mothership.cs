using Duality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Units
{
    public class Mothership: Component
    {
        private ContentRef<MothershipDef> def;
        private string givenName;

        public string GivenName { get => givenName; set => givenName = value; }
        public ContentRef<MothershipDef> Def { get => def; set => def = value; }
    }
}
