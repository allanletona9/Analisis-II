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
    public partial class frm_adminCampeonatos : Form
    {
        public frm_adminCampeonatos()
        {
            //Autor: Allan Letona
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_adminCampeonatos_Load(object sender, EventArgs e)
        {

        }
    }
}
