using Polideportivo_Administrativo;
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

//Autor: Diego Gomez

namespace Polideportivo
{
    public partial class frm_Calendario : Form
    {
        string sIdEquipo;
        List<int> lIdCampeonato = new List<int>();

        public frm_Calendario(string sIdEquipo)
        {
            InitializeComponent();
            this.sIdEquipo = sIdEquipo;
            seleccionarNombreEquipo();
            llenarComboBox();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {

        }

        private void Pnl_titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void seleccionarNombreEquipo()
        {

            OdbcCommand sql = new OdbcCommand("Select nombre_equipo from tbl_equipos WHERE PK_idEquipo=" + sIdEquipo, conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Lbl_nombre_equipo.Text = almacena.GetString(0);
            }
            almacena.Close();
            sql.Connection.Close();
        }

        private void llenarComboBox()
        {

            lIdCampeonato.Clear();
            Cbo_campeonato.Items.Clear();

            OdbcCommand sql = new OdbcCommand("Select tbl_campeonatos.PK_idCampeonato, tbl_campeonatos.nombre_campeonato from tbl_campeonatos " +
                "INNER JOIN tbl_campeonatos_equipos ON tbl_campeonatos.PK_idCampeonato = tbl_campeonatos_equipos.PK_idCampeonato WHERE tbl_campeonatos_equipos.PK_idEquipo=" + sIdEquipo, conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Cbo_campeonato.Items.Add(almacena.GetInt32(0) + " - " + almacena.GetString(1));
                lIdCampeonato.Add(almacena.GetInt32(0));
            }
            almacena.Close();
            sql.Connection.Close();

            if (lIdCampeonato.Count > 0)
            {
                Cbo_campeonato.SelectedIndex = 0;
                llenarDataGrid();
            }
            else
            {
                Cbo_campeonato.Text = "";
            }
        }

        private void llenarDataGrid()
        {
            OdbcDataAdapter dat;
            DataSet ds;
            Dgv_calendario.DataSource = null;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT tbl_partido_encabezado.PK_idJornada as Jornada, (SELECT tbl_campo.nombre_campo FROM tbl_campo WHERE tbl_campo.PK_idCampo = tbl_partido_encabezado.FK_idCampo) as Campo, tbl_partido_encabezado.fecha_partido" +
                    " as Fecha, tbl_partido_encabezado.hora_partido as Hora FROM tbl_partido_encabezado INNER JOIN tbl_partido_detalle " +
                    "ON tbl_partido_encabezado.PK_idPartido = tbl_partido_detalle.PK_idPartido WHERE " +
                    "tbl_partido_encabezado.PK_idCampeonato =" + lIdCampeonato[Cbo_campeonato.SelectedIndex] + " AND " +
                    "tbl_partido_detalle.PK_idEquipo =" + sIdEquipo + " AND " +
                    "tbl_partido_encabezado.estado_partido = 1"
                , conexion.conectar());
                dat.Fill(ds);
                Dgv_calendario.DataSource = ds.Tables[0];

            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Cbo_campeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarDataGrid();
        }

        private void Lbl_nombre_equipo_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_calendario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\usuarios\\" + "ayudacalendario.chm", "ConsultarCalendario.html");
        }
    }
}
