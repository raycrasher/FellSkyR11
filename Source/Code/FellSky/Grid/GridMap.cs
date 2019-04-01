using ca.axoninteractive.Geometry.Hex;
using Duality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Grid
{
    public class GridMap: Component
    {
        [DontSerialize]
        private HexGrid _hexGrid;

        public HexGrid HexGrid { get => _hexGrid; set => _hexGrid = value; }
    }
}
