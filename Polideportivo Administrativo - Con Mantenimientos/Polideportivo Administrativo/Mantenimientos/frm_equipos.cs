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
    public partial class frm_equipos : Form
    {
        public frm_equipos()
        {
            //Autor: Allan Letona
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Btn_ingresarEquipo_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminEquipos adminEquipos = new frm_adminEquipos();
            adminEquipos.Show();
            adminEquipos.Btn_eliminar.Enabled = false;
            adminEquipos.Btn_modificar.Enabled = false;
            adminEquipos.Gpb_estado.Enabled = false;
        }

        private void frm_equipos_Load(object sender, EventArgs e)
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
                dat = new OdbcDataAdapter("SELECT PK_idEquipo AS Codigo, nombre_equipo AS Nombre, descripcion_equipo AS Descripcion FROM tbl_equipos WHERE estado_equipo=1", conexion.conectar());
                dat.Fill(ds);
                Dgv_equipos.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            frm_adminEquipos adminEquipos = new frm_adminEquipos();

            adminEquipos.Txt_codigoEquipo.Text = Convert.ToString(Dgv_equipos.CurrentRow.Cells[0].Value);
            adminEquipos.Txt_nombreEquipo.Text = Convert.ToString(Dgv_equipos.CurrentRow.Cells[1].Value);
            adminEquipos.Txt_descripcionEquipo.Text = Convert.ToString(Dgv_equipos.CurrentRow.Cells[2].Value);
            this.Close();
            adminEquipos.Txt_nombreEquipo.Enabled = false;
            adminEquipos.Txt_descripcionEquipo.Enabled = false;
            adminEquipos.Gpb_estado.Enabled = false;
            adminEquipos.Show();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            llenarGridEquipos();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idEquipo AS Codigo, nombre_equipo AS Nombre, descripcion_equipo AS Descripcion FROM tbl_equipos WHERE PK_idEquipo='"+Txt_buscar.Text+"' OR nombre_equipo = '"+Txt_buscar.Text+"'", conexion.conectar());
                dat.Fill(ds);
                Dgv_equipos.DataSource = ds.Tables[0];
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
