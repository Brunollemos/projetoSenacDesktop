using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    class Pessoa
    {

        public string nome { get; set; }
        public int cpf { get; set; }
        public string rg { get; set; }
        public string genero { get; set; }
        public string email { get; set; }
        public decimal celular { get; set; }
        public string rua { get; set; }
        public string bairro { get; set; }
        public decimal numeroCasa { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public  int cep { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string _nome, int _cpf, string _rg, string _genero, string _email, decimal _celular, string _rua, string _bairro, decimal _numeroCasa, string _cidade, string _estado, int _cep)
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

    }

}
