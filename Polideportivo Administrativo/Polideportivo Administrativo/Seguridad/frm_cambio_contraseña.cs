using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Autor Diego Gomez
namespace Polideportivo_Administrativo.Seguridad
{
    public partial class frm_cambio_contraseña : Form
    {
        conexion nueva = new conexion();
        OdbcCommand cmd;
        public frm_cambio_contraseña()
        {
            InitializeComponent();
        }

        private void frm_cambio_contraseña_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            //Autor Diego Gomez
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("select PK_idUsuario as Codigo,nombre_usuario as Nombre,password_usuario as Contraseña,estado_usuario as Estado from tbl_usuarios where estado_usuario=1", conexion.conectar());
                dat.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        void buscar1()
        {
            try
            {
                cmd = new OdbcCommand("SELECT * FROM Tbl_usuarios WHERE Pk_idUsuario = '" + Txt_codigo.Text + "'", conexion.conectar());
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
                    Txt_codigo.Text = columnas[0];
                    Txt_Usuario.Text = columnas[2];
                    Txt_estado.Text = columnas[1];
                }

                else
                {
                    if (Txt_contraseña.Text == "")
                    {
                        MessageBox.Show("Contraseña No Ingresada");
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

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            buscar1();
        }
        //Autor Diego Gomez
        void actualizar()
        {

            OdbcDataAdapter dat;
            DataSet ds;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("select PK_idUsuario as Codigo,nombre_usuario as Nombre,password_usuario as Contraseña,estado_usuario as Estado from tbl_usuarios where estado_usuario=1", conexion.conectar());
                dat.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        //Autor Diego Gomez
        private void Btn_guardar_Click(object sender, EventArgs e)
        {

            if ((Txt_contraseña.Text == ""))
            {
                MessageBox.Show("Contraseña No Ingresada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmd = new OdbcCommand("UPDATE Tbl_usuarios SET password_usuario ='" + Txt_contraseña.Text + "' where Pk_idUsuario = '" + Txt_codigo.Text + "'", conexion.conectar());
                cmd.ExecuteNonQuery();
                actualizar();
                MessageBox.Show("Contraseña Actualizada");
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
