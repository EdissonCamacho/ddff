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
    public partial class frmEmpresa : Form
    {

        public frmEmpresa()
        {
            InitializeComponent();
        }

        List<clEmpresa> listEmpresa;
        clEmpresa objEmpresa;

        private void frmListarEmpresa_Load(object sender, EventArgs e)
        {
            mtdCargar();
        }
        public void mtdCargarDatos()
        {

            objEmpresa.nombre = txtNombreE.Text;
            objEmpresa.direccion = txtDireccion.Text;
            objEmpresa.telefono = txtTelefono.Text;
            objEmpresa.sector = cmbSector.Text;


        }
        private void mtdCargar()
        {
            listEmpresa = new List<clEmpresa>();
            objEmpresa = new clEmpresa();
            listEmpresa = objEmpresa.mtdConsultaEmpresa();
            dgvListarEmpresa.DataSource = listEmpresa;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            mtdCargarDatos();
            
            int filasAfectadas = objEmpresa.mtdRegistrar();
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Empresa REGISTRADA", "Empresa", MessageBoxButtons.OK);

                mtdCargar();

            }
            else
            {
                MessageBox.Show("Error, no se puedo registrar", "Empresa", MessageBoxButtons.OK);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {

            mtdCargarDatos();

            int contador = 0;
            for (int i = 0; i < listEmpresa.Count; i++)
            {
                if (listEmpresa[i].nombre == txtNombreE.Text && listEmpresa[i].direccion == txtDireccion.Text && listEmpresa[i].telefono == txtTelefono.Text && listEmpresa[i].sector == cmbSector.Text)
                {
                    MessageBox.Show("empresa ya REGISTRADA");
                    contador = contador + 1;
                }
            }
            if (contador == 0)
            {
                int filasAfectadas = objEmpresa.mtdActualizar();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Se actualizo correctamente");
                    mtdCargar();
                   
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
        }
        int idEmpresaBorrar = 0;
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            objEmpresa = new clEmpresa();
            objEmpresa.idEmpresa = idEmpresaBorrar;

            if (objEmpresa.mtdEliminar() > 0)
            {
                MessageBox.Show("Empresa ELIMINADA");
                mtdCargar();

            }
            else
            {
                MessageBox.Show("Error, fallo al eliminar la EMPRESA");
            }
        }
        private void dgvListarEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListarEmpresa.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvListarEmpresa.CurrentRow.Selected = true;
                idEmpresaBorrar = int.Parse(dgvListarEmpresa.Rows[e.RowIndex].Cells["idempresa"].FormattedValue.ToString());
                txtNombreE.Text = dgvListarEmpresa.Rows[e.RowIndex].Cells["nombre"].FormattedValue.ToString();
                txtDireccion.Text = dgvListarEmpresa.Rows[e.RowIndex].Cells["direccion"].FormattedValue.ToString();
                txtTelefono.Text = dgvListarEmpresa.Rows[e.RowIndex].Cells["telefono"].FormattedValue.ToString();
                cmbSector.Text = dgvListarEmpresa.Rows[e.RowIndex].Cells["sector"].FormattedValue.ToString();
            }
        }
    }
    
}
