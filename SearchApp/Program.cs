namespace SearchApp
{
    /// <summary>
    /// Searches for a specific element value.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 5, 9, 1, 6, 70 };
            const int KEY = 1;
            int keyPosition;

            keyPosition = GetPosition(values, KEY);
            Console.WriteLine($"Key {KEY} position is {keyPosition}");
        }

        public static int GetPosition(int[] arr, int key)
        {
            int position = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    position = i;
                    break;
                }

            }
            return position;
        }

        public static int GetMin(int[] arr)
        {
            int min = int.MaxValue;
            if (arr == null) throw new Exception();

            for (int i = 0; arr.Length > 0; i++)
            {
                min = Math.Min(min, arr[i]);
            }

            return min;
        }

        public static int GetMin2(int[] arr)
        {
            if (arr == null || arr.Length == 0) throw new Exception();

            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Selection Sort.
        /// </summary>
        /// <param name="arr"></param>
        public static void sort(int[] arr)
        {
            int min;
            int minPosition = 0;
            int tmp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        minPosition = j;
                    }
                }

                // Swap
                tmp = arr[i];
                arr[i] = arr[minPosition];
                arr[minPosition] = tmp;
            }
        }
    }
}