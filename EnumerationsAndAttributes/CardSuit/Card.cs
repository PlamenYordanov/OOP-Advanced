namespace CardSuit
{
    using System;
    using CardInfo;
    using System.Collections.Generic;
    using System.Linq;

    public class Card : IComparable<Card>
    {
        private CardSuit suit;
        private CardRank rank;

        private IEnumerable<CardSuit> suits = EnumUtil.GetValues<CardSuit>();
        private IEnumerable<CardRank> ranks = EnumUtil.GetValues<CardRank>();

        public CardSuit Suit { get; set; }
        
        public CardRank Rank { get; set; }
       
        public Card(CardRank rank, CardSuit suit)
        {
            this.Suit = suit;
            this.Rank = rank;
        }

        public int CompareTo(Card other)
        {
            if (this.rank != other.rank)
            {
                return this.rank.CompareTo(other.rank);
            }
            return this.suit.CompareTo(other.suit);
        }

        public int GetPower()
        {
            return (int)this.Suit + (int)this.Rank;
        }

        public override string ToString()
        {
            return $"Card name: {this.Rank} of {this.Suit}; Card power: {this.GetPower()}";
        }

        public static bool operator >(Card c1, Card c2)
        {
            return c1.GetPower() > c2.GetPower();
        }

        public static bool operator <(Card c1, Card c2)
        {
            return c1.GetPower() < c2.GetPower();
        }

        public static bool operator ==(Card c1, Card c2)
        {
            return c1.Suit == c2.Suit
                && c1.Rank == c2.Rank;
        }

        public static bool operator !=(Card c1, Card c2)
        {
            return c1.Suit != c2.Suit
                || c1.Rank != c2.Rank;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Card can not be null");
            }
            var card = obj as Card;
            return this.Rank == card.Rank
                && this.Suit == card.Suit;
        }

        public override int GetHashCode()
        {
            return this.Suit.GetHashCode() * 17 + this.Rank.GetHashCode();
        }
    }
}
