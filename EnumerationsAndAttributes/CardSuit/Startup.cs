using System;
using System.Collections.Generic;
using System.Linq;

namespace CardSuit
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var suits = GetValues<CardRanks>();
            Console.WriteLine($"Card Ranks:");
            foreach (var suit in suits)
            {

                Console.WriteLine($"Ordinal value: {(int)suit}; Name value: {suit}");
            }
        }
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
