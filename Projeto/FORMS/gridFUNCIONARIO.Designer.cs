namespace Projeto
{
    partial class gridFUNCIONARIO
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
            this.btnBuscaGridFunc = new System.Windows.Forms.Button();
            this.txtBuscaGridFunc = new System.Windows.Forms.TextBox();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "CPF:";
            // 
            // btnBuscaGridFunc
            // 
            this.btnBuscaGridFunc.Location = new System.Drawing.Point(327, 6);
            this.btnBuscaGridFunc.Name = "btnBuscaGridFunc";
            this.btnBuscaGridFunc.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaGridFunc.TabIndex = 19;
            this.btnBuscaGridFunc.Text = "Buscar";
            this.btnBuscaGridFunc.UseVisualStyleBackColor = true;
            this.btnBuscaGridFunc.Click += new System.EventHandler(this.btnBuscaGridFunc_Click);
            // 
            // txtBuscaGridFunc
            // 
            this.txtBuscaGridFunc.Location = new System.Drawing.Point(55, 9);
            this.txtBuscaGridFunc.Name = "txtBuscaGridFunc";
            this.txtBuscaGridFunc.Size = new System.Drawing.Size(263, 20);
            this.txtBuscaGridFunc.TabIndex = 18;
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(8, 37);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.RowHeadersWidth = 51;
            this.dgvFuncionario.Size = new System.Drawing.Size(395, 382);
            this.dgvFuncionario.TabIndex = 17;
            this.dgvFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFuncionario_CellContentClick);
            // 
            // gridFUNCIONARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscaGridFunc);
            this.Controls.Add(this.txtBuscaGridFunc);
            this.Controls.Add(this.dgvFuncionario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "gridFUNCIONARIO";
            this.Text = "Lista Funcionários";
            this.Load += new System.EventHandler(this.GridFUNCIONARIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaGridFunc;
        private System.Windows.Forms.TextBox txtBuscaGridFunc;
        private System.Windows.Forms.DataGridView dgvFuncionario;
    }
}