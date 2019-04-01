using Duality.Editor;
using Duality.Editor.Plugins.CamView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duality.HexMap.Editor
{
    public class OpenHexMapAction : EditorSingleAction<object>
    {
        public override string Name => "Open HexMap";
        public override int Priority => base.Priority + 1;

        public override bool CanPerformOn(object obj)
        {
            if (!base.CanPerformOn(obj)) return false;
            if (GetHexmap(obj) == null) return false;
            if (DualityEditorApp.GetPlugin<CamViewPlugin>() == null) return false;
            return true;
        }

        public override void Perform(object obj)
        {
            HexMap hexmap = GetHexmap(obj);
            if (hexmap == null) return;

            // Find or create a camera view in tilemap editing mode
            CamViewPlugin camViewPlugin = DualityEditorApp.GetPlugin<CamViewPlugin>();
            if (camViewPlugin == null) return;
            CamView camView = camViewPlugin.CreateOrSwitchCamView(typeof(HexMapCamViewState));
            if (camViewPlugin == null) return;

            DualityEditorApp.Select(this, new ObjectSelection(hexmap));

            DualityEditorApp.Highlight(this, new ObjectSelection(hexmap), HighlightMode.Spatial);
        }

        public override bool MatchesContext(string context)
        {
            return
                context == DualityEditorApp.ActionContextOpenRes ||
                context == DualityEditorApp.ActionContextMenu;
        }

        private static HexMap GetHexmap(object obj)
        {
            HexMap tilemap = obj as HexMap;
            if (tilemap == null)
            {
                GameObject gameObj = obj as GameObject;
                if (gameObj != null) tilemap = gameObj.GetComponent<HexMap>();
            }
            return tilemap;
        }
    }
}
