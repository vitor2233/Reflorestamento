namespace SitAReflorestamento
{
    partial class RegistrarDesmatamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarDesmatamento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReflorestamento = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtArvores = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNArvores = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvReflorestamento = new System.Windows.Forms.DataGridView();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnValidar = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 2;
            // 
            // lblReflorestamento
            // 
            this.lblReflorestamento.AutoSize = true;
            this.lblReflorestamento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReflorestamento.Location = new System.Drawing.Point(3, 17);
            this.lblReflorestamento.Name = "lblReflorestamento";
            this.lblReflorestamento.Size = new System.Drawing.Size(288, 24);
            this.lblReflorestamento.TabIndex = 2;
            this.lblReflorestamento.Text = "REGISTRAR DESMATAMENTO";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(171, 246);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(158, 20);
            this.txtVolume.TabIndex = 4;
            this.txtVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVolume_KeyPress);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVolume.Location = new System.Drawing.Point(77, 247);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(88, 17);
            this.lblVolume.TabIndex = 33;
            this.lblVolume.Text = "VOLUME (M3)";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtArvores
            // 
            this.txtArvores.Location = new System.Drawing.Point(171, 204);
            this.txtArvores.Name = "txtArvores";
            this.txtArvores.Size = new System.Drawing.Size(158, 20);
            this.txtArvores.TabIndex = 3;
            this.txtArvores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArvores_KeyPress);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(171, 120);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(158, 20);
            this.txtAno.TabIndex = 1;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            this.txtAno.Leave += new System.EventHandler(this.txtAno_Leave);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEstado.Location = new System.Drawing.Point(111, 163);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 17);
            this.lblEstado.TabIndex = 29;
            this.lblEstado.Text = "ESTADO";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNArvores
            // 
            this.lblNArvores.AutoSize = true;
            this.lblNArvores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNArvores.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNArvores.Location = new System.Drawing.Point(4, 205);
            this.lblNArvores.Name = "lblNArvores";
            this.lblNArvores.Size = new System.Drawing.Size(161, 17);
            this.lblNArvores.TabIndex = 28;
            this.lblNArvores.Text = "N DE ÁRVORES CORTADAS";
            this.lblNArvores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAno.Location = new System.Drawing.Point(129, 121);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(36, 17);
            this.lblAno.TabIndex = 27;
            this.lblAno.Text = "ANO";
            this.lblAno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(550, 167);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(143, 45);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(387, 167);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(143, 45);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(387, 107);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(143, 45);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvReflorestamento
            // 
            this.dgvReflorestamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReflorestamento.Location = new System.Drawing.Point(38, 282);
            this.dgvReflorestamento.Name = "dgvReflorestamento";
            this.dgvReflorestamento.Size = new System.Drawing.Size(655, 165);
            this.dgvReflorestamento.TabIndex = 38;
            this.dgvReflorestamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReflorestamento_CellClick);
            this.dgvReflorestamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReflorestamento_CellContentClick);
            // 
            // cboEstado
            // 
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
            this.cboEstado.Location = new System.Drawing.Point(171, 159);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(158, 21);
            this.cboEstado.TabIndex = 2;
            this.cboEstado.Leave += new System.EventHandler(this.cboEstado_Leave);
            // 
            // btnValidar
            // 
            this.btnValidar.Image = ((System.Drawing.Image)(resources.GetObject("btnValidar.Image")));
            this.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidar.Location = new System.Drawing.Point(550, 107);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(143, 45);
            this.btnValidar.TabIndex = 39;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // RegistrarDesmatamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.dgvReflorestamento);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtArvores);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNArvores);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrarDesmatamento";
            this.Size = new System.Drawing.Size(742, 464);
            this.Load += new System.EventHandler(this.RegistrarDesmatamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReflorestamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReflorestamento;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtArvores;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNArvores;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvReflorestamento;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnValidar;
    }
}
