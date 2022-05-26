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
    public partial class cadastro_funcionario : Form
    {
        public cadastro_funcionario()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void cadastro_funcionario_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;           
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
                        
            Classes.FUNCIONARIO cf = new Classes.FUNCIONARIO(txtNomeFuncionario.Text, int.Parse(txtCpfFuncionario.Text),txtRuaFuncionario.Text, txtEmailFuncionario.Text, decimal.Parse(txtCelFunc.Text), decimal.Parse(txtNumeroFuncionario.Text),txtBairroFuncionario.Text, txtCidadeFuncionario.Text,
                cmbGeneroFuncionario.Text, int.Parse(txtCepFunc.Text), txtRgFuncionario.Text, cmbEstadoFuncionario.Text, cmbCargoFuncionario.Text,txtPisFuncionario.Text,txtUsuarioFuncionario.Text, txtSenhaFuncionario.Text);

            cf.cadastrarFuncionario();
            MessageBox.Show("deu bom");

        }

        private void btnBuscaFuncionario_Click(object sender, EventArgs e)
        {
            Classes.FUNCIONARIO bf = new Classes.FUNCIONARIO();

            if (bf.buscaFuncionario(decimal.Parse(txtBuscaFuncionario.Text)) == true)
            {

                txtNomeFuncionario.Text = bf.nome;
                cmbGeneroFuncionario.Text = bf.genero;
                txtCpfFuncionario.Text = bf.cpf.ToString();
                txtRgFuncionario.Text = bf.rg;
                txtEmailFuncionario.Text = bf.email;
                cmbEstadoFuncionario.Text = bf.estado;
                txtCidadeFuncionario.Text = bf.cidade;
                txtBairroFuncionario.Text = bf.bairro;
                txtRuaFuncionario.Text = bf.rua;
                txtNumeroFuncionario.Text = bf.numeroCasa.ToString();
                txtCepFunc.Text = bf.cep.ToString();
                txtCelFunc.Text = bf.celular.ToString();
                txtPisFuncionario.Text = bf.pis.ToString();
                cmbCargoFuncionario.Text = bf.cargo;
                txtSenhaFuncionario.Text = bf.senha;
                txtUsuarioFuncionario.Text = bf.usuario;

            }
            else
            {

                MessageBox.Show("Funcionário não encontrado.");


            }

        }

        private void btnAtualizarFuncionario_Click(object sender, EventArgs e)
        {

            Classes.FUNCIONARIO af = new Classes.FUNCIONARIO(txtNomeFuncionario.Text, int.Parse(txtCpfFuncionario.Text), txtRuaFuncionario.Text, txtEmailFuncionario.Text, decimal.Parse(txtCelFunc.Text), decimal.Parse(txtNumeroFuncionario.Text), txtBairroFuncionario.Text, txtCidadeFuncionario.Text,
                cmbGeneroFuncionario.Text, int.Parse(txtCepFunc.Text), txtRgFuncionario.Text, cmbEstadoFuncionario.Text, cmbCargoFuncionario.Text,txtPisFuncionario.Text, txtUsuarioFuncionario.Text, txtSenhaFuncionario.Text);

            af.atualizarfuncionario();

        }

        private void txtEmailFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCelFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
