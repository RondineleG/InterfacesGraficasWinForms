using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP2___Labels_e_Buttons
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
