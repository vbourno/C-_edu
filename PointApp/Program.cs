namespace PointApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new();
            Point2D p2 = new();
            Point3D p3 = new();

            List<Point> points = new() { p1, 
                                        new Point2D {X = 5, Y = 10 }, 
                                        new Point3D { X = 3, Y = 6, Z = 19} ,
                                        p3
                                    };

            foreach (Point point in points) 
            {
                Console.WriteLine(point);
            }

            // Subtype polymorphism
            Point p4 = new Point2D() { X = 10, Y = 30};

            p1.X = 10;

            p2.X = 20;
            p2.Y = 30;

            p3.X = 40;
            p3.Y = 50;
            p3.Z = 60;

            p3.Move10();

            // Downcast to Point2D
            p4.Move10();

            Console.WriteLine($"p1 => {p1}");
            Console.WriteLine($"p2 => {p2}");
            Console.WriteLine($"p3 => {p3}");
            Console.WriteLine($"p4 => {p4}");

            DoPrintPoint(p1);
            DoPrintPoint(p4);

            MakeMove10(p2);
            MakeMove10(p3);
        }

        public static void DoPrintPoint(Point point )
        {
            Console.WriteLine(point);
        }

        public static void MakeMove10(Point point) 
        {
            point.Move10();
        }
    }
}