namespace CardSuit
{
    using CardInfo;
    using System;
    using System.Collections.Generic;

    public class DeckOfCards
    {
        private List<Card> deckOfCards = new List<Card>();

        public void Populate()
        {
            var suits = EnumUtil.GetValues<CardSuit>();
            var ranks = EnumUtil.GetValues<CardRank>();

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
        
    }
}
