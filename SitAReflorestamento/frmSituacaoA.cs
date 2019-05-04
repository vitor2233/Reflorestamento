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
    public partial class frmSituAReflorestamentp : Form
    {
        Login lgn = new Login();
        ClassUsuario usuario = new ClassUsuario();
        public frmSituAReflorestamentp()
        {
            InitializeComponent();
            pagInicial.BringToFront();
        }
        #region Fechar e minimizar
        private void btnSair_Click(object sender, EventArgs e)
        {
            //Sair do programa
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Minimizar o programa
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


        private void pnlLogo_Click(object sender, EventArgs e)
        {
            //Pagina inicial irá aparecer
            pagInicial.BringToFront();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Pagina Login irá aparecer
            pagLogin.BringToFront();
        }


    }
}
