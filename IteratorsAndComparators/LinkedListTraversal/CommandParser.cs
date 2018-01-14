namespace LinkedListTraversal
{
    using System;

    public class CommandParser
    {
        private MyLinkedList linkedList;

        public CommandParser(MyLinkedList list)
        {
            this.linkedList = new MyLinkedList();
            this.linkedList = list;
        }
        public void ParseCommand(string command, int value)
        {
            switch (command)
            {
                case "Add":
                    this.linkedList.AddToEnd(value);
                    break;
                case "Remove":
                    this.linkedList.RemoveFirstOccurance(value);
                    break;
                default:
                    break;
            }
        }
        //public void Print()
        //{
        //    this.linkedList.Print();
        //}
    }
}
