namespace Projeto
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mStripAcesso = new System.Windows.Forms.ToolStripMenuItem();
            this.mStripFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.subCadastroFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.subBuscaF = new System.Windows.Forms.ToolStripMenuItem();
            this.mStripCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.subCadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.subBuscaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mStripProd = new System.Windows.Forms.ToolStripMenuItem();
            this.subCadastroProd = new System.Windows.Forms.ToolStripMenuItem();
            this.subBuscaProd = new System.Windows.Forms.ToolStripMenuItem();
            this.mStripSair = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mStripAcesso,
            this.mStripFuncionario,
            this.mStripCliente,
            this.mStripProd,
            this.mStripSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(591, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mStripAcesso
            // 
            this.mStripAcesso.Name = "mStripAcesso";
            this.mStripAcesso.Size = new System.Drawing.Size(69, 24);
            this.mStripAcesso.Text = "Acesso";
            this.mStripAcesso.Click += new System.EventHandler(this.AcessoToolStripMenuItem_Click);
            // 
            // mStripFuncionario
            // 
            this.mStripFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subCadastroFunc,
            this.subBuscaF});
            this.mStripFuncionario.Name = "mStripFuncionario";
            this.mStripFuncionario.Size = new System.Drawing.Size(100, 24);
            this.mStripFuncionario.Text = "Funcionario";
            this.mStripFuncionario.Visible = false;
            this.mStripFuncionario.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // subCadastroFunc
            // 
            this.subCadastroFunc.Name = "subCadastroFunc";
            this.subCadastroFunc.Size = new System.Drawing.Size(151, 26);
            this.subCadastroFunc.Text = "Cadastro";
            this.subCadastroFunc.Visible = false;
            this.subCadastroFunc.Click += new System.EventHandler(this.CadastrarToolStripMenuItem_Click);
            // 
            // subBuscaF
            // 
            this.subBuscaF.Name = "subBuscaF";
            this.subBuscaF.Size = new System.Drawing.Size(151, 26);
            this.subBuscaF.Text = "Buscar";
            this.subBuscaF.Visible = false;
            this.subBuscaF.Click += new System.EventHandler(this.BuscarToolStripMenuItem_Click);
            // 
            // mStripCliente
            // 
            this.mStripCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subCadastroCliente,
            this.subBuscaCliente});
            this.mStripCliente.Name = "mStripCliente";
            this.mStripCliente.Size = new System.Drawing.Size(69, 24);
            this.mStripCliente.Text = "Cliente";
            this.mStripCliente.Visible = false;
            this.mStripCliente.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // subCadastroCliente
            // 
            this.subCadastroCliente.Name = "subCadastroCliente";
            this.subCadastroCliente.Size = new System.Drawing.Size(155, 26);
            this.subCadastroCliente.Text = "Cadastro ";
            this.subCadastroCliente.Visible = false;
            this.subCadastroCliente.Click += new System.EventHandler(this.PedidosToolStripMenuItem_Click);
            // 
            // subBuscaCliente
            // 
            this.subBuscaCliente.Name = "subBuscaCliente";
            this.subBuscaCliente.Size = new System.Drawing.Size(155, 26);
            this.subBuscaCliente.Text = "Buscar";
            this.subBuscaCliente.Visible = false;
            this.subBuscaCliente.Click += new System.EventHandler(this.BuscarToolStripMenuItem1_Click);
            // 
            // mStripProd
            // 
            this.mStripProd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subCadastroProd,
            this.subBuscaProd});
            this.mStripProd.Name = "mStripProd";
            this.mStripProd.Size = new System.Drawing.Size(76, 24);
            this.mStripProd.Text = "Produto";
            this.mStripProd.Visible = false;
            // 
            // subCadastroProd
            // 
            this.subCadastroProd.Name = "subCadastroProd";
            this.subCadastroProd.Size = new System.Drawing.Size(151, 26);
            this.subCadastroProd.Text = "Cadastro";
            this.subCadastroProd.Visible = false;
            this.subCadastroProd.Click += new System.EventHandler(this.CadastroToolStripMenuItem_Click);
            // 
            // subBuscaProd
            // 
            this.subBuscaProd.Name = "subBuscaProd";
            this.subBuscaProd.Size = new System.Drawing.Size(151, 26);
            this.subBuscaProd.Text = "Buscar";
            this.subBuscaProd.Visible = false;
            this.subBuscaProd.Click += new System.EventHandler(this.BuscarToolStripMenuItem3_Click);
            // 
            // mStripSair
            // 
            this.mStripSair.Name = "mStripSair";
            this.mStripSair.Size = new System.Drawing.Size(48, 24);
            this.mStripSair.Text = "Sair";
            this.mStripSair.Visible = false;
            this.mStripSair.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 631);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(609, 678);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem mStripCliente;
        public System.Windows.Forms.ToolStripMenuItem subCadastroCliente;
        public System.Windows.Forms.ToolStripMenuItem subBuscaCliente;
        public System.Windows.Forms.ToolStripMenuItem mStripFuncionario;
        public System.Windows.Forms.ToolStripMenuItem subCadastroFunc;
        public System.Windows.Forms.ToolStripMenuItem subBuscaF;
        public System.Windows.Forms.ToolStripMenuItem mStripProd;
        public System.Windows.Forms.ToolStripMenuItem subCadastroProd;
        public System.Windows.Forms.ToolStripMenuItem subBuscaProd;
        public System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem mStripSair;
        public System.Windows.Forms.ToolStripMenuItem mStripAcesso;
    }
}

