namespace Projeto
{
    partial class PRODUTO
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
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescProdu = new System.Windows.Forms.RichTextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.txtValorProd = new System.Windows.Forms.TextBox();
            this.btnAtualizarProd = new System.Windows.Forms.Button();
            this.btnCadastrarProd = new System.Windows.Forms.Button();
            this.btnBuscaCodProd = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.txtBuscaCodProd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtqtdProdEst = new System.Windows.Forms.NumericUpDown();
            this.cmbPlataform = new System.Windows.Forms.ComboBox();
            this.txtcategProd = new System.Windows.Forms.TextBox();
            this.btnLimparProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtdProdEst)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Produto.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Plataforma.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valor.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantidade.:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Desc.:";
            // 
            // txtDescProdu
            // 
            this.txtDescProdu.Location = new System.Drawing.Point(93, 268);
            this.txtDescProdu.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescProdu.Name = "txtDescProdu";
            this.txtDescProdu.Size = new System.Drawing.Size(437, 160);
            this.txtDescProdu.TabIndex = 7;
            this.txtDescProdu.Text = "";
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(116, 80);
            this.txtNomeProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(415, 22);
            this.txtNomeProd.TabIndex = 2;
            // 
            // txtValorProd
            // 
            this.txtValorProd.Location = new System.Drawing.Point(93, 124);
            this.txtValorProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorProd.Name = "txtValorProd";
            this.txtValorProd.Size = new System.Drawing.Size(155, 22);
            this.txtValorProd.TabIndex = 3;
            // 
            // btnAtualizarProd
            // 
            this.btnAtualizarProd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAtualizarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarProd.Location = new System.Drawing.Point(52, 454);
            this.btnAtualizarProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizarProd.Name = "btnAtualizarProd";
            this.btnAtualizarProd.Size = new System.Drawing.Size(131, 38);
            this.btnAtualizarProd.TabIndex = 8;
            this.btnAtualizarProd.Text = "Atualizar";
            this.btnAtualizarProd.UseVisualStyleBackColor = false;
            this.btnAtualizarProd.Click += new System.EventHandler(this.btnAtualizarProd_Click);
            // 
            // btnCadastrarProd
            // 
            this.btnCadastrarProd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCadastrarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProd.Location = new System.Drawing.Point(377, 454);
            this.btnCadastrarProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarProd.Name = "btnCadastrarProd";
            this.btnCadastrarProd.Size = new System.Drawing.Size(131, 38);
            this.btnCadastrarProd.TabIndex = 32;
            this.btnCadastrarProd.Text = "Cadastrar";
            this.btnCadastrarProd.UseVisualStyleBackColor = false;
            this.btnCadastrarProd.Click += new System.EventHandler(this.btnCadastrarProd_Click);
            // 
            // btnBuscaCodProd
            // 
            this.btnBuscaCodProd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBuscaCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCodProd.Location = new System.Drawing.Point(435, 25);
            this.btnBuscaCodProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscaCodProd.Name = "btnBuscaCodProd";
            this.btnBuscaCodProd.Size = new System.Drawing.Size(100, 37);
            this.btnBuscaCodProd.TabIndex = 1;
            this.btnBuscaCodProd.Text = "Buscar";
            this.btnBuscaCodProd.UseVisualStyleBackColor = false;
            this.btnBuscaCodProd.Click += new System.EventHandler(this.btnBuscaCodProd_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(260, 122);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(108, 25);
            this.label26.TabIndex = 99;
            this.label26.Text = "Categoria.:";
            // 
            // txtBuscaCodProd
            // 
            this.txtBuscaCodProd.Location = new System.Drawing.Point(116, 33);
            this.txtBuscaCodProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscaCodProd.Name = "txtBuscaCodProd";
            this.txtBuscaCodProd.Size = new System.Drawing.Size(307, 22);
            this.txtBuscaCodProd.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 33);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 25);
            this.label12.TabIndex = 127;
            this.label12.Text = "Código.:";
            // 
            // txtqtdProdEst
            // 
            this.txtqtdProdEst.Location = new System.Drawing.Point(160, 222);
            this.txtqtdProdEst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtqtdProdEst.Name = "txtqtdProdEst";
            this.txtqtdProdEst.Size = new System.Drawing.Size(372, 22);
            this.txtqtdProdEst.TabIndex = 6;
            // 
            // cmbPlataform
            // 
            this.cmbPlataform.FormattingEnabled = true;
            this.cmbPlataform.Items.AddRange(new object[] {
            "XBOX",
            "PC",
            "SWITCH",
            "PLAYSTATION"});
            this.cmbPlataform.Location = new System.Drawing.Point(139, 175);
            this.cmbPlataform.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlataform.Name = "cmbPlataform";
            this.cmbPlataform.Size = new System.Drawing.Size(392, 24);
            this.cmbPlataform.TabIndex = 5;
            // 
            // txtcategProd
            // 
            this.txtcategProd.Location = new System.Drawing.Point(377, 123);
            this.txtcategProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtcategProd.Name = "txtcategProd";
            this.txtcategProd.Size = new System.Drawing.Size(153, 22);
            this.txtcategProd.TabIndex = 4;
            // 
            // btnLimparProd
            // 
            this.btnLimparProd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimparProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparProd.Location = new System.Drawing.Point(205, 454);
            this.btnLimparProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparProd.Name = "btnLimparProd";
            this.btnLimparProd.Size = new System.Drawing.Size(131, 38);
            this.btnLimparProd.TabIndex = 128;
            this.btnLimparProd.Text = "Limpar";
            this.btnLimparProd.UseVisualStyleBackColor = false;
            this.btnLimparProd.Click += new System.EventHandler(this.btnLimparProd_Click);
            // 
            // PRODUTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 522);
            this.Controls.Add(this.btnLimparProd);
            this.Controls.Add(this.txtcategProd);
            this.Controls.Add(this.cmbPlataform);
            this.Controls.Add(this.txtqtdProdEst);
            this.Controls.Add(this.txtBuscaCodProd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBuscaCodProd);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnAtualizarProd);
            this.Controls.Add(this.btnCadastrarProd);
            this.Controls.Add(this.txtValorProd);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.txtDescProdu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PRODUTO";
            this.Text = "Controle de Produtos";
            this.Load += new System.EventHandler(this.PRODUTO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtqtdProdEst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtDescProdu;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.TextBox txtValorProd;
        private System.Windows.Forms.Button btnAtualizarProd;
        private System.Windows.Forms.Button btnCadastrarProd;
        private System.Windows.Forms.Button btnBuscaCodProd;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtBuscaCodProd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown txtqtdProdEst;
        private System.Windows.Forms.ComboBox cmbPlataform;
        private System.Windows.Forms.TextBox txtcategProd;
        private System.Windows.Forms.Button btnLimparProd;
    }
}