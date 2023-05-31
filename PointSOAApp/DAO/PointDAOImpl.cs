using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointSOAApp.Model;

namespace PointSOAApp.DAO
{
    internal class PointDAOImpl : IPointDAO
    {
        private static readonly List<Point> points = new();
        public static List<Point> Points { get { return new List<Point>(points); } }

        public void Insert(Point p)
        {
            Points.Add(p);
        }

        public bool Update(Point p, int x)
        {
            int positionToUpdate = GetPointIndex(p);
            
            if (positionToUpdate < 0)
            {
                return false;
            }
            points[positionToUpdate].X = x;
            return true;
        }

        public Point? Delete(Point p)
        {
            if (!Points.Remove(p))
            {
                return null;
            }
            return p;
        }

        public Point? GetOnePoint(Point p)
        {
            return (points.Contains(p) ? points[GetPointIndex(p)] : null);
        }

        public List<Point> GetAll()
        {
            return Points;
        }

        private int GetPointIndex(Point p) => Points.IndexOf(p);
      
    }
}
