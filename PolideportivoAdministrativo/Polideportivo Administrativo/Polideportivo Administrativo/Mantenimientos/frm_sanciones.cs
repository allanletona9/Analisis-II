using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Polideportivo_Administrativo.Mantenimientos
{
    public partial class frm_sanciones : Form
    {
        conexion nueva = new conexion();
        public frm_sanciones()
        {
            //Autor: Allan Letona
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarSancion_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminSanciones adminSanciones = new frm_adminSanciones();
            adminSanciones.Show();
            adminSanciones.Btn_eliminar.Enabled = false;
            adminSanciones.Btn_modificar.Enabled = false;
            adminSanciones.Gpb_estado.Enabled = false;
        }

        private void frm_sanciones_Load(object sender, EventArgs e)
        {
            llenarGridSanciones();
        }

        void llenarGridSanciones()
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idSancion AS Codigo, nombre_sancion AS Nombre, descripcion_sancion AS Descripcion FROM tbl_sanciones WHERE estado_sancion=1", nueva.conectar());
                dat.Fill(ds);
                Dgv_sanciones.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }


        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idSancion AS Codigo, nombre_sancion AS Nombre, descripcion_sancion AS Descripcion FROM tbl_sanciones WHERE PK_idSancion='" + Txt_buscar.Text + "' OR nombre_sancion = '" + Txt_buscar.Text + "'", nueva.conectar());
                dat.Fill(ds);
                Dgv_sanciones.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            frm_adminSanciones adminSanciones = new frm_adminSanciones();

            /* Codigo por si hay un combo box en el siguiente formulario
            OdbcCommand sql = new OdbcCommand("Select nombre_sucursal from sucursal where Codigo_sucursal='" + Convert.ToInt16(TablaBodega.CurrentRow.Cells[4].Value) + "'", nueva.nuevaConexion());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                adminEquipos.cmbCodigoSucursal.Text = almacena.GetString(0);
            }
            almacena.Close();
            */
            adminSanciones.Txt_codigoSancion.Text = Convert.ToString(Dgv_sanciones.CurrentRow.Cells[0].Value);
            adminSanciones.Txt_nombreSancion.Text = Convert.ToString(Dgv_sanciones.CurrentRow.Cells[1].Value);
            adminSanciones.Txt_descripcionSancion.Text = Convert.ToString(Dgv_sanciones.CurrentRow.Cells[2].Value);
            this.Close();
            adminSanciones.Txt_codigoSancion.Enabled = false;
            adminSanciones.Txt_nombreSancion.Enabled = false;
            adminSanciones.Txt_descripcionSancion.Enabled = false;
            adminSanciones.Gpb_estado.Enabled = false;
            adminSanciones.Show();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            llenarGridSanciones();
        }

        private void Btn_salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
