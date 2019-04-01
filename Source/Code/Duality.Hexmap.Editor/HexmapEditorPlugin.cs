using Duality.Editor;
using Duality.Editor.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duality.HexMap.Editor
{
    public class HexMapEditorPlugin : EditorPlugin
    {
        public override string Id => nameof(HexMapEditorPlugin);

        protected override void InitPlugin(MainForm main)
        {
            base.InitPlugin(main);
            
        }
    }
}
