namespace DeclareExprPrintApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int result;

            result = num1 + num2;

            Console.WriteLine("Το άθροισμα των " + num1 + " και " + num2 + " είναι: " + result);
            Console.WriteLine("Το άθροισμα των {0} και {1} είναι: {2}", num1, num2, result);
            Console.WriteLine($"Το άθροισμα των {num1} και {num2} είναι: {result}");
        }
    }
}