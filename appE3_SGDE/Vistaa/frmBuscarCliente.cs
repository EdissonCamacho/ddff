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
using appE3_SGDE.Vistaa;

namespace appE3_SGDE.Vistaa
{
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmBuscarCliente objBuscarCliente = new frmBuscarCliente();
            this.Close();
            frmMenu objMenu = new frmMenu();
            objMenu.mtdAbrirFormHijo(new frmClientes());
            objMenu.Show();

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
                clCliente objCliente = new clCliente();
                objCliente.telefono = txtFiltrarDocumento.Text;
                DataTable tblDatos = new DataTable();
                tblDatos = objCliente.mtdBuscar();
                dgvFiltrarDocumento.DataSource = tblDatos;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFiltrarDocumento.Text = "";
        }
    }
}
