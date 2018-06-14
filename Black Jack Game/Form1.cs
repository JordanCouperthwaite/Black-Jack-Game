using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Jack_Game
{
    public partial class Form1 : Form
    {

        private int NumberRandomizer()
        {
            Random random = new Random();
            return random.Next();
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            pBoxPlayer1.Image = Image.FromFile("../../Resources/Cards/C2.png"); //Just for testing.
        }
    }
}
