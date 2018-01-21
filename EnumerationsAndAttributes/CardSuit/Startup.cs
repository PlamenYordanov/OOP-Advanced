using System;
using System.Collections.Generic;
using System.Linq;

namespace CardSuit
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var c1Suit = (CardRank)Enum.Parse(typeof(CardRank), Console.ReadLine());
            var c1Rank = (CardSuit)Enum.Parse(typeof(CardSuit), Console.ReadLine());

            var c2Suit = (CardRank)Enum.Parse(typeof(CardRank), Console.ReadLine());
            var c2Rank = (CardSuit)Enum.Parse(typeof(CardSuit), Console.ReadLine());

            var firstCard = new Card(c1Suit, c1Rank);
            var secondCard = new Card(c2Suit, c2Rank);
            Console.WriteLine(firstCard > secondCard ? firstCard : secondCard);
        }


        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
