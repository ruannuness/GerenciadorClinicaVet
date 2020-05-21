namespace form13052020
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_sair = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_nomeusuario = new System.Windows.Forms.TextBox();
            this.txb_dtnascimento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_login = new System.Windows.Forms.TextBox();
            this.txb_senha = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lst_usuarios = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_nomeproprietario = new System.Windows.Forms.TextBox();
            this.txb_nomeanimal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_racaanimal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_telefone = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lst_cadastro = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labPage3 = new System.Windows.Forms.TabControl();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.labPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(612, 459);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(141, 71);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Logout";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Bem Vindo ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(132, 19);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(189, 24);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "NOME DO USUARIO";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txb_senha);
            this.tabPage4.Controls.Add(this.txb_login);
            this.tabPage4.Controls.Add(this.txb_dtnascimento);
            this.tabPage4.Controls.Add(this.txb_nomeusuario);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(751, 381);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Cadastrar Novo Usuário";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nome Completo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Data de Nascimento: ";
            // 
            // txb_nomeusuario
            // 
            this.txb_nomeusuario.Location = new System.Drawing.Point(212, 42);
            this.txb_nomeusuario.Name = "txb_nomeusuario";
            this.txb_nomeusuario.Size = new System.Drawing.Size(179, 20);
            this.txb_nomeusuario.TabIndex = 3;
            // 
            // txb_dtnascimento
            // 
            this.txb_dtnascimento.Location = new System.Drawing.Point(212, 85);
            this.txb_dtnascimento.Name = "txb_dtnascimento";
            this.txb_dtnascimento.Size = new System.Drawing.Size(179, 20);
            this.txb_dtnascimento.TabIndex = 4;
            this.txb_dtnascimento.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(480, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 96);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(149, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "login: ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Senha: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txb_login
            // 
            this.txb_login.Location = new System.Drawing.Point(212, 124);
            this.txb_login.Name = "txb_login";
            this.txb_login.Size = new System.Drawing.Size(179, 20);
            this.txb_login.TabIndex = 8;
            this.txb_login.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txb_senha
            // 
            this.txb_senha.Location = new System.Drawing.Point(212, 167);
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.Size = new System.Drawing.Size(179, 20);
            this.txb_senha.TabIndex = 9;
            this.txb_senha.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.lst_usuarios);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(751, 381);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Usuários";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lst_usuarios
            // 
            this.lst_usuarios.FormattingEnabled = true;
            this.lst_usuarios.Location = new System.Drawing.Point(12, 69);
            this.lst_usuarios.Name = "lst_usuarios";
            this.lst_usuarios.Size = new System.Drawing.Size(730, 225);
            this.lst_usuarios.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btn_cadastrar);
            this.tabPage2.Controls.Add(this.txb_telefone);
            this.tabPage2.Controls.Add(this.txb_racaanimal);
            this.tabPage2.Controls.Add(this.txb_nomeanimal);
            this.tabPage2.Controls.Add(this.txb_nomeproprietario);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(751, 381);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Cadastrar Animal";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Proprietário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Animal";
            // 
            // txb_nomeproprietario
            // 
            this.txb_nomeproprietario.Location = new System.Drawing.Point(16, 84);
            this.txb_nomeproprietario.Name = "txb_nomeproprietario";
            this.txb_nomeproprietario.Size = new System.Drawing.Size(213, 20);
            this.txb_nomeproprietario.TabIndex = 2;
            this.txb_nomeproprietario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txb_nomeanimal
            // 
            this.txb_nomeanimal.Location = new System.Drawing.Point(422, 150);
            this.txb_nomeanimal.Name = "txb_nomeanimal";
            this.txb_nomeanimal.Size = new System.Drawing.Size(213, 20);
            this.txb_nomeanimal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Raça do Animal";
            // 
            // txb_racaanimal
            // 
            this.txb_racaanimal.Location = new System.Drawing.Point(17, 150);
            this.txb_racaanimal.Name = "txb_racaanimal";
            this.txb_racaanimal.Size = new System.Drawing.Size(213, 20);
            this.txb_racaanimal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone para Contato";
            // 
            // txb_telefone
            // 
            this.txb_telefone.Location = new System.Drawing.Point(422, 84);
            this.txb_telefone.Name = "txb_telefone";
            this.txb_telefone.Size = new System.Drawing.Size(213, 20);
            this.txb_telefone.TabIndex = 7;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_cadastrar.Location = new System.Drawing.Point(443, 296);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(192, 55);
            this.btn_cadastrar.TabIndex = 8;
            this.btn_cadastrar.Text = "CADASTRAR ANIMAL";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cadastre um novo animal";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lst_cadastro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(751, 381);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Animais já Cadastrados";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lst_cadastro
            // 
            this.lst_cadastro.FormattingEnabled = true;
            this.lst_cadastro.Location = new System.Drawing.Point(6, 80);
            this.lst_cadastro.Name = "lst_cadastro";
            this.lst_cadastro.Size = new System.Drawing.Size(730, 225);
            this.lst_cadastro.TabIndex = 0;
            this.lst_cadastro.SelectedIndexChanged += new System.EventHandler(this.lst_cadastro_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dados dos animais já cadastrados";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labPage3
            // 
            this.labPage3.Controls.Add(this.tabPage1);
            this.labPage3.Controls.Add(this.tabPage2);
            this.labPage3.Controls.Add(this.tabPage3);
            this.labPage3.Controls.Add(this.tabPage4);
            this.labPage3.Location = new System.Drawing.Point(12, 46);
            this.labPage3.Name = "labPage3";
            this.labPage3.SelectedIndex = 0;
            this.labPage3.Size = new System.Drawing.Size(759, 407);
            this.labPage3.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(301, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Lista de Usuários";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 542);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.labPage3);
            this.Name = "Form2";
            this.Text = "Clinica Veterinária";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.labPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txb_senha;
        private System.Windows.Forms.TextBox txb_login;
        private System.Windows.Forms.TextBox txb_dtnascimento;
        private System.Windows.Forms.TextBox txb_nomeusuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lst_usuarios;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox txb_telefone;
        private System.Windows.Forms.TextBox txb_racaanimal;
        private System.Windows.Forms.TextBox txb_nomeanimal;
        private System.Windows.Forms.TextBox txb_nomeproprietario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lst_cadastro;
        private System.Windows.Forms.TabControl labPage3;
        private System.Windows.Forms.Label label12;
    }
}