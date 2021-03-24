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
    public partial class frmTarifa : Form
    {
        public frmTarifa()
        {
            InitializeComponent();
        }

        List<clTarifa> listTarifa;
        clTarifa objTarifa;

        private void frmTarifa_Load(object sender, EventArgs e)
        {
            mtdCargar();
        }
        public void mtdCargarDatos()
        {

            objTarifa.nombreSector = txtNombre.Text;
            objTarifa.desde = txtDesde.Text;
            objTarifa.hasta = txtHasta.Text;
            objTarifa.descripcion = rtbDescripcion.Text;
            objTarifa.valor = int.Parse(txtValor.Text);
        }
        private void mtdCargar()
        {
            listTarifa = new List<clTarifa>();
            objTarifa = new clTarifa();
            listTarifa = objTarifa.mtdConsultaTarifa();
            dgvTarifa.DataSource = listTarifa;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            mtdCargarDatos();

            int filasAfectadas = objTarifa.mtdRegistrar();
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Tarifa Registrada", "SGDE", MessageBoxButtons.OK);

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
            for (int i = 0; i < listTarifa.Count; i++)
            {
                if (listTarifa[i].nombreSector == txtNombre.Text && listTarifa[i].desde == txtDesde.Text && listTarifa[i].hasta == txtHasta.Text && listTarifa[i].descripcion == rtbDescripcion.Text && listTarifa[i].valor == int.Parse(txtValor.Text))
                {
                    MessageBox.Show("Tarifa Registrada");
                    contador = contador + 1;
                }
            }
            if (contador == 0)
            {
                int filasAfectadas = objTarifa.mtdActualizar();
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
        int idTarifaBorrar = 0;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objTarifa = new clTarifa();
            objTarifa.idTarifa = idTarifaBorrar;

            if (objTarifa.mtdEliminar() > 0)
            {
                MessageBox.Show("Tarifa Eliminada");
                mtdCargar();

            }
            else
            {
                MessageBox.Show("Error, no se pudo eliminar la Tarifa");
            }

        }

        private void dgvTarifa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTarifa.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvTarifa.CurrentRow.Selected = true;
                idTarifaBorrar = int.Parse(dgvTarifa.Rows[e.RowIndex].Cells["idTarifa"].FormattedValue.ToString());
                txtNombre.Text = dgvTarifa.Rows[e.RowIndex].Cells["nombreSector"].FormattedValue.ToString();
                txtDesde.Text = dgvTarifa.Rows[e.RowIndex].Cells["desde"].FormattedValue.ToString();
                txtHasta.Text = dgvTarifa.Rows[e.RowIndex].Cells["hasta"].FormattedValue.ToString();
                rtbDescripcion.Text = dgvTarifa.Rows[e.RowIndex].Cells["descripcion"].FormattedValue.ToString();
                txtValor.Text = dgvTarifa.Rows[e.RowIndex].Cells["valor"].FormattedValue.ToString();
                

            }
        }
    }
}

