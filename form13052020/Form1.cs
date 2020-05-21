using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form13052020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pgb_1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pgb_1.Value < 100)
            {
                pgb_1.Value += 2;

                lbl_progressbar.Text = pgb_1.Value.ToString() + "%";
            }
            else
            {
                tmr_form1.Enabled = false;
                this.Visible = false;
                loginpage begin = new loginpage();
                begin.ShowDialog();
            }
        }
    }
}
