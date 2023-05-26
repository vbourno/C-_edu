using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInterfaceApp
{
    internal class Point3D : Point2D, IMoveable
    {
        public int Z { get; set; }

        sealed public override void Move5()
        {
            base.Move5();
            Z += 5;
        }

        public override string ToString()
        {
            return base.ToString() + ", z = " + Z;
        }
    }
}
