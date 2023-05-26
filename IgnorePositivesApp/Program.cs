namespace IgnorePositivesApp
{
    /// <summary>
    /// Ignores positives and prints negative count.
    /// (needs the addition of a while...)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Please insert different ints");

            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Error in input");
                Environment.Exit(1);
            }

            while (num != 0) 
            {
                if (num < 0) count++;
                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine("Error in input");
                    Environment.Exit(1);
                }
            }

            Console.WriteLine($"Negatives' count: {count}");
        }
    }
}