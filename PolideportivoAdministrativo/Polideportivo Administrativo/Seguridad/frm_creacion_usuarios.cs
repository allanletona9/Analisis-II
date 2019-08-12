using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Net;
using System.Net.NetworkInformation;

namespace Polideportivo_Administrativo.Seguridad
{
    public partial class frm_creacion_usuarios : Form
    {
        conexion nueva = new conexion();
        OdbcCommand cmd;
        public frm_creacion_usuarios()
        {
            InitializeComponent();
        }

        private void Lbl_nombreEntrenador_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {

        }

        private void Gpb_estado_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void llenarComboBoxPuesto()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre from tbl_tipo_usuario", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();


                while (almacena.Read() == true)

                {
                    puesto.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

        private void puesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Cbo_entrenadores.DataSource = null;
            Cbo_entrenadores.Items.Clear();
            Cbo_entrenadores.Text = " ";

            try
                {
                    string sPuesto = puesto.SelectedItem.ToString();
                    if (sPuesto == "Entrenador")
                    {
                        OdbcCommand sql = new OdbcCommand("SELECT CONCAT(E.nombre_entrenador,' ',E.apellido_entrenador) AS nombre FROM tbl_entrenadores E LEFT JOIN tbl_asignacion_usuario_entrenador AUE ON E.PK_idEntrenador = AUE.FK_idEntrenador WHERE AUE.FK_idEntrenador IS NULL;", nueva.conectar());
                        OdbcDataReader almacena = sql.ExecuteReader();


                        while (almacena.Read() == true)

                        {
                            Cbo_entrenadores.Items.Add(almacena.GetValue(0));
                        }
                        almacena.Close();
                    }
                    else
                    {
                        OdbcCommand sql = new OdbcCommand("SELECT CONCAT(E.nombre_empleado,' ',E.apellido_empleado) AS nombre FROM tbl_empleados E LEFT JOIN tbl_asignacion_usuario_empleado AUE ON E.PK_idEmpleado = AUE.FK_idEmpleado WHERE AUE.FK_idEmpleado IS NULL;", nueva.conectar());
                        OdbcDataReader almacena = sql.ExecuteReader();


                        while (almacena.Read() == true)

                        {
                            Cbo_entrenadores.Items.Add(almacena.GetValue(0));
                        }
                        almacena.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void frm_creacion_usuarios_Load(object sender, EventArgs e)
        {
            llenarComboBoxPuesto();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.Rdb_activo.Checked==true)
            {

                try
                {
                    cmd = new OdbcCommand("INSERT INTO tbl_usuarios (PK_idUsuario,PK_id_tipo_usuario,password_usuario,estado_usuario)" +
                       " VALUES " +
                       "('" + Txt_Usuario.Text + "',(SELECT PK_id_tipo_usuario FROM tbl_tipo_usuario WHERE nombre = '" + puesto.Text + "') " +
                       ", MD5('" + Txt_contraseña + "'),'1')"
                       , nueva.conectar());
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();


                    string sPuesto = puesto.SelectedItem.ToString();
                    if (sPuesto == "Entrenador")
                    {
                        string sCodigoEntrenador = "";
                        try
                        {

                            string sNombreEntrenador = Cbo_entrenadores.SelectedItem.ToString();

                            OdbcCommand sql1 = new OdbcCommand("SELECT PK_idEntrenador FROM tbl_entrenadores WHERE CONCAT(nombre_entrenador,' ', apellido_entrenador) = '" + sNombreEntrenador + "'", nueva.conectar());
                            OdbcDataReader almacena = sql1.ExecuteReader();


                            while (almacena.Read() == true)
                            {
                                sCodigoEntrenador = almacena.GetString(0);
                            }
                            almacena.Close();
                            sql1.Connection.Close();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                        OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_asignacion_usuario_entrenador(PK_idUsuario, FK_idEntrenador) VALUES ('" + Txt_Usuario.Text + "','" + sCodigoEntrenador + "')", nueva.conectar());
                        sql.ExecuteNonQuery();
                        sql.Connection.Close();
                    }
                    else
                    {
                        string sCodigoEmpleado = "";
                        try
                        {

                            string sNombreEmpleado = Cbo_entrenadores.SelectedItem.ToString();

                            OdbcCommand sql1 = new OdbcCommand("SELECT PK_idEmpleado FROM tbl_empleados WHERE CONCAT(nombre_empleado,' ', apellido_empleado) = '" + sNombreEmpleado + "'", nueva.conectar());
                            OdbcDataReader almacena = sql1.ExecuteReader();


                            while (almacena.Read() == true)
                            {
                                sCodigoEmpleado = almacena.GetString(0);
                            }
                            almacena.Close();
                            sql1.Connection.Close();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                        OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_asignacion_usuario_empleado(PK_idUsuario, FK_idEmpleado) VALUES ('" + Txt_Usuario.Text + "','" + sCodigoEmpleado + "')", nueva.conectar());
                        sql.ExecuteNonQuery();
                        sql.Connection.Close();
                    }
                    

                    MessageBox.Show("Usuario Creado");
                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.codigo_usuarioparabitacora, "Creó Nuevo Usuario Con estado: Activo", "tbl_usuarios", frm_login.IP[2].ToString());


                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error"+ex);
                }
               

            }
            else if (this.Rdb_inactivo.Checked==true)
            {
                cmd = new OdbcCommand("INSERT INTO tbl_usuarios (PK_idUsuario,PK_id_tipo_usuario,password_usuario,estado_usuario)" +
                    " VALUES " +
                    "('" + Txt_Usuario.Text + "',(SELECT PK_id_tipo_usuario FROM tbl_tipo_usuario WHERE nombre = '" + puesto.Text + "') " +
                    ", MD5('" + Txt_contraseña + "'),'0')"
                    , nueva.conectar());
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                Bitacora.CrearBitacoraMantenimiento(frm_login.codigo_usuarioparabitacora, "Creó Nuevo Usuario Con estado: Inactivo", "tbl_usuarios", frm_login.IP[2].ToString());


            }


            else
            {
                MessageBox.Show("Ingrese Todos Los Campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\" + "ayudacreacionusuarios.chm", "creacion_usuarios.html");
        }
    }
}
