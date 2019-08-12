using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Net;
using System.Net.NetworkInformation;
using Polideportivo_Administrativo;

//Autor: Eduardo Colon

namespace Polideportivo
{
    public partial class frm_MdiParent : Form
    {
        String sIdEquipo = null;
        //Autor Diego Gomez
        conexion nueva = new conexion();

        String usuario;

        public frm_MdiParent(String sIdEquipo, string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.sIdEquipo = sIdEquipo;
            lblUsuario.Text = "Usuario: " + usuario;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Autor: Diego Gomez
            conexion nueva = new conexion();
            OdbcCommand cmd;
            cmd = new OdbcCommand("INSERT INTO tbl_bitacora (" +
                  "PK_idUsuario, " +
                  "accion, " +
                  "fecha, " +
                  "hora, " +
                  "tabla," +
                  "host) " +
                  "VALUES('" + usuario + "' ," +
                  ",'Salida Del Sistema de Usuarios' " +
                   ",'" + DateTime.Now.ToString("yyy/MM/dd") + "'" +
                   ",'" + DateTime.Now.ToString("hh:mm:ss") + "'" +
                   ",'Menu'" +
                   ",' ')"
                  , conexion.conectar());
            cmd.ExecuteNonQuery();

            Application.Exit();
        }

        private void misJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_misJugadores misJugadores = new frm_misJugadores(sIdEquipo);
            misJugadores.MdiParent = this;
            misJugadores.Show();
        }

        private void tablaDePosicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tablaPosiciones tablaPosciones = new frm_tablaPosiciones(sIdEquipo);
            tablaPosciones.MdiParent = this;
            tablaPosciones.Show();
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Calendario calendario = new frm_Calendario(sIdEquipo);
            calendario.MdiParent = this;
            calendario.Show();
        }

        private void sancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sanciones sanciones = new frm_sanciones(sIdEquipo);
            sanciones.MdiParent = this;
            sanciones.Show();
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cambiarClave cambiarClave = new frm_cambiarClave(usuario);
            cambiarClave.MdiParent = this;
            cambiarClave.Show();
        }

        private void partidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Partido partidos = new frm_Partido(sIdEquipo);
            partidos.MdiParent = this;
            partidos.Show();
        }

        private void direccionDeConceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*DiccionarioConceptos diccionarioConceptos = new DiccionarioConceptos();
            diccionarioConceptos.MdiParent = this;
            diccionarioConceptos.Show();*/
        }

        private void preguntasFrecuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreguntasFrecuentas preguntasFrecuentes = new PreguntasFrecuentas();
            preguntasFrecuentes.MdiParent = this;
            preguntasFrecuentes.Show();
        }

        private void mejoresJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_mejoresJugadores mejoresJugadores = new frm_mejoresJugadores(sIdEquipo);
            mejoresJugadores.MdiParent = this;
            mejoresJugadores.Show();
        }

        private void seleccionarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_seleccionarEquipo seleccionarEquipo = new frm_seleccionarEquipo("Menu", sIdEquipo,usuario);
            seleccionarEquipo.Show();
            Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
