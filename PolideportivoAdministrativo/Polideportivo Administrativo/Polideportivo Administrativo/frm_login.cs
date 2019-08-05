//Validacion de datos ingresados por el usuario, realizando la consulta a la base de datos polideportivo//
//Con los campos ingresados usuario y contraseña

//Autor Diego Gomez

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

namespace Polideportivo_Administrativo
{
    public partial class frm_login : Form
    {

        //===Parte para bitacoras, editada por Alejandro Barreda:==============================
        public static String nombre_usuarioparabitacora;
        public static String codigo_usuarioparabitacora;
        //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
        public static string host = Dns.GetHostName();
        public static IPAddress[] IP = Dns.GetHostAddresses(host);
        //-------------------------------------------------------------------------

       //Fin Edicion de Alejandro Barreda
    // ==========================================================================================
          
        //Autor Diego Gomez
        conexion nueva = new conexion();
        public frm_login()
        {
            InitializeComponent();
            Txt_clave.UseSystemPasswordChar = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            //Autor: Diego Gomez
            conexion nueva = new conexion();
            OdbcCommand cmd;
            string User = this.Txt_Usuario.Text;
            string Password = this.Txt_clave.Text;
            if (User == "" || Password == "")
            {
                MessageBox.Show("Ingrese Usuario y Contraseña", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Txt_Usuario.Focus();
                return;
            }

            else
            {
                string host = Dns.GetHostName();
                IPAddress[] IP = Dns.GetHostAddresses(host);
                cmd = new OdbcCommand("INSERT INTO tbl_bitacora (PK_idBitacora," +
                    "PK_idUsuario, " +
                    "accion, " +
                    "fecha, " +
                    "hora, " +
                    "tabla," +
                    "host) " +
                    "VALUES('' ,(SELECT PK_idUsuario FROM tbl_usuarios WHERE Pk_idUsuario = '" + Txt_Usuario.Text + "')" +
                    ",'Ingreso Al Sistema Administrativo' " +
                     ",'" + DateTime.Now.ToString("yyy/MM/dd") + "'" +
                     ",'" + DateTime.Now.ToString("hh:mm:ss") + "'" +
                     ",' '" +
                     ",'"+ host + "'" +
                     ")"
                    , nueva.conectar());
                cmd.ExecuteNonQuery();

                    cmd = new OdbcCommand("SELECT PK_id_tipo_usuario FROM tbl_usuarios WHERE PK_idUsuario='" + Txt_Usuario.Text + "'"
                  , nueva.conectar());
                    OdbcDataReader reader1 = cmd.ExecuteReader();
                    String nombre = "";

                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {

                            nombre = reader1.GetString(0);

                            if (nombre == "1")
                            {
                                cmd = new OdbcCommand("{ call procedimientoLoginAdministrador (?,?)}", nueva.conectar());
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@usuario1", OdbcType.Text).Value = Txt_Usuario.Text;
                                cmd.Parameters.Add("@contraseña", OdbcType.Text).Value = Txt_clave.Text;
                                var f = new MDIPolideportivo_admin(Txt_Usuario.Text, nombre);
                                f.Show();
                                this.Hide();
                            //BITACORA===================================================
                            nombre_usuarioparabitacora = Txt_Usuario.Text;
                            codigo_usuarioparabitacora = reader1.GetString(0);
                              //=========================================================
                            Txt_Usuario.Clear();
                                Txt_clave.Clear();
                        }
                            if (nombre == "2")
                            {
                                cmd = new OdbcCommand("{ call procedimientoLoginEntrenador (?,?)}", nueva.conectar());
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add("@usuario1", OdbcType.Text).Value = Txt_Usuario.Text;
                                cmd.Parameters.Add("@contraseña", OdbcType.Text).Value = Txt_clave.Text;
                                var f = new MDIPolideportivo_admin(Txt_Usuario.Text, nombre);
                                f.Show();
                                this.Hide();
                            //BITACORA===================================================
                            nombre_usuarioparabitacora = Txt_Usuario.Text;
                            codigo_usuarioparabitacora = reader1.GetString(0);
                            //============================================================
                            Txt_Usuario.Clear();
                                Txt_clave.Clear();

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña equivocados,Vuelva a Intentar");
                        cmd = new OdbcCommand("INSERT INTO tbl_bitacora (PK_idBitacora," +
                            "PK_idUsuario, " +
                            "accion, " +
                            "fecha, " +
                            "hora, " +
                            "tabla," +
                            "host) " +
                            "VALUES('' ,(SELECT PK_idUsuario FROM tbl_usuarios WHERE Pk_idUsuario = '" + Txt_Usuario.Text + "')" +
                            ",'Error al ingresar al sistema' " +
                             ",'" + DateTime.Now.ToString("yyy/MM/dd") + "'" +
                             ",'" + DateTime.Now.ToString("hh:mm:ss") + "'" +
                             ",' '" +
                             ",'" + host + "'" +
                             ")"
                            , nueva.conectar());
                        cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    Txt_Usuario.Clear();
                        Txt_clave.Clear();

                    }
                }
            
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void Cb_ver_password_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ver_password.Checked == true)
            {
               Txt_clave.UseSystemPasswordChar = false;
            }
            else
            {
                Txt_clave.UseSystemPasswordChar = true;
            }
        }

        private void Txt_clave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
