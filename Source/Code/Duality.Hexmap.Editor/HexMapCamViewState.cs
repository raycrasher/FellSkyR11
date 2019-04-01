using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duality.Editor.Plugins.CamView.CamViewStates;
using Duality.Editor.Plugins.CamView.CamViewLayers;
using System.Windows.Forms;
using ca.axoninteractive.Geometry.Hex;

namespace Duality.HexMap.Editor
{
    public class HexMapCamViewState : CamViewState
    {
        public override string StateName => "Hex Map";

        public HexMap ActiveMap { get; set; }
        HexGrid _hexGrid;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            var tileset = ActiveMap?.Tileset.Res;
            if (tileset == null)
                return;

            if (_hexGrid==null || _hexGrid.HexRadius != tileset.TileRadius)
            {
                _hexGrid = new HexGrid(tileset.TileRadius);
            }

            
        }
    }
}
