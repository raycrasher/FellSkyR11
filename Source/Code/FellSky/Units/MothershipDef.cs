using Duality;
using Duality.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Units
{
    public class MothershipDef: Resource
    {
        private string displayName;
        private HangarSlot[] hangarSlots;
        private ContentRef<Pixmap> pixmap;
        private int pixmapIndex;

        public string DisplayName { get => displayName; set => displayName = value; }
        public HangarSlot[] Slots { get => hangarSlots; set => hangarSlots = value; }
        public ContentRef<Pixmap> Pixmap { get => pixmap; set => pixmap = value; }
        public int PixmapIndex { get => pixmapIndex; set => pixmapIndex = value; }
        
    }
}
