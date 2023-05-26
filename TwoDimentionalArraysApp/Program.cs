namespace TwoDimentionalArraysApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];
            double[,] doubleArr = new double[4, 5];
            string[,,] stringCube = new string[4, 2, 2];

            int[,] matrix = { { 1, 2, 3, 4 }, 
                              { 5, 6, 7, 8 } };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}