namespace IteratorListy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            ListyIterator<string> iterator;
            if (input.Length > 0)
            {
                iterator = new ListyIterator<string>(input.Skip(1).ToList());
            }
            else
            {
                iterator = new ListyIterator<string>(new List<string>());

            }
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                CommandInterpreter(iterator, command);
            }
        }
        public static void CommandInterpreter(ListyIterator<string> iterator, string command)
        {
            try
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(iterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(iterator.HasNext());
                        break;
                    case "Print":
                        iterator.Print();
                        break;
                    case "PrintAll":
                        iterator.PrintAll();
                        break;
                    default:
                        break;
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
