using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI___Casino_Game
{
    public partial class Slot : Form
    {
        Random generator = new Random();
        int spinner1, spinner2, spinner3;
        int money = 1000;
        List<Bitmap> logos = new List<Bitmap> { 
            Properties.Resources.trench, 
            Properties.Resources.vessel, 
            Properties.Resources.blurryface,
            Properties.Resources.sai,
            Properties.Resources.clancy 
        };

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Slot()
        {
            InitializeComponent();
        }

        



        private void btnSpin_Click(object sender, EventArgs e)
        {
            money -= 100;

            spinner1 = generator.Next(0, logos.Count);
            spinner2 = generator.Next(0, logos.Count);
            spinner3 = generator.Next(0, logos.Count);


            imgLogo1.Image = logos[spinner1];
            imgLogo2.Image = logos[spinner2];
            imgLogo3.Image = logos[spinner3];

            if (spinner1 == spinner2 && spinner1 == spinner3)
                money += 1000;
            else if (spinner1 == spinner2 || spinner1 == spinner3 || spinner2 == spinner3)
                money += 250;

            lblMoney.Text = "Money: $" + money.ToString();
        }

        

    }
}
