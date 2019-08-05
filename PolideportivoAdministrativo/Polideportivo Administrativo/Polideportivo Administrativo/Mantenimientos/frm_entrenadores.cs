using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Polideportivo_Administrativo.Mantenimientos
{
    public partial class frm_entrenadores : Form
    {
        conexion nueva = new conexion();
        public frm_entrenadores()
        {
            //Autor: Eduardo Colon
            InitializeComponent();
            llenarGridEntrenadores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarEntrenador_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminEntrenadores adminEntrenadores = new frm_adminEntrenadores();
            adminEntrenadores.Show();
            adminEntrenadores.Txt_apellidoEntrenador.Enabled = false;
            adminEntrenadores.Txt_codigoEntrenador.Enabled = false;
            adminEntrenadores.Txt_especialidadEntrenador.Enabled = false;
            adminEntrenadores.Txt_nombreEntrenador.Enabled = false;
            adminEntrenadores.Cbo_equipo.Enabled = false;
            adminEntrenadores.Gpb_estado.Enabled = false;
        }

        void llenarGridEntrenadores()
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idEntrenador AS Codigo, nombre_entrenador AS Nombre, apellido_entrenador as Apellido, especialidad_entrenador as Especialidad FROM tbl_entrenadores WHERE estado_entrenador=1", nueva.conectar());
                dat.Fill(ds);
                Dgv_entrenadores.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }


        private void frm_entrenadores_Load(object sender, EventArgs e)
        {

        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            frm_adminEntrenadores adminEntrenadores = new frm_adminEntrenadores();
            adminEntrenadores.Txt_codigoEntrenador.Text = Convert.ToString(Dgv_entrenadores.CurrentRow.Cells[0].Value);
            adminEntrenadores.Txt_nombreEntrenador.Text = Convert.ToString(Dgv_entrenadores.CurrentRow.Cells[1].Value);
            adminEntrenadores.Txt_apellidoEntrenador.Text = Convert.ToString(Dgv_entrenadores.CurrentRow.Cells[2].Value);
            adminEntrenadores.Txt_especialidadEntrenador.Text = Convert.ToString(Dgv_entrenadores.CurrentRow.Cells[3].Value);
            this.Close();
            adminEntrenadores.Txt_codigoEntrenador.Enabled = false;
            adminEntrenadores.Txt_apellidoEntrenador.Enabled = false;
            adminEntrenadores.Cbo_equipo.Enabled = false;
            adminEntrenadores.Txt_nombreEntrenador.Enabled = false;
            adminEntrenadores.Txt_especialidadEntrenador.Enabled = false;
            adminEntrenadores.Gpb_estado.Enabled = false;
            adminEntrenadores.Show();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            llenarGridEntrenadores();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idEntrenador AS Codigo, nombre_entrenador AS Nombre, apellido_entrenador as Apellido, especialidad_entrenador as Especialidad FROM tbl_entrenadores WHERE PK_idEntrenador='" + Txt_buscar.Text + "' OR nombre_entrenadors = '" + Txt_buscar.Text + "'", nueva.conectar());
                dat.Fill(ds);
                Dgv_entrenadores.DataSource = ds.Tables[0];
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
