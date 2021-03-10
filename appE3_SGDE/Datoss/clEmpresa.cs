using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appE3_SGDE.Datoss
{
    class clEmpresa
    {
        public int idEmpresa { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public List<clEmpresa> mtdListarEmpresa()
        {
            string consulta = "select* from empresa";

            clConexion objConexion = new clConexion();
            DataTable tblEmpresa = new DataTable();
            objConexion.mtdDesconectado(consulta);
            tblEmpresa = objConexion.mtdDesconectado(consulta);

            List<clEmpresa> listaEmpresa = new List<clEmpresa>();
            for (int i = 0; i < tblEmpresa.Rows.Count; i++)
            {
                clEmpresa objEmpresa = new clEmpresa();
                objEmpresa.idEmpresa = int.Parse(tblEmpresa.Rows[i]["idEmpresa"].ToString());
                objEmpresa.nombre = tblEmpresa.Rows[i]["nombre"].ToString();
                objEmpresa.direccion = tblEmpresa.Rows[i]["direccion"].ToString();
                objEmpresa.telefono = tblEmpresa.Rows[i]["telefono"].ToString();

                listaEmpresa.Add(objEmpresa);

            }

            return listaEmpresa;
        }
    }
}
