using System;
using System.Windows.Forms;

namespace AppComboBox
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Eu sou um teste");
            comboBox1.Items.Add("Eu fui inserido via codigo");

            label1.Text = "A lista possui: "+comboBox1.Items.Count + "itens";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
