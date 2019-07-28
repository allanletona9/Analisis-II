using System;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Net;
using Polideportivo_Administrativo;
using System.Data;

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

                try
                {
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

                }
                catch (OdbcException) {

                    MessageBox.Show("Error");
                }

                
       
                cmd = new OdbcCommand("{ call procedimientoLoginEntrenador (?,?)}", conexion.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usuario1", OdbcType.Text).Value = Txt_usuario.Text;
                cmd.Parameters.Add("@contraseña", OdbcType.Text).Value = Txt_clave.Text;

                OdbcDataReader reader = cmd.ExecuteReader();
                int sIdEntrenador;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        sIdEntrenador = reader.GetInt32(0);
                   
                            SeleccionarEquipo seleccionar = new SeleccionarEquipo("Login", sIdEntrenador.ToString(),  null);
                            seleccionar.Show();
                            Hide();
                            Txt_usuario.Clear();
                            Txt_clave.Clear();                
                    }
                }
                else
                {

                    try
                    {

                    }
                    catch (OdbcException)
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
