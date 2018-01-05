using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck.Suit
{
    public class SpanishSuit : BaseSuit, ISuit
    {
        
        public static readonly string[] suits = 
            {"Oros", "Copas", "Espadas", "Bastos"}; //golden coins, goblets, swords, clubs

        public SpanishSuit() : base(suits) {}
    }
}
