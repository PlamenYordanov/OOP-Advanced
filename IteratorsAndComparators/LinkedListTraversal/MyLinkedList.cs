namespace LinkedListTraversal
{
    using System;

    public class MyLinkedList
    {
        public MyLinkedList()
        {
            this.headNode = null;
            this.count = 0;
        }
        private Node headNode;
        private int count;
        public int Count
        {
            get { return this.count; }
        }
        public void AddToEnd(int number)
        {
            if (headNode == null)
            {
                headNode = new Node(number);
            }
            else
            {
                headNode.AddToEnd(number);
            }
            count++;
        }
        public void Print()
        {
            if (this.headNode != null)
            {
                this.headNode.Print();
            }
        }
        public bool RemoveFirstOccurance(int number)
        {
            var node = this.First();
            if (node.Number == number)
            {
                this.headNode = node.Next;
                count--;
                return true;
            }
            else
            {
                while (true)
                {
                    if (node.Next == null)
                    {
                        break;
                    }
                    Node nextNode = node.Next;

                    if (nextNode.Number == number)
                    {
                        node.Next = nextNode.Next;
                        count--;
                        return true;
                    }

                    node = node.Next;
                }
            }
            return false;
        }
        public Node First()
        {
            return this.headNode;
        }
    }
}
