using System;
using CardDeck.Suit;
using CardDeck.Number;

namespace CardDeck
{
    public class Card
    {
        private string suit;
        private string number;

        public Card(string suit, string number)
        {
            this.suit = suit;
            this.number = number;
        }

        public string GetSuit()
        {
            return this.suit;
        }

        public string GetNumber()
        {
            return this.number;
        }
    }
}
