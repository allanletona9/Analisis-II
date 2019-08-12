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

//Autor: Allan Letona

namespace Polideportivo
{
    public partial class frm_tablaPosiciones : Form
    {
        string sIdEquipo;
        List<int> lIdCampeonato = new List<int>();

        public frm_tablaPosiciones(string sIdEquipo)
        {
            InitializeComponent();
            this.sIdEquipo = sIdEquipo;
            llenarComboBox();
        }

        private void TablaPosiciones_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Hide();
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

        private void Cbo_campeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarDataGrid();
        }

        private void llenarDataGrid()
        {
            OdbcDataAdapter dat;
            DataSet ds;
            Dgv_posiciones.DataSource = null;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT tbl_equipos.nombre_equipo as Posicion, " +
                    " tbl_equipos.nombre_equipo as Equipo, " +
                    " COUNT(tbl_partido_detalle.puntaje_obtenido) AS Partidos_Jugados, " +
                    " SUM(tbl_partido_detalle.puntaje_obtenido) AS Puntos, " +
                    " SUM(tbl_partido_detalle.puntos) AS Goles_Anotados FROM tbl_equipos " +
                    " INNER JOIN tbl_partido_detalle ON tbl_equipos.PK_idEquipo = tbl_partido_detalle.PK_idEquipo " +
                    " INNER JOIN tbl_partido_encabezado ON tbl_partido_encabezado.PK_idPartido = tbl_partido_detalle.PK_idPartido " +
                    " WHERE tbl_partido_encabezado.PK_idCampeonato =" + lIdCampeonato[Cbo_campeonato.SelectedIndex] +
                    " GROUP BY tbl_partido_detalle.PK_idEquipo ORDER BY  Puntos  DESC"
                , conexion.conectar());
                dat.Fill(ds);
                Dgv_posiciones.DataSource = ds.Tables[0];
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
        }

        private void Dgv_posiciones_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.Dgv_posiciones.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\usuarios\\" + "ayudatablaposiciones.chm", "TablaPosiciones.html");
        }
    }
}
