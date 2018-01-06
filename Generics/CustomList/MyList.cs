using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomList
{
    public class MyList<T> : IEnumerable where T : IComparable
    {

        private List<T> list = new List<T>();

        public List<T> List { get { return this.list; } }

        public void Add(T element)
        {
            list.Add(element);
        }
        public T Remove(int index)
        {
            T element = list[index];
            list.RemoveAt(index);
            return element;
        }
        public bool Contains(T element)
        {
            return list.Contains(element);
        }
        public void Swap(int index1, int index2)
        {
            T firstElement = list[index1];
            list[index1] = list[index2];
            list[index2] = firstElement;
        }
        public int CountGreaterThan(T element)
        {
            var count = list.Where(x => x.CompareTo(element) > 0).Count();
            return count;
        }
        public T Max()
        {
            return list.Max();
        }
        public T Min()
        {
            return list.Min();
        }
        public void Sort()
        {
            this.list.Sort();
        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }

        
    }
}
