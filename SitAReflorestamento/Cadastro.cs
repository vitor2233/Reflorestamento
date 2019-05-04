using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SitAReflorestamento
{
    public partial class Cadastro : UserControl
    {
        public Cadastro()
        {
            InitializeComponent();
            dgvUsuario.DataSource = usuario.RetTodosUsuarios();
        }
        ClassUsuario usuario = new ClassUsuario();
        int codUsuarioClicado = 0;
        bool validar;
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Se o email não existir irá permitir o cadastro
            if (usuario.VerificarEmail(txtEmail.Text) == 0)
            {
                //Se o cpf não existir irá permitir o cadastro
                if (usuario.VerificarCpf(mskCpf.Text) == 0)
                {
                    //Se tipoUsuario for Assistente, no banco será 2, se adm será 1                
                    if (cboTipoUsu.Text == "Assistente Administrador")
                    {
                        cboTipoUsu.Text = "2";
                    }
                    else
                    {
                        cboTipoUsu.Text = "1";
                    }
                    //Se algum campo estiver vazio irá aparecer o MessageBox
                    if ((cboTipoUsu.Text == null) || (txtEmail.Text == "") || (txtLogin.Text == "") || (txtSenha.Text == "")
                        && (txtNome.Text == "") || (mskTelefone.Text == "") || (mskCpf.Text == ""))
                    {
                        MessageBox.Show("Preencha todos os dados.");
                    }
                    //Pegando as variaveis pra colocar no banco
                    usuario.TipoUsuario = int.Parse(cboTipoUsu.Text);
                    usuario.Email = txtEmail.Text;
                    usuario.Login = txtLogin.Text;
                    usuario.Senha = txtSenha.Text;
                    usuario.Nome = txtNome.Text;
                    usuario.Telefone = mskTelefone.Text;
                    usuario.Cpf = mskCpf.Text;
                    if (validar == true)
                    {
                        if (usuario.Inserir() == true)
                        {
                            MessageBox.Show("Usuário cadastrado com sucesso");
                            dgvUsuario.DataSource = usuario.RetTodosUsuarios();
                            #region Limpando os textBox
                            txtNome.Text = "";
                            mskCpf.Text = "";
                            txtEmail.Text = "";
                            txtLogin.Text = "";
                            txtSenha.Text = "";
                            mskTelefone.Text = "";
                            cboTipoUsu.Text = "";
                            #endregion
                            validar = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valide o cadastro primeiro.");
                    }
                }
                else
                {
                    MessageBox.Show("CPF já cadastrado");
                    #region Limpando os textBox
                    txtNome.Text = "";
                    mskCpf.Text = "";
                    txtEmail.Text = "";
                    txtLogin.Text = "";
                    txtSenha.Text = "";
                    mskTelefone.Text = "";
                    cboTipoUsu.Text = "";
                    #endregion
                }
            }
            else
            {
                MessageBox.Show("E-mail já cadastrado");
                #region Limpando os textBox
                txtNome.Text = "";
                mskCpf.Text = "";
                txtEmail.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
                mskTelefone.Text = "";
                cboTipoUsu.Text = "";
                #endregion
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Pegando as variaveis pra colocar no banco
            usuario.TipoUsuario = int.Parse(cboTipoUsu.Text);
            usuario.Email = txtEmail.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nome = txtNome.Text;
            usuario.Telefone = mskTelefone.Text;
            usuario.Cpf = mskCpf.Text;
            
            usuario.Editar(codUsuarioClicado);
            MessageBox.Show("Cod " + codUsuarioClicado + " Editado.");
            dgvUsuario.DataSource = usuario.RetTodosUsuarios();

            #region Limpando os textBox
            txtNome.Text = "";
            mskCpf.Text = "";
            txtEmail.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            mskTelefone.Text = "";
            cboTipoUsu.Text = "";
            #endregion
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se clicar em um campo diferente que nada
            if (dgvUsuario.Rows[e.RowIndex].Cells["codUsuario"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codUsuarioClicado = int.Parse(dgvUsuario.Rows[e.RowIndex].Cells["codUsuario"].Value.ToString());
            }
            //Pegando os valores para colocar no textBox
            cboTipoUsu.Text = dgvUsuario.Rows[e.RowIndex].Cells["tipoUsuario"].Value.ToString();
            txtEmail.Text = dgvUsuario.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtLogin.Text = dgvUsuario.Rows[e.RowIndex].Cells["loginUsuario"].Value.ToString();
            txtSenha.Text = dgvUsuario.Rows[e.RowIndex].Cells["senhaUsuario"].Value.ToString();
            txtNome.Text = dgvUsuario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            mskTelefone.Text = dgvUsuario.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            mskCpf.Text = dgvUsuario.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            //Atualizando o dataGrid pelo txtBusca
            dgvUsuario.DataSource = usuario.RetUsuario(txtBusca.Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Pegando as variaveis pra colocar no banco
            usuario.TipoUsuario = int.Parse(cboTipoUsu.Text);
            usuario.Email = txtEmail.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nome = txtNome.Text;
            usuario.Telefone = mskTelefone.Text;
            usuario.Cpf = mskCpf.Text;
            //Chamando o método excluir
            usuario.Excluir(codUsuarioClicado);
            MessageBox.Show("Cod = " + codUsuarioClicado + " Excluido.");
            dgvUsuario.DataSource = usuario.RetTodosUsuarios();
            
            #region Limpando os textBox
            txtNome.Text = "";
            mskCpf.Text = "";
            txtEmail.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            mskTelefone.Text = "";
            cboTipoUsu.Text = "";
            #endregion
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Feito para o textBox aceitar apenas letras
            if (!(char.IsLetter(e.KeyChar))//.IsLetter apenas letras
        && !(e.KeyChar == (char)Keys.Enter)//Exeto enter
        && !(e.KeyChar == (char)Keys.Back))//Exeto backSpace
            {
                e.Handled = true;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            //Caracteres da senha viram *
            txtSenha.PasswordChar = '*';
            //Máximo de caracteres
            txtSenha.MaxLength = 6;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //TextBox com menos de 3 caracteres
            if ((txtEmail.Text.Length < 3) || (txtLogin.Text.Length < 3) || (txtSenha.Text.Length < 3) || (txtNome.Text.Length < 3) || (mskTelefone.Text.Length < 3) || (mskCpf.Text.Length < 3))
            {
                MessageBox.Show("Existem caixas com menos de 3 caracteres.");
                validar = false;
            }
            else
            {
                MessageBox.Show("Cadastro validado com sucesso, pressione cadastrar para inserir o novo usuário");
                validar = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            //Se email tiver fazio terá que colocar um email válido
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Digite um email válido.");
            }
            else
            {
                //Irá receber os caracteres antes do @ e irá colocar no txtLogin
                txtLogin.Text = txtEmail.Text.Substring(0, txtEmail.Text.IndexOf('@'));
            }
        }
    }
}
