using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Units
{
    public enum HangarSize
    {
        Small, Medium, Large
    }

    public class HangarSlot
    {
        private HangarSize size;

        public HangarSize Size { get => size; set => size = value; }
    }
}
