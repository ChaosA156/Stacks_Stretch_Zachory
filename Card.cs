using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Stretch_Zachory
{
    //Some code with parameters for the cards and suit
    class Card
    {

        public string Number { get; }

        public string Suit { get; }

        public Card(string numParam, string suitParam)
        {
            Number = numParam;
            Suit = suitParam;
        }
    }
}
