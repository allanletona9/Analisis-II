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
    public partial class frm_Partido : Form
    {

        string sIdEquipo;
        List<int> lIdCampeonato = new List<int>();
        List<int> lIdJornada = new List<int>();


        public frm_Partido(string sIdEquipo)
        {
            InitializeComponent();
            this.sIdEquipo = sIdEquipo;
            llenarComboBox();
            llenarJornada();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Partidos_Load(object sender, EventArgs e)
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
            Cbo_jornada.Items.Clear();


            OdbcCommand sql = new OdbcCommand("Select tbl_jornadas.PK_idJornada, tbl_jornadas.nombre_jornada from tbl_jornadas " +
                "INNER JOIN tbl_partido_encabezado ON tbl_jornadas.PK_idJornada = tbl_partido_encabezado.PK_idJornada INNER JOIN " +
                "tbl_partido_detalle ON tbl_partido_encabezado.PK_idPartido=tbl_partido_detalle.PK_idPartido" +
                " WHERE estado_jornada=1 " +
                "AND tbl_partido_detalle.PK_idEquipo="  + sIdEquipo +
                " AND tbl_partido_encabezado.PK_idCampeonato=" + lIdCampeonato[Cbo_campeonato.SelectedIndex], conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Cbo_jornada.Items.Add(almacena.GetInt32(0) + " - " + almacena.GetString(1));
                lIdJornada.Add(almacena.GetInt32(0));
            }
            almacena.Close();
            sql.Connection.Close();

            if (lIdJornada.Count > 0)
            {
                Cbo_jornada.SelectedIndex = 0;
            }
            else
            {
                Cbo_jornada.Text = "";
            }

        }

        private void Cbo_jornada_SelectedIndexChanged(object sender, EventArgs e)
        {
           llenarForm();
        }

        private void llenarForm()
        {

            OdbcCommand sql = new OdbcCommand("Select tbl_campo.nombre_campo, tbl_partido_encabezado.fecha_partido, tbl_partido_encabezado.PK_idPartido from tbl_partido_encabezado INNER JOIN " +
                "tbl_partido_detalle ON tbl_partido_encabezado.PK_idPartido = tbl_partido_detalle.PK_idPartido " +
                " INNER JOIN tbl_campo ON tbl_campo.PK_idCampo= tbl_partido_encabezado.FK_idCampo" +
                " WHERE tbl_partido_detalle.PK_idEquipo=" + sIdEquipo + 
                " AND tbl_partido_encabezado.PK_idJornada=" + lIdJornada[Cbo_jornada.SelectedIndex], conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();

            if (almacena.HasRows)
            {
                Lbl_campo.Text = almacena.GetString(0);
                Lbl_fecha.Text = almacena.GetString(1);

                consultarResultado(almacena.GetString(2));
            }
            else
            {
                Lbl_estado_partido.Text = "";
                Lbl_campo.Text = "";
                Lbl_fecha.Text = "";
                Lbl_puntaje_equipo1.Text = "";
                Lbl_puntaje_equipo2.Text = "";
                Lbl_nombre_equipo1.Text = "Equipo 1";
                Lbl_nombre_equipo2.Text = "Equipo 2";
            }

            almacena.Close();
            sql.Connection.Close();


        }

        private void consultarResultado(string v)
        {

            OdbcCommand sql = new OdbcCommand("Select tbl_equipos.nombre_equipo, tbl_partido_detalle.puntos from tbl_equipos INNER JOIN tbl_partido_detalle " +
                "ON tbl_equipos.PK_idEquipo = tbl_partido_detalle.PK_idEquipo" +           
                " WHERE tbl_partido_detalle.PK_idPartido=" + v , conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            int iContador = 0;

            while (almacena.Read())
            {
                string sPuntaje = "";
                Boolean bNull = true;
                if(iContador == 0)
                {
                    Lbl_nombre_equipo1.Text = almacena.GetString(0);
                    try
                    {
                        sPuntaje = almacena.GetString(1);
                    }catch(InvalidCastException ex)
                    {
                        Lbl_puntaje_equipo1.Text = "Pendiente";
                        Lbl_estado_partido.Text = "Pendiente";
                        bNull = false;
                    }

                    if (bNull)
                    {
                        Lbl_puntaje_equipo1.Text = sPuntaje;
                        Lbl_estado_partido.Text = "Disputado";
                    }
                   

                    iContador++;
                }
                else
                {
                    Lbl_nombre_equipo2.Text = almacena.GetString(0);

                    try
                    {
                        sPuntaje = almacena.GetString(1);
                    }
                    catch (InvalidCastException ex)
                    {
                        Lbl_puntaje_equipo2.Text = "Pendiente";
                        bNull = false;
                    }

                    if (bNull)
                        Lbl_puntaje_equipo2.Text = sPuntaje;

                    iContador++;
                }
            }
        
        }

        private void Btn_goleadores_Click(object sender, EventArgs e)
        {
            frm_mejoresJugadores frm = new frm_mejoresJugadores(sIdEquipo);
            frm.Show();
            Hide();
        }

        private void Btn_sanciones_Click(object sender, EventArgs e)
        {
            frm_sanciones frm = new frm_sanciones(sIdEquipo);
            frm.Show();
            Hide();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\usuarios\\" + "ayudapartidos.chm", "Partidos.html");
        }
    }
}
