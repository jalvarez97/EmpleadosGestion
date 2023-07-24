using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace EmpleadosGestion
{
    public class ConexionBBDD
    {
       
        public ConexionBBDD() { }

        public SqlConnection Conexion()
        {
            string servidor = "185.253.153.20,54321";
            string bd = "JavierAlvarezEmployees";
            string usuario = "sa";
            string password = "123456789";

            string cadenaConexion = "Data Source=" + servidor + "; Initial Catalog =" + bd + "; User Id= " + usuario + "; Password=" + password + "";

            try
            {
                SqlConnection conexionBD = new SqlConnection(cadenaConexion);

                return conexionBD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }
      
    }
}
