using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    internal class Line : AbstractShape
    {
        public double Length { get; set; }

        public Line() { }

        public Line(long id, double length)
        {
            Id = id;
            Length = length;
        }
        public override string ToString()
        {
            return $"Id: {Id} Length: {Length}";
        }
    }
}
