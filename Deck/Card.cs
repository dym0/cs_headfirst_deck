using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    class Card
    {
        public Suits Suit;
        public Values Value;

        public Card(Suits suit, Values value )
        {
            Suit = suit;
            Value = value;
        }

        public string Name { get; set; }

        public override string ToString()
        {
             return Value.ToString() + " of " + Suit.ToString();
        }
    
    }
}
