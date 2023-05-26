namespace DaysHoursMinutesSecondsToSecondsApp
{
    /// <summary>
    /// Receives a number of days, hours, minutes and seconds
    /// and converts them to the correpondent total seconds.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int days;
            int hours;
            int minutes;
            int seconds;
            int totalSeconds;

            Console.WriteLine("Please insert a number of days: ");
            days = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Please insert a number of hours: ");
            hours = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Please insert a number of minutes: ");
            minutes = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Please insert a number of seconds: ");
            seconds = int.Parse(Console.ReadLine()!);

            totalSeconds = (days * 24 * 60 * 60) + (hours * 60 * 60) + (minutes * 60) + seconds;
            Console.WriteLine("{0} days, {1} hours, {2} minutes and {3} seconds equal to {4:N0} total seconds", days, hours, minutes, seconds, totalSeconds);
        }
    }
}