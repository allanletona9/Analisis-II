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
    public partial class frm_equipos : Form
    {
        public frm_equipos()
        {
            //Autor: Diego Gomez
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarEquipo_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminEquipos adminEquipos = new frm_adminEquipos();
            adminEquipos.Show();
        }

        private void frm_equipos_Load(object sender, EventArgs e)
        {

        }
    }
}
