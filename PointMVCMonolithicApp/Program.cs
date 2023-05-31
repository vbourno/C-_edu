namespace PointMVCMonolithicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point() { X = 1 };
            Point p2 = new Point() { X = 2 };
            Point p3 = new Point() { X = 3 };
            Point p4 = new () { X=4 };
            Point p5 = new () { X = 5 };

            p1.InsertPointService();
            p2.InsertPointService();
            p3.InsertPointService();
            p4.InsertPointService();
            p5.InsertPointService();
            p5.DeletePointService();
            p4.UpdatePointService(90);

            Point? tmp = p1.GetPointService();
            Console.WriteLine($"tmp: { tmp}");

            foreach (Point p in Point.GetAllPointsService())
            {
                Console.WriteLine(p);
            }
        }
    }
}