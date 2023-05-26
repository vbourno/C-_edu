namespace JaggedArraysApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];

            jagged[0] = new int[5];
            jagged[1] = new int[3];
            jagged[2] = new int[7];

            int[][] jagged2 = new int[][]
            {
                new int[] { 1, 2,},
                new int[] { 3, 4, 6 },
                new int[] { 5, 6, 2, 8 } };

            for (int i = 0; i < jagged2.Length; i++)
            {
                for (int j = 0; j < jagged2[i].Length; j++)
                {
                    Console.Write($"{jagged2[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}