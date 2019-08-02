using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//ALEJANDRO BARREDA MENDOZA
    /// <summary>
    /// CREACION DE CLASE BITACORA:
    /// ESTA CLASE ES UNICAMENTE CREADA PARA INSERTAR ACCIONES HECHAS POR EL USUARIO ACTUAL A LA TABLA DE BITACORAS
    /// DE LA BASE DE DATOS,LA FUNCION CrearBitacoraMantenimientos SE LLAMARÁ DESDE CUALQUIER PARTE DEL PROYECTO PARA INGRESARLE LOS
    /// DATOS CORRESPONDIENTES DE TAL FORMA QUE PARA DARLE DATOS A LA FUNCION SE HIZO 2 VARIABLES PUBLICAS PARA LA IP Y USUARIO
    /// AL MOMENTO DE INGRESAR SE TOMAN ESTOS DATOS PARA LAS BITACORAS, LA FUNCION SE LLAMA Y SE LE AGREGA LA ACCION QUE HIZO EL USUARIO
    /// 
    /// Codigo_usuario: 1 Para Administrador, 2 Para Entrenador.
    /// 
    /// Nombre_Usuario: Ingresado por el Usuario si y solo si el usuario ingresado Existe en la BD.
    /// 
    /// Accion: Actividad que realiza el Usuario que agregue, elimine, modifique o altere la Base de Datos, esto incluye hacer un informe.
    /// 
    /// IP: La Direccion de red asignada a la terminal desde donde el usuario realizó una acción.
    /// 
    /// CrearBitacoraMantenimientos(Codigo_Usuario, Nombre_Usuario, "Accion realizada por usuario", IP del usuario);
    ///
    /// </summary>
namespace Polideportivo_Administrativo
{
    class Bitacora
    {
 
            public static void CrearBitacoraMantenimiento(String codigo_usuario, String nombre_usuario, String accion, String host)
            {
                try
                {
                    conexion nueva = new conexion();
                    OdbcCommand cmd;
                    cmd = new OdbcCommand(" INSERT tbl_bitacora SET codigo_usuario='"
                                    + codigo_usuario + "', nombre_usuario='"
                                    + nombre_usuario + "', accion='"
                                    + accion + "', host='"
                                    + host + "', hora='"
                                    + DateTime.Now.ToString("hh:mm:ss") + "',fecha='"
                                    + DateTime.Now.ToString("yyy/MM/dd") + "'", nueva.conectar());
                    cmd.ExecuteNonQuery();
                nueva.cerrarConexion();
                }

                catch (OdbcException ex)
                {

                }

            }
        }
}



