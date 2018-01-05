using CardDeck.Number;
using CardDeck.Suit;
using System;
using System.Collections.Generic;

namespace CardDeck.Decks
{
    class EnglishDeck : BaseDeck, IDeck
    {
        public EnglishDeck() : base(new EnglishSuit(), new EnglishNumber())
        {
        }
    }
}
