namespace CardSuit
{
    public class Card
    {
        public Card(CardRank rank, CardSuit suit)
        {
            this.suit = suit;
            this.rank = rank;
        }
        public int power { get; set; }

        public CardSuit suit { get; set; }

        public CardRank rank { get; set; }

        public int GetPower()
        {
            return (int)this.suit + (int)this.rank;
        }
    }
}
