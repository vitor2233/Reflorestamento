namespace SitAReflorestamento
{
    partial class CalcularReflorestamento
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReflorestamento = new System.Windows.Forms.Label();
            this.dgvReflorestamento = new System.Windows.Forms.DataGridView();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtArvores = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNArvores = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnRepor = new System.Windows.Forms.Button();
            this.txtArvoresR = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRepor = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReflorestamento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.lblReflorestamento);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 41);
            this.panel1.TabIndex = 1;
            // 
            // lblReflorestamento
            // 
            this.lblReflorestamento.AutoSize = true;
            this.lblReflorestamento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReflorestamento.Location = new System.Drawing.Point(3, 17);
            this.lblReflorestamento.Name = "lblReflorestamento";
            this.lblReflorestamento.Size = new System.Drawing.Size(317, 24);
            this.lblReflorestamento.TabIndex = 2;
            this.lblReflorestamento.Text = "CALCULAR REFLORESTAMENTO";
            // 
            // dgvReflorestamento
            // 
            this.dgvReflorestamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReflorestamento.Location = new System.Drawing.Point(58, 321);
            this.dgvReflorestamento.Name = "dgvReflorestamento";
            this.dgvReflorestamento.Size = new System.Drawing.Size(571, 118);
            this.dgvReflorestamento.TabIndex = 2;
            this.dgvReflorestamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesmatamento_CellClick);
            // 
            // cboEstado
            // 
            this.cboEstado.Enabled = false;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Gosso Do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cboEstado.Location = new System.Drawing.Point(178, 120);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(158, 21);
            this.cboEstado.TabIndex = 35;
            this.cboEstado.Leave += new System.EventHandler(this.cboEstado_Leave);
            // 
            // txtVolume
            // 
            this.txtVolume.Enabled = false;
            this.txtVolume.Location = new System.Drawing.Point(178, 207);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(158, 20);
            this.txtVolume.TabIndex = 37;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVolume.Location = new System.Drawing.Point(84, 208);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(88, 17);
            this.lblVolume.TabIndex = 41;
            this.lblVolume.Text = "VOLUME (M3)";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtArvores
            // 
            this.txtArvores.Enabled = false;
            this.txtArvores.Location = new System.Drawing.Point(178, 165);
            this.txtArvores.Name = "txtArvores";
            this.txtArvores.Size = new System.Drawing.Size(158, 20);
            this.txtArvores.TabIndex = 36;
            // 
            // txtAno
            // 
            this.txtAno.Enabled = false;
            this.txtAno.Location = new System.Drawing.Point(178, 81);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(158, 20);
            this.txtAno.TabIndex = 34;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEstado.Location = new System.Drawing.Point(118, 124);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 17);
            this.lblEstado.TabIndex = 40;
            this.lblEstado.Text = "ESTADO";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNArvores
            // 
            this.lblNArvores.AutoSize = true;
            this.lblNArvores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNArvores.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNArvores.Location = new System.Drawing.Point(11, 166);
            this.lblNArvores.Name = "lblNArvores";
            this.lblNArvores.Size = new System.Drawing.Size(161, 17);
            this.lblNArvores.TabIndex = 39;
            this.lblNArvores.Text = "N DE ÁRVORES CORTADAS";
            this.lblNArvores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAno.Location = new System.Drawing.Point(136, 82);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(36, 17);
            this.lblAno.TabIndex = 38;
            this.lblAno.Text = "ANO";
            this.lblAno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(491, 158);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(138, 45);
            this.btnTotal.TabIndex = 42;
            this.btnTotal.Text = "TOTAL A PAGAR";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnRepor
            // 
            this.btnRepor.Location = new System.Drawing.Point(491, 96);
            this.btnRepor.Name = "btnRepor";
            this.btnRepor.Size = new System.Drawing.Size(138, 45);
            this.btnRepor.TabIndex = 43;
            this.btnRepor.Text = "REPOSIÇÃO DE ÁRVORES";
            this.btnRepor.UseVisualStyleBackColor = true;
            this.btnRepor.Click += new System.EventHandler(this.btnRepor_Click);
            // 
            // txtArvoresR
            // 
            this.txtArvoresR.Enabled = false;
            this.txtArvoresR.Location = new System.Drawing.Point(176, 242);
            this.txtArvoresR.Name = "txtArvoresR";
            this.txtArvoresR.Size = new System.Drawing.Size(158, 20);
            this.txtArvoresR.TabIndex = 44;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Location = new System.Drawing.Point(70, 282);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 17);
            this.lblTotal.TabIndex = 47;
            this.lblTotal.Text = "TOTAL A PAGAR";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRepor
            // 
            this.lblRepor.AutoSize = true;
            this.lblRepor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRepor.Location = new System.Drawing.Point(55, 243);
            this.lblRepor.Name = "lblRepor";
            this.lblRepor.Size = new System.Drawing.Size(115, 17);
            this.lblRepor.TabIndex = 46;
            this.lblRepor.Text = "ÁRVORES A REPOR";
            this.lblRepor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(176, 281);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(158, 20);
            this.txtTotal.TabIndex = 48;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(648, 321);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 55);
            this.btnAtualizar.TabIndex = 49;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // CalcularReflorestamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtArvoresR);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRepor);
            this.Controls.Add(this.btnRepor);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtArvores);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNArvores);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.dgvReflorestamento);
            this.Controls.Add(this.panel1);
            this.Name = "CalcularReflorestamento";
            this.Size = new System.Drawing.Size(742, 464);
            this.Load += new System.EventHandler(this.CalcularReflorestamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReflorestamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReflorestamento;
        private System.Windows.Forms.DataGridView dgvReflorestamento;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtArvores;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNArvores;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnRepor;
        private System.Windows.Forms.TextBox txtArvoresR;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRepor;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAtualizar;
    }
}
