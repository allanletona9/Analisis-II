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
    public partial class frm_campos : Form
    {
        public frm_campos()
        {
            //Autor: Eduardo Colon
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarCampo_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminCampos adminCampos = new frm_adminCampos();
            adminCampos.Show();
        }

        private void frm_campos_Load(object sender, EventArgs e)
        {

        }
    }
}
