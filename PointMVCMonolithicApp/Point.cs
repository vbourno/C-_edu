using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointMVCMonolithicApp
{
    internal class Point : IComparable<Point>, IEquatable<Point>
    {
        public int X { get; set; }

        private static readonly List<Point> points = new();
        public static List<Point> Points { get {  return new List<Point>(points); } }

        public int CompareTo(Point? other)
        {
            return X - other!.X;
        }

        /// <summary>
        /// Implements IEquatable.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Point? other)
        {
            if (other == null) return false;
            return CompareTo(other) == 0;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || GetType() != obj.GetType()) return false;

            return CompareTo((Point)obj) == 0;
        }

        public override int GetHashCode()
        {
            return X;
        }

        public override string? ToString()
        {
            return "x = " + X;
        }

        public static bool operator >(Point p1, Point p2)
        {
            return p1.CompareTo(p2) > 0;
        }

        public static bool operator <(Point p1, Point p2)
        {
            return p1.CompareTo(p2) < 0;
        }

        public static bool operator >=(Point p1, Point p2)
        {
            return p1.CompareTo(p2) >= 0;
        }

        public static bool operator <=(Point p1, Point p2)
        {
            return p1.CompareTo(p2) <= 0;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            if (p1 is null || p2 is null) return false;
            if (ReferenceEquals(p1, p2)) return true;

            return p1.CompareTo(p2) == 0;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            if (p1 is null || p2 is null) return false;

            return p1.CompareTo(p2) != 0;
        }

        // DAO - CRUD API
        /// <summary>
        /// 
        /// </summary>
        public void Insert()
        {
            points.Add(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Point? Delete()
        {
            if (!points.Remove(this))
            {
                return null;
            }
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool Update(int x)
        {
            int positionToUpdate = GetPointPosition();

            if (positionToUpdate < 0)
            {
                return false;
            }

            points[positionToUpdate].X = x;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Point? GetPoint()
        {
            return (points.Contains(this)) ? points[GetPointPosition()] : null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int GetPointPosition()
        {
            return points.IndexOf(this);
        }
    }
}
