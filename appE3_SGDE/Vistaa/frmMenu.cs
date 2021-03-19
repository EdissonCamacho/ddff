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
            mtdAbrirFormHijo(new frmBienvenida());
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes objListarClientes = new frmClientes();
            objListarClientes.Show();
        }

        private void listaDeEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa objListarEmpresa = new frmEmpresa();
            objListarEmpresa.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void mtdAbrirFormHijo(object formhijo)
        {
            if (this.PanelContenedor.Controls.Count>0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            mtdAbrirFormHijo(new frmEmpresa());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            mtdAbrirFormHijo(new frmClientes());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            mtdAbrirFormHijo(new frmBienvenida());
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            mtdAbrirFormHijo(new frmProducto());
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();

        }
    }
}
