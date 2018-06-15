using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Black_Jack_Game
{
    public partial class Form1 : Form
    {
        //Instanced variables and declarations.
        SortedList CardArray = new SortedList();
        ArrayList CardCheckList = new ArrayList();

        //Methods
        private int NumberRandomizer()
        {
            Random random = new Random();
            return random.Next();
        }

        //Changes all the properties back to their default value, hides used picture boxes and clears values.
        private void GameReset()
        {
            //Hides the Dealer and Players pictureboxes when the game is reset.
            pBoxDealer3.Visible = false;
            pBoxDealer4.Visible = false;
            pBoxDealer5.Visible = false;
            pBoxDealer6.Visible = false;
            pBoxDealer7.Visible = false;
            pBoxDealer8.Visible = false;
            pBoxDealer9.Visible = false;

            pBoxPlayer3.Visible = false;
            pBoxPlayer4.Visible = false;
            pBoxPlayer5.Visible = false;
            pBoxPlayer6.Visible = false;
            pBoxPlayer7.Visible = false;
            pBoxPlayer8.Visible = false;
            pBoxPlayer9.Visible = false;

            btnHit.Enabled = true;
            btnStand.Enabled = true;



        }
        
        private 

        private string CardSelector()
        {

        }

        public Form1()
        {
            InitializeComponent();

            //Where should I put this?
            //Would also like to somehow create a more randomized deck, that allows for multiple decks.
            //This method would be truely random using the random method but doesnt work like a real deck, perhaps use the randomizer to add these to a random array and use that as the deck?
            CardArray.Add("../../Resources/Cards/C10.png", 10);
            CardArray.Add("../../Resources/Cards/C2.png", 2);
            CardArray.Add("../../Resources/Cards/C3.png", 3);
            CardArray.Add("../../Resources/Cards/C4.png", 4);
            CardArray.Add("../../Resources/Cards/C5.png", 5);
            CardArray.Add("../../Resources/Cards/C6.png", 6);
            CardArray.Add("../../Resources/Cards/C7.png", 7);
            CardArray.Add("../../Resources/Cards/C8.png", 8);
            CardArray.Add("../../Resources/Cards/C9.png", 9);
            CardArray.Add("../../Resources/Cards/CA.png", 0);
            CardArray.Add("../../Resources/Cards/CJ.png", 10);
            CardArray.Add("../../Resources/Cards/CQ.png", 10);
            CardArray.Add("../../Resources/Cards/CK.png", 10);
            CardArray.Add("../../Resources/Cards/D10.png", 10);
            CardArray.Add("../../Resources/Cards/D2.png", 2);
            CardArray.Add("../../Resources/Cards/D3.png", 3);
            CardArray.Add("../../Resources/Cards/D4.png", 4);
            CardArray.Add("../../Resources/Cards/D5.png", 5);
            CardArray.Add("../../Resources/Cards/D6.png", 6);
            CardArray.Add("../../Resources/Cards/D7.png", 7);
            CardArray.Add("../../Resources/Cards/D8.png", 8);
            CardArray.Add("../../Resources/Cards/D9.png", 9);
            CardArray.Add("../../Resources/Cards/DA.png", 0);
            CardArray.Add("../../Resources/Cards/DJ.png", 10);
            CardArray.Add("../../Resources/Cards/DQ.png", 10);
            CardArray.Add("../../Resources/Cards/DK.png", 10);
            CardArray.Add("../../Resources/Cards/H10.png", 10);
            CardArray.Add("../../Resources/Cards/H2.png", 2);
            CardArray.Add("../../Resources/Cards/H3.png", 3);
            CardArray.Add("../../Resources/Cards/H4.png", 4);
            CardArray.Add("../../Resources/Cards/H5.png", 5);
            CardArray.Add("../../Resources/Cards/H6.png", 6);
            CardArray.Add("../../Resources/Cards/H7.png", 7);
            CardArray.Add("../../Resources/Cards/H8.png", 8);
            CardArray.Add("../../Resources/Cards/H9.png", 9);
            CardArray.Add("../../Resources/Cards/HA.png", 0);
            CardArray.Add("../../Resources/Cards/HJ.png", 10);
            CardArray.Add("../../Resources/Cards/HQ.png", 10);
            CardArray.Add("../../Resources/Cards/HK.png", 10);
            CardArray.Add("../../Resources/Cards/S10.png", 10);
            CardArray.Add("../../Resources/Cards/S2.png", 2);
            CardArray.Add("../../Resources/Cards/S3.png", 3);
            CardArray.Add("../../Resources/Cards/S4.png", 4);
            CardArray.Add("../../Resources/Cards/S5.png", 5);
            CardArray.Add("../../Resources/Cards/S6.png", 6);
            CardArray.Add("../../Resources/Cards/S7.png", 7);
            CardArray.Add("../../Resources/Cards/S8.png", 8);
            CardArray.Add("../../Resources/Cards/S9.png", 9);
            CardArray.Add("../../Resources/Cards/SA.png", 0);
            CardArray.Add("../../Resources/Cards/SJ.png", 10);
            CardArray.Add("../../Resources/Cards/SQ.png", 10);
            CardArray.Add("../../Resources/Cards/SK.png", 10);

        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            pBoxPlayer1.Image = Image.FromFile("../../Resources/Cards/C2.png"); //Just for testing.
            pBoxPlayer2.Visible = Enabled;
            pBoxPlayer2.Image = Image.FromFile("../../Resources/Cards/C2.png"); //Just for testing.
        }
    }
}
