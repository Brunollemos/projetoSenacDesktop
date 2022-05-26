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
    public partial class CLIENTE : Form
    {
        public CLIENTE()
        {
            InitializeComponent();
        }

        private void cadastro_cliente_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            
            
            Classes.CLIENTE cc = new Classes.CLIENTE(txtNomeCliente.Text, int.Parse(txtCpfCliente.Text),
                txtRuaCliente.Text, txtEmailCliente.Text, decimal.Parse(textCelCliente.Text), int.Parse(txtNumeroCliente.Text), txtBairroCliente.Text, txtCidadeCliente.Text, cmbClienteGenero.Text, int.Parse(textCepCliente.Text),txtRgCliente.Text,cmbEstadoCliente.Text );

            cc.CadastrarCliente();

            MessageBox.Show("deu bom");








        }

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {


            Classes.CLIENTE ac = new Classes.CLIENTE(txtNomeCliente.Text, int.Parse(txtCpfCliente.Text),
               txtRuaCliente.Text, txtEmailCliente.Text, decimal.Parse(textCelCliente.Text), int.Parse(txtNumeroCliente.Text), txtBairroCliente.Text, txtCidadeCliente.Text, cmbClienteGenero.Text, int.Parse(textCepCliente.Text), txtRgCliente.Text, cmbEstadoCliente.Text);

            ac.Atualizarcliente();





        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {

         

                
                Classes.CLIENTE bc = new Classes.CLIENTE();
                if(bc.buscaCliente(int.Parse(txtBuscaCliente.Text)) == true)
                {


                    txtNomeCliente.Text = bc.nome;
                    cmbClienteGenero.Text = bc.genero;
                    txtCpfCliente.Text = bc.cpf.ToString();
                    txtRgCliente.Text = bc.rg;
                    txtEmailCliente.Text = bc.email;
                    cmbEstadoCliente.Text = bc.estado;
                    txtCidadeCliente.Text = bc.cidade;
                    txtBairroCliente.Text = bc.bairro;
                    txtRuaCliente.Text = bc.rua;
                    txtNumeroCliente.Text = bc.numeroCasa.ToString();
                    textCepCliente.Text = bc.cep.ToString();                    
                    textCelCliente.Text = bc.celular.ToString();


                }            
                else
                {

                 MessageBox.Show("Cliente não encontrado.");


                }      

        }


        private void btnCliLimpar_Click(object sender, EventArgs e)
        {

            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textCepCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbClienteGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
