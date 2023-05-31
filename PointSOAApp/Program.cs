using PointSOAApp.DTO;
using PointSOAApp.Model;
using PointSOAApp.Service;
namespace PointSOAApp
{
    internal class Program
    {
        static IPointService Service = new PointServiceImpl(null);

        static void Main(string[] args)
        {
            PointDTO p1 = new() { X = 5 };
            PointDTO p2 = new() { X = 2 };
            PointDTO p3 = new() { X = 1 };
            PointDTO p4 = new() { X = 4 };
            PointDTO p5 = new() { X = 5 };

            Service.InsertPoint(p1);
            Service.InsertPoint(p2);
            Service.InsertPoint(p3);
            Service.InsertPoint(p4);
            Service.InsertPoint(p5);
            Service.UpdatePoint(p1, 18);
            Service.UpdatePoint(p2, 90);

            foreach (Point p in Service.GetAllPoints())
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            List<Point> list = Service.GetAllPoints();
            list.Sort();

            foreach (Point p in list)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            list.Reverse();

            foreach (Point p in list)
            {
                Console.WriteLine();
            }
        }
    }
}