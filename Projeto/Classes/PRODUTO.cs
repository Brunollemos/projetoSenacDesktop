using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Classes
{
    class PRODUTO
    {
        
        public string nomeProduto { get; set; }
        public string categoriaProduto { get; set; }
        public decimal preçoProduto { get; set; }
        public int estoqueProduto { get; set; }
        public string descProduto { get; set; }
        public string plataformaProduto { get; set; }
        public int idproduto { get; set; }

        string sql = System.Configuration.ConfigurationManager.ConnectionStrings["ProjetoPIonline"].ToString();

        public PRODUTO()
        {

        }
        public PRODUTO(string _nomeProduto,string _categoriaProduto,decimal _preçoProduto,int _estoqueProduto,string _descProduto,string _plataformaProduto)
        {
            this.nomeProduto = _nomeProduto;
            this.categoriaProduto = _categoriaProduto;
            this.preçoProduto = _preçoProduto;
            this.estoqueProduto = _estoqueProduto;
            this.descProduto = _descProduto;
            this.plataformaProduto = _plataformaProduto;

        }
        public PRODUTO(int _idproduto)
        {

            this.idproduto = _idproduto;
        }
        public void cadastrarProduto()
        {
            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "pi_Produto";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("nomeProduto", this.nomeProduto);
            cmd.Parameters.AddWithValue("categoriaProduto", this.categoriaProduto);
            cmd.Parameters.AddWithValue("preçoProduto", this.preçoProduto);
            cmd.Parameters.AddWithValue("estoqueProduto", this.estoqueProduto);
            cmd.Parameters.AddWithValue("descProduto", this.descProduto);
            cmd.Parameters.AddWithValue("plataformaProduto", this.plataformaProduto);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void atualizarProduto()
        {

            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "up_Produto";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("nomeProduto", this.nomeProduto);
            cmd.Parameters.AddWithValue("categoriaProduto", this.categoriaProduto);
            cmd.Parameters.AddWithValue("preçoProduto", this.preçoProduto);
            cmd.Parameters.AddWithValue("estoqueProduto", this.estoqueProduto);
            cmd.Parameters.AddWithValue("descProduto", this.descProduto);
            cmd.Parameters.AddWithValue("plataformaProduto", this.plataformaProduto);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public bool buscarProduto(int _idProduto)
        {

            SqlConnection con = new SqlConnection(sql);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.Parameters.AddWithValue("idProduto", _idProduto);

            cmd.Connection = con;
            cmd.CommandText = "ps_Produto";
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                dr.Read();
                this.nomeProduto = dr.GetString(1);
                this.categoriaProduto = dr.GetString(2);
                this.preçoProduto = dr.GetDecimal(3);
                this.estoqueProduto = dr.GetInt32(4);
                this.descProduto = dr.GetString(5);
                this.plataformaProduto = dr.GetString(6);

                con.Close();
                return true;

            }
            else
            {
                con.Close();
                return false;

            }
            

        }
       
    }
}
