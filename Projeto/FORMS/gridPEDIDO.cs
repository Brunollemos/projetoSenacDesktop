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
    public partial class gridPEDIDO : Form
    {
        public gridPEDIDO()
        {
            InitializeComponent();
        }

        private void GridPEDIDO_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnBuscaPedidoGrid_Click(object sender, EventArgs e)
        {

        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
