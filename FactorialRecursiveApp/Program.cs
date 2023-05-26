using System.Numerics;

namespace FactorialRecursiveApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine($"Factorial({n}) = {Facto(n):N0}");
        }

        /// <summary>
        /// Returns n! with recusion.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>n!</returns>
        public static BigInteger Facto(int n) 
        {
            return (n == 0) ? 1 : n * Facto(n - 1);
        }
    }
}