namespace SwapTuplesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Swap();
        }

        public static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }
    }
}