namespace CardDeck.Number
{
    public class EnglishNumber : BaseNumber, INumber
    {
        //2-A
        public static readonly string[] numbers =
            { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};

        public EnglishNumber() : base(numbers) { }
        
    }
}
