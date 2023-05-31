using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSOAApp.Model
{
    internal class Point : IEquatable<Point>, IComparable<Point>
    {
        public int X { get; set; }

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
            if (other is null) return false;
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
    }
}
