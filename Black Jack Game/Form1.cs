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
       
        int playerCount=0;
        int dealerCount = 0;
        int playerPoints = 0;
        int dealerPoints = 0;
        PictureBox[] dealerBoxes = new PictureBox[9];
        PictureBox[] playerBoxes = new PictureBox[9];
        Game game = new Game();


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
            dealerBoxes[0] = pBoxDealer1;
            dealerBoxes[1] = pBoxDealer2;
            dealerBoxes[2] = pBoxDealer3;
            dealerBoxes[3] = pBoxDealer4;
            dealerBoxes[4] = pBoxDealer5;
            dealerBoxes[5] = pBoxDealer6;
            dealerBoxes[6] = pBoxDealer7;
            dealerBoxes[7] = pBoxDealer8;
            dealerBoxes[8] = pBoxDealer9;

            playerBoxes[0] = pBoxPlayer1;
            playerBoxes[1] = pBoxPlayer2;
            playerBoxes[2] = pBoxPlayer3;
            playerBoxes[3] = pBoxPlayer4;
            playerBoxes[4] = pBoxPlayer5;
            playerBoxes[5] = pBoxPlayer6;
            playerBoxes[6] = pBoxPlayer7;
            playerBoxes[7] = pBoxPlayer8;
            playerBoxes[8] = pBoxPlayer9;
            

        }

       

        private void btnHit_Click(object sender, EventArgs e)
        {
            SetPlayerBox(game.DrawCard());
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            GameReset();
            SetPlayerBox(game.DrawCard());
            SetPlayerBox(game.DrawCard());
            SetDealerBox(game.DrawCard());
        }

        public void SetPlayerBox(Card card)
        {
            playerPoints += card.GetValue();
            playerBoxes[playerCount].Image = Image.FromFile(card.GetPath());
            playerCount++;
        }

        public void SetDealerBox(Card card)
        {
            dealerPoints += card.GetValue();
            dealerBoxes[dealerCount].Image = Image.FromFile(card.GetPath());
            dealerCount++;
        }
    }
}
