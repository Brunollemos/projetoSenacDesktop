using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto.Classes
{
    class CLIENTE : Pessoa
    {



        //string sql = System.Configuration.ConfigurationManager.ConnectionStrings["BANCOATT"].ToString();
        //string sql = System.Configuration.ConfigurationManager.ConnectionStrings["BIGINT"].ToString();
        string sql = System.Configuration.ConfigurationManager.ConnectionStrings["ProjetoPIonline"].ToString();


        public CLIENTE()
        {

        }

        public CLIENTE(string _nome, int _cpf, string _rua, string _email, decimal _celular, decimal _numeroCasa, string _bairro, string _cidade, string _genero, int _cep,string _rg ,string _estado)
        {

            this.nome = _nome;
            this.cpf = _cpf;
            this.rg = _rg;
            this.genero = _genero;
            this.email = _email;
            this.celular = _celular;
            this.rua = _rua;
            this.bairro = _bairro;
            this.numeroCasa = _numeroCasa;
            this.cidade = _cidade;
            this.estado = _estado;
            this.cep = _cep;


        }
        public void CadastrarCliente()
        {

            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "pi_Cliente";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("nomePessoa", this.nome);
            cmd.Parameters.AddWithValue("cpfPessoa", this.cpf);
            cmd.Parameters.AddWithValue("enderecoPessoa", this.rua);

            cmd.Parameters.AddWithValue("emailPessoa", this.email);
            cmd.Parameters.AddWithValue("celularPessoa", this.celular);
            cmd.Parameters.AddWithValue("numeroCasaPessoa", this.numeroCasa);
            cmd.Parameters.AddWithValue("bairroPessoa", this.bairro);

            cmd.Parameters.AddWithValue("cidadePessoa", this.cidade);
            cmd.Parameters.AddWithValue("generoPessoa", this.genero);
            cmd.Parameters.AddWithValue("cepPessoa", this.cep);
            cmd.Parameters.AddWithValue("rgPessoa", this.rg);
            cmd.Parameters.AddWithValue("estadoPessoa", this.estado);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }        
        public void Atualizarcliente()
        {


            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "up_Cliente";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("nomePessoa", this.nome);
            cmd.Parameters.AddWithValue("cpfPessoa", this.cpf);
            cmd.Parameters.AddWithValue("enderecoPessoa", this.rua);

            cmd.Parameters.AddWithValue("emailPessoa", this.email);
            cmd.Parameters.AddWithValue("celularPessoa", this.celular);
            cmd.Parameters.AddWithValue("numeroCasaPessoa", this.numeroCasa);
            cmd.Parameters.AddWithValue("bairroPessoa", this.bairro);

            cmd.Parameters.AddWithValue("cidadePessoa", this.cidade);
            cmd.Parameters.AddWithValue("generoPessoa", this.genero);
            cmd.Parameters.AddWithValue("cepPessoa", this.cep);
            cmd.Parameters.AddWithValue("rgPessoa", this.rg);
            cmd.Parameters.AddWithValue("estadoPessoa", this.estado);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public bool buscaCliente(int _cpf)
        {
         
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.Parameters.AddWithValue("cpfPessoa", _cpf);

            cmd.Connection = con;
            cmd.CommandText = "ps_Busca_Cliente";
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                dr.Read(); 

                this.nome = dr.GetString(1);
                this.cpf = dr.GetInt32(2);
                this.rg = dr.GetString(11);
                this.genero = dr.GetString(9);
                this.email = dr.GetString(4);
                this.celular = dr.GetDecimal(5);
                this.rua = dr.GetString(3);
                this.bairro = dr.GetString(7);
                this.numeroCasa = dr.GetInt32(6);
                this.cidade = dr.GetString(8);
                this.estado = dr.GetString(12);
                this.cep = dr.GetInt32(10);

                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }

        }
        public void CadastrarClienteSemAtributo(string _nome, Int64 _cpf, string _rg, string _genero, string _email, decimal _celular, string _rua, string _bairro, decimal _numeroCasa, string _cidade, string _estado, Int64 _cep)
        {

            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "pi_Cliente";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("nomePessoa", _nome);
            cmd.Parameters.AddWithValue("cpfPessoa", _cpf);
            cmd.Parameters.AddWithValue("rgPessoa", _rg);
            cmd.Parameters.AddWithValue("generoPessoa", _genero);

            cmd.Parameters.AddWithValue("emailPessoa", _email);
            cmd.Parameters.AddWithValue("celularPessoa", _celular);

            cmd.Parameters.AddWithValue("ruaPessoa", _rua);
            cmd.Parameters.AddWithValue("bairroPessoa", _bairro);
            cmd.Parameters.AddWithValue("numeroCasaPessoa", _numeroCasa);
            cmd.Parameters.AddWithValue("cidadePessoa", _cidade);
            cmd.Parameters.AddWithValue("estadoPessoa", _estado);
            cmd.Parameters.AddWithValue("cepPessoa", _cep);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }


    }
}
