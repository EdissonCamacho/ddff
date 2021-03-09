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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="Administrador" & txtContraseña.Text=="sgde2021")
            {
                frmMenu objMenu = new frmMenu();
                objMenu.Show();
                frmLogin objLogin = new frmLogin();
                this.Hide();
                MessageBox.Show("!Bienvenido¡", "Sesión iniciada correctamente",MessageBoxButtons.OK);
            }
            else
            {
                if (txtUsuario.Text == "" & txtContraseña.Text == "")
                {
                    MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK);
                }
                MessageBox.Show("Datos invalidos", "Error al iniciar", MessageBoxButtons.OK);
            }
        }
    }
}
