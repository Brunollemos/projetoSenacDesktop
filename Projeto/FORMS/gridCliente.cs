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
    public partial class gridCliente : Form
    {
        public gridCliente()
        {
            InitializeComponent();
        }

        private void GridCliente_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnBuscarGridCliente_Click(object sender, EventArgs e)
        {
            string sql = System.Configuration.ConfigurationManager.ConnectionStrings["ProjetoPIonline"].ToString();

            SqlConnection con = new SqlConnection(sql);
            SqlDataAdapter adapt = new SqlDataAdapter("ps_Cliente_grid " + txtBuscaGridCliente.Text, con);



            DataSet ds = new DataSet();

            con.Open();
            adapt.Fill(ds, "Cliente");
            con.Close();

            dgvCliente.DataSource = ds;
            dgvCliente.DataMember = "Cliente";
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
