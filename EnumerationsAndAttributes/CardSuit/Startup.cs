namespace CardSuit
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var deckOfCards = new DeckOfCards();
            deckOfCards.Populate();
            deckOfCards.Print();
        }
        
    }
}
