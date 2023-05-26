namespace ExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            while (true) 
            {
                try
                {
                    Console.WriteLine("Please insert an int or 0 for quit");
                    num = int.Parse(Console.ReadLine()!);       // FormatException

                    Console.WriteLine($"You inserted {num}");
                    if (num == 0) break;
                } catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}