using Duality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duality.HexMap
{
    public static class HexMapExtensions
    {
        public static Vector2 ToVector2(this ca.axoninteractive.Geometry.Hex.Vec2D v2d)
        {
            return new Vector2(v2d.x, v2d.y);
        }
        public static Vector3 ToVector3(this ca.axoninteractive.Geometry.Hex.Vec2D v2d, float z=0)
        {
            return new Vector3(v2d.x, v2d.y, z);
        }
    }
}
