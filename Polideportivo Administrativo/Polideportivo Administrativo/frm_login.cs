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
                    "VALUES('' ,(SELECT PK_idUsuario FROM tbl_usuarios WHERE nombre_usuario = '" + Txt_Usuario.Text + "')" +
                    ",'Ingreso Al Sistema Administrativo' " +
                     ",'" + DateTime.Now.ToString("yyy/MM/dd") + "'" +
                     ",'" + DateTime.Now.ToString("hh:mm:ss")  + "'" +
                     ",' '" +
                     ",' '" +
                     ")"
                    , conexion.conectar());
                cmd.ExecuteNonQuery();


                cmd = new OdbcCommand("{ call procedimientoLoginAdministrador (?,?)}", conexion.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usuario1", OdbcType.Text).Value = Txt_Usuario.Text;
                cmd.Parameters.Add("@contraseña", OdbcType.Text).Value = Txt_clave.Text;

                /*cmd = new OdbcCommand("select PK_id_tipo_usuario FROM tbl_usuarios where nombre_usuario LIKE '%" + Txt_Usuario.Text
                    + "%' AND password_usuario LIKE '%" + Txt_clave.Text + "%'"
                    , conexion.conectar());*/

                OdbcDataReader reader = cmd.ExecuteReader();
                String nombre = "";

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        nombre = reader.GetString(0);

                        if (nombre == "1")
                        {

                            var f = new MDIPolideportivo_admin(Txt_Usuario.Text, nombre);
                            f.Show();
                            this.Hide();
                            Txt_Usuario.Clear();
                            Txt_clave.Clear();

                        }
                        if (nombre == "2")
                        {
                            var f = new MDIPolideportivo_admin(Txt_Usuario.Text, nombre);
                            f.Show();
                            this.Hide();
                            Txt_Usuario.Clear();
                            Txt_clave.Clear();
                        }
                        if (nombre == "3")
                        {
                            var f = new MDIPolideportivo_admin(Txt_Usuario.Text, nombre);
                            f.Show();
                            this.Hide();
                            Txt_Usuario.Clear();
                            Txt_clave.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña equivocados,Vuelva a Intentar");
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
