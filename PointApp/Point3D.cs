using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointApp
{
    internal class Point3D : Point2D
    {
        public int Z { get; set; }

        public static Point3D GetPoint3D()
        {
            return new Point3D();
        }

        public override void Move10()
        {
            base.Move10();
            Z += 10;
        }

        public override string ToString()
        {
            return base.ToString() + " z = " + Z;
        }
    }
}
