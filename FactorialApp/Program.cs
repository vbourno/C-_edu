namespace FactorialApp
{
    /// <summary>
    /// Factorial n.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            
            Console.WriteLine($"{n}! = {Factorial(n):N0}");
        }

        /// <summary>
        /// Returns n!
        /// </summary>
        /// <param name="n">The input number.</param>
        /// <returns>The result of n!.</returns>
        public static int Factorial (int n)
        {
            int facto = 1;

            while (true) 
            {
                if (n < 1 )
                {
                    break;
                }

                facto *= n;
                n--;
            }
            return facto;
        }
    }
}