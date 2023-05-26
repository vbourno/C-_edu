namespace ArraysApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3]; // arr.Length == 3
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 2;

            // unsized array init
            int[] arr2 = {1, 2, 3, 4};

            // array initializer
            int[] arr3 = new int[] {1, 2, 3, 4};

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();

            foreach (int item in arr2)
            {
                Console.Write(item + " ");
            }
        }
    }
}