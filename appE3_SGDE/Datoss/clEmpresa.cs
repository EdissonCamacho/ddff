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
        public string sector { get; set; }

        public List<clEmpresa> mtdConsultaEmpresa()
        {

            string consulta = "select * from empresa";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            List<clEmpresa> listEmpresa = new List<clEmpresa>();
            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                clEmpresa objEmpresa = new clEmpresa();
                objEmpresa.idEmpresa = int.Parse(tblDatos.Rows[i]["idEmpresa"].ToString());
                objEmpresa.nombre = tblDatos.Rows[i]["nombre"].ToString();
                objEmpresa.direccion = tblDatos.Rows[i]["direccion"].ToString();
                objEmpresa.telefono = tblDatos.Rows[i]["telefono"].ToString();
                objEmpresa.sector = tblDatos.Rows[i]["sector"].ToString();

                listEmpresa.Add(objEmpresa);

            }

            return listEmpresa;
        }
        public DataTable mtdVisualizar()
        {
            string consulta = "select * from empresa";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            return tblDatos;
        }
        public int mtdRegistrar()
        {

            string consulta = "insert into empresa(nombre,direccion,telefono,sector) " +
                "values ('" + nombre + "','" + direccion + "','" + telefono + "','" + sector + "')";
            clConexion objConexion = new clConexion();
            int Datos = objConexion.mtdConectado(consulta);
            return Datos;


        }
        public int mtdActualizar()
        {
            string consulta = "update empresa set nombre='" + nombre + "',direccion= '" + direccion + 
                "', telefono='" + telefono + "', sector='"+ sector + "' where nombre='" + nombre + "'";
            clConexion objConexion = new clConexion();
            int filasAfectadas = objConexion.mtdConectado(consulta);
            return filasAfectadas;
        }
        public int mtdEliminar()
        {

            string consulta = "delete from empresa where idEmpresa = " + idEmpresa;
            clConexion objConexion = new clConexion();
            int eliminar = objConexion.mtdConectado(consulta);
            return eliminar;

        }


    }
}
