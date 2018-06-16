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


        //Methods
     

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

        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnHit_Click(object sender, EventArgs e)
        {
            pBoxPlayer1.Image = Image.FromFile("../../Resources/Cards/C2.png"); //Just for testing.
            pBoxPlayer2.Visible = Enabled;
            pBoxPlayer2.Image = Image.FromFile("../../Resources/Cards/C2.png"); //Just for testing.
        }
    }
}
