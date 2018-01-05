namespace CardDeck.Number
{
    public class SpanishNumber : BaseNumber, INumber
    {
        //1-9, 10-12 face cards (jack, knight, king)

        public static readonly string[] numbers = 
            { "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Diez", "Sota", "Caballo", "Rey" };

        public SpanishNumber() : base(numbers)
        {
        }
    }
}
