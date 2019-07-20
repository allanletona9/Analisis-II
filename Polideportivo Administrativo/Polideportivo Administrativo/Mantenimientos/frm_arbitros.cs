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
    public partial class frm_arbitros : Form
    {
        public frm_arbitros()
        {
            //Autor: Alejandro Barreda
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarArbitro_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminArbitros adminArbitros = new frm_adminArbitros();
            adminArbitros.Show();
        }

        private void frm_arbitros_Load(object sender, EventArgs e)
        {

        }
    }
}
