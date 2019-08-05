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
    public partial class Menu : Form
    {
        String sIdEquipo = null;
        //Autor Diego Gomez
        conexion nueva = new conexion();

        String nombreUsuario, tipo,usuario;

        public Menu(String sIdEquipo, string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            this.sIdEquipo = sIdEquipo;
            lblUsuario.Text = "Usuario: " + usuario;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Autor: Diego Gomez
            conexion nueva = new conexion();
            OdbcCommand cmd;
            cmd = new OdbcCommand("INSERT INTO tbl_bitacora (PK_idBitacora," +
                  "PK_idUsuario, " +
                  "accion, " +
                  "fecha, " +
                  "hora, " +
                  "tabla," +
                  "host) " +
                  "VALUES('' ,'1'" +
                  ",'Salida Del Sistema de Usuarios' " +
                   ",'" + DateTime.Now.ToString("yyy/MM/dd") + "'" +
                   ",'" + DateTime.Now.ToString("hh:mm:ss") + "'" +
                   ",' '" +
                   ",' '" +
                   ")"
                  , conexion.conectar());
            cmd.ExecuteNonQuery();

            Application.Exit();
        }

        private void misJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MisJugadores misJugadores = new MisJugadores();
            misJugadores.MdiParent = this;
            misJugadores.Show();
        }

        private void tablaDePosicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaPosiciones tablaPosciones = new TablaPosiciones();
            tablaPosciones.MdiParent = this;
            tablaPosciones.Show();
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario();
            calendario.MdiParent = this;
            calendario.Show();
        }

        private void sancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sanciones sanciones = new Sanciones();
            sanciones.MdiParent = this;
            sanciones.Show();
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarClave cambiarClave = new CambiarClave(usuario);
            cambiarClave.MdiParent = this;
            cambiarClave.Show();
        }

        private void partidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Partidos partidos = new Partidos();
            partidos.MdiParent = this;
            partidos.Show();
        }

        private void direccionDeConceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiccionarioConceptos diccionarioConceptos = new DiccionarioConceptos();
            diccionarioConceptos.MdiParent = this;
            diccionarioConceptos.Show();
        }

        private void preguntasFrecuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreguntasFrecuentas preguntasFrecuentes = new PreguntasFrecuentas();
            preguntasFrecuentes.MdiParent = this;
            preguntasFrecuentes.Show();
        }

        private void mejoresJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MejoresJugadores mejoresJugadores = new MejoresJugadores();
            mejoresJugadores.MdiParent = this;
            mejoresJugadores.Show();
        }

        private void seleccionarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarEquipo seleccionarEquipo = new SeleccionarEquipo("Menu", sIdEquipo,usuario);
            seleccionarEquipo.Show();
            Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
