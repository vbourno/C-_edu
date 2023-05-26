namespace GradesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradesSum;
            int gradesCount;
            int average;

            Console.WriteLine("Please insert grades sum and grades count");
            if (!int.TryParse(Console.ReadLine(), out gradesSum) )
            {
                Console.WriteLine("Error in grades sum");
            }

            if (!int.TryParse(Console.ReadLine(), out gradesCount))
            {
                Console.WriteLine("Error in grades count");
            }

            if (gradesCount == 0) 
            {
                Console.WriteLine("Error: grades count is zero");
            }

            average = gradesSum / gradesCount;
            Console.WriteLine($"The average of {gradesSum} / {gradesCount} is {average}");
            if (average >= 8) Console.WriteLine("Excellent");
            else if (average >= 6) Console.WriteLine("Very good");
            else if (average >= 5) Console.WriteLine("Good");
            else Console.WriteLine("Fail");
        }
    }
}