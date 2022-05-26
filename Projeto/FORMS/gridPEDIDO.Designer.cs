namespace Projeto
{
    partial class gridPEDIDO
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
            this.btnBuscaPedidoGrid = new System.Windows.Forms.Button();
            this.txtBuscaPedidoGrid = new System.Windows.Forms.TextBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscaPedidoGrid
            // 
            this.btnBuscaPedidoGrid.Location = new System.Drawing.Point(436, 7);
            this.btnBuscaPedidoGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscaPedidoGrid.Name = "btnBuscaPedidoGrid";
            this.btnBuscaPedidoGrid.Size = new System.Drawing.Size(100, 28);
            this.btnBuscaPedidoGrid.TabIndex = 23;
            this.btnBuscaPedidoGrid.Text = "Buscar";
            this.btnBuscaPedidoGrid.UseVisualStyleBackColor = true;
            this.btnBuscaPedidoGrid.Click += new System.EventHandler(this.btnBuscaPedidoGrid_Click);
            // 
            // txtBuscaPedidoGrid
            // 
            this.txtBuscaPedidoGrid.Location = new System.Drawing.Point(208, 11);
            this.txtBuscaPedidoGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscaPedidoGrid.Name = "txtBuscaPedidoGrid";
            this.txtBuscaPedidoGrid.Size = new System.Drawing.Size(217, 22);
            this.txtBuscaPedidoGrid.TabIndex = 22;
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(11, 46);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.Size = new System.Drawing.Size(527, 470);
            this.dgvPedido.TabIndex = 21;
            this.dgvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Número do Pedido.:";
            // 
            // gridPEDIDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 522);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnBuscaPedidoGrid);
            this.Controls.Add(this.txtBuscaPedidoGrid);
            this.Controls.Add(this.dgvPedido);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "gridPEDIDO";
            this.Text = "Lista de Pedidos";
            this.Load += new System.EventHandler(this.GridPEDIDO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscaPedidoGrid;
        private System.Windows.Forms.TextBox txtBuscaPedidoGrid;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Label label11;
    }
}