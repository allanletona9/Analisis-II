using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;


namespace Polideportivo_Administrativo.Procesos
{
    public partial class frm_nuevoCalendario : Form
    {

        List<int> lIdDeporte = new List<int>();
        List<int> lIdCampeonato = new List<int>();
        List<int> lIdCampo = new List<int>();
        List<int> lidEquipoLocal = new List<int>();
        List<int> lIdEquipoVisitante = new List<int>();
        List<int> lIdJornada = new List<int>();


        public frm_nuevoCalendario()
        {
            //Autor: Allan Letona
            InitializeComponent();
            Rdb_manual.Checked = true;
            llenarComboBoxDeporte();
            llenarJornada();
            llenarDataGrid();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_nuevoCalendario_Load(object sender, EventArgs e)
        {

        }

        private void Rdb_manual_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_manual.Checked == true)

                desbloquearControles();
            else
                bloquearControles();

        }

        private void Rdb_automatico_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_manual.Checked == true)
                desbloquearControles();
            else
                bloquearControles();

        }

        private void bloquearControles()
        {
            Cbo_deporte.Enabled = true;
            Cbo_deporte.Enabled = true;
            Cbo_campos.Enabled = false;
            Btn_agregar.Enabled = false;
            Cbo_equiposLocales.Enabled = false;
            Cbo_equiposVisitantes.Enabled = false;
            Cbo_jornadas.Enabled = false;
            Btn_generarAutomatico.Enabled = true;
            Dgv_jornada.Enabled = false;
            Dtp_fecha.Enabled = false;
            Dtp_hora.Enabled = false;
        }

        private void desbloquearControles()
        {
            Cbo_deporte.Enabled = true;
            Cbo_deporte.Enabled = true;
            Cbo_campos.Enabled = true;
            Btn_agregar.Enabled = true;
            Cbo_equiposLocales.Enabled = true;
            Cbo_equiposVisitantes.Enabled = true;
            Cbo_jornadas.Enabled = true;
            Btn_generarAutomatico.Enabled = false;
            Dgv_jornada.Enabled = false;
            Dtp_fecha.Enabled = true;
            Dtp_hora.Enabled = true;

        }

        private void llenarCampeonatos()
        {
            lIdCampeonato.Clear();
            Cbo_campeonatos.Items.Clear();
            OdbcCommand sql = new OdbcCommand("Select PK_idCampeonato, nombre_campeonato from tbl_campeonatos WHERE estado_campeonato=1 "
                + "AND FK_idDeporte=" + lIdDeporte[Cbo_deporte.SelectedIndex], conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Cbo_campeonatos.Items.Add(almacena.GetInt32(0) + " - " + almacena.GetString(1));
                lIdCampeonato.Add(almacena.GetInt32(0));
            }
            almacena.Close();

            if (lIdCampeonato.Count > 0)
            {
                Cbo_campeonatos.SelectedIndex = 0;
                llenarEquipoLocal();
                llenarEquipoVisitante();
            }else
            {
                Cbo_campeonatos.Text = "";
            }

        }

        private void llenarComboBoxDeporte()
        {
            lIdDeporte.Clear();
            Cbo_deporte.Items.Clear();

            OdbcCommand sql = new OdbcCommand("Select PK_idDeporte, nombre_deporte from tbl_deportes WHERE estado_deporte=1", conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Cbo_deporte.Items.Add(almacena.GetInt32(0) + " - " + almacena.GetString(1));
                lIdDeporte.Add(almacena.GetInt32(0));
            }
            almacena.Close();

            if (lIdDeporte.Count > 0)
            {
                Cbo_deporte.SelectedIndex = 0;
                llenarCampeonatos();
            }
            else
            {
                Cbo_deporte.Text = "";
            }
        }

        private void llenarCampos()
        {
            lIdCampo.Clear();
            Cbo_campos.Items.Clear();

            OdbcCommand sql = new OdbcCommand("Select PK_idCampo, nombre_campo from tbl_campo WHERE estado_campo=1 "
                + "AND FK_idDeporte =" + lIdDeporte[Cbo_deporte.SelectedIndex], conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Cbo_campos.Items.Add(almacena.GetInt32(0) + " - " + almacena.GetString(1));
                lIdCampo.Add(almacena.GetInt32(0));
            }
            almacena.Close();


            if (lIdCampo.Count > 0)
            {
                Cbo_campos.SelectedIndex = 0;
            }
            else
            {
                Cbo_campos.Text = "";
            }
        }

        private void llenarEquipoLocal()
        {
            lidEquipoLocal.Clear();
            Cbo_equiposLocales.Items.Clear();

            OdbcCommand sql = new OdbcCommand("SELECT PK_idEquipo, (SELECT tbl_equipos.nombre_equipo FROM tbl_equipos WHERE tbl_equipos.PK_idEquipo = tbl_campeonatos_equipos.PK_idEquipo AND estado_equipo=1) FROM tbl_campeonatos_equipos WHERE "
                + " PK_idCampeonato =" + lIdCampeonato[Cbo_campeonatos.SelectedIndex], conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Cbo_equiposLocales.Items.Add(almacena.GetInt32(0)+ " - " + almacena.GetString(1));
                lidEquipoLocal.Add(almacena.GetInt32(0));
            }
            almacena.Close();

            if (lidEquipoLocal.Count > 0)
            {
                Cbo_equiposLocales.SelectedIndex = 0;
            }
            else
            {
                Cbo_equiposLocales.Text="";
            }
        }

        private void llenarEquipoVisitante()
        {
            lIdEquipoVisitante.Clear();
            Cbo_equiposVisitantes.Items.Clear();

            OdbcCommand sql = new OdbcCommand("SELECT PK_idEquipo, (SELECT tbl_equipos.nombre_equipo FROM tbl_equipos WHERE tbl_equipos.PK_idEquipo = tbl_campeonatos_equipos.PK_idEquipo AND estado_equipo=1) FROM tbl_campeonatos_equipos WHERE "
                + " PK_idCampeonato =" + lIdCampeonato[Cbo_campeonatos.SelectedIndex], conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Cbo_equiposVisitantes.Items.Add(almacena.GetInt32(0) + " - " + almacena.GetString(1));
                lIdEquipoVisitante.Add(almacena.GetInt32(0));
            }
            almacena.Close();

            if (lIdEquipoVisitante.Count > 0)
            {
                Cbo_equiposVisitantes.SelectedIndex = 0;
            }else
            {
                Cbo_equiposVisitantes.Text = "";
            }
        }

        private void llenarJornada()
        {
            lIdJornada.Clear();
            Cbo_jornadas.Items.Clear();

            OdbcCommand sql = new OdbcCommand("Select PK_idJornada, nombre_jornada from tbl_jornadas WHERE estado_jornada=1", conexion.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Cbo_jornadas.Items.Add(almacena.GetInt32(0) + " - " + almacena.GetString(1));
                lIdJornada.Add(almacena.GetInt32(0));
            }
            almacena.Close();

            if (lIdJornada.Count > 0)
            {
                Cbo_jornadas.SelectedIndex = 0;
                llenarCampeonatos();
            }else
            {
                Cbo_jornadas.Text = "";
            }

        }

        private bool verificarEquipoLocal()
        {

            OdbcCommand sql = new OdbcCommand("SELECT tbl_partido_encabezado.PK_idPartido FROM tbl_partido_encabezado INNER JOIN tbl_partido_detalle ON tbl_partido_encabezado.PK_idPartido = tbl_partido_detalle.PK_idPartido WHERE "
           + " tbl_partido_encabezado.PK_idCampeonato  =" + lIdCampeonato[Cbo_campeonatos.SelectedIndex] + " AND "
           + " tbl_partido_encabezado.PK_idJornada  =" + lIdJornada[Cbo_jornadas.SelectedIndex] + " AND "
           + " tbl_partido_detalle.PK_idEquipo  =" + lidEquipoLocal[Cbo_equiposLocales.SelectedIndex]
           , conexion.conectar());
            OdbcDataReader reader = sql.ExecuteReader();

            if (reader.HasRows)
                return true;

            reader.Close();

            return false;
        }

        private bool verificarEquipoVisitante()
        {

            OdbcCommand sql = new OdbcCommand("SELECT tbl_partido_encabezado.PK_idPartido FROM tbl_partido_encabezado INNER JOIN tbl_partido_detalle ON tbl_partido_encabezado.PK_idPartido = tbl_partido_detalle.PK_idPartido WHERE "
           + " tbl_partido_encabezado.PK_idCampeonato  =" + lIdCampeonato[Cbo_campeonatos.SelectedIndex] + " AND "
           + " tbl_partido_encabezado.PK_idJornada  =" + lIdJornada[Cbo_jornadas.SelectedIndex] + " AND "
           + " tbl_partido_detalle.PK_idEquipo  =" + lIdEquipoVisitante[Cbo_equiposVisitantes.SelectedIndex]
           , conexion.conectar());
            OdbcDataReader reader = sql.ExecuteReader();

            if (reader.HasRows)
                return true;

            reader.Close();

            return false;
        }

        private bool verificarCampoOcupado()
        {
            OdbcCommand sql = new OdbcCommand("SELECT PK_idPartido FROM tbl_partido_encabezado WHERE "
                    + " FK_idCampo  =" + lIdCampo[Cbo_campos.SelectedIndex] + " AND "
                    + " fecha_partido  ='" + Dtp_fecha.Text + "' AND "
                    + " hora_partido  ='" + Dtp_hora.Text + "'"
                    , conexion.conectar());
            OdbcDataReader reader = sql.ExecuteReader();

            if (reader.HasRows)
                return true;

            reader.Close();

            return false;
        }

        private void llenarDataGrid()
        {

            OdbcDataAdapter dat;
            DataSet ds;
            Dgv_jornada.DataSource = null;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT tbl_partido_encabezado.PK_idPartido as Codigo, (SELECT tbl_campo.nombre_campo FROM tbl_campo WHERE tbl_campo.PK_idCampo = tbl_partido_encabezado.FK_idCampo) as Campo, tbl_partido_encabezado.fecha_partido" +
                    " as Fecha, tbl_partido_encabezado.hora_partido as Hora, (SELECT tbl_equipos.nombre_equipo FROM tbl_equipos WHERE tbl_equipos.PK_idEquipo = tbl_partido_detalle.PK_idEquipo) as Equipo FROM tbl_partido_encabezado INNER JOIN tbl_partido_detalle " +
                    "ON tbl_partido_encabezado.PK_idPartido = tbl_partido_detalle.PK_idPartido WHERE " +
                    "tbl_partido_encabezado.PK_idCampeonato =" + lIdCampeonato[Cbo_campeonatos.SelectedIndex] + " AND " +
                    "tbl_partido_encabezado.PK_idJornada =" + lIdJornada[Cbo_jornadas.SelectedIndex] + " AND " +
                    "tbl_partido_encabezado.estado_partido = 1"
                , conexion.conectar());
                dat.Fill(ds);
                Dgv_jornada.DataSource = ds.Tables[0];

            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
        }

        private void Cbo_deporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCampeonatos();
            llenarCampos();
            llenarEquipoVisitante();
            llenarEquipoLocal();
            llenarDataGrid();
        }

        private void Cbo_campeonatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarEquipoLocal();
            llenarEquipoVisitante();
            llenarDataGrid();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {

            if (Cbo_equiposLocales.SelectedIndex == Cbo_equiposVisitantes.SelectedIndex)
            {
                MessageBox.Show("No puede colocar a un equipo a jugar contra si mismo", "Error");
            }
            else
            {
                bool bEquipo1, bEquipo2;
                bEquipo1 = verificarEquipoLocal();
                bEquipo2 = verificarEquipoVisitante();

                if (bEquipo1 || bEquipo2)
                {
                    if (bEquipo1)
                        MessageBox.Show("El equipo " + Cbo_equiposLocales.Text + " ya cuenta con un partido programado en este campeonato y jornada", "Error");

                    if (bEquipo2)
                        MessageBox.Show("El equipo " + Cbo_equiposVisitantes.Text + " ya cuenta con un partido programado en este campeonato y jornada", "Error");
                }
                else
                {
                    bool bCampoOcupado;

                    bCampoOcupado = verificarCampoOcupado();

                    if (bCampoOcupado)
                        MessageBox.Show("El campo ya se encuentra ocupado por otro partido", "Error");
                    else
                    {
                        //Insertar partido_encabezado

                        bool ingresoCorrecto = true;
                        try
                        {
                            OdbcCommand cmd = new OdbcCommand();

                            cmd = new OdbcCommand("INSERT INTO tbl_partido_encabezado(PK_idCampeonato, PK_idJornada, FK_idCampo, fecha_partido, hora_partido, estado_partido) VALUES (" +
                            lIdCampeonato[Cbo_campeonatos.SelectedIndex] + " , " +
                            lIdJornada[Cbo_jornadas.SelectedIndex] + " , " +
                            lIdCampo[Cbo_campos.SelectedIndex] + " , '" +
                            Dtp_fecha.Text + "' , '" +
                            Dtp_hora.Text + "' , " +
                            "1" + ")"
                            , conexion.conectar());
                            cmd.ExecuteNonQuery();

                        }
                        catch (OdbcException ex)
                        {
                            MessageBox.Show(ex.Message);
                            ingresoCorrecto = false;
                        }

                        if (ingresoCorrecto)
                        {
                            bool bIngresoCorrectoDetalle = true;
                            int iIdPartido = 0;

                            try
                            {
                                OdbcCommand sql = new OdbcCommand("Select PK_idPartido FROM tbl_partido_encabezado ORDER BY PK_idPartido DESC LIMIT 1"
                           , conexion.conectar());
                                OdbcDataReader almacena = sql.ExecuteReader();
                                while (almacena.Read() == true)
                                {
                                    iIdPartido = almacena.GetInt32(0);
                                }
                                almacena.Close();

                                //Insertar partido_detalle;

                                OdbcCommand cmd = new OdbcCommand("INSERT INTO tbl_partido_detalle(PK_idPartido, PK_idEquipo) VALUES (" +
                                iIdPartido.ToString() + " , " +
                                lidEquipoLocal[Cbo_equiposLocales.SelectedIndex] + ")"
                                , conexion.conectar());
                                cmd.ExecuteNonQuery();

                                cmd = new OdbcCommand("INSERT INTO tbl_partido_detalle(PK_idPartido, PK_idEquipo) VALUES (" +
                                iIdPartido.ToString() + " , " +
                                lIdEquipoVisitante[Cbo_equiposVisitantes.SelectedIndex] + ")"
                                , conexion.conectar());
                                cmd.ExecuteNonQuery();

                            }
                            catch (OdbcException ex)
                            {
                                MessageBox.Show(ex.Message);
                                bIngresoCorrectoDetalle = false;
                            }

                            if (bIngresoCorrectoDetalle)
                                MessageBox.Show("Partido programado correctamente", "Exito");

                        }
                    }
                }
            }

            llenarDataGrid();
        }

        private void Cbo_jornadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarDataGrid();
        }

        private void Btn_programacionFinalizada_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Btn_generarAutomatico_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Generar calendario de manera automatica para el campeonato: " + Cbo_campeonatos.Text + "\nSi ya programo algun partido en modo manual no sera posible utilizar esta opcion.",
                                     "Calendario automatico",
                                     MessageBoxButtons.OKCancel);

            if (confirmResult == DialogResult.OK)
            {
                OdbcCommand sql = new OdbcCommand("SELECT PK_idPartido FROM tbl_partido_encabezado WHERE "
                   + " PK_idCampeonato  =" + lIdCampeonato[Cbo_campeonatos.SelectedIndex]
                   , conexion.conectar());
                OdbcDataReader reader = sql.ExecuteReader();

                if (reader.HasRows)
                    MessageBox.Show("Ya existe un calendario programado para este campeonato", "Error");
                else
                {
                    if(Cbo_campeonatos.Text == "" || lidEquipoLocal.Count == 0 || lIdCampo.Count == 0)
                    {
                        if (Cbo_campeonatos.Text == "")
                            MessageBox.Show("Debe seleccionar un campeonato para continuar", "Error");

                        if (lidEquipoLocal.Count == 0)
                            MessageBox.Show("No hay equipos asignados a este campeonato", "Error");

                        if (lIdCampo.Count == 0)
                            MessageBox.Show("No existen campos disponibles", "Error");
                    }
                
                    else
                    {
                        frm_nuevoCalendarioAutomatico nuevoCalendarioAutomatico = new frm_nuevoCalendarioAutomatico(lIdCampeonato[Cbo_campeonatos.SelectedIndex].ToString(), lidEquipoLocal, lIdCampo);
                        nuevoCalendarioAutomatico.Show();
                    }       
                }

                reader.Close();
            }
        }
    }
}
