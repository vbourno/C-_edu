namespace PointInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMoveable p1 = new Point() { X = 10 };
            IMoveable p2 = new Point2D() { X = 20 };

            // Wiring
            MovingSpace ms1 = new MovingSpace(p1);
            MovingSpace ms2 = new MovingSpace(p2);

            ms1.MakeMove5();
            ms2.MakeMove5();

            p1.Move5();
            p2.Move5();

            DoMove5(p2);
            
        }

        public static void DoMove5(IMoveable moveable)
        {
            moveable.Move5();
        }
    }
}