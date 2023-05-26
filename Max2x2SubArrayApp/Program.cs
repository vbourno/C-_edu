namespace Max2x2SubArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = { { 0, 2, 4, 0, 9, 5 },
                            { 1, 2, 3, 4, 5, 6 },
                            { 3, 4, 5, 6, 7, 8 },
                            { 4, 5, 6, 7, 8, 9 } };

            int[] maxSubarray = GetMaxSubArray(grid)!;
            foreach (int item in  maxSubarray)
            {
                Console.Write(item + " ");
            }
            
        }

        public static int[] GetMaxSubArray(int[,] arr)
        {
            int sum;
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            if (arr == null || arr.GetLength(0) == 0 || arr.GetLength(1) == 0)
            {
                return null!;
            }

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    sum = arr[i, j] + arr[i, j + 1] + arr[i + 1, j] + arr[i + 1, j + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = i;
                        bestCol = j;
                    }
                }
            }
            return new int[] { bestSum, bestRow, bestCol };
        }
    }
}