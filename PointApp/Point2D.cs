using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointApp
{
    internal class Point2D : Point
    {
        public int Y { get; set; }

        public Point2D() : base() { }

        // Static Factory
        public static Point2D GetPoint2D()
        {
            return new Point2D();
        }

        public override void Move10()
        {
            base.Move10();
            Y += 10;
        }

        public override string ToString()
        {
            return base.ToString() + " y = " + Y;
        }
    }
}
