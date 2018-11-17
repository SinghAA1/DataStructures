using System;

namespace Stacks
{
    public class Stack<T>
    {
        Node first;

        public bool IsEmpty()
        {
            return first == null;
        }

        public void Push(T newHead)
        {
            var temp = new Node { Item = newHead, Next = first };
            first = temp;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new StackUnderflowException();
            }

            var headItem = first.Item;
            first = first.Next;
            return headItem;
        }

        class Node
        {
            public T Item { get; set; }
            public Node Next { get; set; }
        }
    }


    public class StackUnderflowException : Exception
    {

    }
}
