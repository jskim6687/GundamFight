using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GundamFight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //git test
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            Fight fight = new Fight();
            fight.test(1);
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            Fight fight = new Fight();
            fight.test(2);
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            Fight fight = new Fight();
            fight.test(3);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
