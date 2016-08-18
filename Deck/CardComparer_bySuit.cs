﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    class CardComparer_bySuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if(x.Suit < y.Suit)
                return 1;

            if (x.Suit > y.Suit)
                return -1;
            else
                return 0;
        }
    }
}
