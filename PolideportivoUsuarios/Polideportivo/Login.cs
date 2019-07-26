using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Autor: Allan letona

namespace Polideportivo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Txt_clave.UseSystemPasswordChar = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SeleccionarEquipo seleccionar = new SeleccionarEquipo("Login", null);
            seleccionar.Show();
            Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Cb_ver_password_CheckedChanged(object sender, EventArgs e)
        {
            if(Cb_ver_password.Checked == false)
            {
                Txt_clave.UseSystemPasswordChar = true;
            }
            else
            {
               Txt_clave.UseSystemPasswordChar = false;
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
