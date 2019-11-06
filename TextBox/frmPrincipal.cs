using System;
using System.Windows.Forms;

namespace AppTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tb_Nome.Text) && !string.IsNullOrEmpty(tb_Idade.Text))
            { 
            lbl_Resposta.Text = "Olá, "+ tb_Nome.Text + " " +  tb_Sobrenome.Text + ", você tem "+tb_Idade.Text+" anos";
            tb_Nome.Text = "";
            tb_Sobrenome.Text = "";
            tb_Idade.Text = "";
            }
            else
            {
                lbl_Resposta.Text = "Por favor, complete todos os campos! PS: Sobrenome é Opcional!";
            }
        }

        private void lbl_Resposta_Click(object sender, EventArgs e)
        {

        }

        private void ValidarInt(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) &&  e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void ValidarTexto(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Idade.Text))
            {
                int resultado;
                bool sucesso = Int32.TryParse(tb_Idade.Text, out resultado);
                if (!sucesso)
                    tb_Idade.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
