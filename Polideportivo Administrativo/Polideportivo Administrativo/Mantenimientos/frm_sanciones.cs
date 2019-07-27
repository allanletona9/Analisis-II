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
    public partial class frm_sanciones : Form
    {
        public frm_sanciones()
        {
            //Autor: Eduardo Colon
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarSancion_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminSanciones adminSanciones = new frm_adminSanciones();
            adminSanciones.Show();
        }

        private void frm_sanciones_Load(object sender, EventArgs e)
        {

        }
    }
}
