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
using appE3_SGDE.Vistaa;

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

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            mtdCargar();
        }
        public void mtdCargarDatos()
        {

            objEmpresa.nombre = txtNombreE.Text;
            objEmpresa.direccion = txtDireccion.Text;
            objEmpresa.telefono = txtTelefono.Text;
            objEmpresa.sector = cmbSector.Text;
            if (rbAbierto.Checked == true)
            {
                objEmpresa.estado = "Abierto";
            }
            else
            {
                objEmpresa.estado = "Cerrado";
            }


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
                MessageBox.Show("Empresa Registrada", "SGDE", MessageBoxButtons.OK);

                mtdCargar();

            }
            else
            {
                MessageBox.Show("Error Al Registrar", "SGDE", MessageBoxButtons.OK);
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
                    MessageBox.Show("Empresa Registrada");
                    contador = contador + 1;
                }
            }
            if (contador == 0)
            {
                int filasAfectadas = objEmpresa.mtdActualizar();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Se Actualizo Correctamente");
                    mtdCargar();

                }
                else
                {
                    MessageBox.Show("Error Al Actualizar");
                }
            }


        }
        int idEmpresaBorrar = 0;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objEmpresa = new clEmpresa();
            objEmpresa.idEmpresa = idEmpresaBorrar;

            if (objEmpresa.mtdEliminar() > 0)
            {
                MessageBox.Show("Empresa Eliminada");
                mtdCargar();

            }
            else
            {
                MessageBox.Show("Error, no se pudo eliminar la empresa");
            }

        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            frmBuscarEmpresa objBuscarEmpresa = new frmBuscarEmpresa();
            objBuscarEmpresa.ShowDialog();
        }

        private void dgvListarEmpresa_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListarEmpresa.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvListarEmpresa.CurrentRow.Selected = true;
                idEmpresaBorrar = int.Parse(dgvListarEmpresa.Rows[e.RowIndex].Cells["idempresa"].FormattedValue.ToString());
                txtNombreE.Text = dgvListarEmpresa.Rows[e.RowIndex].Cells["nombre"].FormattedValue.ToString();
                txtDireccion.Text = dgvListarEmpresa.Rows[e.RowIndex].Cells["direccion"].FormattedValue.ToString();
                txtTelefono.Text = dgvListarEmpresa.Rows[e.RowIndex].Cells["telefono"].FormattedValue.ToString();
                cmbSector.Text = dgvListarEmpresa.Rows[e.RowIndex].Cells["sector"].FormattedValue.ToString();
                txtHorario.Text = dgvListarEmpresa.Rows[e.RowIndex].Cells["horaAtencion"].FormattedValue.ToString();
                string estado = dgvListarEmpresa.Rows[e.RowIndex].Cells["estado"].FormattedValue.ToString();
                if (estado == "Abierto")
                {
                    rbAbierto.Checked = true;
                }
                else
                {
                    rbCerrado.Checked = true;
                }

            }
        }
    }
}
