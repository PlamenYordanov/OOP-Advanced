namespace StackExercise
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var args = Console.ReadLine().Split(new[] {' ', ',' },StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<int>(args.Length - 1);
            string command = string.Empty;
            while (true)
            {
                if (command == "END")
                {
                    break;
                }

                CommandInterpreter(stack, args);

                command = Console.ReadLine();
                args = command.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            }
            PrintStack(stack);
            PrintStack(stack);
        }
        public static void CommandInterpreter(Stack<int> s, string[] args)
        {
            try
            {
                var command = args[0];
                switch (command)
                {
                    case "Push":
                        var elements = args.Skip(1).ToArray();
                        foreach (var item in elements)
                        {
                            s.Push(int.Parse(item));
                        }
                        break;
                    case "Pop":
                        s.Pop();
                        break;
                    default:
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void PrintStack(Stack<int> s)
        {
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}
