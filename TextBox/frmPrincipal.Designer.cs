namespace AppTextBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Idade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tb_Sobrenome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Resposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira a sua idade";
            // 
            // tb_Idade
            // 
            this.tb_Idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.tb_Idade.ForeColor = System.Drawing.Color.Teal;
            this.tb_Idade.Location = new System.Drawing.Point(31, 50);
            this.tb_Idade.MaxLength = 50;
            this.tb_Idade.Name = "tb_Idade";
            this.tb_Idade.Size = new System.Drawing.Size(178, 32);
            this.tb_Idade.TabIndex = 1;
            this.tb_Idade.TextChanged += new System.EventHandler(this.ValidarTexto);
            this.tb_Idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarInt);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insira seu nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Insira seu Sobrenome";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.tb_Nome.Location = new System.Drawing.Point(31, 145);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(178, 32);
            this.tb_Nome.TabIndex = 4;
            // 
            // tb_Sobrenome
            // 
            this.tb_Sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.tb_Sobrenome.Location = new System.Drawing.Point(31, 242);
            this.tb_Sobrenome.Name = "tb_Sobrenome";
            this.tb_Sobrenome.Size = new System.Drawing.Size(178, 32);
            this.tb_Sobrenome.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(31, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 77);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apresentar Mensagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Resposta
            // 
            this.lbl_Resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_Resposta.Location = new System.Drawing.Point(55, 437);
            this.lbl_Resposta.Name = "lbl_Resposta";
            this.lbl_Resposta.Size = new System.Drawing.Size(225, 114);
            this.lbl_Resposta.TabIndex = 7;
            this.lbl_Resposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Resposta.Click += new System.EventHandler(this.lbl_Resposta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 386);
            this.Controls.Add(this.lbl_Resposta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Sobrenome);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Idade);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TextBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Idade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TextBox tb_Sobrenome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Resposta;
    }
}

