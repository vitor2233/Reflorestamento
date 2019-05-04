namespace SitAReflorestamento
{
    partial class frmAdministrador
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
            this.pnlDireito = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRegistrarDsmt = new System.Windows.Forms.Button();
            this.btnReflorestamento = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pagInicial = new SitAReflorestamento.PagInicial();
            this.pagCadastro = new SitAReflorestamento.Cadastro();
            this.pagRegDesmt = new SitAReflorestamento.RegistrarDesmatamento();
            this.pagCalculo = new SitAReflorestamento.CalcularReflorestamento();
            this.pnlDireito.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDireito
            // 
            this.pnlDireito.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlDireito.Controls.Add(this.SidePanel);
            this.pnlDireito.Controls.Add(this.btnMinimizar);
            this.pnlDireito.Controls.Add(this.btnSair);
            this.pnlDireito.Controls.Add(this.btnRegistrarDsmt);
            this.pnlDireito.Controls.Add(this.btnReflorestamento);
            this.pnlDireito.Controls.Add(this.btnCadastrar);
            this.pnlDireito.Controls.Add(this.pnlLogo);
            this.pnlDireito.Location = new System.Drawing.Point(732, 0);
            this.pnlDireito.Name = "pnlDireito";
            this.pnlDireito.Size = new System.Drawing.Size(159, 461);
            this.pnlDireito.TabIndex = 2;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Transparent;
            this.SidePanel.Location = new System.Drawing.Point(146, 448);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 10);
            this.SidePanel.TabIndex = 3;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(74, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(43, 39);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(117, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(43, 39);
            this.btnSair.TabIndex = 3;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRegistrarDsmt
            // 
            this.btnRegistrarDsmt.FlatAppearance.BorderSize = 0;
            this.btnRegistrarDsmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDsmt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarDsmt.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarDsmt.Image")));
            this.btnRegistrarDsmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarDsmt.Location = new System.Drawing.Point(3, 198);
            this.btnRegistrarDsmt.Name = "btnRegistrarDsmt";
            this.btnRegistrarDsmt.Size = new System.Drawing.Size(156, 43);
            this.btnRegistrarDsmt.TabIndex = 3;
            this.btnRegistrarDsmt.Text = "REGISTRAR DESMATAMENTO";
            this.btnRegistrarDsmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarDsmt.UseVisualStyleBackColor = true;
            this.btnRegistrarDsmt.Click += new System.EventHandler(this.btnRegistrarDsmt_Click);
            // 
            // btnReflorestamento
            // 
            this.btnReflorestamento.FlatAppearance.BorderSize = 0;
            this.btnReflorestamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReflorestamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReflorestamento.Image = ((System.Drawing.Image)(resources.GetObject("btnReflorestamento.Image")));
            this.btnReflorestamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReflorestamento.Location = new System.Drawing.Point(3, 253);
            this.btnReflorestamento.Name = "btnReflorestamento";
            this.btnReflorestamento.Size = new System.Drawing.Size(156, 43);
            this.btnReflorestamento.TabIndex = 4;
            this.btnReflorestamento.Text = "CALCULAR REFLORESTAMENTO";
            this.btnReflorestamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReflorestamento.UseVisualStyleBackColor = true;
            this.btnReflorestamento.Click += new System.EventHandler(this.btnReflorestamento_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 141);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(156, 45);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "CADRASTRAR USUÁRIO";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLogo.Location = new System.Drawing.Point(0, 41);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(159, 103);
            this.pnlLogo.TabIndex = 1;
            // 
            // pagInicial
            // 
            this.pagInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pagInicial.Location = new System.Drawing.Point(-3, 0);
            this.pagInicial.Name = "pagInicial";
            this.pagInicial.Size = new System.Drawing.Size(742, 461);
            this.pagInicial.TabIndex = 4;
            // 
            // pagCadastro
            // 
            this.pagCadastro.Location = new System.Drawing.Point(-3, 0);
            this.pagCadastro.Name = "pagCadastro";
            this.pagCadastro.Size = new System.Drawing.Size(742, 461);
            this.pagCadastro.TabIndex = 5;
            // 
            // pagRegDesmt
            // 
            this.pagRegDesmt.Location = new System.Drawing.Point(-3, 0);
            this.pagRegDesmt.Name = "pagRegDesmt";
            this.pagRegDesmt.Size = new System.Drawing.Size(742, 464);
            this.pagRegDesmt.TabIndex = 6;
            // 
            // pagCalculo
            // 
            this.pagCalculo.Location = new System.Drawing.Point(-3, 0);
            this.pagCalculo.Name = "pagCalculo";
            this.pagCalculo.Size = new System.Drawing.Size(742, 464);
            this.pagCalculo.TabIndex = 7;
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 460);
            this.Controls.Add(this.pagCalculo);
            this.Controls.Add(this.pagRegDesmt);
            this.Controls.Add(this.pagCadastro);
            this.Controls.Add(this.pagInicial);
            this.Controls.Add(this.pnlDireito);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministrador";
            this.pnlDireito.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDireito;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnReflorestamento;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnRegistrarDsmt;
        private PagInicial pagInicial;
        private Cadastro pagCadastro;
        private RegistrarDesmatamento pagRegDesmt;
        private CalcularReflorestamento pagCalculo;
    }
}