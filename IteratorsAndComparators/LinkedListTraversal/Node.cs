namespace LinkedListTraversal
{
    public class Node
    {
        public Node(int number)
        {
            this.Number = number;
            this.Next = null;
        }
        private int number;
        private Node next;

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public void AddToEnd(int number)
        {
            if (this.next == null)
            {
                this.next = new Node(number);
            }
            else
            {
                next.AddToEnd(number);
            }
        }
        public void Print()
        {
            System.Console.Write($"{this.number} ");
            if (this.next != null)
            {
                next.Print();
            }
        }
        //public void RemoveFirstOccurance(int number)
        //{
        //    if (this.Next != null && this.Next.Number == number)
        //    {
        //        this.Next = this.Next.Next;
        //    }
        //    else
        //    {
        //        this.Next.RemoveFirstOccurance(number);
        //    }
        //}

    }
}
