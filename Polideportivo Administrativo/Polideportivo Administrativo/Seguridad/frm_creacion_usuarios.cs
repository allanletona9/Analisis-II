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
                OdbcCommand sql = new OdbcCommand("Select Pk_id_tipo_usuario,nombre as Nombre  from tbl_tipo_usuario", conexion.conectar());
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
            string valor = Convert.ToString(puesto.Text);
            string idPuesto = "";

            if (valor == "Administrador")
            {
                idPuesto = "1";

            }
            else if (valor == "Entrenador")
            {
                idPuesto = "2";
            }

            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("select max(PK_idUsuario) +1 as Cont from tbl_usuarios", conexion.conectar());
                dat.Fill(ds);

                string cont;

                cont = Convert.ToString(ds.Tables[0].Columns["Cont"]); //Convert.ToString(ds.Tables[0].Rows[0]);

                idPuesto = "2";
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }

        }
    }
}
