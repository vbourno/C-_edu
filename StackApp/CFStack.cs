using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    internal class CFStack
    {
        public int[] Stack { get; set; } = null!;
        public int Top { get; set; }
        public int Size { get; set; }

        // Static Factory
        public static CFStack GetStack(int n)
        {
            return new CFStack()
            {
                Stack = new int[n],
                Top = 0,
                Size = n
            };
        }

        public void Push(int num)
        {
            try
            {
                if (!isFull())
                {
                    Stack[Top++] = num;
                }
                else
                {
                    throw new StackIsFullException("Stack is full");
                }
            }
            catch (StackIsFullException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        public int Pop()
        {
            try
            {
                if (isEmpty())
                {
                    throw new StackIsEmptyException("Stack is empty");
                }
                Top--;
                return Stack[Top];
            }
            catch (StackIsEmptyException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        public bool isEmpty()
        {
            return Top == 0;
        }

        public bool isFull()
        {
            return Top == Size;
        }

        public void Traverse()
        {
            for (int i = Top - 1; i >= 0; i--) 
            {
                Console.WriteLine($"{i,2}: {Stack[i]}");
            }
        }
    }
}
