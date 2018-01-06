namespace GenericBoxOfString
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var doubles = new List<string>(n);
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                
                doubles.Add(input);
            }
            var element = Console.ReadLine();

            Console.WriteLine(NumberOfGreaterElements(doubles, element));
        }
        
        static void Swap<T>(List<T> listToSwap, int firstIndex, int secondIndex)
        {
            T firstElement = listToSwap[firstIndex];
            listToSwap[firstIndex] = listToSwap[secondIndex];
            listToSwap[secondIndex] = firstElement;
        }

        static int NumberOfGreaterElements<T>(List<T> list, T element) where T : IComparable
        {
            var count = list.Where(x => x.CompareTo(element) > 0).Count();
            return count;
        }
    }
}
