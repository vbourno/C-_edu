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
        public Point? GetOnePoint()
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

        // Services Layer

        public void InsertPointService()
        {
            this.Insert();
        }

        public Point? DeletePointService()
        {
            return Delete();
        }

        public void UpdatePointService(int x)
        {
            try
            {
                if (!Update(x))
                {
                    throw new Exception("Update Error");
                }
            } catch (Exception e) 
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        public Point? GetPointService()
        {
            return GetOnePoint();
        }

        public static List<Point> GetAllPointsService()
        {
            return points;
        }
    }
}
