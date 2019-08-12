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
    public partial class frm_controlResultados : Form
    {
        conexion nueva = new conexion();
        public frm_controlResultados()
        {
            //Autor: Allan Letona
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        void llenarComboBoxCampeonatos()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_campeonato from tbl_campeonatos WHERE estado_campeonato = 1", nueva.conectar());
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

        void llenarComboBoxEquipos(string sCodigoCampeonato)
        {

            
            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT E.nombre_equipo FROM tbl_equipos E INNER JOIN tbl_campeonatos_equipos CE ON E.PK_idEquipo = CE.PK_idEquipo INNER JOIN tbl_campeonatos C ON CE.PK_idCampeonato = C.PK_idCampeonato WHERE C.PK_idCampeonato = '"+sCodigoCampeonato+"'" , nueva.conectar());
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

        void llenarComboBoxJugadores(string sCodigoEquipo)
        {


            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT J.nombre_jugador, J.apellido_jugador FROM tbl_jugadores J INNER JOIN tbl_equipos_jugadores EJ ON J.PK_idJugador = EJ.PK_idJugador INNER JOIN tbl_equipos E ON EJ.PK_idEquipo = E.PK_idEquipo WHERE E.PK_idEquipo = '"+sCodigoEquipo+"'", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_jugador.Items.Add(almacena.GetValue(0) +" "+ almacena.GetValue(1));
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

        string scodigoCampeonato = " ";

        void controlDeEquipos()
        {
            
            bool bValidacionCampeonato = false;

            if (Cbo_campeonatos.SelectedItem != null)
            {
                string sNombreCampeonato = Cbo_campeonatos.SelectedItem.ToString();

                //consulta el codigo del campeonato obteniendo el texto del combobox con el nombre del deporte
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

            llenarComboBoxEquipos(scodigoCampeonato);

        }


        string scodigoJornada = " ";
        void controlDeJornadas()
        {
            
            bool bValidacionJornada = false;

            if (Cbo_jornada.SelectedItem != null)
            {
                string sNombreJornada = Cbo_jornada.SelectedItem.ToString();

                //consulta el codigo del campeonato obteniendo el texto del combobox con el nombre del deporte
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
                OdbcCommand sql = new OdbcCommand("SELECT PE.PK_idPartido, E.nombre_equipo, PD.puntos FROM tbl_partido_encabezado PE INNER JOIN tbl_partido_detalle PD ON PE.PK_idPartido = PD.PK_idPartido INNER JOIN tbl_equipos E ON PD.PK_idEquipo = E.PK_idEquipo WHERE PE.PK_idJornada = '"+sCodigoJornada+"' AND PE.PK_idCampeonato = '"+scodigoCampeonato+ "' ORDER BY PE.PK_idPartido", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(Dgv_resultados);

                    filas.Cells[0].Value = almacena.GetString(0);
                    filas.Cells[1].Value = almacena.GetString(1);

                    try
                    {
                        if(almacena.GetString(2) != null)
                        {
                            filas.Cells[2].Value = almacena.GetString(2);
                        }
                    }catch(Exception ex)
                    {
                        filas.Cells[2].Value = " ";
                    }

                    Dgv_resultados.Rows.Add(filas);

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
       
              

        private void frm_controlResultados_Load(object sender, EventArgs e)
        {
            llenarComboBoxDeportes();
            llenarComboBoxJornadas();
        }

        private void Cbo_deportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbo_campeonatos.DataSource = null;
            Cbo_campeonatos.Items.Clear();
            Cbo_campeonatos.Text = " ";
            controlDeComboBox();

        }

        private void Cbo_campeonatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbo_equipos.DataSource = null;
            Cbo_equipos.Items.Clear();
            Cbo_equipos.Text = " ";
            controlDeEquipos();
        }

        private void Cbo_jornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dgv_resultados.Rows.Clear();
            controlDeJornadas();
        }

        bool validacionColumnaGoles()
        {
            bool encontrado = false;

            foreach (DataGridViewRow row in Dgv_resultados.Rows)
            {
                try
                {
                    string validar = Convert.ToString(row.Cells[2].Value);
                    if (row.Cells[0].Value != null)
                    {
                        if (Convert.ToString(row.Cells[2].Value) == " ")
                        {
                            encontrado = true;
                            row.Cells[2].Style.BackColor = Color.OrangeRed;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
            return encontrado;
        }

        void limpiarForm()
        {
            Txt_goles.Clear();
            Cbo_jugador.Items.Clear();
            Cbo_jugador.Text = " ";
            Cbo_campeonatos.Items.Clear();
            Cbo_campeonatos.Text = " ";
            Cbo_deportes.Text = " ";
            Cbo_equipos.Items.Clear();
            Cbo_equipos.Text = " ";
            Cbo_jornada.Text = " ";
            Dgv_goles.Rows.Clear();
            Dgv_resultados.Rows.Clear();
        }

        string sCodigoDePartido = "";
        string sResultado = "";

        private void Btn_Finalizar_Click(object sender, EventArgs e)
        {

            if (validacionColumnaGoles())
            {
                MessageBox.Show("Debe ingresar goles o puntos");
            }
            else
            {
                if (Dgv_resultados.Rows.Count > 0)
                {

                    try
                    {
                        List<int> lResultados = new List<int>();
                        int iPar = 0, iResultado1 = 0, iResultado2 = 0, iContador = 0;

                        foreach (DataGridViewRow row in Dgv_resultados.Rows)
                        {
                            if (iPar == 0)
                            {
                                iPar = 1;
                                iResultado1 = int.Parse(Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                iResultado2 = int.Parse(Convert.ToString(row.Cells[2].Value));

                                iPar = 0;

                                if (iResultado1 > iResultado2)
                                {
                                    lResultados.Add(3);
                                    lResultados.Add(0);
                                }
                                else if (iResultado1 < iResultado2)
                                {
                                    lResultados.Add(0);
                                    lResultados.Add(3);
                                }
                                else if (iResultado1 == iResultado2)
                                {
                                    lResultados.Add(1);
                                    lResultados.Add(1);
                                }
                            }
                        }

                        foreach (DataGridViewRow row in Dgv_resultados.Rows)
                        {
                            try
                            {

                                if (row.Cells[0].Value != null)
                                {
                                    string sNombreDeEquipo = Convert.ToString(row.Cells[1].Value);
                                    string sCodigoDeEquipo = "";
                                    try
                                    {

                                        OdbcCommand sqlEquipo = new OdbcCommand("Select PK_idEquipo from tbl_equipos where nombre_equipo = '" + sNombreDeEquipo + "'", nueva.conectar());
                                        OdbcDataReader almacena = sqlEquipo.ExecuteReader();
                                        while (almacena.Read() == true)
                                        {

                                            sCodigoDeEquipo = almacena.GetString(0);
                                            OdbcCommand sql = new OdbcCommand("UPDATE tbl_partido_detalle " +
                                                " SET puntos = " + Convert.ToString(row.Cells[2].Value) +
                                                ", puntaje_obtenido = " + lResultados[iContador] +
                                                " WHERE PK_idPartido = '" + Convert.ToInt16(row.Cells[0].Value) + "' AND PK_idEquipo = '" + sCodigoDeEquipo + "'", nueva.conectar());
                                            sql.ExecuteNonQuery();
                                            sql.Connection.Close();

                                        }
                                        almacena.Close();

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
                            iContador++;
                        }

                        try
                        {
                            foreach (DataGridViewRow row in Dgv_resultados.Rows)
                            {
                                try
                                {

                                    string sResultadoPartido = "";
                                    if (row.Cells[0].Value != null)
                                    {
                                        sCodigoDePartido = Convert.ToString(row.Cells[0].Value);
                                        OdbcCommand sqlEquipo = new OdbcCommand("SELECT GROUP_CONCAT(PD.puntos SEPARATOR '-') as puntos FROM tbl_partido_detalle PD INNER JOIN tbl_partido_encabezado PE ON PD.PK_idPartido = PE.PK_idPartido WHERE PE.PK_idPartido = '" + sCodigoDePartido + "'", nueva.conectar());
                                        OdbcDataReader almacena = sqlEquipo.ExecuteReader();
                                        while (almacena.Read() == true)
                                        {

                                            sResultadoPartido = almacena.GetString(0);
                                            OdbcCommand sql = new OdbcCommand("UPDATE tbl_partido_encabezado SET resultado_partido = '" + sResultadoPartido + "' WHERE PK_idPartido = '" + sCodigoDePartido + "' AND PK_idJornada = '" + scodigoJornada + "' ", nueva.conectar());
                                            sql.ExecuteNonQuery();
                                            nueva.cerrarConexion();

                                        }
                                        almacena.Close();
                                    }
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



                        MessageBox.Show("Resultados Almacenados Exitosamente");
                        //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                        Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Control de Resultados", "tbl_partido_encabezado", frm_login.IP[2].ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                    foreach (DataGridViewRow row in Dgv_goles.Rows)
                    {
                        try
                        {

                            if (row.Cells[0].Value != null)
                            {

                                OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_estadistica_jugadores(PK_idJugador, PK_idPartido, PK_idCampeonato, goles_puntos, PK_idJornada) VALUES ('" + Convert.ToString(row.Cells[0].Value) + "', '" + scodigoJornada + "', '" + scodigoCampeonato + "', '" + Convert.ToString(row.Cells[2].Value) + "' , '" + scodigoJornada + "') ", nueva.conectar());
                                sql.ExecuteNonQuery();
                                sql.Connection.Close();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());

                        }
                    }



                    limpiarForm();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }


        }



        private void Cbo_equipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbo_jugador.DataSource = null;
            Cbo_jugador.Items.Clear();
            Cbo_jugador.Text = " ";
            controlDeJugadores();
        }
        string sCodigoDeJugador = "";
        private void Btn_agrega_Click(object sender, EventArgs e)
        {
            string sCodigoDeEquipo = "";
            if (Cbo_jugador.SelectedItem != null && Cbo_equipos.SelectedItem != null)
            {
                string sNombreJugador = Cbo_jugador.SelectedItem.ToString();
                string sNombreEquipo = Cbo_equipos.SelectedItem.ToString();

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
                    OdbcCommand sql1 = new OdbcCommand("SELECT J.PK_idJugador FROM tbl_jugadores J INNER JOIN tbl_equipos_jugadores EP ON J.PK_idJugador = EP.PK_idJugador WHERE ((SELECT (nombre_jugador&apellido_jugador) AS nombre) = '"+sNombreJugador+"') AND EP.PK_idEquipo = '"+sCodigoDeEquipo+"'", nueva.conectar());
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
            }

            DataGridViewRow filas = new DataGridViewRow();
            filas.CreateCells(Dgv_goles);

            filas.Cells[0].Value = sCodigoDeJugador;
            filas.Cells[1].Value = Cbo_jugador.SelectedItem;
            filas.Cells[2].Value = Txt_goles.Text;

            Dgv_goles.Rows.Add(filas);
            Txt_goles.Clear();

        }

        private void Gpb_datosPartido_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_deporte_Click(object sender, EventArgs e)
        {

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Dgv_goles.Rows.RemoveAt(Dgv_goles.CurrentRow.Index);
        }

        private void Txt_goles_TextChanged(object sender, EventArgs e)
        {
            
                
            
        }

        private void Txt_goles_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\" + "ayudaresultados.chm", "control_resultados.html");
        }
    }
}
