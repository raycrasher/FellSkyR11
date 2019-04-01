using Duality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Map
{
    public class HexMapTile : Component
    {
        private ContentRef<HexMapTileDef> moveCost;

        public ContentRef<HexMapTileDef> MoveCost { get => moveCost; set => moveCost = value; }
    }
}
