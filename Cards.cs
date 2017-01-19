using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Cards
    {
        int value;
        string name;

        /************************************
         * Constructor
         ***********************************/
        public Cards(int _value, string _name)
        {
            value = _value;
            name = _name;
        }

        /************************************
         * DisplayValue()
         ***********************************/
        public int DisplayValue()
        {
            return value;
        }

    }
}
