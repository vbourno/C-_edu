﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInterfaceApp
{
    internal class Point : IMoveable
    {
        public int X {get; set; }

        public virtual void Move5()
        {
            X += 5;
        }

        public override string ToString()
        {
            return "x = " + X;
        }
    }
}
