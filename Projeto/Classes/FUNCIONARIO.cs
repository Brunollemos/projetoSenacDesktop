using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    class FUNCIONARIO : Pessoa
    {
               
        public string pis { get; set; }
        public string cargo { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public Principal MdiParent { get; private set; }

        
        string sql = System.Configuration.ConfigurationManager.ConnectionStrings["ProjetoPIonline"].ToString();

        public FUNCIONARIO()
        {

        }

        public FUNCIONARIO(string _nome, int _cpf, string _rua, string _email, decimal _celular, decimal _numeroCasa, string _bairro, string _cidade, string _genero, int _cep, string _rg, string _estado,string _cargo, string _pis, string _usuario, string _senha)
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
            //_________________________
            this.pis = _pis;
            this.cargo = _cargo;
            this.usuario = _usuario;
            this.senha = _senha;

        }
        public void cadastrarFuncionario()
        {

            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "pi_Funcionario_Desktop";
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

            cmd.Parameters.AddWithValue("funcaoFuncionario", this.cargo);
            cmd.Parameters.AddWithValue("pisFuncionario", this.pis);
            cmd.Parameters.AddWithValue("loginFuncionario", this.usuario);  
            cmd.Parameters.AddWithValue("senhaFuncionario", this.senha);            
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();                                

        }       
        public void atualizarfuncionario()
        {

            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "up_Funcionario";
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

            cmd.Parameters.AddWithValue("pisFuncionario", this.pis);
            cmd.Parameters.AddWithValue("loginFuncionario", this.usuario);
            cmd.Parameters.AddWithValue("senhaFuncionario", this.senha);
            cmd.Parameters.AddWithValue("funcaoFuncionario", this.cargo);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public bool buscaFuncionario(decimal _cpf)
        {
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.Parameters.AddWithValue("cpfPessoa", _cpf);

            cmd.Connection = con;
            cmd.CommandText = "ps_Busca_Funcionario";
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
                this.pis = dr.GetString(15);
                this.usuario = dr.GetString(16);
                this.senha = dr.GetString(17);
                this.cargo = dr.GetString(14);

                con.Close();
                return true;

            }
            else
            {
                
                con.Close();
                return false;

            }

        }       
        public void cadastrarFuncionarioSemAtributo(string _nome, decimal _cpf, string _rg, string _genero, string _email, decimal _celular, string _rua, string _bairro, decimal _numeroCasa, string _cidade, string _estado, decimal _cep, string _pis, string _cargo, string _usuario, string _senha)
        {

            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "pi_Funcionario";
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

            cmd.Parameters.AddWithValue("pisFuncionario", _pis);
            cmd.Parameters.AddWithValue("cargoFuncionario", _cargo);
            cmd.Parameters.AddWithValue("usuarioFuncionario", _usuario);
            cmd.Parameters.AddWithValue("senhaFuncionario", _senha);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

    }
}
