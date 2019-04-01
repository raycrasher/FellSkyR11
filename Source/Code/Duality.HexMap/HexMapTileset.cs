using Duality;
using Duality.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duality.HexMap
{
    public class HexMapTileset : Resource
    {
        private ContentRef<Prefab>[] tiles;
        private int tileRadius = 16;

        public int TileRadius { get => tileRadius; set => tileRadius = value; }
        public ContentRef<Prefab>[] Tiles { get => tiles; set => tiles = value; }
    }
}
