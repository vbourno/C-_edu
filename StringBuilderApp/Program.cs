using System.Text;

namespace StringBuilderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new();

            for (int i = 1; i < 1000; i++) 
            {
                sb.Append (i.ToString());
            }

            Console.WriteLine(sb);
        }
    }
}