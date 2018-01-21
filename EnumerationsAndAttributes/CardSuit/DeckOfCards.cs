namespace CardSuit
{
    using CardInfo;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class DeckOfCards
    {
        private List<Card> deckOfCards = new List<Card>();

        public void Populate()
        {
            var suits = GetValues<CardSuit>();
            var ranks = GetValues<CardRank>();

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    var card = new Card(rank, suit);
                    this.deckOfCards.Add(card);
                }
            }
        }
        public void Print()
        {
            foreach (var card in this.deckOfCards)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");
            }
        }
        public int Count()
        {
            return this.deckOfCards.Count;
        }
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
