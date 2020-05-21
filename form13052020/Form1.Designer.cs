namespace form13052020
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pgb_1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tmr_form1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_progressbar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgb_1
            // 
            this.pgb_1.Location = new System.Drawing.Point(244, 218);
            this.pgb_1.Name = "pgb_1";
            this.pgb_1.Size = new System.Drawing.Size(309, 23);
            this.pgb_1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_1.TabIndex = 0;
            this.pgb_1.Click += new System.EventHandler(this.pgb_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Por Favor Aguarde";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tmr_form1
            // 
            this.tmr_form1.Enabled = true;
            this.tmr_form1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_progressbar
            // 
            this.lbl_progressbar.AutoSize = true;
            this.lbl_progressbar.Location = new System.Drawing.Point(389, 266);
            this.lbl_progressbar.Name = "lbl_progressbar";
            this.lbl_progressbar.Size = new System.Drawing.Size(13, 13);
            this.lbl_progressbar.TabIndex = 2;
            this.lbl_progressbar.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_progressbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgb_1);
            this.Name = "Form1";
            this.Text = "Carregando";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgb_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmr_form1;
        private System.Windows.Forms.Label lbl_progressbar;
    }
}

