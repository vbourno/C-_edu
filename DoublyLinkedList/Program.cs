namespace DoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DLList<int>? intList = new();

            intList.InsertFirst(1);
            intList.InsertLast(2);
            intList.InsertLast(3);
            intList.InsertLast(4);
            intList.InsertLast(5);
            intList.InsertLast(6);

            GenericNode<int>? removedItem = intList.RemoveLast();
            Console.WriteLine($"Removed item: {removedItem?.Value}");

            removedItem = intList.RemoveFirst();
            Console.WriteLine($"Removed first item: {removedItem?.Value}");

            intList.Traverse();
        }
    }
}