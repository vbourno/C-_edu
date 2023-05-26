namespace DigitsCountApp
{
    /// <summary>
    /// Counts the number of digits in an int.
    /// For instance 123 -> 3
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int digitsCount = 0;
            int result;

            Console.WriteLine("Please insert an int");
            
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Error in int");
                Environment.Exit(1);
            }

            result = num;
            do
            {
                result /= 10;
                digitsCount++;
            } while (result != 0);

            Console.WriteLine($"Digits Count: {digitsCount}");
        }
    }
}