namespace SinglyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SLList<int> intList = new SLList<int>();

            intList.InsertFirst(1);
            intList.InsertLast(2);
            intList.InsertLast(3);
            intList.InsertLast(4);
            intList.InsertLast(5);
            intList.InsertLast(6);

            GenericNode<int>? removedItem = intList.RemoveLast();

            Console.WriteLine($"Removed item: {removedItem?.Value}");
            Console.WriteLine();

            intList.Traverse();
            Console.WriteLine();

            removedItem = intList.RemoveFirst();
            Console.WriteLine($"Removed item: {removedItem?.Value}");
            Console.WriteLine();

            intList.Traverse();
        }
    }
}