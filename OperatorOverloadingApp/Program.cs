namespace OperatorOverloadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Fraction(1, 2);
            var b = new Fraction(2, 3);

            Console.WriteLine(-a);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }
    }
}