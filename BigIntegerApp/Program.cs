using System.Numerics;

namespace BigIntegerApp
{
    /// <summary>
    /// Prints the a^b.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //int b;
            BigInteger result = 1;

            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Error in grades sum");
            }

            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Error in grades count");
            }

            for (int i =1; i <= b; i++) 
            {
                result *= a;
            }

            Console.WriteLine($"{a}^{b} = {result}");
        }
    }
}