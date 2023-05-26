namespace PrimesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Please insert a positive number");
            num = int.Parse(Console.ReadLine()!);

            for (int i = 1; i < num; i++) 
            {
                if (IsPrime(i)) Console.WriteLine(i + " is prime");
            }
        }

        public static bool IsPrime(int n)
        {
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(n);
            bool isPrime = true;

            while (isPrime && (divider <= maxDivider)) 
            {
                if (n % divider == 0) 
                {
                    isPrime = false;
                }
                divider++;
            }
            return isPrime;
        }
    }
}