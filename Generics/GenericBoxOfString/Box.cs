using System;

namespace GenericBoxOfString
{
    public class Box<T> where T: IComparable
    {
        public Box(T value)
        {
            this.Element = value;
        }
        public T Element { get; set; }

        public int CompareTo(T other)
        {
            return other.CompareTo(Element);
        }

        public override string ToString()
        {
            return $"{Element.GetType().FullName}: {this.Element}";
        }
    }
}
