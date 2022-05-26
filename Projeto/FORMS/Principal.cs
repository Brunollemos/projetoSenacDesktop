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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void desativarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void filtrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //this.ControlBox = false;
        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(cadastro_funcionario))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new cadastro_funcionario();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void BuscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(gridFUNCIONARIO))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new gridFUNCIONARIO();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void ProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(gridPEDIDO))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new gridPEDIDO();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();

        }     


        private void PedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CLIENTE))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new CLIENTE();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void BuscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(gridCliente))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new gridCliente();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();

        }

        private void CadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PRODUTO))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new PRODUTO();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();

        }

        private void BuscarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(gridPRODUTO))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new gridPRODUTO();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();

        }


        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mStripFuncionario.Visible = false;
            this.Close();
        }

        private void AcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ACESSO))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new ACESSO();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            



            
        }
    }
}
