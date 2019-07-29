using Polideportivo_Administrativo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
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
        String sIdEquipo, sOrigen, sIdEntrenador;
        List<int> lIdEquipo = new List<int>();

        public SeleccionarEquipo(String origen, String sIdEntrenador, String sIdEquipo)
        {
            InitializeComponent();
            this.sIdEntrenador = sIdEntrenador;
            this.sIdEquipo = sIdEquipo;
            this.sOrigen = origen;
            llenarComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(sIdEntrenador, lIdEquipo[Cbo_seleccionar_equipo.SelectedIndex].ToString());
            menu.Show();
            Hide();
        }

        private void SeleccionarEquipo_Load(object sender, EventArgs e)
        {

        }

        private void Cbo_seleccionar_equipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {

            if(sOrigen == "Menu")
            {
                Menu menu = new Menu(sIdEntrenador, sIdEquipo);
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

        private void llenarComboBox()
        {
            OdbcCommand sql = new OdbcCommand("Select PK_idEquipo, (SELECT tbl_equipos.nombre_equipo FROM tbl_equipos WHERE tbl_equipos.PK_idEquipo = tbl_equipos_entrenadores.PK_idEquipo) from tbl_equipos_entrenadores WHERE PK_idEntrenador='"  + sIdEntrenador +   "'", conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Cbo_seleccionar_equipo.Items.Add(almacena.GetString(1));
                lIdEquipo.Add(almacena.GetInt32(0));
            }
            almacena.Close();
        }
    }
}
