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
    public partial class frm_deportes : Form
    {
        conexion nueva = new conexion();
        public frm_deportes()
        {
            //Autor: ALEJANDRO BARREDA
            InitializeComponent();
        }

        private void frm_deportes_Load(object sender, EventArgs e)
        {
            llenarGridEquipos();
        }

        void llenarGridEquipos()
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idDeporte AS Codigo, nombre_deporte AS Nombre, descripcion_deporte AS Descripcion FROM tbl_deportes WHERE estado_deporte=1", nueva.conectar());
                dat.Fill(ds);
                Dgv_deportes.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarDeporte_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminDeportescs adminDeportes = new frm_adminDeportescs();
            adminDeportes.Show();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idDeporte AS Codigo, nombre_deporte AS Nombre, descripcion_Deporte AS Descripcion FROM tbl_deportes WHERE PK_idDeporte='" + Txt_buscar.Text + "' OR nombre_deporte = '" + Txt_buscar.Text + "'", nueva.conectar());
                dat.Fill(ds);
                Dgv_deportes.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            frm_adminDeportescs adminDeportes = new frm_adminDeportescs();

         
            adminDeportes.Txt_codigoDeporte.Text = Convert.ToString(Dgv_deportes.CurrentRow.Cells[0].Value);
            adminDeportes.Txt_nombreDeporte.Text = Convert.ToString(Dgv_deportes.CurrentRow.Cells[1].Value);
            adminDeportes.Txt_descripcionDeporte.Text = Convert.ToString(Dgv_deportes.CurrentRow.Cells[2].Value);
            this.Close();
            adminDeportes.Txt_nombreDeporte.Enabled = false;
            adminDeportes.Txt_descripcionDeporte.Enabled = false;
            adminDeportes.Gpb_estado.Enabled = false;
            adminDeportes.Show();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            llenarGridEquipos();
        }

        private void btn_salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
