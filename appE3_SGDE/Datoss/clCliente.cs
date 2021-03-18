using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using appE3_SGDE.Datoss;


namespace appE3_SGDE.Datoss
{
    class clCliente
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string nombreEmpresa { get; set; }

        public List<clCliente> mtdListarCliente()
        {
            string consulta = "select* from cliente";

            clConexion objConexion = new clConexion();
            DataTable tblClientes = new DataTable();
            objConexion.mtdDesconectado(consulta);
            tblClientes = objConexion.mtdDesconectado(consulta);

            List<clCliente> listaClientes = new List<clCliente>();
            for (int i = 0; i < tblClientes.Rows.Count; i++)
            {
                clCliente objPasarProfesion = new clCliente();
                objPasarProfesion.idCliente = int.Parse(tblClientes.Rows[i]["idCliente"].ToString());
                objPasarProfesion.nombre = tblClientes.Rows[i]["nombre"].ToString();
                objPasarProfesion.apellido = tblClientes.Rows[i]["apellido"].ToString();
                objPasarProfesion.direccion = tblClientes.Rows[i]["direccion"].ToString();
                objPasarProfesion.telefono = tblClientes.Rows[i]["telefono"].ToString();
                objPasarProfesion.email = tblClientes.Rows[i]["email"].ToString();
                objPasarProfesion.nombreEmpresa = tblClientes.Rows[i]["nombreEmpresa"].ToString();

                listaClientes.Add(objPasarProfesion);
            }

            return listaClientes;
        }
        public void mtdFiltrarClientes()
        {
            string consultaFiltrar = "select* from ";
        }

        public int mtdRegistrar()
        {
            string consultaInsert = "insert into cliente(nombre,apellido,direccion,telefono,email,nombreEmpresa)values" +
                "('" + nombre + "','" + apellido + "','" + direccion + "','" + telefono + "','" + email + "','" + nombreEmpresa + "')";
            clConexion objConexion = new clConexion();
            int registrosAfectados = objConexion.mtdConectado(consultaInsert);
            return registrosAfectados;
        }
        public int mtdEliminar()
        {
            clConexion objConexion = new clConexion();
            string consulta = "delete from cliente where nombre='" + nombre + "'and apellido='" + apellido + "'and direccion='" + direccion + "'and telefono='" + telefono + "'and email='" + email + "'and nombreEmpresa='" + nombreEmpresa + "'";
            int eliminar = objConexion.mtdConectado(consulta);
            return eliminar;
        }
        }
    }

