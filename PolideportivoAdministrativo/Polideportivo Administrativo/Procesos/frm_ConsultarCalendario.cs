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
using System.Data.SqlClient;
using System.Net;
using System.Net.NetworkInformation;

namespace Polideportivo_Administrativo.Procesos
{
    public partial class frm_ConsultarCalendario : Form
    {
        conexion nueva = new conexion();
        OdbcCommand cmd;

        List<int> lIdDeporte = new List<int>();
        List<int> lIdCampeonato = new List<int>();
        List<int> lidEquipoLocal = new List<int>();

        public frm_ConsultarCalendario()
        {
            //Autor: Alejandro Barreda
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ConsultarCalendario_Load(object sender, EventArgs e)
        {
            llenarComboBoxDeporte();
            llenarComboBoxJornadas();
        }

        private void Cbo_campeonato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        //Autor Diego Gomez
        void llenarComboBoxDeporte()
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
                    Cbo_campeonato.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void controlDeComboBox()
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

        void llenarComboBoxJornadas()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_jornada from tbl_jornadas WHERE estado_jornada=1", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_jornada.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }


        string scodigoCampeonato = " ";

        void controlDeEquipos()
        {

            bool bValidacionCampeonato = false;

            if (Cbo_campeonato.SelectedItem != null)
            {
                string sNombreCampeonato = Cbo_campeonato.SelectedItem.ToString();

                //consulta el codigo del campeonato obteniendo el texto del combobox con el nombre del campeonato
                try
                {

                    
                    OdbcCommand sql = new OdbcCommand("Select PK_idCampeonato from tbl_campeonatos where nombre_campeonato = '" + sNombreCampeonato + "'", nueva.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {

                        scodigoCampeonato = almacena.GetString(0);

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
                bValidacionCampeonato = true;
            }


        }

    
        //Autor Allan Letona

        string scodigoJornada = " ";
        void controlDeJornadas()
        {

            bool bValidacionJornada = false;

            if (Cbo_jornada.SelectedItem != null)
            {
                string sNombreJornada = Cbo_jornada.SelectedItem.ToString();

                //consulta el codigo de la jornada obteniendo el texto del combobox con el nombre de la jornada
                try
                {

                    OdbcCommand sql = new OdbcCommand("Select PK_idJornada from tbl_jornadas where nombre_jornada = '" + sNombreJornada + "'", nueva.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {

                        scodigoJornada = almacena.GetString(0);

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

            llenarGridResultados(scodigoJornada);


        }



        void llenarGridResultados(string sCodigoJornada)
        {
            try
            {

                OdbcCommand sql = new OdbcCommand("SELECT PE.PK_idPartido, C.nombre_campeonato, J.nombre_jornada, PE.fecha_partido , PE.hora_partido , E.nombre_equipo, PE.resultado_partido FROM tbl_partido_encabezado PE INNER JOIN tbl_partido_detalle PD ON PE.PK_idPartido = PD.PK_idPartido INNER JOIN tbl_equipos E ON PD.PK_idEquipo = E.PK_idEquipo INNER JOIN tbl_campeonatos C ON PE.PK_idCampeonato = C.PK_idCampeonato INNER JOIN tbl_jornadas J ON PE.PK_idJornada = J.PK_idJornada WHERE PE.PK_idJornada = '" + sCodigoJornada + "' AND PE.PK_idCampeonato = '" + scodigoCampeonato + "'", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                
                while (almacena.Read() == true)
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(Dgv_calendario);

                    filas.Cells[0].Value = "Partido " + almacena.GetString(0);
                    filas.Cells[1].Value = almacena.GetString(1);
                    filas.Cells[2].Value = almacena.GetString(2);
                    filas.Cells[3].Value = almacena.GetString(3);
                    filas.Cells[4].Value = almacena.GetString(4);
                    filas.Cells[5].Value = almacena.GetString(5);

                    try
                    {
                        if (almacena.GetString(6) != null)
                        {
                            filas.Cells[6].Value = almacena.GetString(6);
                        }
                    }
                    catch (Exception ex)
                    {
                        filas.Cells[6].Value = "No se ha jugado";
                    }

                    Dgv_calendario.Rows.Add(filas);

                }


                almacena.Close();
                sql.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Cbo_jornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dgv_calendario.Rows.Clear();
            controlDeEquipos();
            controlDeJornadas();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            
        }

        private void Cbo_deportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbo_campeonato.DataSource = null;
            Cbo_campeonato.Items.Clear();
            Cbo_campeonato.Text = "";
            controlDeComboBox();
        }

        private void Gpb_consultar_Enter(object sender, EventArgs e)
        {

        }
    }
}
