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

        public clConexion()
        {
            try
            {
                objConexion = new MySqlConnection("server=localhost; user id=root;Port=3306;database=domiciliosbd;Password=2142457");
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
    }
}
