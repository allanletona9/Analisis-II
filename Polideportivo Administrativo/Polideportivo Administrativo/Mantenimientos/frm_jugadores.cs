using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polideportivo_Administrativo.Mantenimientos
{
    public partial class frm_jugadores : Form
    {
        public frm_jugadores()
        {
            //Autor: Alejandro Barreda
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarJugador_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminJugadores adminJugadores = new frm_adminJugadores();
            adminJugadores.Show();
        }

        private void frm_jugadores_Load(object sender, EventArgs e)
        {

        }
    }
}
