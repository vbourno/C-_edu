using System.Text.RegularExpressions;

namespace RegExApp
{
    /// <summary>
    /// Calculator App
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string? expr;
            string[] tokens = null!;
            int num1;
            int num2;
            string op;
            int result = 0;

            Console.WriteLine("Please insert an arithmetic expression");
            expr = Console.ReadLine();

            if (expr != null) 
            {
                tokens = Regex.Split(expr, @"\s+");
            }
            
            num1 = int.Parse(tokens[0]);
            num2 = int.Parse(tokens[2]);
            op = tokens[1];

            switch (op) 
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        result = 0;
                    } else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}