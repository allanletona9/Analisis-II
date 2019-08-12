using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;


namespace Polideportivo_Administrativo.Mantenimientos
{
    public partial class frm_jugadores : Form
    {
        conexion nueva = new conexion();
        public frm_jugadores()
        {
            //Autor: Eduardo Colon
            InitializeComponent();
            llenarGridJugadores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarJugador_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminJugadores adminJugadores = new frm_adminJugadores();
            adminJugadores.Show();
            adminJugadores.Txt_codigoJugador.Enabled = false;
            adminJugadores.Txt_dpi.Enabled = false;
            adminJugadores.Cbo_equipo.Enabled = false;
            adminJugadores.Txt_nombreJugador.Enabled = false;
            adminJugadores.Txt_apellidoJugador.Enabled = false;
            adminJugadores.Txt_numeroCamisola.Enabled = false;
            adminJugadores.Txt_telefono.Enabled = false;
        }

        private void frm_jugadores_Load(object sender, EventArgs e)
        {

        }

        void llenarGridJugadores()
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idJugador AS Codigo, nombre_jugador AS Nombre, apellido_jugador as Apellido, fecha_nacimiento_jugador as FechaDeNacimiento, numeroCamisola_jugador as Camisola, telefono_jugador as Telefono, dpi_jugador as DPI FROM tbl_jugadores WHERE estado_jugador=1", nueva.conectar());
                dat.Fill(ds);
                Dgv_jugadores.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            frm_adminJugadores adminJugadores = new frm_adminJugadores();

   
            adminJugadores.Txt_codigoJugador.Text = Convert.ToString(Dgv_jugadores.CurrentRow.Cells[0].Value);
            adminJugadores.Txt_nombreJugador.Text = Convert.ToString(Dgv_jugadores.CurrentRow.Cells[1].Value);
            adminJugadores.Txt_apellidoJugador.Text = Convert.ToString(Dgv_jugadores.CurrentRow.Cells[2].Value);
            adminJugadores.Txt_numeroCamisola.Text = Convert.ToString(Dgv_jugadores.CurrentRow.Cells[4].Value);
            adminJugadores.Txt_dpi.Text = Convert.ToString(Dgv_jugadores.CurrentRow.Cells[6].Value);
            adminJugadores.Txt_telefono.Text = Convert.ToString(Dgv_jugadores.CurrentRow.Cells[5].Value);

            this.Close();
            adminJugadores.Txt_codigoJugador.Enabled = false;
            adminJugadores.Txt_dpi.Enabled = false;
            adminJugadores.Cbo_equipo.Enabled = false;
            adminJugadores.Txt_nombreJugador.Enabled = false;
            adminJugadores.Txt_apellidoJugador.Enabled = false;
            adminJugadores.Txt_numeroCamisola.Enabled = false;
            adminJugadores.Txt_telefono.Enabled = false;

            adminJugadores.Show();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            llenarGridJugadores();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("PK_idJugador AS Codigo, nombre_jugador AS Nombre, apellido_jugador as Apellido, fecha_nacimiento_jugador as FechaDeNacimiento, numeroCamisola_jugador as Camisola, telefono_jugador as Telefono, dpi_jugador as DPI  FROM tbl_jugadores WHERE PK_idJugador='" + Txt_buscar.Text + "' OR nombre_jugador = '" + Txt_buscar.Text + "'", nueva.conectar());
                dat.Fill(ds);
                Dgv_jugadores.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Btn_salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }  
}
