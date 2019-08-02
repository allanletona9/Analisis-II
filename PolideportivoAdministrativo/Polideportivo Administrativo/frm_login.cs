//Validacion de datos ingresados por el usuario, realizando la consulta a la base de datos polideportivo//
//Con los campos ingresados usuario y contraseña

//Autor Diego Gomez

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Net;
using System.Net.NetworkInformation;

namespace Polideportivo_Administrativo
{
    public partial class frm_login : Form
    {
        //Autor Diego Gomez
        conexion nueva = new conexion();
        public frm_login()
        {
            InitializeComponent();
            Txt_clave.UseSystemPasswordChar = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

         
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

        private void Cb_ver_password_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ver_password.Checked == true)
            {
               Txt_clave.UseSystemPasswordChar = false;
            }
            else
            {
                Txt_clave.UseSystemPasswordChar = true;
            }
        }

        private void Txt_clave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
