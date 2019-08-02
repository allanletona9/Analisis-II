using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polideportivo_Administrativo.Mantenimientos;
using Polideportivo_Administrativo.Procesos;
using Polideportivo_Administrativo.Seguridad;
using System.Runtime.InteropServices;
using System.Data.Odbc;

//Autor Diego Gomez
namespace Polideportivo_Administrativo.Seguridad
{
    public partial class frm_tipo : Form
    {

        public frm_tipo()
        {
            InitializeComponent();
        }

        private void tipo_Load(object sender, EventArgs e)
        {

        }



        //Autor Diego Gomez
        bool ventanaUsuarios1 = false;
        frm_empleados mostrarUsuarios1 = new frm_empleados();

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            bool isCheckedempleado = Rdb_empleado.Checked;
            bool isCheckedentrenador = Rdb_entrenador.Checked;


            if (isCheckedempleado)
            {
                
              
            }
            else if (isCheckedentrenador)
            {
               frm_creacion_usuarios f = new frm_creacion_usuarios();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
                
            }
            else
            {
                MessageBox.Show("Seleccione Opcion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}