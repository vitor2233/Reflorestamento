using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SitAReflorestamento
{

    public partial class Login : UserControl
    {
        
        public Login()
        {
            InitializeComponent();
        }
        ClassUsuario usuario = new ClassUsuario();

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DataTable dt = usuario.VerificarUsu(txtLogin.Text,txtSenha.Text);
            //Se não retornar linhas afetadas ira retornar 0
            if (dt.Rows.Count == 0) 
            {
                MessageBox.Show("Usuário não existe");
            }
            else
            {
                
                MessageBox.Show("Logado como "+ txtLogin.Text);
                //Se o tipo for igual a 1 será o adm, se login igual a 2 será assistente
                string tipo = dt.Rows[0]["tipoUsuario"].ToString();
                txtLogin.Text = "";
                txtSenha.Text = "";
                if(tipo == "1")
                {
                    //Se 1, (tipo do adm) irá mostrar o frm do adm
                    frmAdministrador form = new frmAdministrador();
                    form.Show();
                }
                else
                {
                    //Se 2, (tipo do assistenteADM) irá mostrar o frm do assistente
                    frmAssistente form = new frmAssistente();
                    form.Show();
                }
            }                   
        }

        private void btnEsqSenha_Click(object sender, EventArgs e)
        {
            //Irá abrir o form de recuperação de senha
            frmRecuperacao form = new frmRecuperacao();
            form.Show();            
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            //Caracteres da senha viram *
            txtSenha.PasswordChar = '*';
            //Máximo de caracteres
            txtSenha.MaxLength = 6;
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Fazendo que, quando apertar enter (13) o botão acessar irá ser clicado
            if (e.KeyChar == 13)
            {
                this.btnEntrar.PerformClick();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Fazendo que, quando apertar enter (13) o botão acessar irá ser clicado
            if (e.KeyChar == 13)
            {
                this.btnEntrar.PerformClick();
            }
        }
    }
}
