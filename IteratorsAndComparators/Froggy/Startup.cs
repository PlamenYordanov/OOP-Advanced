using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Froggy
{
    public class Startup
    {
        public static void Main()
        {
            var stones = Console.ReadLine().Split(new[] { ' ', ',' }
            , StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

            var lake = new Lake(stones);

            lake = Cross(lake);

            Console.WriteLine(lake);
        }
        private static Lake Cross(Lake lake)
        {
            var crossedLake = new List<int>();
            foreach (var stone in lake)
            {
                crossedLake.Add(stone);
            }
            return new Lake(crossedLake);
        }
    }
}
