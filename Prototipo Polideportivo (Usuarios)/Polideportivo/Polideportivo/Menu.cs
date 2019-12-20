using System;
using System.Windows.Forms;

//Autor: Eduardo Colon

namespace Polideportivo
{
    public partial class Menu : Form
    {
        public Menu(String sIdEquipo)
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            CambiarClave cambiarClave = new CambiarClave();
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
            SeleccionarEquipo seleccionarEquipo = new SeleccionarEquipo();
            seleccionarEquipo.Show();
            Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
