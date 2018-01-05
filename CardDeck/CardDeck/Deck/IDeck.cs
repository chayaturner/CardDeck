using System.Collections.Generic;

namespace CardDeck.Decks
{
    interface IDeck
    {

        //method signature:
        Card DrawCard();
        List<Card> GetDeck();
    }
}
