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

//Autor: Alejandro Barreda

namespace Polideportivo
{
    public partial class frm_sanciones : Form
    {
        List<int> lIdCampeonato = new List<int>();
        List<int> lIdJornada = new List<int>();
        string sIdEquipo;

        public frm_sanciones(string sIdEquipo)
        {
            InitializeComponent();
            this.sIdEquipo = sIdEquipo;
            llenarComboBox();
            llenarJornada();
        }

        private void Sanciones_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
            }
            else
            {
                Cbo_campeonato.Text = "";
            }
        }

        private void llenarJornada()
        {
            lIdJornada.Clear();
            Cbo_jornadas.Items.Clear();


            OdbcCommand sql = new OdbcCommand("Select tbl_jornadas.PK_idJornada, tbl_jornadas.nombre_jornada from tbl_jornadas " +
                "INNER JOIN tbl_partido_encabezado ON tbl_jornadas.PK_idJornada = tbl_partido_encabezado.PK_idJornada INNER JOIN " +
                "tbl_partido_detalle ON tbl_partido_encabezado.PK_idPartido=tbl_partido_detalle.PK_idPartido" +
                " WHERE estado_jornada=1 " +
                "AND tbl_partido_detalle.PK_idEquipo=" + sIdEquipo +
                " AND tbl_partido_encabezado.PK_idCampeonato=" + lIdCampeonato[Cbo_campeonato.SelectedIndex], conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Cbo_jornadas.Items.Add(almacena.GetInt32(0) + " - " + almacena.GetString(1));
                lIdJornada.Add(almacena.GetInt32(0));
            }
            almacena.Close();
            sql.Connection.Close();

            if (lIdJornada.Count > 0)
            {
                Cbo_jornadas.SelectedIndex = 0;
                llenarDataGrid();
            }
            else
            {
                Cbo_jornadas.Text = "";
            }

        }

        private void llenarDataGrid()
        {

            OdbcDataAdapter dat;
            DataSet ds;
            Dgv_sanciones.DataSource = null;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("Select tbl_jugadores.nombre_jugador as Nombre, tbl_jugadores.apellido_jugador as Apellido, " +
                    "tbl_jugadores.numeroCamisola_jugador as Camisola, tbl_sanciones.nombre_sancion as Sancion, " +
                    "tbl_jugadores_sanciones.motivo_sancion as Motivo FROM tbl_jugadores " +
                    "INNER JOIN tbl_jugadores_sanciones ON tbl_jugadores.PK_idJugador = tbl_jugadores_sanciones.PK_idJugador " +
                    "INNER JOIN tbl_sanciones ON tbl_sanciones.PK_idSancion = tbl_jugadores_sanciones.PK_idSancion " +
                    "INNER JOIN tbl_partido_encabezado on tbl_partido_encabezado.PK_idPartido = tbl_jugadores_sanciones.PK_idPartido " +
                    "INNER JOIN tbl_equipos_jugadores on tbl_equipos_jugadores.PK_idJugador = tbl_jugadores.PK_idJugador " +
                    "WHERE tbl_jugadores_sanciones.estado_jugador_sancion = 1 AND " +
                    "tbl_partido_encabezado.PK_idCampeonato =" + lIdCampeonato[Cbo_campeonato.SelectedIndex] + " AND " +
                    "tbl_equipos_jugadores.PK_idEquipo =" + sIdEquipo + " AND " +
                    "tbl_jugadores_sanciones.PK_idJornada=" + lIdJornada[Cbo_jornadas.SelectedIndex]
                , conexion.conectar());
                dat.Fill(ds);
                Dgv_sanciones.DataSource = ds.Tables[0];
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
        }

        private void Cbo_jornadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarDataGrid();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\usuarios\\" + "ayudasanciones.chm", "Sanciones.html");
        }
    }
}
