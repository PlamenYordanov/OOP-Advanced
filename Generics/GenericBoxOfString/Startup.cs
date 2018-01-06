namespace GenericBoxOfString
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var boxes = new List<Box<int>>(n);


            for (int i = 0; i < n; i++)
            {
                var integer = int.Parse(Console.ReadLine());
                var box = new Box<int>(integer);
                boxes.Add(box);
            }
            var swapIndexes = Console.ReadLine().Split();
            var firstIndex = int.Parse(swapIndexes[0]);
            var secondIndex = int.Parse(swapIndexes[1]);
            Swap(boxes, firstIndex, secondIndex);
            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }
        static void Swap<T>(List<T> listToSwap, int firstIndex, int secondIndex)
        {
            T firstElement = listToSwap[firstIndex];
            listToSwap[firstIndex] = listToSwap[secondIndex];
            listToSwap[secondIndex] = firstElement;
        }
    }
}
