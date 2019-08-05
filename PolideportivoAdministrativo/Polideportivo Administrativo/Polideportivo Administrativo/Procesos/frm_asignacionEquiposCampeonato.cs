using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Polideportivo_Administrativo.Procesos
{
    public partial class frm_asignacionEquiposCampeonato : Form
    {
        conexion nueva = new conexion();

        public frm_asignacionEquiposCampeonato()
        {

            //Autor: Allan Letona
            InitializeComponent();
        }


        void llenarComboBoxDeportes()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_deporte from tbl_deportes WHERE estado_deporte = 1", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_deportes.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        void llenarComboBoxCampeonatos(string sCodigoDeporte)
        {

            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_campeonato from tbl_campeonatos WHERE FK_idDeporte = '" + sCodigoDeporte + "' AND estado_campeonato = 1", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_campeonatos.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void controlDeComboBoxDeportes()
        {
            string scodigoTipoDeporte = "";

            bool bValidacionTipoDeporte = false;

            if (Cbo_deportes.SelectedItem != null)
            {
                string snombreTipoDeporte = Cbo_deportes.SelectedItem.ToString();

                //consulta el codigo del tipo del deporte obteniendo el texto del combobox con el nombre del tipo de deporte
                try
                {

                    OdbcCommand sql = new OdbcCommand("Select PK_idDeporte from tbl_deportes where nombre_deporte = '" + snombreTipoDeporte + "'", nueva.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {

                        scodigoTipoDeporte = almacena.GetString(0);

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
                bValidacionTipoDeporte = true;
            }

            llenarComboBoxCampeonatos(scodigoTipoDeporte);


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


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_asignacionEquiposCampeonato_Load(object sender, EventArgs e)
        {
            llenarComboBoxDeportes();
            llenarComboBoxEquipos();
        }

        private void Btn_ingresarEquipo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ingresarEquipo_Click_1(object sender, EventArgs e)
        {
            string sCodigoDeEquipo = "";
            string sCodigoCampeonato = "";

            if (Cbo_campeonatos.SelectedItem != null && Cbo_equipos.SelectedItem != null)
            {
                string sNombreCampeonato = Cbo_campeonatos.SelectedItem.ToString();
                string sNombreEquipo = Cbo_equipos.SelectedItem.ToString();


                try
                {

                    OdbcCommand sql = new OdbcCommand("SELECT PK_idCampeonato FROM tbl_campeonatos WHERE nombre_campeonato = '" + sNombreCampeonato + "'", nueva.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {

                        sCodigoCampeonato = almacena.GetString(0);

                    }
                    almacena.Close();
                    sql.Connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                try
                {

                    OdbcCommand sql = new OdbcCommand("SELECT PK_idEquipo FROM tbl_equipos WHERE nombre_equipo = '" + sNombreEquipo + "'", nueva.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {

                        sCodigoDeEquipo = almacena.GetString(0);

                    }
                    almacena.Close();
                    sql.Connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                DataGridViewRow filas = new DataGridViewRow();
                filas.CreateCells(Dgv_asignacion);

                filas.Cells[0].Value = sCodigoCampeonato;
                filas.Cells[1].Value = Cbo_campeonatos.SelectedItem;
                filas.Cells[2].Value = sCodigoDeEquipo;
                filas.Cells[3].Value = Cbo_equipos.SelectedItem;

                Dgv_asignacion.Rows.Add(filas);
            }

            
        }

        private void Cbo_deportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbo_campeonatos.DataSource = null;
            Cbo_campeonatos.Items.Clear();
            Cbo_campeonatos.Text = " ";
            controlDeComboBoxDeportes();
        }

        private void Btn_eliminarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                Dgv_asignacion.Rows.RemoveAt(Dgv_asignacion.CurrentRow.Index);
            }
            catch(Exception ex)
            {
                MessageBox.Show("La tabla esta vacia");
                //MessageBox.Show(ex.ToString());
            }
            
        }

        void limpiarForm()
        {
      
            Cbo_campeonatos.Items.Clear();
            Cbo_campeonatos.Text = " ";
            Cbo_deportes.Text = " ";
            Cbo_equipos.Text = " ";
            Dgv_asignacion.Rows.Clear();

        }

        private void Btn_finalizarAsignacion_Click(object sender, EventArgs e)
        {
            if (Dgv_asignacion.Rows.Count > 0)
            {

                try
                {
                    foreach (DataGridViewRow row in Dgv_asignacion.Rows)
                    {
                        try
                        {

                            if (row.Cells[0].Value != null)
                            {
                               
                                try
                                {
                       
                                 OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_campeonatos_equipos(PK_idCampeonato, PK_idEquipo) VALUES ('"+Convert.ToString(row.Cells[0].Value)+"', '"+Convert.ToString(row.Cells[2].Value)+"' )", nueva.conectar());
                                 sql.ExecuteNonQuery();
                                    sql.Connection.Close();

                         
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

                    MessageBox.Show("Equipos Asignados Correctamente");
                    limpiarForm();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Asignó Equipos a Campeonato", "tbl_campeonatos_equipos", frm_login.IP[2].ToString());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
