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

namespace Polideportivo_Administrativo.Procesos
{
    public partial class frm_controlSanciones : Form
    {
        conexion nueva = new conexion();
        string nombresancion = "";
        string nombrejugador = "";
        string nombreequipo = "";

        public frm_controlSanciones()
        {
            //Autor: Alejandro Barreda
            InitializeComponent();
            llenarComboBoxEquipos();
            llenarComboBoxSanciones();
            llenarComboBoxJornadas();
        }

        void llenarComboBoxEquipos()
        {

            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT nombre_equipo FROM tbl_equipos WHERE estado_equipo = 1", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_equipos.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        void llenarComboBoxSanciones()
        {

            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT nombre_sancion FROM tbl_sanciones WHERE estado_sancion = 1", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_sanciones.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_controlSanciones_Load(object sender, EventArgs e)
        {

        }

        void llenarComboBoxJugadores(string sCodigoEquipo)
        {
           
            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT J.nombre_jugador, J.apellido_jugador FROM tbl_jugadores J INNER JOIN tbl_equipos_jugadores EJ ON J.PK_idJugador = EJ.PK_idJugador INNER JOIN tbl_equipos E ON EJ.PK_idEquipo = E.PK_idEquipo WHERE E.PK_idEquipo = '" + sCodigoEquipo + "'", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_jugadores.Items.Add(almacena.GetValue(0) + " " + almacena.GetValue(1));
                    
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        void controlDeJugadores()
        {
            string scodigoEquipo = " ";
            bool bValidacionJugador = false;

            if (Cbo_equipos.SelectedItem != null)
            {
                string sNombreEquipo = Cbo_equipos.SelectedItem.ToString();

                //consulta el codigo del equipo obteniendo el texto del combobox con el nombre del equipo
                try
                {

                    OdbcCommand sql = new OdbcCommand("Select PK_idEquipo from tbl_equipos where nombre_equipo = '" + sNombreEquipo + "'", nueva.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {

                        scodigoEquipo = almacena.GetString(0);

                    }
                    almacena.Close();
                    sql.Connection.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                bValidacionJugador = true;
            }

            llenarComboBoxJugadores(scodigoEquipo);

        }


        string sCodigoDeJugador = "";
        string sCodigoDeEquipo = "";
        string sCodigoSancion = "";
        string scodigoJornada = "";

        private void Btn_agregar_Click(object sender, EventArgs e)
        {

          
            if (Cbo_jugadores.SelectedItem != null && Cbo_equipos.SelectedItem != null && Cbo_sanciones.SelectedItem != null && Cbo_jornadas.SelectedItem != null)
            {
                string sNombreJugador = Cbo_jugadores.SelectedItem.ToString();
                string sNombreEquipo = Cbo_equipos.SelectedItem.ToString();
                string sNombreSancion = Cbo_sanciones.SelectedItem.ToString();
                string sNombreJornada = Cbo_jornadas.SelectedItem.ToString();

                try
                {

                    OdbcCommand sql1 = new OdbcCommand("SELECT PK_idEquipo FROM tbl_equipos WHERE nombre_equipo = '" + sNombreEquipo + "'", nueva.conectar());
                    OdbcDataReader almacena1 = sql1.ExecuteReader();
                    while (almacena1.Read() == true)
                    {

                        sCodigoDeEquipo = almacena1.GetString(0);

                    }
                    almacena1.Close();
                    sql1.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                try
                {
                    OdbcCommand sql1 = new OdbcCommand("SELECT J.PK_idJugador FROM tbl_jugadores J INNER JOIN tbl_equipos_jugadores EP ON J.PK_idJugador = EP.PK_idJugador WHERE ((SELECT (nombre_jugador&apellido_jugador) AS nombre) = '" + sNombreJugador + "') AND EP.PK_idEquipo = '" + sCodigoDeEquipo + "'", nueva.conectar());
                    OdbcDataReader almacena1 = sql1.ExecuteReader();
                    while (almacena1.Read() == true)
                    {

                        sCodigoDeJugador = almacena1.GetString(0);

                    }
                    almacena1.Close();
                    sql1.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                try
                {

                    OdbcCommand sql2 = new OdbcCommand("SELECT PK_idSancion FROM tbl_sanciones WHERE nombre_sancion = '" + sNombreSancion + "'", nueva.conectar());
                    OdbcDataReader almacena2 = sql2.ExecuteReader();
                    while (almacena2.Read() == true)
                    {

                        sCodigoSancion = almacena2.GetString(0);

                    }
                    almacena2.Close();
                    sql2.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                try
                {

                    OdbcCommand sql2 = new OdbcCommand("SELECT PK_idSancion FROM tbl_sanciones WHERE nombre_sancion = '" + sNombreSancion + "'", nueva.conectar());
                    OdbcDataReader almacena2 = sql2.ExecuteReader();
                    while (almacena2.Read() == true)
                    {

                        sCodigoSancion = almacena2.GetString(0);

                    }
                    almacena2.Close();
                    sql2.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                try
                {

                    OdbcCommand sql3 = new OdbcCommand("SELECT PK_idJornada FROM tbl_jornadas WHERE nombre_jornada = '" + sNombreJornada + "'", nueva.conectar());
                    OdbcDataReader almacena3 = sql3.ExecuteReader();
                    while (almacena3.Read() == true)
                    {

                        scodigoJornada = almacena3.GetString(0);

                    }
                    almacena3.Close();
                    sql3.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }

            DataGridViewRow filas = new DataGridViewRow();
            filas.CreateCells(Dgv_sanciones);

            filas.Cells[0].Value = sCodigoDeJugador;
            filas.Cells[1].Value = Cbo_jugadores.SelectedItem;
            filas.Cells[2].Value = sCodigoSancion;
            filas.Cells[3].Value = Txt_motivo.Text;
            filas.Cells[4].Value = scodigoJornada;
   

            Dgv_sanciones.Rows.Add(filas);

            Cbo_equipos.Text = "";
            Cbo_jugadores.Text = "";
            Cbo_jornadas.Text = "";
            Cbo_sanciones.Text = "";
            Txt_motivo.Text = "";

           /* bool x = true;
            try
            {
                nombreequipo = Cbo_equipos.SelectedItem.ToString();
                string[] nombreseparadoequipo;
                nombreseparadoequipo = nombreequipo.Split(' ');

                nombrejugador = Cbo_jugadores.SelectedItem.ToString();
                string[] nombreseparadojugador;
                nombreseparadojugador = nombrejugador.Split(' ');

                //nombreseparado[0]=IDJugador
                nombresancion = Cbo_sanciones.SelectedItem.ToString();
                string[] nombreseparadosancion;
                nombreseparadosancion = nombresancion.Split(' ');

                try
                {

                    OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_jugadores sanciones(PK_idPartido,PK_idJugador,PK_idSancion,motivo_sancion,estado_jugador_sancion) VALUES ((SELECT PK_idPartido FROM tbl_partido_detalle WHERE PK_idEquipo="+ nombreequipo[0] +")'" +nombrejugador[0]+"','"+nombresancion[0]+"','"+("(SELECT descripcion_sancion from tbl_sanciones WHERE PK_idSancion="+nombresancion[0]+")")+"',1)", nueva.conectar());
                    sql.ExecuteNonQuery();
                    sql.Connection.Close();
                    x = false;
                }
                catch (OdbcException er)
                {
                    MessageBox.Show(er.Message);
                }

                if (x == false)
                {
                    MessageBox.Show("Sanciones asignadas Correctamente");


                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.codigo_usuarioparabitacora, "Asignó Sanción a Jugador", "tbl_sanciones", frm_login.IP[2].ToString());
                }
            }

            catch (Exception er)

            {
                MessageBox.Show
                       (er.Message);
            }*/





        }
        void llenarComboBoxJornadas()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_jornada from tbl_jornadas WHERE estado_jornada=1", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_jornadas.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void Cbo_jugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Dgv_sanciones.Rows.RemoveAt(Dgv_sanciones.CurrentRow.Index);
        }

        private void Btn_finalizar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Dgv_sanciones.Rows)
            {
                try
                {
                    if (row.Cells[0].Value != null)
                    {
                        try
                        {

                            OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_jugadores_sanciones(PK_idPartido, PK_idJugador, PK_idSancion, PK_idJornada, motivo_sancion, estado_jugador_sancion) VALUES ((SELECT MIN(PK_idPartido) FROM tbl_partido_encabezado), '"+Convert.ToString(row.Cells[0].Value)+"', '"+Convert.ToString(row.Cells[2].Value)+"', '"+Convert.ToString(row.Cells[4].Value)+"', '"+Convert.ToString(row.Cells[3].Value)+"', 1)", nueva.conectar());
                            sql.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }

            MessageBox.Show("Sanciones Asignadas Exitosamente");
            Cbo_equipos.Text = "";
            Cbo_jugadores.Text = "";
            Cbo_jornadas.Text = "";
            Cbo_sanciones.Text = "";
            Txt_motivo.Text = "";
            Dgv_sanciones.Rows.Clear();
            //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
            Bitacora.CrearBitacoraMantenimiento(frm_login.codigo_usuarioparabitacora, "Asignó Sanción a Jugador", "tbl_sanciones", frm_login.IP[2].ToString());
        }

        private void Cbo_equipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbo_jugadores.DataSource = null;
            Cbo_jugadores.Items.Clear();
            Cbo_jugadores.Text = " ";
            controlDeJugadores();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\" + "ayudasanciones.chm", "control_de_sanciones.html");
        }
    }
}
