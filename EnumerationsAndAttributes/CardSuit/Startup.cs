using System;
using System.Collections.Generic;
using System.Linq;

namespace CardSuit
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var cardRank = (CardRank)Enum.Parse(typeof(CardRank), Console.ReadLine());
            var cardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), Console.ReadLine());

            var card = new Card(cardRank, cardSuit);
            Console.WriteLine($"Card name: {cardRank} of {cardSuit}; Card power: {card.GetPower()}");
        }


        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
