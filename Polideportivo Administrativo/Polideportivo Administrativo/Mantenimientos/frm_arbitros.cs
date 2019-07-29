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

namespace Polideportivo_Administrativo.Mantenimientos
{
    public partial class frm_arbitros : Form
    {
        public frm_arbitros()
        {
            //Autor: Alejandro Barreda
            InitializeComponent();
            llenarGridArbitros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarArbitro_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminArbitros adminArbitros = new frm_adminArbitros();
            adminArbitros.Show();
            adminArbitros.Txt_nombreArbitro.Enabled = false;
            adminArbitros.Txt_codigoArbitro.Enabled = false;
            adminArbitros.Txt_apellidoArbitro.Enabled = false;
            adminArbitros.Cbo_deporte.Enabled = false;
            adminArbitros.Gpb_estado.Enabled = false;
        }

        private void frm_arbitros_Load(object sender, EventArgs e)
        {

        }

        void llenarGridArbitros()
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idArbitro AS Codigo, nombre_arbitro AS Nombre, apellido_arbitro as Apellido FROM tbl_arbitros WHERE estado_arbitro=1", conexion.conectar());
                dat.Fill(ds);
                Dgv_arbitros.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            frm_adminArbitros adminArbitros = new frm_adminArbitros();
            adminArbitros.Txt_codigoArbitro.Text = Convert.ToString(Dgv_arbitros.CurrentRow.Cells[0].Value);
            adminArbitros.Txt_nombreArbitro.Text = Convert.ToString(Dgv_arbitros.CurrentRow.Cells[1].Value);
            adminArbitros.Txt_apellidoArbitro.Text = Convert.ToString(Dgv_arbitros.CurrentRow.Cells[2].Value);
            this.Close();
            adminArbitros.Txt_codigoArbitro.Enabled = false;
            adminArbitros.Txt_nombreArbitro.Enabled = false;
            adminArbitros.Cbo_deporte.Enabled = false;
            adminArbitros.Txt_apellidoArbitro.Enabled = false;
            adminArbitros.Gpb_estado.Enabled = false;
            adminArbitros.Show();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            llenarGridArbitros();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            OdbcDataAdapter dat;
            DataSet ds;
        
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idArbitro AS Codigo, nombre_arbitro AS Nombre, apellido_arbitro as Apellido tbl_arbitro WHERE PK_idArbitro=" + Txt_buscar.Text , conexion.conectar());
                dat.Fill(ds);
                Dgv_arbitros.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Btn_salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
