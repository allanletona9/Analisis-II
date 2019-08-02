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
            llenarComboBoxJugador();
            llenarDataGrid();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //======================================================================

        void llenarComboBoxJugador()
        {


            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT PK_IdJugador, nombre_jugador, apellido_jugador FROM tbl_jugadores WHERE estado_jugador= 1", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_jugadores.Items.Add(almacena.GetValue(0) + " " + almacena.GetValue(1) + " " + almacena.GetValue(2));
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            try { 

            nombrejugador = Cbo_jugadores.SelectedItem.ToString();
            string[] nombreseparadojugador;
            nombreseparadojugador = nombrejugador.Split(' ');
                //nombreseparado[0]=IDJugador

               
                    OdbcDataAdapter dat;
                    DataSet ds;

                    try
                    {

                        ds = new DataSet();
                        dat = new OdbcDataAdapter("SELECT * FROM tbl_estadistica_jugadores WHERE PK_idJugador=" + nombreseparadojugador[0], nueva.conectar());
                        dat.Fill(ds);
                        Dgv_goleadores.DataSource = ds.Tables[0];
                    }
                    catch (OdbcException er)
                    {
                        MessageBox.Show(er.Message);
                    }

                }

                    catch(Exception er)

            {
                         MessageBox.Show
                                (er.Message);
                      }




            }

        private void Btn_nuevaConsulta_Click(object sender, EventArgs e)
        {
            llenarDataGrid();
            Cbo_equipos.Text = "Elija equipo";
            Cbo_jugadores.Text = "Elija Jugador";
        }
    }
    }


