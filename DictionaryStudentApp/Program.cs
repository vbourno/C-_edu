namespace DictionaryStudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Student> map = new Dictionary<int, Student>();

            map.Add(1, new Student() { Id = 1, Firstname = "Alice", Lastname = "W."});
            map.Add(2, new Student() { Id = 2, Firstname = "Bob", Lastname = "Dylan." });
            map.Add(3, new Student() { Id = 3, Firstname = "Chris", Lastname = "R." });

            map.Remove(3);

            map[2] = new() { Id = 3, Firstname = "Elon", Lastname = "M." };
            if (map.ContainsKey(1)) 
            {
                Student student = map[1];
            }

            Console.WriteLine("Dict size: " + map.Count);

            foreach (KeyValuePair<int, Student> kvp in map)
            {
                Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
            }
        }
    }
}