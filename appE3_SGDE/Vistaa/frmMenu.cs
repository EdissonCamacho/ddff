using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appE3_SGDE.Vistaa;

namespace appE3_SGDE.Vistaa
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarClientes objListarClientes = new frmListarClientes();
            objListarClientes.Show();
        }

        private void listaDeEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarEmpresa objListarEmpresa = new frmListarEmpresa();
            objListarEmpresa.Show();
        }
    }
}
