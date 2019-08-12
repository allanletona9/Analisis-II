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

    public partial class frm_goleadores : Form
    {
        conexion nueva = new conexion();
        string nombreequipo = "";
        string nombrejugador = "";




        public frm_goleadores()
        {
            InitializeComponent();
            llenarComboBoxEquipos();
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


        

        //======================================================================

        void llenarComboBoxJugadores(string sCodigoEquipo)
        {


            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT J.nombre_jugador, J.apellido_jugador FROM tbl_jugadores J INNER JOIN tbl_equipos_jugadores EJ ON J.PK_idJugador = EJ.PK_idJugador INNER JOIN tbl_equipos E ON EJ.PK_idEquipo = E.PK_idEquipo WHERE E.PK_idEquipo = '" + sCodigoEquipo + "'", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_jugadores.Items.Add(almacena.GetValue(0) + " " + almacena.GetValue(1));
                    //Cbo_jugador.Items.Add(almacena.GetValue(1));
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



        //==========================================================================

        void llenarDataGrid()
        {

            {
                OdbcDataAdapter dat;
                DataSet ds;

                try
                {

                    ds = new DataSet();
                    dat = new OdbcDataAdapter("SELECT * FROM tbl_estadistica_jugadores WHERE goles_puntos>0", nueva.conectar());
                    dat.Fill(ds);
                    Dgv_goleadores.DataSource = ds.Tables[0];
                }
                catch (OdbcException er)
                {
                    MessageBox.Show(er.Message);
                }

            }


        }
        

        void controlDeJugadoresGoles()
        {
            string sCodigoDeJugador = "";
            bool bValidacionJornada = false;

            if (Cbo_jugadores.SelectedItem != null)
            {
                string sNombreJugador = Cbo_jugadores.SelectedItem.ToString();

                //consulta el codigo del campeonato obteniendo el texto del combobox con el nombre del deporte
                try
                {
                    OdbcCommand sql = new OdbcCommand("SELECT PK_idJugador FROM tbl_jugadores WHERE concat(nombre_jugador, ' ', apellido_jugador) = '" + sNombreJugador + "'", nueva.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {

                        sCodigoDeJugador = almacena.GetString(0);

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
                bValidacionJornada = true;
            }

            llenarGridGoles(sCodigoDeJugador);


        }

        void llenarGridGoles(string scodigoJugador)
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT J.PK_idJugador, J.nombre_jugador, J.apellido_jugador, SUM(EJ.goles_puntos) FROM tbl_estadistica_jugadores EJ INNER JOIN tbl_jugadores J ON EJ.PK_idJugador = J.PK_idJugador WHERE J.PK_idJugador = '"+scodigoJugador+"'", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(Dgv_goleadores);

                    filas.Cells[0].Value = almacena.GetString(0);
                    filas.Cells[1].Value = almacena.GetString(1);
                    filas.Cells[2].Value = almacena.GetString(2);

                    try
                    {
                        if(almacena.GetString(3) != null)
                        {
                            filas.Cells[3].Value = almacena.GetString(3);
                        }
                        
                    }
                    catch(Exception e)
                    {
                        filas.Cells[3].Value = "No tiene goles anotados";
                    }
                    

                   
                    Dgv_goleadores.Rows.Add(filas);

                }


                almacena.Close();
                sql.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
           




        }

        private void Btn_nuevaConsulta_Click(object sender, EventArgs e)
        {
            llenarDataGrid();
            Cbo_equipos.Text = "Elija equipo";
            Cbo_jugadores.Text = "Elija Jugador";
        }

        private void Btn_salir_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Cbo_deportes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Cbo_equipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbo_jugadores.DataSource = null;
            Cbo_jugadores.Items.Clear();
            Cbo_jugadores.Text = " ";
            controlDeJugadores();
        }

        private void Cbo_jugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dgv_goleadores.Rows.Clear();
            controlDeJugadoresGoles();
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\" + "ayudagoleadores.chm", "goleadores.html");
        }
    }
    }


