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
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        private void loginpage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void transferir ()
        {
            Form2 destino = new Form2(txb_login.Text);
            this.Visible = false;

            destino.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txb_login.Text != "")
            {
                if (txb_senha.Text != "")
                {
                    transferir();
                }
                else
                {
                    
                }
            }
            else
            {
                
            }
            
           
        }

        private void txb_senha_TextChanged(object sender, EventArgs e)
        {
            txb_senha.PasswordChar = '*';
            txb_senha.MaxLength = 14;
        }
    }
}
