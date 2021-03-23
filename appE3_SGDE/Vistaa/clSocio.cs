using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appE3_SGDE.Datoss;

namespace appE3_SGDE.Vistaa
{
    class clSocio
    {
        public int idSocio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Disponibilidad { get; set; }
        public string clave { get; set; }
        


    clConexion objConexion;
        public List<clSocio> mtdConsultaSocio
        {
            get; 
            {
              
            

            
             string consulta = "select * from area";
                objConexion = new clConexion();
                DataTable tblresultado = new DataTable();
                tblresultado = objConexion.mtdDesconectado(consulta);
                List<clSocio> listSocio = new List<clSocio>();
                for (int i = 0; i < tblresultado.Rows.Count; i++)
                {

                    clSocio objSocio = new clSocio();
                    objSocio.idSocio = int.Parse(tblresultado.Rows[i]["idSocio"].ToString());
                    objSocio.Nombre = tblresultado.Rows[i]["Nombre"].ToString();
                    objSocio.Apellido = tblresultado.Rows(tblresultado.Rows[i]["Apellido"].ToString());
                    objSocio.Direccion = tblresultado.Rows[i]["Direccion"].ToString();
                    objSocio.Telefono = tblresultado.Rows[i]["Telefono"].ToString();
                    objSocio.Email = tblresultado.Rows[i]["Email"].ToString();
                    objSocio.Disponibilidad = tblresultado.Rows[i]["Disponibilidad"].ToString();
                    objSocio.Clave = tblresultado.Rows[i]["Clave"].ToString();



                    listSocio.Add(objSocio);
                    {
                        return listSocio;
                    }
                    public int mtdIngresar();

                    {
                        string consulta = "insert into Socio (Socio,Nombre,Apellido,Direccion,Telefono,Email,Disponibilidad,Clave) values ('" + Socio + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Telefono + "','" + Email + "','" + Disponibilidad + "','" + Clave + ";)";
                        objConexion = new clConexion();
                        int resultado = objConexion.mtdConectado(consulta);
                        return resultado;
                    }
                    public int mtdActualizar();
                    {
                        string consulta = "update Socio set Socio='" + Socio + "',Nombre = '" + Nombre + "', Apellido ='" + Direccion + "' where area='" + Socio +  "'";
                        objConexion = new clConexion();
                        int filasAfectadas = objConexion.mtdConectado(consulta);
                        return filasAfectadas;
                    }

                  public int mtdEliminar();

                    {
                        string consulta = "delete from area where area = '" + area + "'and sueldo='" + sueldo + "'and descripcion= '" + descripcion + "'";
                        objConexion = new clConexion();
                        int eliminado = objConexion.mtdConectado(consulta);
                        return eliminado;





                    }
                }
            }
        }
    }
}