using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace appE3_SGDE.Datoss
{
    class clConexion
    {
        MySqlConnection objConexion = null;

        //Recordar para cada prueba de ejecucion, digitar la contraseña correspondiente a su base de datos

        public clConexion()
        {
            try
            {
                objConexion = new MySqlConnection("server=localhost; user id=root;Port=3306;database=dbdomicilio;Password=3134281540");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }
        }
        public DataTable mtdDesconectado(string consulta)
        {
            objConexion.Open();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, objConexion);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            objConexion.Close();
            return tblDatos;
        }

        public int mtdConectado(string consulta)
        {
            objConexion.Open();
            MySqlCommand comando = new MySqlCommand(consulta, objConexion);
            int filasAfectadas = comando.ExecuteNonQuery();
            objConexion.Close();
            return filasAfectadas;
        }
    }
}
