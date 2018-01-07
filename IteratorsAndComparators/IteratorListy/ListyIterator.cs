using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorListy
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> list;
        private int currentIndex = 0;

        public ListyIterator(List<T> list)
        {
            this.list = new List<T>();
            this.list = list;
        }

        public bool Move()
        {
            if (this.currentIndex+1 < this.list.Count)
            {
                currentIndex++;
                return true;
            }
            return false;
        }

        public bool HasNext() => this.currentIndex + 1 < this.list.Count;

        public void Print()
        {
            if (this.list.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(list[currentIndex]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                yield return this.list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void PrintAll()
        {
            var sb = new StringBuilder();
            foreach (var item in this.list)
            {
                sb.Append($"{item.ToString()} ");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
