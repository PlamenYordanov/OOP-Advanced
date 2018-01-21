namespace CardSuit
{
    using System;
    using CardInfo;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main(string[] args)
        {

            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            List<Card> deltCards = new List<Card>();
            var player1 = new Player(name1);
            AddCardsToPlayer(player1, deltCards);

            var player2 = new Player(name2);
            AddCardsToPlayer(player2, deltCards);

            var firstBestCard = player1.Cards.OrderByDescending(x => x.GetPower()).FirstOrDefault();
            var secondBestCard = player2.Cards.OrderByDescending(x => x.GetPower()).FirstOrDefault();
            
            if (firstBestCard > secondBestCard)
            {
                Console.WriteLine($"{player1.Name} wins with {firstBestCard.Rank} of {firstBestCard.Suit}.");
            }
            else
            {
                Console.WriteLine($"{player2.Name} wins with {secondBestCard.Rank} of {secondBestCard.Suit}.");
            }
        }

        private static void AddCardsToPlayer(Player player, List<Card> deltCards)
        {
            while (player.Cards.Count < 5)
            {
                var cardInfo = Console.ReadLine();
                AddValidCard(player, deltCards, cardInfo);
            }
        }

        static void AddValidCard(Player player,List<Card> deltCards, string input)
        {
            var cardInfo = input.Split();
            if (!Enum.TryParse(cardInfo[0], out CardRank rank)
                    || !Enum.TryParse(cardInfo[2], out CardSuit suit))
            {
                Console.WriteLine($"No such card exists.");
                return;
            }
            var card = new Card(rank, suit);
            if (deltCards.Any(x => x.Equals(card)))
            {
                Console.WriteLine($"Card is not in the deck.");
                return;
            }
            player.Cards.Add(card);
            deltCards.Add(card);
        }
    }
}
