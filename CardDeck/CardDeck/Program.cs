using CardDeck.Decks;
using CardDeck.Helpers;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CardDeck
{
    class Program
    {
        private static List<IDeck> decks = new List<IDeck>();
        //private static IDeck deck = null;
        private static int decksAmount = 0;
        private static int index = 0;
        private static string language = null;

        static void Main(string[] args)
        {
            ConsoleHelpers.ShowWelcomMessage();
            language = ConsoleHelpers.SelectDeckType();

            CreateDecks();

            DrawCards();

            ProgramFlowHelpers.StopProgram();
        }

        private static void DrawCards()
        {
            while (index < decksAmount)
            {
                Console.WriteLine("Player " + (index + 1) + " ");
                string response = ConsoleHelpers.RequestAction();
                if (response.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                {
                    performAction();
                }
                else if (response.Equals("c", StringComparison.InvariantCultureIgnoreCase))
                {
                    ProgramFlowHelpers.StopProgram();
                }

                index++;

                //go back to first player
                if (index == decksAmount)
                {
                    index = 0;
                }
            }
        }

        private static void CreateDecks()
        {
            decksAmount = ConsoleHelpers.SelectAmountOfDecks();

            for (int i = 1; i <= decksAmount; i++)
            {
                IDeck deck = DeckHelpers.InitializeDeck(language);
                decks.Add(deck);
            }
        }

        private static void performAction()
        {
            IDeck deck = decks[index];
            Card card = deck.DrawCard();
            Console.WriteLine("Card: " + card.GetNumber() + " of " + card.GetSuit() + ".");
            if (deck.GetDeck().Count() == 0)
            {
                Console.WriteLine("Reached end of deck");
                deck = DeckHelpers.InitializeDeck(language);
            }
        }
    }
}
