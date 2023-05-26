using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInterfaceApp
{
    internal class MovingSpace
    {
        private IMoveable moveable;

        //DI - IoC (Dependency Injection - Inversion of Control)
        public MovingSpace(IMoveable moveable)
        {
            this.moveable = moveable;
        }

        public void MakeMove5()
        {
            moveable.Move5();
        }
    }
}
