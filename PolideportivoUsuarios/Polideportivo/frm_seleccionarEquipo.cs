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
    public partial class frm_seleccionarEquipo : Form
    {
        String sIdEquipo, sOrigen,usuario;
        List<int> lIdEquipo = new List<int>();
        conexion nueva = new conexion();

        public frm_seleccionarEquipo(String origen, String equipo, string sIdEntrenador)
        {
            this.usuario = sIdEntrenador;
            InitializeComponent();
            this.sIdEquipo = equipo;
            this.sOrigen = origen;
            llenarComboBox(sIdEntrenador);
        }

        private void llenarComboBox(string sIdEntrenador)
        {

            lIdEquipo.Clear();
            Cbo_seleccionar_equipo.Items.Clear();

            OdbcCommand sql = new OdbcCommand("Select tbl_equipos.PK_idEquipo, tbl_equipos.nombre_equipo from tbl_equipos " +
                "INNER JOIN tbl_equipos_entrenadores on tbl_equipos.PK_idEquipo = tbl_equipos_entrenadores.PK_idEquipo WHERE " +
                "tbl_equipos_entrenadores.PK_idEntrenador= " + "(SELECT FK_idEntrenador from tbl_asignacion_usuario_entrenador WHERE PK_idUsuario= '" + sIdEntrenador +"')", conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Cbo_seleccionar_equipo.Items.Add(almacena.GetInt32(0) + " - " + almacena.GetString(1));
                lIdEquipo.Add(almacena.GetInt32(0));
            }
            almacena.Close();
            sql.Connection.Close();

            if (lIdEquipo.Count > 0)
            {
                Cbo_seleccionar_equipo.SelectedIndex = 0;
            }
            else
            {
                Cbo_seleccionar_equipo.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_MdiParent menu = new frm_MdiParent(lIdEquipo[Cbo_seleccionar_equipo.SelectedIndex].ToString() , usuario);
            menu.Show();
            Hide();
        }

        private void Cbo_seleccionar_equipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SeleccionarEquipo_Load(object sender, EventArgs e)
        {

        }

        private void Btn_regresar_Click(object sender, EventArgs e)
        {

            if(sOrigen == "Menu")
            {
                frm_MdiParent menu = new frm_MdiParent(sIdEquipo,usuario);
                menu.Show();
                Hide();
            }
            else
            {
                frm_login login = new frm_login();
                login.Show();
                Hide();
            }

        }
    }
}
