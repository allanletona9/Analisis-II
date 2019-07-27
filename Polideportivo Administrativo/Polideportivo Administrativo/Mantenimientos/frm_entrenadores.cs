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
    public partial class frm_entrenadores : Form
    {
        public frm_entrenadores()
        {
            //Autor: Eduardo Colon
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarEntrenador_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminEntrenadores adminEntrenadores = new frm_adminEntrenadores();
            adminEntrenadores.Show();
        }

        private void frm_entrenadores_Load(object sender, EventArgs e)
        {

        }
    }
}
