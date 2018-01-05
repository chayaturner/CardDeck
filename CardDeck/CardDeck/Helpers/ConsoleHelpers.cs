using System;

namespace CardDeck.Helpers
{
    internal static class ConsoleHelpers
    {
        internal static void ShowWelcomMessage()
        {
            Console.WriteLine("Welcome! You are playing with an English deck of cards.");
        }
        internal static string SelectDeckType()
        {
            string languageSelection = string.Empty;
            string welcomeMessage =
                             Environment.NewLine + "To play with Spanish cards, press S." +
                             Environment.NewLine + "To continue with English, press E." +
                             Environment.NewLine + "To Exit at any time, press C.";
            while (!string.Equals(languageSelection, "s", StringComparison.InvariantCultureIgnoreCase)
                    && !string.Equals(languageSelection, "e", StringComparison.InvariantCultureIgnoreCase)
                    && !string.Equals(languageSelection, "c", StringComparison.InvariantCultureIgnoreCase)
                )
            {
                Console.WriteLine(welcomeMessage);
                languageSelection = Console.ReadLine();
                if (!string.IsNullOrEmpty(languageSelection))
                    languageSelection = languageSelection.Substring(0, 1);
            }
            return languageSelection;
        }

        internal static int SelectAmountOfDecks()
        {
            int amount = 0;
            while(!(amount > 0))
            {
                Console.WriteLine("Enter the amount of players/decks you would like to play with.");
                amount = Int32.Parse(Console.ReadLine());
            }

            return amount;
        }

        internal static string RequestAction()
        {
            string response = string.Empty;
            while (!string.Equals(response, "y", StringComparison.InvariantCultureIgnoreCase)
                    && !string.Equals(response, "n", StringComparison.InvariantCultureIgnoreCase)
                                        && !string.Equals(response, "c", StringComparison.InvariantCultureIgnoreCase)

                )
            {
                Console.WriteLine("Would you like to draw a card? Y/N");
                response = Console.ReadLine();
                if (!string.IsNullOrEmpty(response))
                    response = response.Substring(0, 1);
                else
                    Console.WriteLine("Enter a value.");
            }
            return response;
        }
    }
}
