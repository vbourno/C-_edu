namespace ForApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "London", "Paris", "Milan", "Athens", "New York" };

            for (int i = 0; i < cities.Length; i++) 
            {
                Console.Write(cities[i] + " ");
                
            }
            Console.WriteLine();
            foreach (string city in cities) 
            {
                Console.Write(city + " ");
            }
        }
    }
}