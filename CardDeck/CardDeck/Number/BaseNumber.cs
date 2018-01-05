using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck.Number
{
    public class BaseNumber
    {
        static string[] _numbers;

        public BaseNumber(string[] numbers)
        {
            _numbers = numbers;
        }

        public string[] getNumbers()
        {
            return _numbers;
        }


        
    }
}
