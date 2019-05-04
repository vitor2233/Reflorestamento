using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SitAReflorestamento
{
    public partial class frmAssistente : Form
    {
        public frmAssistente()
        {
            InitializeComponent();
            pagInicial.BringToFront();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistrarDsmt_Click(object sender, EventArgs e)
        {
            pagRegistro.BringToFront();
        }
    }
}
