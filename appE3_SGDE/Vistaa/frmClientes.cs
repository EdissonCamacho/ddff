using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appE3_SGDE.Datoss;

namespace appE3_SGDE.Vistaa
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmListarClientes_Load(object sender, EventArgs e)
        {
            clCliente objCliente = new clCliente();
            List<clCliente> listClientes = new List<clCliente>();
            listClientes = objCliente.mtdListarCliente();
            dgvListarClientes.DataSource = listClientes;
        }
    }
}
