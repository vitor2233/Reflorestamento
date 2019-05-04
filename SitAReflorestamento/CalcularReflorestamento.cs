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
    public partial class CalcularReflorestamento : UserControl
    {
        public CalcularReflorestamento()
        {
            InitializeComponent();
            dgvReflorestamento.DataSource = desmatamento.RetTodosUsuarios();
        }
        ClassDesmatamento desmatamento = new ClassDesmatamento();
        int codCalculoClicado = 0;
        private void dgvDesmatamento_CellClick(object sender, DataGridViewCellEventArgs e)
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
            txtArvoresR.Text = dgvReflorestamento.Rows[e.RowIndex].Cells["arvoresARepor"].Value.ToString();
            txtTotal.Text = dgvReflorestamento.Rows[e.RowIndex].Cells["valorAPagar"].Value.ToString();
            
        }

        private void CalcularReflorestamento_Load(object sender, EventArgs e)
        {
            //Atualizando o dataGrid
            dgvReflorestamento.DataSource = desmatamento.RetTodosUsuarios();
        }

        private void cboEstado_Leave(object sender, EventArgs e)
        {
            //Os estados recebem a sigla
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

            if (cboEstado.Text == "Espirito Santo")
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

        private void btnRepor_Click(object sender, EventArgs e)
        {
            //Cálculo da reposição
            double reposicao = double.Parse(txtVolume.Text) * 0.75;
            //Irá colocar no banco de dados
            desmatamento.ArvoresARepor = reposicao;
            desmatamento.ReporArvores(codCalculoClicado);
            //Atualiza o banco de dados
            dgvReflorestamento.DataSource = desmatamento.RetTodosUsuarios();
            //txtArvores recebe o resultado da conta
            txtArvoresR.Text = reposicao.ToString();

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //Cálculo do valor a pagar
            int valorPagar = int.Parse(txtArvores.Text) * 6;
            //Irá colocar no banco de dados
            desmatamento.ValorAPagar = valorPagar;
            desmatamento.InserirValor(codCalculoClicado);
            //Atualiza o banco de dados
            dgvReflorestamento.DataSource = desmatamento.RetTodosUsuarios();
            //txtTotal recebe o resultado da conta
            txtTotal.Text = valorPagar.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvReflorestamento.DataSource = desmatamento.RetTodosUsuarios();
        }
    }
}
