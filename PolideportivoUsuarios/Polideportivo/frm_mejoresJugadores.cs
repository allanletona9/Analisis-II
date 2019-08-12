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
    public partial class frm_mejoresJugadores : Form
    {
        List<int> lIdCampeonato = new List<int>();
        string sIdEquipo;

        public frm_mejoresJugadores(string sIdEquipo)
        {
            InitializeComponent();
            this.sIdEquipo = sIdEquipo;
            llenarComboBox();
           
        }

        private void MejoresJugadores_Load(object sender, EventArgs e)
        {

        }

        private void dgv_mejores_jugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void llenarDataGrid()
        {
            OdbcDataAdapter dat;
            DataSet ds;
            Dgv_mejores_jugadores.DataSource = null;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT tbl_jugadores.dpi_jugador as Posicion, tbl_jugadores.nombre_jugador as Nombre, tbl_jugadores.apellido_jugador as Apellido, " +
                    "tbl_jugadores.numeroCamisola_jugador as Camisola, sum(tbl_estadistica_jugadores.goles_puntos) as Anotaciones " +
                    "FROM tbl_estadistica_jugadores inner join tbl_jugadores ON tbl_jugadores.PK_idJugador = tbl_estadistica_jugadores.PK_idJugador" +
                    " WHERE tbl_estadistica_jugadores.PK_idCampeonato =" + lIdCampeonato[Cbo_campeonato.SelectedIndex] +
                    " GROUP by tbl_estadistica_jugadores.PK_idJugador ORDER BY  Anotaciones DESC"
                , conexion.conectar());
                dat.Fill(ds);
                Dgv_mejores_jugadores.DataSource = ds.Tables[0];
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
        }



        private void Cbo_campeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarDataGrid();
        }

        private void Pnl_titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dgv_mejores_jugadores_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.Dgv_mejores_jugadores.Rows[e.RowIndex].Cells[0].Value  = (e.RowIndex + 1).ToString();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\usuarios\\" + "ayudamejoresjugadores.chm", "MejoresJugadores.html");
        }
    }
}
