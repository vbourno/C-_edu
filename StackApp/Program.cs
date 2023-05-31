namespace StackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CFStack stack = CFStack.GetStack(15);

            try
            {
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);
                stack.Push(5);
                stack.Push(6);
                stack.Push(7);
                stack.Push(8);
                stack.Push(9);
                stack.Push(10);
                stack.Pop();
                stack.Pop();

                stack.Traverse();
            }
            catch (StackIsFullException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (StackIsEmptyException e2)
            {
                Console.WriteLine(e2.Message);
            }
        }
    }
}