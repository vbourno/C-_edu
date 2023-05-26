namespace StudentFinalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student alice = new Student();
            // Student bob = new Student(2, "Bob", "Dylan");
            Student bob = new () { Id = 2, FirstName = "Bob", LastName = "Dylan" };

            bob.FirstName = "Chris";
            Console.WriteLine($"{bob.Id} {bob.FirstName} {bob.LastName}");
        }
    }
}