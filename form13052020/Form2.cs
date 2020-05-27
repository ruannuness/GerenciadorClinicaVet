using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form13052020
{

    public partial class Form2 : Form
    {

        animal cachorro;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string username)
        {
            InitializeComponent();
            lbl_username.Text = username;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            cachorro = new animal(txb_nomeanimal, txb_nomeproprietario, txb_racaanimal);

                        
            string telefone = txb_telefone.Text;


            lst_cadastro.Items.Add("|Nome do Responsável: " + txb_nomeproprietario + " | Nome do Animal: " + txb_nomeanimal + " | Raça do Animal : " + txb_racaanimal + " | Telefone para Contato : " + telefone);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            loginpage begin = new loginpage();
            this.Visible = false;
            begin.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lst_cadastro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nomeusuario = txb_nomeusuario.Text;
            string dtnasuser = txb_dtnascimento.Text;
            string login = txb_login.Text;
            string senha = txb_senha.Text;

            lst_usuarios.Items.Add("|Nome do Usuário: " + nomeusuario + " | Data de Nascimento: " + dtnasuser + " | login: " + login + " | Senha: " + senha);
        }
    }

}
    


