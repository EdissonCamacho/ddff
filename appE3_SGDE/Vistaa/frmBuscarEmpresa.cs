using appE3_SGDE.Datoss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appE3_SGDE.Vistaa
{
    public partial class frmBuscarEmpresa : Form
    {
        public frmBuscarEmpresa()
        {
            InitializeComponent();
        }

        private void frmBuscarEmpresa_Load(object sender, EventArgs e)
        {
            clEmpresa objEmpresa = new clEmpresa();
            DataTable resultado = new DataTable();
            resultado = objEmpresa.mtdConsultarSectores();
            cmbBuscar.DataSource = resultado;
            cmbBuscar.DisplayMember = "sector";

        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmBuscarEmpresa objBuscarEmpresa = new frmBuscarEmpresa();
            this.Close();
            frmMenu objMenu = new frmMenu();
            objMenu.mtdAbrirFormHijo(new frmEmpresa());
            objMenu.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clEmpresa objEmpresa = new clEmpresa();
            objEmpresa.sector = cmbBuscar.Text;
            DataTable tblDatos = new DataTable();
            tblDatos = objEmpresa.mtdBuscar();


            dgvBuscar.DataSource = tblDatos;
        }
    }
}
