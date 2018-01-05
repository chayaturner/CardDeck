namespace CardDeck.Suit
{
    public class EnglishSuit : BaseSuit, ISuit
    {
        public static readonly string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };

        public EnglishSuit() : base(suits) { }
    }
}
