namespace Projeto
{
    partial class gridPRODUTO
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaProdutoGrid = new System.Windows.Forms.Button();
            this.txtBuscaProdutoGrid = new System.Windows.Forms.TextBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Código.:";
            // 
            // btnBuscaProdutoGrid
            // 
            this.btnBuscaProdutoGrid.Location = new System.Drawing.Point(327, 6);
            this.btnBuscaProdutoGrid.Name = "btnBuscaProdutoGrid";
            this.btnBuscaProdutoGrid.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaProdutoGrid.TabIndex = 23;
            this.btnBuscaProdutoGrid.Text = "Buscar";
            this.btnBuscaProdutoGrid.UseVisualStyleBackColor = true;
            this.btnBuscaProdutoGrid.Click += new System.EventHandler(this.btnBuscaProdutoGrid_Click);
            // 
            // txtBuscaProdutoGrid
            // 
            this.txtBuscaProdutoGrid.Location = new System.Drawing.Point(80, 9);
            this.txtBuscaProdutoGrid.Name = "txtBuscaProdutoGrid";
            this.txtBuscaProdutoGrid.Size = new System.Drawing.Size(224, 20);
            this.txtBuscaProdutoGrid.TabIndex = 22;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(8, 37);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersWidth = 51;
            this.dgvProduto.Size = new System.Drawing.Size(395, 382);
            this.dgvProduto.TabIndex = 21;
            this.dgvProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            // 
            // gridPRODUTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscaProdutoGrid);
            this.Controls.Add(this.txtBuscaProdutoGrid);
            this.Controls.Add(this.dgvProduto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "gridPRODUTO";
            this.Text = "Lista de Produtos";
            this.Load += new System.EventHandler(this.GridPRODUTO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaProdutoGrid;
        private System.Windows.Forms.TextBox txtBuscaProdutoGrid;
        private System.Windows.Forms.DataGridView dgvProduto;
    }
}