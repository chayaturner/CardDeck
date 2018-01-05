using CardDeck.Number;
using CardDeck.Suit;
using System;
using System.Collections.Generic;

namespace CardDeck.Decks
{
    class SpanishDeck : BaseDeck, IDeck
    {
        public SpanishDeck() : base(new SpanishSuit(), new SpanishNumber())
        {
            
        }
    }
}