using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    internal class DLList<T>
    {
        public GenericNode<T>? Head { get; set; }
        public GenericNode<T>? Tail { get; set; }

        public DLList()
        {
            Head = null;
            Tail = null;
        }

        /// <summary>
        /// Inserts the first node to the list.
        /// </summary>
        /// <param name="t">The value of the node</param>
        public void InsertFirst(T t)
        {
            GenericNode<T> tmp = new();
            tmp.Value = t;
            tmp.Prev = null;
            tmp.Next = Head;

            if (IsEmpty())
            {
                Tail = tmp;
            }

            Head = tmp;
        }


        /// <summary>
        /// Removes the first node of the list.
        /// </summary>
        /// <returns>The first node</returns>
        public GenericNode<T>? RemoveFirst()
        {
            if (IsEmpty())
            {
                return null;
            }

            GenericNode<T>? tmp = Head;

            if (Head?.Next == null)
            {
                Tail = null;
            }
            else
            {
                Head.Next.Prev = null;
            }

            Head = Head?.Next;
            return tmp;
        }

        /// <summary>
        /// Inserts last node to the list.
        /// </summary>
        /// <param name="t">The value of the node.</param>
        public void InsertLast(T t) 
        {
            if(IsEmpty())
            { 
                InsertFirst(t);
                return;
            }

            GenericNode<T>? tmp = new();

            tmp.Value = t;
            tmp.Next = null;
            tmp.Prev = Tail;

            Tail.Next = tmp;
            Tail = tmp;
        }

        /// <summary>
        /// Removes the last node of the list.
        /// </summary>
        /// <returns>The last node.</returns>
        public GenericNode<T>? RemoveLast() 
        {
            if (IsEmpty())
            {
                return null;
            }

            GenericNode<T>? tmp = Tail;

            // Only one node
            if (Tail?.Prev == null)
            {
                Head = null;
            }
            else
            {
                Tail.Prev.Next = null;
            }

            Tail = Tail?.Prev;
            return tmp;
        }

        /// <summary>
        /// Traverses the list and prints the values of the nodes.
        /// </summary>
        public void Traverse()
        {
            if (IsEmpty()) 
            {
                Console.WriteLine("List is empty");
            }

            for (GenericNode<T> node = Head; node != null; node = node.Next)
            {
                Console.WriteLine($"Value: {node.Value}");
            }
        }

        /// <summary>
        /// Checks if the list is empty.
        /// </summary>
        /// <returns>True if the list is empty, false otherwise.</returns>
        public bool IsEmpty()
        {
            return Head == null || Tail == null;
        }
    }
}
