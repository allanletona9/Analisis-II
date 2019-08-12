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
/// Codigo_usuario: Es la ID del Usuario 1 Para Administrador, 2 Para Entrenador.
/// 
/// Accion: Actividad que realiza el Usuario que agregue, elimine, modifique o altere la Base de Datos, esto incluye hacer un informe.
/// 
/// IP: La Direccion de red asignada a la terminal desde donde el usuario realizó una acción.
/// 
/// CrearBitacoraMantenimiento(String codigo_usuario, String accion, String tabla, String host)
///
/// </summary>
namespace Polideportivo_Administrativo
{
    class Bitacora
    {
 
            public static void CrearBitacoraMantenimiento(String codigo_usuario, String accion, String tabla, String host)
            {
                try
                {
                    conexion nueva = new conexion();
                    OdbcCommand cmd;
                    cmd = new OdbcCommand(" INSERT INTO tbl_bitacora(PK_idUsuario, accion, fecha, hora,tabla,host) VALUES('"+codigo_usuario + "', '"+ accion + "', '"+ DateTime.Now.ToString("yyyy-MM-dd") + "', '"+ DateTime.Now.ToString("hh:mm:ss") + "', '"+tabla +"', '"+host +   "')", nueva.conectar());
                    cmd.ExecuteNonQuery();
                }

                catch (OdbcException ex)
                {

                }

            }
        }
}



