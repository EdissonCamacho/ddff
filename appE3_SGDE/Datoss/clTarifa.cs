using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appE3_SGDE.Datoss
{
    class clTarifa
    {
        public int idTarifa { get; set; }
        public string nombreSector { get; set; }
        public string desde { get; set; }
        public string hasta { get; set; }
        public string descripcion { get; set; }
        public int valor { get; set; }


        public List<clTarifa> mtdConsultaTarifa()
        {

            string consulta = "select * from tarifa";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            List<clTarifa> listTarifa = new List<clTarifa>();
            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                clTarifa objTarifa = new clTarifa();
                objTarifa.idTarifa = int.Parse(tblDatos.Rows[i]["idTarifa"].ToString());
                objTarifa.nombreSector = tblDatos.Rows[i]["nombreSector"].ToString();
                objTarifa.desde = tblDatos.Rows[i]["desde"].ToString();
                objTarifa.hasta = tblDatos.Rows[i]["hasta"].ToString();
                objTarifa.descripcion = tblDatos.Rows[i]["descripcion"].ToString();
                objTarifa.valor = int.Parse(tblDatos.Rows[i]["valor"].ToString());


                listTarifa.Add(objTarifa);

            }

            return listTarifa;
        }
        public DataTable mtdVisualizar()
        {
            string consulta = "select * from tarifa";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            return tblDatos;
        }
        public int mtdRegistrar()
        {

            string consulta = "insert into tarifa(nombresector,desde,hasta,descripcion,valor) " +
                "values ('" + nombreSector + "','" + desde + "','" + hasta + "','" + descripcion + "'," +
                "" + valor + ")";

            clConexion objConexion = new clConexion();
            int Datos = objConexion.mtdConectado(consulta);
            return Datos;
        }
        public int mtdActualizar()
        {
            string consulta = "update tarifa set nombreSector='" + nombreSector + "',desde= '" + desde +
                "', hasta='" + hasta + "', descripcion='" + descripcion + "', valor='" + valor + "'";

            clConexion objConexion = new clConexion();
            int filasAfectadas = objConexion.mtdConectado(consulta);
            return filasAfectadas;
        }
        public int mtdEliminar()
        {

            string consulta = "delete from tarifa where idTarifa = " + idTarifa;
            clConexion objConexion = new clConexion();
            int eliminar = objConexion.mtdConectado(consulta);
            return eliminar;

        }
    }

}

