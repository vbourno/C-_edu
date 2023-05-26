namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Swap(ref a, ref b);

            Console.WriteLine(a + " " + b);

            string s = "AUEB";
            ChangeStr(out s);
            Console.WriteLine(s);
        }

        public static void Swap(ref int a, ref int b) 
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static void ChangeStr(out string str)
        {
            str = "Coding";
        }
    }
}