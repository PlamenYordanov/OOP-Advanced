namespace CardSuit
{
    using System.Collections.Generic;
    using System;

    public class Player
    {
        public List<Card> Cards;

        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;

            Cards = new List<Card>();
        }
       
    }
}
