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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
            pagInicial.BringToFront();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Irá minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Trazer pagina de cadastro para frente
            pagCadastro.BringToFront();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            //Irá sair
            this.Close();
        }

        private void btnRegistrarDsmt_Click(object sender, EventArgs e)
        {
            //Irá trazer a página desmatamento para frente
            pagRegDesmt.BringToFront();            
        }


        private void btnReflorestamento_Click(object sender, EventArgs e)
        {
            //Irá trazer a página reflorestamento para frente
            pagCalculo.BringToFront();
        }
    }
}
