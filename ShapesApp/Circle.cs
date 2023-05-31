using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    internal class Circle : AbstractShape, ITwoDimensional
    {
        public double Radius { get; set; }

        public Circle() { }

        public Circle(long id,  double radius)
        {
            Id = id;
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Id: {Id} Radius: {Radius}";
        }
    }
}
