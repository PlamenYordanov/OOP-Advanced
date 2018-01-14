namespace LinkedListTraversal
{
    using System;
    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var list = new MyLinkedList();
            var commandParser = new CommandParser(list);
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];
                var value = int.Parse(input[1]);
                commandParser.ParseCommand(command, value);
            }

            Console.WriteLine(list.Count);
            list.Print();
        }
    }
}
