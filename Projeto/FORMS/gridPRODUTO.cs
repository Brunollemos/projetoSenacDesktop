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
    public partial class gridPRODUTO : Form
    {
        public gridPRODUTO()
        {
            InitializeComponent();
        }

        private void GridPRODUTO_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;




        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          








        }

        private void btnBuscaProdutoGrid_Click(object sender, EventArgs e)
        {

            string sql = System.Configuration.ConfigurationManager.ConnectionStrings["ProjetoPIonline"].ToString();

            SqlConnection con = new SqlConnection(sql);
            SqlDataAdapter adapt = new SqlDataAdapter("ps_Produto_grid " + txtBuscaProdutoGrid.Text, con);

            

            DataSet ds = new DataSet();

            con.Open();
            adapt.Fill(ds, "Produto");
            con.Close();

            dgvProduto.DataSource = ds;
            dgvProduto.DataMember = "Produto";     



        }
    }
}
