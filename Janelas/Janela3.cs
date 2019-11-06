using System;
using System.Windows.Forms;

namespace AppJanelas
{
    public partial class Janela3 : Form
    {
        public Janela3()
        {
            InitializeComponent();
        }

        private void Janela3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Parabéns! Chegamos na última janela!!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Janela2 j2 = new Janela2();
            j2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Janela1 j1 = new Janela1();
            j1.Show();
            this.Hide();
        }
    }
}
