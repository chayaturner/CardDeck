using CardDeck.Decks;
using System;

namespace CardDeck.Helpers
{
    internal class DeckHelpers
    {
        internal static IDeck InitializeDeck(string language)
        {
            IDeck deck = null;
            //switch (ConsoleHelpers.SelectDeckType().ToUpper())
            switch (language.ToUpper())
            {
                case "S":
                    deck = new SpanishDeck();
                    break;
                case "E":
                    deck = new EnglishDeck();
                    break;
                default:
                    ProgramFlowHelpers.StopProgram();
                    break;
            }
            return deck;
        }
        
    }
}
