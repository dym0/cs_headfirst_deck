using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    class Deck
    {
        public List<Card> cards;

        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();

            for(int suit = 1; suit < 4; suit++)
            {
                for(int value = 0; value < 14; value++)
                {
                    cards.Add(new Card((Suits)suit, (Values)value));
                }
            }
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count { get { return cards.Count; } }

        public void Add( Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        public void Shuffle()
        {
            /* shuffle deck, random */
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] eachCard = new string[cards.Count]; 
            
            for(int i = 0; i < cards.Count; i++)
            {
                eachCard[i] = cards[i].ToString();
            }

            return eachCard;
        }

        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit());
        }
    }
    
}
