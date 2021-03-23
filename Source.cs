using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Stack<T>
    {
        LinkedList<T> list;
        int size;

        public Stack()
        {
            list = new LinkedList<T>();
            size = 0;
        }

        public int Size()
        {
            return size;
        }

        public T Pop()
        {
            if (size == 0) return default;
            T item = list.First.Value;
            list.RemoveFirst();
            size--;
            return item;
        }

        public void Push(T val)
        {
            list.AddFirst(val);
            size++;
        }

        public T Peek()
        {
            if (size == 0) return default;
            return list.First.Value;
        }

        static public bool ValidBraces(string sequence)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char brace in sequence)
            {
                if (brace == '(')
                {
                    stack.Push(brace);
                }
                else
                {
                    if (stack.Pop() != '(')
                    {
                        return false;
                    }
                }
            }
            return stack.Size() == 0;
        }
    }



}
