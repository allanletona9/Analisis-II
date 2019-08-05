using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Autor: Eduardo Colon

namespace Polideportivo
{
    public partial class SeleccionarEquipo : Form
    {
        String sIdEquipo, sOrigen,usuario;


        public SeleccionarEquipo(String origen, String equipo, string text)
        {
            this.usuario = text;
            InitializeComponent();
            this.sIdEquipo = sIdEquipo;
            this.sOrigen = origen;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(Cbo_seleccionar_equipo.Text,usuario);
            menu.Show();
            Hide();
        }

        private void SeleccionarEquipo_Load(object sender, EventArgs e)
        {

        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {

            if(sOrigen == "Menu")
            {
                Menu menu = new Menu(sIdEquipo,usuario);
                menu.Show();
                Hide();
            }
            else
            {
                Login login = new Login();
                login.Show();
                Hide();
            }

        }
    }
}
