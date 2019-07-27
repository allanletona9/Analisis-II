using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polideportivo_Administrativo
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            //Autor: Allan Letona
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new MDIPolideportivo_admin();
            f.Show();
            Hide();
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
