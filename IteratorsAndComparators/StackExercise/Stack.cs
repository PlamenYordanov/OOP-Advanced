using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackExercise
{
    public class Stack<T> : IEnumerable<T>
    {
        public Stack(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException("Value must be non-negative");
            }
            this.stack = new T[n];
        }

        private T[] stack;
        private int currentIndex = -1;

        public void Push(T item)
        {
            if (++currentIndex >= stack.Length)
            {
                Array.Resize(ref stack, stack.Length + 1);
            }

            stack[currentIndex] = item;
        }

        public T Pop()
        {
            if (currentIndex < 0)
            {
                throw new InvalidOperationException("No elements");
            }
            T value = stack[currentIndex--];
            stack = stack.Take(stack.Length - 1).ToArray();
            return value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Length - 1; i >= 0; i--)
            {
                var element = stack[i];
                yield return element;
            }
        }

        
    }
}
