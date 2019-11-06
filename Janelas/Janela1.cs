using System;
using System.Windows.Forms;

namespace AppJanelas
{
    public partial class Janela1 : Form
    {
        public Janela1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Janela2 janela2 = new Janela2();
            janela2.Show();
            this.Hide();
        }
    }
}
