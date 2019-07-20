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
    public partial class frm_empleados : Form
    {
        public frm_empleados()
        {
            //Autor: Alejandro Barreda
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminEmpleados adminEmpleados = new frm_adminEmpleados();
            adminEmpleados.Show();
        }

        private void frm_empleados_Load(object sender, EventArgs e)
        {

        }
    }
}
