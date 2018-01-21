using System;

namespace CardSuit
{
    public class Card : IComparable<Card>
    {
        public Card(CardRank rank, CardSuit suit)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public CardSuit suit { get; set; }

        public CardRank rank { get; set; }

        public int CompareTo(Card other)
        {
            return this.GetPower().CompareTo(other.GetPower());
        }

        public int GetPower()
        {
            return (int)this.suit + (int)this.rank;
        }
        public override string ToString()
        {
            return $"Card name: {this.rank} of {this.suit}; Card power: {this.GetPower()}";
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
            return c1.GetPower() == c2.GetPower();
        }
        public static bool operator !=(Card c1, Card c2)
        {
            return c1.GetPower() != c2.GetPower();
        }

    }
}
