using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace SitAReflorestamento
{
    public partial class frmRecuperacao : Form
    {
        //X e Y para mover o form
        int X = 0;
        int Y = 0;

        public frmRecuperacao()
        {
            InitializeComponent();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ClassLogin login = new ClassLogin();           
            lblMsgErro.Text = "";
            login.EmailEsquecido = txtEmailEsquecido.Text;
            //Se false irá ativar a lblErro e dizer que não foi encontrado
            if (login.EsqueceuSenha() == false)
            {
                lblConcluido.Text = "";
                lblMsgErro.Text = "Email não encontrado.";
            }
            else//Se true lbl irá dizer 
            {
                lblConcluido.Text = "Email enviado com sucesso.";
            }
        }
        public void SemNet()
        {
            //Catch do try EnvioEmail (se não der certo irá aparecer)
            lblMsgErro.Text = "Não foi possível conectar a internet.";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //Código para mover o form
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Código para mover o form
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }
    }
}
