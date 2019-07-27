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
using Polideportivo_Administrativo;

//Autor: Allan letona

namespace Polideportivo
{
    public partial class Login : Form
    {
        //Autor Diego Gomez
        conexion nueva = new conexion();
        public Login()
        {
            InitializeComponent();
            Txt_clave.UseSystemPasswordChar = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Autor: Diego Gomez
            conexion nueva = new conexion();
            OdbcCommand cmd;
            string User = this.Txt_usuario.Text;
            string Password = this.Txt_clave.Text;
            if (User == "" || Password == "")
            {
                MessageBox.Show("Ingrese Usuario y Contraseña", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Txt_usuario.Focus();
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
                    "VALUES('' ,(SELECT PK_idUsuario FROM tbl_usuarios WHERE nombre_usuario = '" + Txt_usuario.Text + "')" +
                    ",'Ingreso Al Sistema De Usuario' " +
                     ",'" + DateTime.Now.ToString("yyy/MM/dd") + "'" +
                     ",'" + DateTime.Now.ToString("hh:mm:ss") + "'" +
                     ",' '" +
                     ",' '" +
                     ")"
                    , conexion.conectar());
                cmd.ExecuteNonQuery();

                cmd = new OdbcCommand("select PK_id_tipo_usuario FROM tbl_usuarios where nombre_usuario LIKE '%" + Txt_usuario.Text
                    + "%' AND password_usuario LIKE '%" + Txt_clave.Text + "%'"
                    , conexion.conectar());


                OdbcDataReader reader = cmd.ExecuteReader();
                String nombre = "";

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        nombre = reader.GetString(0);

                        if (nombre == "1")
                        {

                            SeleccionarEquipo seleccionar = new SeleccionarEquipo("Login", null);
                            seleccionar.Show();
                            Hide();
                            Txt_usuario.Clear();
                            Txt_clave.Clear();

                        }
                        if (nombre == "2")
                        {
                            SeleccionarEquipo seleccionar = new SeleccionarEquipo("Login", null);
                            seleccionar.Show();
                            Hide();
                            Txt_usuario.Clear();
                            Txt_clave.Clear();
                        }
                        if (nombre == "3")
                        {
                            SeleccionarEquipo seleccionar = new SeleccionarEquipo("Login", null);
                            seleccionar.Show();
                            Hide();
                            Txt_usuario.Clear();
                            Txt_clave.Clear();
                        }
                    }
                }
                else
                {

                    cmd = new OdbcCommand("INSERT INTO tbl_bitacora (PK_idBitacora," +
                        "PK_idUsuario, " +
                        "accion, " +
                        "fecha, " +
                        "hora, " +
                        "tabla," +
                        "host) " +
                        "VALUES('' ,(SELECT PK_idUsuario FROM tbl_usuarios WHERE nombre_usuario = '" + Txt_usuario.Text + "')" +
                        ",'Intento Fallido Logueo Usuarios' " +
                         ",'" + DateTime.Now.ToString("yyy/MM/dd") + "'" +
                         ",'" + DateTime.Now.ToString("hh:mm:ss") + "'" +
                         ",' '" +
                         ",' '" +
                         ")"
                        , conexion.conectar());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario o Contraseña equivocados,Vuelva a Intentar");
                    Txt_usuario.Clear();
                    Txt_clave.Clear();
                }
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Cb_ver_password_CheckedChanged(object sender, EventArgs e)
        {
            if(Cb_ver_password.Checked == false)
            {
                Txt_clave.UseSystemPasswordChar = true;
            }
            else
            {
               Txt_clave.UseSystemPasswordChar = false;
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
