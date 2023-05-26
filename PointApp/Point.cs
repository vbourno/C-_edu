using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointApp
{
    internal class Point
    {
        public int X { get; set; }

        public static Point GetPoint()
        {
            return new Point();
        }

        public virtual void Move10()
        {
            X += 10;
        }

        public override string ToString() => $"x = {X}";
        
    }
}
