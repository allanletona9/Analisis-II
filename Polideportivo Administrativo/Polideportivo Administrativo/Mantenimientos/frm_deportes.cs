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
    public partial class frm_deportes : Form
    {
        public frm_deportes()
        {
            //Autor: Diego Gomez
            InitializeComponent();
        }

        private void frm_deportes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarDeporte_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminDeportescs adminDeportes = new frm_adminDeportescs();
            adminDeportes.Show();
        }
    }
}
