using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class PRODUTO : Form
    {
        public PRODUTO()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PRODUTO_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
     

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {


            Classes.PRODUTO cp = new Classes.PRODUTO(txtNomeProd.Text, txtcategProd.Text, decimal.Parse(txtValorProd.Text), int.Parse(txtqtdProdEst.Text), txtDescProdu.Text,cmbPlataform.Text);
            cp.cadastrarProduto();
            MessageBox.Show("deu bom");


        }

        private void btnAtualizarProd_Click(object sender, EventArgs e)
        {

            Classes.PRODUTO ap = new Classes.PRODUTO(txtNomeProd.Text, txtcategProd.Text, decimal.Parse(txtValorProd.Text), int.Parse(txtqtdProdEst.Text), txtDescProdu.Text, cmbPlataform.Text);
            ap.atualizarProduto();



        }

        private void btnBuscaCodProd_Click(object sender, EventArgs e)
        {

            Classes.PRODUTO bp = new Classes.PRODUTO();

            if(bp.buscarProduto(int.Parse(txtBuscaCodProd.Text)) == true)
            {
                txtNomeProd.Text = bp.nomeProduto;
                txtcategProd.Text = bp.categoriaProduto;
                txtValorProd.Text = bp.preçoProduto.ToString();
                txtqtdProdEst.Value = bp.estoqueProduto;
                txtDescProdu.Text = bp.descProduto;
                cmbPlataform.Text = bp.plataformaProduto;

            }
            else
            {
                MessageBox.Show("Produto não encontrado!!!");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLimparProd_Click(object sender, EventArgs e)
        {



            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }

        }
    }
}
