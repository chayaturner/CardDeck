using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck.Suit
{
    public class BaseSuit 
    {
        static string[] _suits;

        public BaseSuit(string[] suits)
        {
            _suits = suits;
        }
        public string[] getSuits()
        {
            return _suits;
        }

    }
}
