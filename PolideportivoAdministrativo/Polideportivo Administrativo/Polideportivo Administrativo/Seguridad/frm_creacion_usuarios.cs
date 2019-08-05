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

        }

        private void frm_creacion_usuarios_Load(object sender, EventArgs e)
        {
            llenarComboBoxPuesto();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.Rdb_activo.Checked==true)
            {


                cmd = new OdbcCommand("INSERT INTO tbl_usuarios (PK_idUsuario,PK_id_tipo_usuario,password_usuario,estado_usuario)" +
                    " VALUES " +
                    "('"+Txt_Usuario.Text+ "',(SELECT PK_id_tipo_usuario FROM tbl_tipo_usuario WHERE nombre = '"+puesto.Text+"') " +
                    ", MD5('"+Txt_contraseña +"'),'1')"
                    , nueva.conectar());
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                MessageBox.Show("Usuario Creado");
                //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                Bitacora.CrearBitacoraMantenimiento(frm_login.codigo_usuarioparabitacora, "Creó Nuevo Usuario Con estado: Activo", "tbl_usuarios", frm_login.IP[2].ToString());


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
    }
}
