using ca.axoninteractive.Geometry.Hex;
using Duality;
using Duality.Components;
using Duality.Components.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duality.HexMap
{
    [RequiredComponent(typeof(Transform))]
    public class HexMap : Component
    {
        private Dictionary<AxialHexCoord, GameObject> hexes = new Dictionary<AxialHexCoord, GameObject>();
        private ContentRef<HexMapTileset> tileset;

        public Dictionary<AxialHexCoord, GameObject> Hexes { get => hexes; set => hexes = value; }
        public ContentRef<HexMapTileset> Tileset { get => tileset; set => tileset = value; }

        [DontSerialize]
        private HexGrid _grid = null;

        public HexMap()
        {
        }

        public GameObject SetHex(AxialHexCoord pos, int index)
        {
            if (!Tileset.IsAvailable)
                return null;

            var tiles = (HexMapTileset)Tileset;
            if(Hexes.TryGetValue(pos,out var oldHex))
            {
                oldHex.Parent = null;
                oldHex.DisposeLater();
            }
            if(index >=0 && index < tiles.Tiles.Length && tiles.Tiles[index] != null)
            {
                var newHex = tiles.Tiles[index].Res.Instantiate();

                if (_grid == null || _grid.HexRadius != tiles.TileRadius)
                    _grid = new HexGrid(_grid.HexRadius);

                newHex.Transform.Pos = _grid.AxialToPoint(pos).ToVector3();
                newHex.Parent = GameObj;
                var depth = newHex.Transform.Pos.Y;
                foreach (var rnd in newHex.GetComponentsDeep<SpriteRenderer>())
                {
                    rnd.DepthOffset = depth;
                }

                foreach(var depthoffset in newHex.GetComponentsDeep<IHexDepthOffset>())
                {
                    depthoffset.DepthOffset = depth;
                }

                return newHex;
            }
            return null;
        }

    }
}
