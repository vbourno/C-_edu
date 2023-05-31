using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    internal class SLList<T>
    {
        public GenericNode<T>? Head { get; set; }

        public SLList()
        {
            Head = null;
        }

        /// <summary>
        /// Inserts first node.
        /// </summary>
        /// <param name="t">The value of T</param>
        public void InsertFirst(T t)
        {
            GenericNode<T> tmp = new GenericNode<T>();
            tmp.Value = t;
            tmp.Next = Head;
            Head = tmp;
        }

        /// <summary>
        /// Removes the first node.
        /// </summary>
        /// <returns>The first node</returns>
        public GenericNode<T>? RemoveFirst()
        {
            if (Head == null)
            {
                return null;
            }

            GenericNode<T> tmp = Head;
            Head = Head.Next;
            return tmp;
        }

        /// <summary>
        /// Inserts last node.
        /// </summary>
        /// <param name="t">The value of T</param>
        public void InsertLast(T t) 
        {
            if (Head == null) 
            {
                InsertFirst(t);
                return;
            }

            GenericNode<T> tmp = new();
            tmp.Value = t;
            tmp.Next = null;

            GenericNode<T> node;

            for (node = Head; node.Next != null; node = node.Next) { }

            node.Next = tmp;
        }

        /// <summary>
        /// Removes last node.
        /// </summary>
        /// <returns>The last node</returns>
        public GenericNode<T>? RemoveLast() 
        {
            // If List.size() == 0
            if (Head == null)
            {
                return null;
            }

            GenericNode<T> tmp;

            // If List.size() == 1
            if (Head.Next == null) 
            {
                tmp = Head;
                Head = null;
                return tmp;
            }

            GenericNode<T>? node;

            for (node = Head; node.Next?.Next != null; node = node.Next) { }
            tmp = node.Next!;
            node.Next = null;
            return tmp;
        }

        /// <summary>
        /// Traverses the list.
        /// </summary>
        public void Traverse()
        {
            if (Head == null) 
            {
                //throw new ListIsEmptyException();
                Console.WriteLine("List is empty");
                return;
            }

            GenericNode<T> node = Head;

            /*while (node != null) 
            {
                Console.WriteLine($"Value: {node.Value}");
                node = node.Next!;
            }*/

                for (node = Head; node != null; node = node.Next!) 
                {
                    Console.WriteLine($"Value: {node.Value}");
                }
            }

    }
}

