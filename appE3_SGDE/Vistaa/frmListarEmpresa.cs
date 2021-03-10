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
    public partial class frmListarEmpresa : Form
    {

        public frmListarEmpresa()
        {
            InitializeComponent();
        }

        private void frmListarEmpresa_Load(object sender, EventArgs e)
        {
            clEmpresa objEmpresa = new clEmpresa();
            List<clEmpresa> listaEmpresa = new List<clEmpresa>();
            listaEmpresa = objEmpresa.mtdListarEmpresa();
            dgvListarEmpresa.DataSource = listaEmpresa;
        }
    }
}
