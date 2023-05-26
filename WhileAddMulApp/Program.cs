namespace WhileAddMulApp
{
    /// <summary>
    /// Sum10 and Mul10 with while
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            int mul = 1;

            while (i <= 10)
            {
                sum += i;
                mul *= i;
                i++;
            }
            Console.WriteLine($"Sum10: {sum} - Mul10: {mul}");
        }
    }
}