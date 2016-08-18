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
        Deck deck1 = new Deck();
        Deck deck2 = new Deck();

        public void ResetDeck(int DeckNumber)
        {
            if(DeckNumber == 1)
            {
                //deckList1.Items.Clear();
                //deck1 = new List<Card>();
                //deckList1.Items.AddRange(deck1.);
                /* todo */
                /* add 10 random cards to deck1 */
            }
            else
            {
                
                /* Todo */
                /* recover default deck 2 state, 52 cards - sorted */

            }

        }

        public void RedrawDeck(int DeckNumber)
        {
            if(DeckNumber == 1)
            {
                deckList1.Items.Clear();

                //foreach(string cardName in deck1.GetCardNames())
                //{
                //    deckList1.Items.Add(cardName);
                //}

                deckLabel1.Text = "Deck 1. (" + deck1.Count + "cards)";
            }
            else
            {

                deckList2.Items.Clear();
                
                //foreach(string cardName in deck2.GetCardNames())
                //{
                //    deckList2.Items.Add(cardName);
                //}

                deckLabel2.Text = "Deck 2. (" + deck2.Count + "cards)";
            }
        }
            

        public Form1()
        {
          

            InitializeComponent();

            foreach(string cardName in (deck2.GetCardNames()))
            {
                deckList2.Items.Add(cardName);
            }

                                      
                   
           

            
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

        }

        private void Shuffle2_Click(object sender, EventArgs e)
        {

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
