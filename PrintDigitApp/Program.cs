namespace PrintDigitApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = -12345678;
            PrintDigit(n);
        }

        public static void PrintDigit(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("-");
                n = -n;
            }

            if (Convert.ToBoolean(n / 10)) PrintDigit(n / 10);
            Console.WriteLine(n % 10);
        }
    }
}