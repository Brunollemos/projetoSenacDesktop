using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class ACESSO : Form
    {
        public ACESSO()
        {
            InitializeComponent();
        }

        private void ACESSO_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            string sql = System.Configuration.ConfigurationManager.ConnectionStrings["ProjetoPIonline"].ToString();

            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.Parameters.AddWithValue("loginFuncionario", txtUsuarioAcesso.Text);
            cmd.Parameters.AddWithValue("senhaFuncionario", txtSenha.Text);

            cmd.Connection = con;
            cmd.CommandText = "ps_Login_Desktop";
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                MessageBox.Show("Bem vindo!");
                dr.Read();

                if (dr.GetString(17) == "Gerente")
                {
                    //privilégios de gerente
                    ((Principal)this.MdiParent).mStripAcesso.Visible = false;

                    ((Principal)this.MdiParent).mStripFuncionario.Visible = true;
                    ((Principal)this.MdiParent).subBuscaF.Visible = true;
                    ((Principal)this.MdiParent).subCadastroFunc.Visible = true;

                    ((Principal)this.MdiParent).mStripCliente.Visible = true;
                    ((Principal)this.MdiParent).subBuscaCliente.Visible = true;
                    ((Principal)this.MdiParent).subCadastroCliente.Visible = true;


                    ((Principal)this.MdiParent).mStripProd.Visible = true;
                    ((Principal)this.MdiParent).subBuscaProd.Visible = true;
                    ((Principal)this.MdiParent).subCadastroProd.Visible = true;

                    
                    ((Principal)this.MdiParent).mStripSair.Visible = true;

                }
                else if (dr.GetString(17) == "Estagiário")
                {
                    //privilégios de est/pósvenda
                    ((Principal)this.MdiParent).mStripAcesso.Visible = false;

                    ((Principal)this.MdiParent).mStripFuncionario.Visible = false;
                    ((Principal)this.MdiParent).subBuscaF.Visible = false;
                    ((Principal)this.MdiParent).subCadastroFunc.Visible = false;

                    ((Principal)this.MdiParent).mStripCliente.Visible = true;
                    ((Principal)this.MdiParent).subBuscaCliente.Visible = true;
                    ((Principal)this.MdiParent).subCadastroCliente.Visible = true;


                    ((Principal)this.MdiParent).mStripProd.Visible = true;
                    ((Principal)this.MdiParent).subBuscaProd.Visible = true;
                    ((Principal)this.MdiParent).subCadastroProd.Visible = false;

                    
                    ((Principal)this.MdiParent).mStripSair.Visible = true;
                }

                con.Close();
                this.Close();

            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválido(s).");
                con.Close();
            }

            //-----------comentar bloco acima e descomentar o bloco abaixo pra teste sem banco de dados

            //if (txtUsuarioAcesso.Text == "gerente" && txtSenha.Text == "gerente123")
            //{
            //    ((Principal)this.MdiParent).mStripAcesso.Visible = false;

            //    ((Principal)this.MdiParent).mStripFuncionario.Visible = true;
            //    ((Principal)this.MdiParent).subBuscaF.Visible = true;
            //    ((Principal)this.MdiParent).subCadastroFunc.Visible = true;

            //    ((Principal)this.MdiParent).mStripCliente.Visible = true;
            //    ((Principal)this.MdiParent).subBuscaCliente.Visible = true;
            //    ((Principal)this.MdiParent).subCadastroCliente.Visible = true;


            //    ((Principal)this.MdiParent).mStripProd.Visible = true;
            //    ((Principal)this.MdiParent).subBuscaProd.Visible = true;
            //    ((Principal)this.MdiParent).subCadastroProd.Visible = true;

            //    ((Principal)this.MdiParent).mStripPedido.Visible = true;
            //    ((Principal)this.MdiParent).mStripSair.Visible = true;

            //    this.Close();

            //}
            //else if (txtUsuarioAcesso.Text == "vendedor" && txtSenha.Text == "vendedor123")
            //{

            //    ((Principal)this.MdiParent).mStripAcesso.Visible = false;

            //    ((Principal)this.MdiParent).mStripFuncionario.Visible = false;
            //    ((Principal)this.MdiParent).subBuscaF.Visible = false;
            //    ((Principal)this.MdiParent).subCadastroFunc.Visible = false;

            //    ((Principal)this.MdiParent).mStripCliente.Visible = true;
            //    ((Principal)this.MdiParent).subBuscaCliente.Visible = true;
            //    ((Principal)this.MdiParent).subCadastroCliente.Visible = true;


            //    ((Principal)this.MdiParent).mStripProd.Visible = true;
            //    ((Principal)this.MdiParent).subBuscaProd.Visible = true;
            //    ((Principal)this.MdiParent).subCadastroProd.Visible = false;

            //    ((Principal)this.MdiParent).mStripPedido.Visible = true;
            //    ((Principal)this.MdiParent).mStripSair.Visible = true;

            //}
            //else
            //{


            //    MessageBox.Show("USUÁRIO OU SENHA INVÁLIDOS");


            //}



        }
    }
}
