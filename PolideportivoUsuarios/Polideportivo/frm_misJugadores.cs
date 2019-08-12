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
    public partial class frm_misJugadores : Form
    {
        string sIdEquipo;
        conexion nueva = new conexion();

        public frm_misJugadores(string sIdEquipo)
        {
            InitializeComponent();
            this.sIdEquipo = sIdEquipo;
            seleccionarNombreEquipo();
            llenarDataGrid();
        }

        private void llenarDataGrid()
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT tbl_jugadores.PK_idJugador AS Codigo, tbl_jugadores.nombre_jugador AS Nombre, tbl_jugadores.apellido_jugador as Apellido, " +
                    "tbl_jugadores.fecha_nacimiento_jugador as FechaDeNacimiento, tbl_jugadores.numeroCamisola_jugador as Camisola, tbl_jugadores.telefono_jugador as Telefono, " +
                    "tbl_jugadores.dpi_jugador as DPI FROM tbl_jugadores INNER JOIN tbl_equipos_jugadores ON tbl_jugadores.PK_idJugador= tbl_equipos_jugadores.PK_idJugador " +
                    "WHERE tbl_jugadores.estado_jugador=1 AND tbl_equipos_jugadores.PK_idEquipo=" + sIdEquipo, conexion.conectar());
                dat.Fill(ds);
                Dgv_listado_jugadores.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void MisJugadores_Load(object sender, EventArgs e)
        {

        }

        private void seleccionarNombreEquipo()
        {

            OdbcCommand sql = new OdbcCommand("Select nombre_equipo from tbl_equipos WHERE PK_idEquipo=" +  sIdEquipo, conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Lbl_nombre_equipo.Text = almacena.GetString(0);  
            }
            almacena.Close();
            sql.Connection.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\usuarios\\" + "ayudamisjugadores.chm", "MisJugadores.html");
        }
    }
}
