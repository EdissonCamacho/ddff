using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appE3_SGDE.Datoss
{
    class clProducto
    {

        public int idEmpresaProducto { get; set; }
        public int valorAproximado { get; set; }
        public int idEmpresa { get; set; }
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public string descripcion { get; set; }


        public List<clProducto> mtdConsultaProducto()
        {
            string consulta = "select * from producto join epresaproducto";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            List<clProducto> listProducto = new List<clProducto>();
            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                clProducto objProducto = new clProducto();
                objProducto.idEmpresaProducto = int.Parse(tblDatos.Rows[i]["idEmpresaProducto"].ToString());
                objProducto.valorAproximado = int.Parse(tblDatos.Rows[i]["valorAproximado"].ToString());
                objProducto.idEmpresa = int.Parse(tblDatos.Rows[i]["idEmpresa"].ToString());
                objProducto.idProducto = int.Parse(tblDatos.Rows[i]["idProducto"].ToString());
                objProducto.nombreProducto = tblDatos.Rows[i]["nombreProducto"].ToString();
                objProducto.descripcion = tblDatos.Rows[i]["descripcion"].ToString();


                listProducto.Add(objProducto);

            }

            return listProducto;
        }

        // FALTA POR CORREGIR 
        public DataTable mtdVisualizar()
        {
            string consulta = "select * from producto ";
            clConexion objConexion = new clConexion();
            DataTable tblDatos = new DataTable();
            tblDatos = objConexion.mtdDesconectado(consulta);
            return tblDatos;
        }
        public int mtdRegistrar()
        {

            string consulta = "insert into empresaproducto(valorAproximado,idEmpresa,idProducto) " +
                "values ('" + valorAproximado + "','" + idEmpresa + "','" + idProducto + "')";
            clConexion objConexion = new clConexion();
            int Datos = objConexion.mtdConectado(consulta);
            return Datos;

        }

        public int mtdActualizar()
        {
            string consulta = "update empresaproducto set valorAproximado='" + valorAproximado + "',idEmpresa= '" + idEmpresa +
                "', idProducto='" + idProducto + "' where valorAproximado='" + valorAproximado + "'";
            clConexion objConexion = new clConexion();
            int filasAfectadas = objConexion.mtdConectado(consulta);
            return filasAfectadas;
        }
        public int mtdEliminar()
        {

            string consulta = "delete from empresaproducto where idEmpresaProducto = " + idEmpresaProducto;
            clConexion objConexion = new clConexion();
            int eliminar = objConexion.mtdConectado(consulta);
            return eliminar;

        }

    }
}
