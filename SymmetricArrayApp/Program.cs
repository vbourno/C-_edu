namespace SymmetricArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 2, 1};   
        }

        public static bool IsSymmetric(int[] arr)
        {
            bool isSymmetric = true;
            int n = arr.Length;

            for (int i = 0; i < n/2; i++) 
            {
                if (arr[i] != arr[n-1-i])
                {
                    isSymmetric = false;
                    break;
                }
            }
            return isSymmetric;
        }

        public static bool IsSymmetric2(int[] arr)
        {
            bool isSymmetric = true;
            int n = arr.Length;

            for (int i = 0, j = n-1; i < j; i++, j--)
            {
                if (arr[i] != arr[j])
                {
                    isSymmetric = false;
                    break;
                }
            }
            return isSymmetric;
        }
    }
}