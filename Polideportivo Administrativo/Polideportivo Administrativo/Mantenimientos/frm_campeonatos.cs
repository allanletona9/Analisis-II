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
    public partial class frm_campeonatos : Form
    {
        public frm_campeonatos()
        {
            //Autor: Allan Letona
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarCampeonato_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminCampeonatos adminCampeonatos = new frm_adminCampeonatos();
            adminCampeonatos.Show();
        }

        private void frm_campeonatos_Load(object sender, EventArgs e)
        {

        }
    }
}
