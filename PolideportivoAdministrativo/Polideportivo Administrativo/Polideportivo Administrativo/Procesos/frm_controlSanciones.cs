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
            llenarComboBoxJugador();
            llenarComboBoxSanciones();
            llenarDataGrid();
        }

        void llenarComboBoxEquipos()
        {

            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT PK_idEquipo, nombre_equipo FROM tbl_equipos WHERE estado_equipo = 1", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_equipos.Items.Add(almacena.GetValue(0)+" "+ almacena.GetValue(1));
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

        void llenarComboBoxJugador()
        {

            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT PK_idJugador,nombre_jugador,apellido_jugador FROM tbl_jugadores WHERE estado_jugador= 1", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_jugadores.Items.Add(almacena.GetValue(0) + " "+almacena.GetValue(1)+" "+ almacena.GetValue(2));
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //========================================================================

        void llenarComboBoxSanciones()
        {

            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT PK_idSancion, nombre_sancion FROM tbl_sanciones WHERE estado_sancion = 1", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_sanciones.Items.Add(almacena.GetValue(0)+" "+ almacena.GetValue(1));
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //==========================================================================

        void llenarDataGrid()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT * FROM tbl_jugadores_sanciones WHERE estado_jugador_sancion = 1", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(Dgv_sanciones);

                    filas.Cells[0].Value = almacena.GetString(0);
                    filas.Cells[1].Value = almacena.GetString(1);
                    filas.Cells[2].Value = almacena.GetString(2);
                    filas.Cells[3].Value = almacena.GetString(3);
                    filas.Cells[4].Value = almacena.GetString(4);
                    filas.Cells[5].Value = almacena.GetString(5);

                    Dgv_sanciones.Rows.Add(filas);
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

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            bool x = true;
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

                 
                    //NO Jala ID PARTIDO .
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
            }





        }

        private void Cbo_jugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            bool x = true;
            try
            {
                
                Dgv_sanciones.Rows.RemoveAt(Dgv_sanciones.CurrentRow.Index);

                string IDPartido = Dgv_sanciones.SelectedRows[0].ToString();

                string IDjugador = Dgv_sanciones.SelectedRows[1].ToString();
               
                string IDSancion = Dgv_sanciones.SelectedRows[2].ToString();

                try
                {
                   
                    //Eliminar de BD con los datos de fila marcada
                    OdbcCommand sql = new OdbcCommand("DELETE FROM tbl_jugadores_sanciones WHERE PK_idPartido="+IDPartido+" AND PK_idJugador="+IDjugador+" AND PK_idSancion="+IDSancion,nueva.conectar());
                    sql.ExecuteNonQuery();
                    sql.Connection.Close();
                    x = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La tabla de Sanciones esta vacia");
               
            }


            if (x == false)
            {
                MessageBox.Show("Sancion eliminadas Correctamente");


                //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Eliminó Sanción a Jugador", "tbl_sanciones", frm_login.IP[2].ToString());
            }
        }

        private void Btn_finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
