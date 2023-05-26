namespace ReadApp
{
    /// <summary>
    /// Reads, checks and writes a num.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine()!;
            int value;

            if (int.TryParse(str, out value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}