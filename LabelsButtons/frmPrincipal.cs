using System;
using System.Windows.Forms;

namespace LabelsButtons
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            int valor = 20 - 2;
            lbl_qtd.Text = "No mínimo faltam "+valor;
            lbl_qtd.Visible = true;
        }
    }
}
