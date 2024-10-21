using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI___Casino_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int money = 1000;
        List<string> logos = new List<string> { "trench", "vessel", "blurryface", "sai", "clancy"};
        Random generator = new Random();
        int logo = generator.Next(logos.Count);

        private void btnSpin_Click(object sender, EventArgs e)
        {

        }

        

    }
}
