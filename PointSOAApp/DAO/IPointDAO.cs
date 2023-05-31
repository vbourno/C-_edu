using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointSOAApp.Model;

namespace PointSOAApp.DAO
{
    internal interface IPointDAO
    {
        void Insert(Point p);
        bool Update(Point p, int x);
        Point? Delete(Point p);
        Point? GetOnePoint(Point p);
        List<Point> GetAll();
    }
}
