namespace SwitchFallThroughApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert grade");
            if (!int.TryParse(Console.ReadLine(), out int grade))
            {
                Console.WriteLine("Error in grade");
                Environment.Exit(1);
            }

            switch (grade) 
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                
                    Console.WriteLine("Fail");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Good");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Very good");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("Excellent");
                    break;
                default:
                    Console.WriteLine("Error in grade");
                    break;
            }
        }
    }
}