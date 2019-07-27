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
    public partial class frm_usuarios : Form
    {
        conexion nueva = new conexion();
        public frm_usuarios()
        {
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            //Autor Diego Gomez
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("select PK_idUsuario as Codigo,nombre_usuario as Nombre,estado_usuario as Estado from tbl_usuarios where estado_usuario=1", conexion.conectar());
                dat.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
