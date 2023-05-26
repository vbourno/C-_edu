namespace CharReadApp
{
    /// <summary>
    /// Reads and writes chars until return is pressed.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int ord;

            Console.WriteLine("Please write");

            do
            { 
                ord = Console.Read();
                ch = (char)ord;
                Console.WriteLine($"char: {ch} -- ordinal: {ord}");
            } while (ord != 10);
        }
    }
}