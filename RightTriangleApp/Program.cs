namespace RightTriangleApp
{
    /// <summary>
    /// Checks if a triangle is a right triangle.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const double EPSILON = 0.000005;
            double a;
            double b;
            double c;
            bool isRight;

            Console.WriteLine("Δώστε υποτείνουσα και δύο κάθετες");
            a = double.Parse(Console.ReadLine()!);
            b = double.Parse(Console.ReadLine()!);
            c = double.Parse(Console.ReadLine() !);

            isRight = Math.Abs(a*a - b*b - c*c) <= EPSILON;

            Console.WriteLine("Το τρίγωνο{0}είναι ορθογώνιο", (isRight ? " " : " δεν "));
        }
    }
}