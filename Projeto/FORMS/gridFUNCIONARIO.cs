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
    public partial class gridFUNCIONARIO : Form
    {
        public gridFUNCIONARIO()
        {
            InitializeComponent();
        }

        private void GridFUNCIONARIO_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void DgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscaGridFunc_Click(object sender, EventArgs e)
        {




            string sql = System.Configuration.ConfigurationManager.ConnectionStrings["ProjetoPIonline"].ToString();

            SqlConnection con = new SqlConnection(sql);
            SqlDataAdapter adapt = new SqlDataAdapter("ps_Funcionario_grid " + txtBuscaGridFunc.Text, con);

            

            DataSet ds = new DataSet();

            con.Open();
            adapt.Fill(ds, "Funcionario");
            con.Close();

            dgvFuncionario.DataSource = ds;
            dgvFuncionario.DataMember = "Funcionario";



        }
    }
}
