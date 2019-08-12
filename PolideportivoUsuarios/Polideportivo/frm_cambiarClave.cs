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
//Autor: Eduardo Colon

namespace Polideportivo
{
    public partial class frm_cambiarClave : Form
    {
        //Autor Diego Gomez
        conexion nueva = new conexion();
        OdbcCommand cmd;
        String usuario;
        public frm_cambiarClave(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void CambiarClave_Load(object sender, EventArgs e)
        {
            buscar1();
        }

        //Autor Diego Gomez
        void actualizar()
        {

            //Autor Diego Gomez
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("select PK_idUsuario as Nombre,password_usuario as Contraseña from tbl_usuarios where Pk_idUsuario='" + usuario + "'", conexion.conectar());
                dat.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        //Autor Diego Gomez
        void buscar1()
        {
            try
            {
                cmd = new OdbcCommand("SELECT * FROM Tbl_usuarios WHERE Pk_idUsuario = '" + usuario + "'", conexion.conectar());
                OdbcDataReader reader = cmd.ExecuteReader();
                String[] columnas = new string[6];
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        columnas[0] = reader.GetString(0);
                        columnas[1] = reader.GetString(1);
                        columnas[2] = reader.GetString(2);
                        columnas[3] = reader.GetString(3);
                    }
       
                    Txt_Usuario.Text = columnas[0];
                    Txt_estado.Text = columnas[3];
                }

                else
                {
                    if (Txt_contraseña.Text == "")
                    {
                       
                    }
                    else
                    {
                        MessageBox.Show("Usuario no Encontrado");
                    }

                }
                reader.Close();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Pnl_Buscar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

            if ((Txt_contraseña.Text == ""))
            {
               
            }
            else
            {
                //Autor Diego Gomez
                cmd = new OdbcCommand("UPDATE Tbl_usuarios SET password_usuario = MD5('" + Txt_contraseña.Text + "') where Pk_idUsuario = '" + usuario + "'", conexion.conectar());
                cmd.ExecuteNonQuery();
                actualizar();
                MessageBox.Show("Contraseña Actualizada");

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
                    ",'Cambio de Contraseña' " +
                     ",'" + DateTime.Now.ToString("yyy/MM/dd") + "'" +
                     ",'" + DateTime.Now.ToString("hh:mm:ss") + "'" +
                     ",' '" +
                     ",'" + host + "'" +
                     ")"
                    , conexion.conectar());
                cmd.ExecuteNonQuery();
            }
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            //Autor Diego Gomez
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("select PK_idUsuario as Nombre,password_usuario as Contraseña from tbl_usuarios where Pk_idUsuario='"+ usuario + "'", conexion.conectar());
                dat.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            buscar1();
        }

        private void Lbl_codigoEntrenador_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_deportespro_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\usuarios\\" + "ayudacambiocontrasena.chm", "CambiarClave.html");
        }
    }
}
