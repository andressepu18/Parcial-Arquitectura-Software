using CapaNegocio;
using Microsoft.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class ConexionSQLServer : IFuenteDeDatos
    {
        public SqlConnection conexion;

        public ConexionSQLServer()
        {
            // Cadena de conexión de ejemplo - ajustar según entorno
            this.conexion = new SqlConnection(@"Data Source=DESKTOP-2UJFAS2\SQLEXPRESS;Persist Security Info=True;User ID=sa;Password=erlangshen56;TrustServerCertificate=True;Initial Catalog=CentralRiesgo");
        }

        public int consultarPuntaje(string tipoDoc, string nroDoc)
        {
            int puntaje = 0;

            string select = string.Format("SELECT Puntaje FROM CentralRiesgo WHERE TipoDoc = '{0}' AND NroDoc = '{1}'", tipoDoc, nroDoc);

            conexion.Open();

            SqlCommand comando = new SqlCommand(select, conexion);

            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                // Asumimos que la columna Puntaje es la primera (0) o buscar por nombre
                puntaje = reader.GetInt32(0);
            }

            conexion.Close();

            return puntaje;
        }

    }
}
