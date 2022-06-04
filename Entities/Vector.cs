using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThroughTheWalls.Entities
{
    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static Vector Up { get { return new Vector(0, -1); } }
        public static Vector Down { get { return new Vector(0, 1); } }
        public static Vector Right { get { return new Vector(1, 0); } }
        public static Vector Left { get { return new Vector(-1, 0); } }
        public static Vector Zero { get { return new Vector(0, 0); } }


        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
