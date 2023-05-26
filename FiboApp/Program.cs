namespace FiboApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type an int");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Error in int");
                Environment.Exit(1);
            }

            Console.WriteLine(FiboIterVars(n));
            Console.WriteLine(FiboArray(n));
            Console.WriteLine(FiboRecursive(n));

        }

        public static int FiboIterVars(int n)
        {
            int a = 0;
            int b = 1;
            int c = 1;

            for (int i = 1;  i < n; i++) 
            {
                c = a + b;
                a = b; 
                b = c;
            }
            return c;
        }

        public static int FiboArray(int n)
        {
            int[] arr = new int[n + 1];
            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                arr[i] = arr[i-1] + arr[i-2];
            }
            return arr[n];
        }

        public static int? FiboRecursive(int n)
        {
            int? fibo;

            if (n > 1)
            {
                fibo = FiboRecursive(n - 1) + FiboRecursive(n - 2);
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n == 0)
            {
                return 0;
            }
            else
            {
                fibo = null;
                Console.WriteLine("Error");
            }

            return fibo;
        }
    }
}