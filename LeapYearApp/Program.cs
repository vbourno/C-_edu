namespace LeapYearApp
{
    /// <summary>
    /// Finds leap years.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2000;
            Console.WriteLine(IsLeap(year));
        }

        public static bool IsLeap(int year)
        {
            return (year % 4 == 0) && !(((year % 100) == 0) && (year % 400 != 0));
        }
    }
}