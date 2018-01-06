using System;

namespace CustomList
{
    public class Startup
    {
        public static void Main()
        {
            var list = new MyList<string>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split();
                var command = tokens[0];
                switch (command)
                {
                    case "Add":
                        var element = tokens[1];
                        list.Add(element);
                        break;
                    case "Remove":
                        var index = int.Parse(tokens[1]);
                        list.Remove(index);
                        break;
                    case "Contains":
                        element = tokens[1];
                        Console.WriteLine(list.Contains(element));
                        break;
                    case "Greater":
                        element = tokens[1];
                        Console.WriteLine(list.CountGreaterThan(element));
                        break;
                    case "Swap":
                        var index1 = int.Parse(tokens[1]);
                        var index2 = int.Parse(tokens[2]);
                        list.Swap(index1, index2);
                        break;
                    case "Max":
                        Console.WriteLine(list.Max());
                        break;
                    case "Min":
                        Console.WriteLine(list.Min());
                        break;
                    case "Print":
                        foreach (var item in list)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "Sort":
                        list.Sort();
                        break;
                    default:
                        break;

                }
            }
        }
        
    }
}
