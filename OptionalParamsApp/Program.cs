namespace OptionalParamsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            result = Add(1, 2, 3, 4, 5);
            Console.WriteLine(result);

            DateTime dateTime = GetDateTime();
            Console.WriteLine($"{dateTime:D}");

            dateTime = GetDateTime(year: 2020, day: 3);
            Console.WriteLine($"{dateTime:D}");

            dateTime = GetDateTime(2023, 5, 24, 19, 01, 0, 0);
            Console.WriteLine($"{dateTime:F}");
        }

        public static DateTime GetDateTime(int year=1970, int month=1, int day=1, int hour=0, int min=0, int sec=0, int milli=0)
        {
            return new DateTime(year, month, day, hour, min, sec, milli, DateTimeKind.Utc);
        }


        /// <summary>
        /// Varargs.
        /// </summary>
        /// <param name="nums">Zero or more int args.</param>
        /// <returns>The sum.</returns>
        public static int Add(params int[] nums) 
        {
            int sum = 0;

            foreach(int num in nums) 
            {
                sum += num;
            }
            return sum;
        }

        public static float Add(int i, float b) 
        {
            return i + b;
        }
    }
}