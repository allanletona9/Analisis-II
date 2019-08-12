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
    public partial class frm_login : Form
    {
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
                    "VALUES('' ,(SELECT PK_idUsuario FROM tbl_usuarios WHERE Pk_idUsuario = '" + Txt_usuario.Text + "')" +
                    ",'Ingreso Al Sistema Administrativo' " +
                     ",'" + DateTime.Now.ToString("yyy/MM/dd") + "'" +
                     ",'" + DateTime.Now.ToString("hh:mm:ss") + "'" +
                     ",' '" +
                     ",'" + host + "'" +
                     ")"
                    , conexion.conectar());
                cmd.ExecuteNonQuery();

                cmd = new OdbcCommand("SELECT PK_id_tipo_usuario FROM tbl_usuarios WHERE PK_idUsuario='" + Txt_usuario.Text + "'"
              , conexion.conectar());
                OdbcDataReader reader1 = cmd.ExecuteReader();
                String nombre = "";

                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {

                        nombre = reader1.GetString(0);

                        if (nombre == "1")
                        {
                            cmd = new OdbcCommand("{ call procedimientoLoginAdministrador (?,?)}", conexion.conectar());
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usuario1", OdbcType.Text).Value = Txt_usuario.Text;
                            cmd.Parameters.Add("@contraseña", OdbcType.Text).Value = Txt_clave.Text;
                            frm_seleccionarEquipo seleccionar = new frm_seleccionarEquipo("Login", null,Txt_usuario.Text);
                            seleccionar.Show();
                            Hide();
                            Txt_usuario.Clear();
                            Txt_clave.Clear();

                        }
                        if (nombre == "2")
                        {
                            cmd = new OdbcCommand("{ call procedimientoLoginEntrenador (?,?)}", conexion.conectar());
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usuario1", OdbcType.Text).Value = Txt_usuario.Text;
                            cmd.Parameters.Add("@contraseña", OdbcType.Text).Value = Txt_clave.Text;
                            frm_seleccionarEquipo seleccionar = new frm_seleccionarEquipo("Login", null, Txt_usuario.Text);
                            seleccionar.Show();
                            Hide();
                            Txt_usuario.Clear();
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
                        "VALUES('' ,(SELECT PK_idUsuario FROM tbl_usuarios WHERE Pk_idUsuario = '" + Txt_usuario.Text + "')" +
                        ",'Error al ingresar al sistema' " +
                         ",'" + DateTime.Now.ToString("yyy/MM/dd") + "'" +
                         ",'" + DateTime.Now.ToString("hh:mm:ss") + "'" +
                         ",' '" +
                         ",'" + host + "'" +
                         ")"
                        , conexion.conectar());
                    cmd.ExecuteNonQuery();
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

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\usuarios\\" + "ayudalogin.chm", "MDI.html");
        }
    }
}
