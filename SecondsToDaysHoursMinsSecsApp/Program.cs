namespace SecondsToDaysHoursMinsSecsApp
{
    /// <summary>
    /// Receives a number of seconds and converts them
    /// to days, hours, minutes and remaining seconds.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int seconds;
            int minutes;
            int hours;
            int days;
            int remainingSeconds;

            Console.WriteLine("Please provide number of seconds");
            seconds = int.Parse(Console.ReadLine()!);
            days = seconds / (60 * 60 * 24);
            remainingSeconds = seconds % (60 * 60 * 24);
            hours = remainingSeconds / (60 * 60);
            remainingSeconds = remainingSeconds % (60 * 60);
            minutes = remainingSeconds / 60;
            remainingSeconds = remainingSeconds % 60;

            Console.WriteLine("{0} seconds equal to {1} days, {2} hours, {3} minutes and {4} seconds",
                                                    seconds, days, hours, minutes, remainingSeconds);
        }
    }
}