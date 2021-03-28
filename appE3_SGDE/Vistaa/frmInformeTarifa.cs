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
using System.IO;
using Microsoft.Reporting.WinForms;

namespace appE3_SGDE.Vistaa
{
    public partial class frmInformeTarifa : Form
    {
        public frmInformeTarifa()
        {
            InitializeComponent();
        }

        private void frmInformeTarifa_Load(object sender, EventArgs e)
        {

            this.reportDatos.RefreshReport();
        }
        public void mtdCargarInforme(List<clTarifa> listTarifa)
        {
            string ruta = Directory.GetCurrentDirectory() + "\\Informes\\reporteTarifa.rdlc";
            reportDatos.LocalReport.ReportPath = ruta;
            reportDatos.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", listTarifa));
        }

    }
}
