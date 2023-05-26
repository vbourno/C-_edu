using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInterfaceApp
{
    internal class Point2D : Point, IMoveable
    {
        public int Y { get; set; }

        public override void Move5()
        {
            base.Move5();
            Y += 5;
        }

        public override string ToString()
        {
            return base.ToString() + ", y = " + Y;
        }
    }
}
