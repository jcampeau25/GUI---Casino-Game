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
    public partial class Form1 : Form
    {
        Random generator = new Random();
        int logo;
        int money = 1000;
        List<string> logos = new List<string> { "trench", "vessel", "blurryface", "sai", "clancy" };

        public Form1()
        {
            InitializeComponent();
        }

        



        private void btnSpin_Click(object sender, EventArgs e)
        {
            logo = generator.Next(0, logos.Count - 1);
            imgLogo1.Image = GUI___Casino_Game.Properties.Resources.blurryface;
            imgLogo2.Image = GUI___Casino_Game.Properties.Resources.vessel;
            imgLogo3.Image = GUI___Casino_Game.Properties.Resources.sai;


        }



    }
}
