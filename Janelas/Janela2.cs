using System;
using System.Windows.Forms;

namespace AppJanelas
{
    public partial class Janela2 : Form
    {
        public Janela2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Janela1 j1 = new Janela1();
            j1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Janela3 j3 = new Janela3();
            j3.Show();
            this.Hide();

        }
    }
}
