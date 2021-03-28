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
    public partial class frmSocio : Form
    {
        public frmSocio()
        {
            InitializeComponent();
        }
        List<clSocio> listSocio;
        clSocio objSocio;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            mtdCargarDatos();

            int filasAfectadas = objSocio.mtdIngresar();
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Socio Registrado", "SGDE", MessageBoxButtons.OK);

                mtdCargar();

            }

            else
            {
                MessageBox.Show("Error al registrar", "SGDE", MessageBoxButtons.OK);
            }


        }






        public void mtdCargarDatos()
        {
            objSocio.Nombre = txtNombre.Text;
            objSocio.Apellido = txtApellido.Text;
            objSocio.Direccion = txtDireccion.Text;
            objSocio.Telefono = txtTelefono.Text;
            objSocio.Email = txtEmail.Text;
            objSocio.Clave = txtClave.Text;

        }

        private void mtdCargar()
        {
            listSocio = new List<clSocio>();
            objSocio = new clSocio();
            listSocio = objSocio.mtdConsultaSocio();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            mtdCargarDatos();

            int Contador = 0;
            for (int i = 0; i < listSocio.Count; i++)
            {
                if (listSocio[i].Nombre == txtNombre.Text && listSocio[i].Apellido == txtApellido.Text && listSocio[i].Direccion == txtDireccion.Text && listSocio[i].Telefono == txtTelefono.Text && listSocio[i].Email == txtEmail.Text && listSocio[i].Clave == txtClave.Text)
                {
                    MessageBox.Show("Socio Registrado");
                    Contador = Contador + 1;
                }

            }

            if (Contador == 0)
            {
                int filasAfectadas = objSocio.mtdActualizar();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Actualizado correctamente");
                    mtdCargar();

                }

                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
        }

        int idSocioBorrar = 0;

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objSocio = new clSocio();
            objSocio.idSocio = idSocioBorrar;

            if (objSocio.mtdEliminar() > 0)
            {
                MessageBox.Show("Socio Eliminado");
                mtdCargar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar socio");
            }

        }


    }
}
