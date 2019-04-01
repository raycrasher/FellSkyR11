using Duality;
using FellSky.Units;
using System.Collections.Generic;

namespace FellSky.Map
{
    public class HexMapTileDef : Resource
    {
        private Dictionary<MoveTypes, float> moveMult;
        private Dictionary<MoveTypes, int> moveAdd;

        public Dictionary<MoveTypes, float> MoveMult { get => moveMult; set => moveMult = value; }
        public Dictionary<MoveTypes, int> MoveAdd { get => moveAdd; set => moveAdd = value; }

        public bool BlocksFlight { get; set; }
        public bool BlocksSurface { get; set; }
        public bool BlocksVisibility { get; set; }
        public bool HasCover { get; set; }
        public bool IsUnstableSurface { get; set; }
        public bool HasSolidSurface { get; set; }
        public bool HasLiquid { get; set; }
        public bool HasAir { get; set; }
        public bool HasAtmo { get; set; }
        public bool HasGravity { get; set; }
    }
}