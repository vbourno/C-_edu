namespace FloatDoubleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float f = 0F;
            double d = 0D;

            Console.WriteLine("Please provide two floating-points");
            f = float.Parse(Console.ReadLine()!);
            d = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"f = {f:N2} \t d = {d:N2}");
        }
    }
}