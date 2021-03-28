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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }
        
        List<clProducto> listProductos;
        clProducto objProducto;

        private void frmProducto_Load(object sender, EventArgs e)
        {
            //mtdCargar();
        }

        /*
public void mtdCargarDatos()
{
   objProducto.nombreProducto = txtProducto.Text;
   objProducto.valorAproximado = int.Parse(txtValorAprox.Text);
   objProducto.descripcion = txtDescripcion.Text;
   objProducto.idEmpresa = int.Parse(txtEmpresa.Text);

}
public void mtdCargar()
{
   listProductos = new List<clProducto>();
   objProducto = new clProducto();
   listProductos = objProducto.mtdConsultaProducto();
   dgvListarProducto.DataSource = listProductos;
}
// FALTA POR TERMINAR 
*/

    }
    
}
