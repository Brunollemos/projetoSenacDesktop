namespace Projeto
{
    partial class gridCliente
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
            this.btnBuscarGridCliente = new System.Windows.Forms.Button();
            this.txtBuscaGridCliente = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarGridCliente
            // 
            this.btnBuscarGridCliente.Location = new System.Drawing.Point(436, 7);
            this.btnBuscarGridCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarGridCliente.Name = "btnBuscarGridCliente";
            this.btnBuscarGridCliente.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarGridCliente.TabIndex = 14;
            this.btnBuscarGridCliente.Text = "Buscar";
            this.btnBuscarGridCliente.UseVisualStyleBackColor = true;
            this.btnBuscarGridCliente.Click += new System.EventHandler(this.btnBuscarGridCliente_Click);
            // 
            // txtBuscaGridCliente
            // 
            this.txtBuscaGridCliente.Location = new System.Drawing.Point(81, 11);
            this.txtBuscaGridCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscaGridCliente.Name = "txtBuscaGridCliente";
            this.txtBuscaGridCliente.Size = new System.Drawing.Size(341, 22);
            this.txtBuscaGridCliente.TabIndex = 13;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(11, 46);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.Size = new System.Drawing.Size(527, 470);
            this.dgvCliente.TabIndex = 12;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "CPF.:";
            // 
            // gridCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarGridCliente);
            this.Controls.Add(this.txtBuscaGridCliente);
            this.Controls.Add(this.dgvCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "gridCliente";
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.GridCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarGridCliente;
        private System.Windows.Forms.TextBox txtBuscaGridCliente;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label1;
    }
}