namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student alice = new Student();
            Student bob = new();
            var chris = new Student();

            alice.Id = 1;
            alice.Firstname = "Alice";
            alice.Lastname = "W.";

            Console.WriteLine($"{alice.Id} {alice.Firstname} {alice.Lastname}");
        }
    }
}