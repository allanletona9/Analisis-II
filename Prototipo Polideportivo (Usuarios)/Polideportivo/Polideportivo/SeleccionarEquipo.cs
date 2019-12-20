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
        public SeleccionarEquipo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(Cbo_seleccionar_equipo.Text);
            menu.Show();
            Hide();
        }

        private void SeleccionarEquipo_Load(object sender, EventArgs e)
        {

        }
    }
}
