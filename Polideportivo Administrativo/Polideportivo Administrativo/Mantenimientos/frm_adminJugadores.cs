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
    public partial class frm_adminJugadores : Form
    {
        public frm_adminJugadores()
        {
            //Autor: Alejandro Barreda
            InitializeComponent();
        }

        private void frm_adminJugadores_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
