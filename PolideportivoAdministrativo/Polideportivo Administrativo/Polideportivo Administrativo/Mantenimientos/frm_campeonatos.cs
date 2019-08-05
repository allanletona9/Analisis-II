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
    public partial class frm_campeonatos : Form
    {
        conexion nueva = new conexion();
        public frm_campeonatos()
        {
            //Autor: Allan Letona
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void llenarGridCampeonatos()
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idCampeonato AS Codigo, FK_idDeporte AS Deporte, nombre_campeonato AS Nombre, descripcion_campeonato AS Descripcion, precio_campeonato AS Precio, cantidad_equipos Cantidad_equipos FROM tbl_campeonatos WHERE estado_campeonato=1", nueva.conectar());
                dat.Fill(ds);
                Dgv_campeonatos.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Btn_ingresarCampeonato_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminCampeonatos adminCampeonatos = new frm_adminCampeonatos();
            adminCampeonatos.Show();
            adminCampeonatos.Btn_eliminar.Enabled = false;
            adminCampeonatos.Btn_modificar.Enabled = false;
            adminCampeonatos.Gpb_estado.Enabled = false;
        }

        private void frm_campeonatos_Load(object sender, EventArgs e)
        {
            llenarGridCampeonatos();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idCampeonato AS Codigo, FK_idDeporte AS Deporte, nombre_campeonato AS Nombre, descripcion_campeonato AS Descripcion, precio_campeonato AS Precio, cantidad_equipos Cantidad_equipos FROM tbl_campeonatos WHERE PK_idCampeonato='" + Txt_buscar.Text + "' OR nombre_campeonato = '" + Txt_buscar.Text + "'", nueva.conectar());
                dat.Fill(ds);
                Dgv_campeonatos.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            frm_adminCampeonatos adminCampeonatos = new frm_adminCampeonatos();


            OdbcCommand sql = new OdbcCommand("Select nombre_deporte from tbl_deportes where PK_idDeporte='" + Convert.ToInt16(Dgv_campeonatos.CurrentRow.Cells[4].Value) + "'", nueva.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                adminCampeonatos.Cbo_deportes.Text = almacena.GetString(0);
            }
            almacena.Close();

            adminCampeonatos.Txt_codigoCampeonato.Text = Convert.ToString(Dgv_campeonatos.CurrentRow.Cells[0].Value);
            adminCampeonatos.Txt_nombreCampeonato.Text = Convert.ToString(Dgv_campeonatos.CurrentRow.Cells[2].Value);
            adminCampeonatos.Txt_descripcionCampeonato.Text = Convert.ToString(Dgv_campeonatos.CurrentRow.Cells[3].Value);
            adminCampeonatos.Txt_precioCampeonato.Text = Convert.ToString(Dgv_campeonatos.CurrentRow.Cells[4].Value);
            adminCampeonatos.Txt_cantidadEquipos.Text = Convert.ToString(Dgv_campeonatos.CurrentRow.Cells[5].Value);
            this.Close();
            adminCampeonatos.Txt_codigoCampeonato.Enabled = false;
            adminCampeonatos.Txt_nombreCampeonato.Enabled = false;
            adminCampeonatos.Txt_descripcionCampeonato.Enabled = false;
            adminCampeonatos.Txt_precioCampeonato.Enabled = false;
            adminCampeonatos.Txt_cantidadEquipos.Enabled = false;
            adminCampeonatos.Gpb_estado.Enabled = false;
            adminCampeonatos.Cbo_deportes.Enabled = false;
            adminCampeonatos.Show();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            llenarGridCampeonatos();
        }

        private void Btn_salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
