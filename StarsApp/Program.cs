namespace StarsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Please insert n");
            n = int.Parse(Console.ReadLine()!);

            PrintStarsHV(n);
            PrintStarsHVAsc(n);
            PrintStarsHVDesc(n);
        }

        /// <summary>
        /// Prints n*n stars.
        /// </summary>
        /// <param name="n"></param>
        public static void PrintStarsHV(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Prints stars in ascending order.
        /// </summary>
        /// <param name="n"></param>
        public static void PrintStarsHVAsc(int n)
        {
            for ( int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Prints stars in descending order.
        /// </summary>
        /// <param name="n"></param>
        public static void PrintStarsHVDesc(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}