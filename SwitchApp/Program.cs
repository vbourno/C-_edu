namespace SwitchApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("Please insert choice");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Error in choice");
                    continue;
                }

                switch (choice) 
                {
                    case 1:
                        Console.WriteLine("Insert");
                        break;
                    case 2:
                        Console.WriteLine("Update");
                        break;
                    case 3:
                        Console.WriteLine("Delete");
                        break;
                    case 4:
                        Console.WriteLine("Select");
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        break;
                }
            } while (choice != 5);
        }
    }
}