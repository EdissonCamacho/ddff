using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
        public string Clave { get; set; }
        public int  mtdRegistrar { get; set; }
       

        clSocio objSocio;
        private readonly List<clSocio> mtdRegistrar1;

        public List<clSocio> GetmtdRegistrar()
        {
            return mtdRegistrar1;
        }

        internal int mtdConectado(string consulta)
           
        {
            throw new NotImplementedException();
        }

         
    }
     public int mtdRegistrar()
    {
        string Nombre = null;
        string Apellido = null;
        string Direccion = null;
        string Clave = null;
        string Telefono = null;
        string Email = null;
        string consulta = "insert into socio (Nombre,Apellido,Direccion,Telefono,email,Clave) values ('" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Telefono + "','" + Email + "','" + Clave + "')";
        clSocio objConexion = new clSocio();
        int resultado = objConexion.mtdConectado(consulta);
        return resultado;

    }

    public int mtdActualizar()
    {

        string Nombre = null;
        string Direccion = null;
        string Email = null;
        string consulta = "update Socio set documento='" + Nombre + "',Apellido'" + Direccion + "', Telefono'" + Email + "',Clave'";
        clSocio objConexion = new clSocio();
        int filasAfectadas = objConexion.mtdConectado(consulta);
        return filasAfectadas;
    }
}

    
