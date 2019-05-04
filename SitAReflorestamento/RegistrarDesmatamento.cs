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
    public partial class RegistrarDesmatamento : UserControl
    {
        public RegistrarDesmatamento()
        {
            InitializeComponent();
            dgvReflorestamento.DataSource = desmatamento.RetTodosUsuarios();
        }
        ClassDesmatamento desmatamento = new ClassDesmatamento();
        int codCalculoClicado = 0;
        bool validar;
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Pegando as variaveis pra colocar no banco
            desmatamento.Ano = int.Parse(txtAno.Text);
            desmatamento.Estado = cboEstado.Text;
            desmatamento.NumArvores = int.Parse(txtArvores.Text);
            desmatamento.VolumeM3 = int.Parse(txtVolume.Text);
            //Se algum campo ficar nulo
            if ((txtAno.Text == "") || (cboEstado.Text == "") || (txtArvores.Text == "") || (txtVolume.Text == ""))
            {
                MessageBox.Show("Preencha todos os dados.");
            }
            if (validar == true)
            {


                if (desmatamento.Inserir() == true)
                {

                    MessageBox.Show("Calculo cadastrado com sucesso");
                    dgvReflorestamento.DataSource = desmatamento.RetTodosUsuarios();
                    #region Limpando textBox
                    txtAno.Text = "";
                    cboEstado.Text = "";
                    txtArvores.Text = "";
                    txtVolume.Text = "";
                    #endregion
                    validar = false;
                }
            }
            else
            {
                MessageBox.Show("Valide o cadastro primeiro.");
            }
        }

        private void dgvReflorestamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se clicar em um campo diferente que nada
            if (dgvReflorestamento.Rows[e.RowIndex].Cells["codCalculo"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codCalculoClicado = int.Parse(dgvReflorestamento.Rows[e.RowIndex].Cells["codCalculo"].Value.ToString());
            }
            //Pegando as variaveis para inserir no banco
            txtAno.Text = dgvReflorestamento.Rows[e.RowIndex].Cells["ano"].Value.ToString();
            cboEstado.Text = dgvReflorestamento.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            txtArvores.Text = dgvReflorestamento.Rows[e.RowIndex].Cells["numArvoresCortadas"].Value.ToString();
            txtVolume.Text = dgvReflorestamento.Rows[e.RowIndex].Cells["volumeM3"].Value.ToString();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Pegando as variaveis pra colocar no banco
            desmatamento.Ano = int.Parse(txtAno.Text);
            desmatamento.Estado = cboEstado.Text;
            desmatamento.NumArvores = int.Parse(txtArvores.Text);
            desmatamento.VolumeM3 = int.Parse(txtVolume.Text);
            desmatamento.Editar(codCalculoClicado);
            MessageBox.Show("Cod " + codCalculoClicado + " Editado.");
            dgvReflorestamento.DataSource = desmatamento.RetTodosUsuarios();
        }

        private void RegistrarDesmatamento_Load(object sender, EventArgs e)
        {
            //Atualizando o dataGridView
            dgvReflorestamento.DataSource = desmatamento.RetTodosUsuarios();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Pegando as variaveis pra colocar no banco
            desmatamento.Ano = int.Parse(txtAno.Text);
            desmatamento.Estado = cboEstado.Text;
            desmatamento.NumArvores = int.Parse(txtArvores.Text);
            desmatamento.VolumeM3 = int.Parse(txtVolume.Text);
            desmatamento.Excluir(codCalculoClicado);
            MessageBox.Show("Cod " + codCalculoClicado + " Excluido.");
            dgvReflorestamento.DataSource = desmatamento.RetTodosUsuarios();

            #region Limpando textBox
            txtAno.Text = "";
            cboEstado.Text = "";
            txtArvores.Text = "";
            txtVolume.Text = "";
            #endregion
        }

        private void dgvReflorestamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboEstado_Leave(object sender, EventArgs e)
        {
            //Feito para o estado selecionado receber apenas a sigla
            #region estados
            if (cboEstado.Text == "Acre")
            {
                cboEstado.Text = "AC";
            }

            if (cboEstado.Text == "Alagoas")
            {
                cboEstado.Text = "AL";
            }

            if (cboEstado.Text == "Amapá")
            {
                cboEstado.Text = "AP";
            }

            if (cboEstado.Text == "Amazonas")
            {
                cboEstado.Text = "AM";
            }

            if (cboEstado.Text == "Bahia")
            {
                cboEstado.Text = "BA";
            }

            if (cboEstado.Text == "Ceará")
            {
                cboEstado.Text = "CE";
            }

            if (cboEstado.Text == "Distrito Federal")
            {
                cboEstado.Text = "DF";
            }

            if (cboEstado.Text == "Espírito Santo")
            {
                cboEstado.Text = "ES";
            }

            if (cboEstado.Text == "Goiás")
            {
                cboEstado.Text = "GO";
            }

            if (cboEstado.Text == "Maranhão")
            {
                cboEstado.Text = "MA";
            }

            if (cboEstado.Text == "Mato Grosso")
            {
                cboEstado.Text = "MT";
            }

            if (cboEstado.Text == "Mato Grosso do Sul")
            {
                cboEstado.Text = "MS";
            }

            if (cboEstado.Text == "Minas Gerais")
            {
                cboEstado.Text = "MG";
            }

            if (cboEstado.Text == "Pará")
            {
                cboEstado.Text = "PA";
            }

            if (cboEstado.Text == "Paraíba")
            {
                cboEstado.Text = "PB";
            }

            if (cboEstado.Text == "Paraná")
            {
                cboEstado.Text = "PR";
            }

            if (cboEstado.Text == "Pernambuco")
            {
                cboEstado.Text = "PE";
            }

            if (cboEstado.Text == "Piauí")
            {
                cboEstado.Text = "PI";
            }

            if (cboEstado.Text == "Rio de Janeiro")
            {
                cboEstado.Text = "RJ";
            }

            if (cboEstado.Text == "Rio Grande do Norte")
            {
                cboEstado.Text = "RN";
            }

            if (cboEstado.Text == "Rio Grande do Sul")
            {
                cboEstado.Text = "RS";
            }

            if (cboEstado.Text == "Rondônia")
            {
                cboEstado.Text = "RO";
            }

            if (cboEstado.Text == "Roraima")
            {
                cboEstado.Text = "RR";
            }

            if (cboEstado.Text == "Santa Catarina")
            {
                cboEstado.Text = "SC";
            }

            if (cboEstado.Text == "São Paulo")
            {
                cboEstado.Text = "SP";
            }

            if (cboEstado.Text == "Sergipe")
            {
                cboEstado.Text = "SE";
            }

            if (cboEstado.Text == "Tocantins")
            {
                cboEstado.Text = "TO";
            }
            #endregion
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Feito para o textBox aceitar apenas números
            if (!(char.IsNumber(e.KeyChar))//.IsLetter apenas números
        && !(e.KeyChar == (char)Keys.Enter)//Exeto enter
        && !(e.KeyChar == (char)Keys.Back))//Exeto backSpace
            {
                e.Handled = true;
            }
        }

        private void txtArvores_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Feito para o textBox aceitar apenas números
            if (!(char.IsNumber(e.KeyChar))//.IsLetter apenas números
        && !(e.KeyChar == (char)Keys.Enter)//Exeto enter
        && !(e.KeyChar == (char)Keys.Back))//Exeto backSpace
            {
                e.Handled = true;
            }
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Feito para o textBox aceitar apenas números
            if (!(char.IsNumber(e.KeyChar))//.IsLetter apenas números
        && !(e.KeyChar == (char)Keys.Enter)//Exeto enter
        && !(e.KeyChar == (char)Keys.Back))//Exeto backSpace
            {
                e.Handled = true;
            }
        }

        private void txtAno_Leave(object sender, EventArgs e)
        {
            if ((int.Parse(txtAno.Text) <1999) || (int.Parse(txtAno.Text) > 2018))
            {
                MessageBox.Show("Anos válidos são de 1999 até 2018.");
                txtAno.Text = "";
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //Não irá aceitar TextBox com menos de 3 caracteres
            if ((txtAno.Text.Length < 3) || (txtArvores.Text.Length < 3) || (txtVolume.Text.Length < 3))
            {
                MessageBox.Show("Existem caixas com menos de 3 caracteres.");
                validar = false;
            }
            else
            {
                MessageBox.Show("Cadastro validado com sucesso, pressione cadastrar para inserir o novo desmatamento");
                validar = true;
            }
        }
    }
}
