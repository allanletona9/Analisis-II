using System.Data.Odbc;

namespace Polideportivo_Administrativo
{
    class conexion
    {
        public static OdbcConnection conectar()
        {
            OdbcConnection conexion = new OdbcConnection("Dsn=polideportivo");
            conexion.Open();
            return conexion;
        }

        public static OdbcConnection cerrarConexion()
        {
            OdbcConnection conexion = new OdbcConnection("Dsn=polideportivo");
            conexion.Close();
            return conexion;
        }
    }
}
