namespace NullableStrApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert two strings");
            string? s1 = Console.ReadLine();
            string s2= Console.ReadLine()!;

            if (s1 != null)
            {
                if (s2.Equals("Coding") && s1.Equals("Factory"))
                {
                    Console.WriteLine("!");
             }
            }

            if (s2.Equals("Coding") && s1!.Equals("Factory"))
            {
                Console.WriteLine("!");
             }
        }

        public static string? GetUpper(string? s1) 
        {
            return s1?.ToUpper();
            //if (s1 == null) return null;
            //else return s1.ToUpper();
        }
    }
}