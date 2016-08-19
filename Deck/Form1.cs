using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deck
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Deck deck1;
        Deck deck2 = new Deck();

        List<Card> randomCards = new List<Card>();
        
       
        


        public void ResetDeck(int DeckNumber)
        {
            if(DeckNumber == 1)
            {
                for (int suit = 0; suit < 4; suit++)
                {
                    for (int value = 1; value < 14; value++)
                    {
                        randomCards.Add(new Card((Suits)suit, (Values)value));
                    }
                }

                for(int i = 0; i < 42; i++)
                {
                    randomCards.RemoveAt(random.Next(1, randomCards.Count));
                }

                /* todo */
                /* add 10 random cards to deck1 */
            }
            else
            {

                /* Todo */
                /* recover default deck 2 state, 52 cards - sorted */
                deck2.Sort();

            }

        }

        public void RedrawDeck(int DeckNumber)
        {
            if(DeckNumber == 1)
            {
                deckList1.Items.Clear();

                foreach (string cardName in deck1.GetCardNames())
                {
                    deckList1.Items.Add(cardName);
                }

                deckLabel1.Text = "Deck 1. (" + deck1.Count + "cards)";
            }
            else
            {

                deckList2.Items.Clear();

                foreach (string cardName in deck2.GetCardNames())
                {
                    deckList2.Items.Add(cardName);
                }

                deckLabel2.Text = "Deck 2. (" + deck2.Count + "cards)";
            }
        }
            

        public Form1()
        {


            InitializeComponent();

            //foreach(string cardName in (deck2.GetCardNames()))
            //{
            //    deckList2.Items.Add(cardName);
            //}

            //IEnumerable<string> mineTable = deck1.GetCardNames();

            //  for (int i = 0; i < 10; i++)
            //  {
            //      deckList1.Items.Add(mineTable);


            //  }
            ResetDeck(1);
            deck1 = new Deck(randomCards);

            RedrawDeck(1);
            RedrawDeck(2);
            
        }

        private void deckBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset1_Click(object sender, EventArgs e)
        {

        }

        private void Reset2_Click(object sender, EventArgs e)
        {

        }

        private void Shuffle_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void Shuffle2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void MoveToDeck2_Click(object sender, EventArgs e)
        {

        }

        private void MoveToDeck1_Click(object sender, EventArgs e)
        {

        }

        private void deckList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
