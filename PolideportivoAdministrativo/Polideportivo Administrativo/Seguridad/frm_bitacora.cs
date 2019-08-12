using System;
using System.Collections.Generic;
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

// Autor Diego Gomez;
namespace Polideportivo_Administrativo.Seguridad
{
    public partial class frm_bitacora : Form
    {
        conexion nueva = new conexion();
        OdbcCommand cmd;
        public frm_bitacora()
        {
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_bitacora_Load(object sender, EventArgs e)
        {
            //autor Diego Gomez
            OdbcDataAdapter dat;
            DataSet ds;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idbitacora as Id,PK_idUsuario as Id_Usuario, accion as Accion,fecha as Fecha, Hora as Hora, host as Host FROM `tbl_bitacora`", nueva.conectar());
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
