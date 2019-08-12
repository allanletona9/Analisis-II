using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Data.SqlClient;
using System.Net;

namespace Polideportivo_Administrativo.Mantenimientos
{
    public partial class frm_adminEntrenadores : Form
    {
        conexion nueva = new conexion();
        bool boton_ingreso = false;
        bool boton_modificar = false;
        bool boton_eliminar = false;
        OdbcCommand cmd;
        byte[] ficheroBLOB = null;
        List<int> lIdEquipo = new List<int>();

        public frm_adminEntrenadores()
        {
            //Autor: Eduardo Colon
            InitializeComponent();
            llenarComboBox();
            Rdb_habilitado.Checked = true;
            Btn_guardar.Enabled = false;
        }

        private void llenarComboBox()
        {
            OdbcCommand sql = new OdbcCommand("Select PK_idEquipo, nombre_equipo from tbl_equipos WHERE estado_equipo=1", nueva.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Cbo_equipo.Items.Add(almacena.GetString(1));
                lIdEquipo.Add(almacena.GetInt32(0));
            }
            almacena.Close();
        }

        private void frm_adminEntrenadores_Load(object sender, EventArgs e)
        {
            Txt_codigoEntrenador.Enabled = false;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        void habilitarBotones()
        {
            Txt_codigoEntrenador.Enabled = false;
            Txt_nombreEntrenador.Enabled = true;
            Txt_apellidoEntrenador.Enabled = true;
            Txt_especialidadEntrenador.Enabled = true;
            Cbo_equipo.Enabled = true;
            Gpb_estado.Enabled = true;
        }

        void bloquearBotones()
        {
            Btn_eliminar.Enabled = false;
            Btn_ingresar.Enabled = false;
            Btn_modificar.Enabled = false;
            Btn_guardar.Enabled = true;
        }

        void habilitarTodo()
        {
            Txt_nombreEntrenador.Enabled = true;
            Txt_apellidoEntrenador.Enabled = true;
            Txt_especialidadEntrenador.Enabled = true;
            Cbo_equipo.Enabled = true;
            Gpb_estado.Enabled = true;
            Btn_eliminar.Enabled = true;
            Btn_ingresar.Enabled = true;
            Btn_modificar.Enabled = true;
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            bloquearBotones();
            Txt_nombreEntrenador.Text = "";
            Txt_apellidoEntrenador.Text = "";
            Txt_especialidadEntrenador.Text = "";
            Cbo_equipo.Text = "";
            Gpb_estado.Enabled = false;
            boton_ingreso = true;

            try
            {
                int scodigoCampo = 0;
                OdbcCommand sql = new OdbcCommand("SELECT MAX(PK_idEntrenador) FROM tbl_entrenadores", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    scodigoCampo = almacena.GetInt16(0);
                }
                string sSumaCodigo = " ";
                sSumaCodigo = Convert.ToString(scodigoCampo + 1);

                Txt_codigoEntrenador.Text = sSumaCodigo;

                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            bloquearBotones();
            boton_modificar = true;
            boton_ingreso = false;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            bloquearBotones();
            boton_eliminar = true;
            boton_ingreso = false;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

            string host = Dns.GetHostName();
            IPAddress[] IP = Dns.GetHostAddresses(host);
            string sFecha = DateTime.Now.ToString("yyy/MM/dd");
            string sHora = DateTime.Now.ToString("hh:mm:ss");


            if (boton_ingreso == true)
            {

                bool ingresoCorrecto = true;
                try
                {

                    if (Txt_nombreEntrenador.Text == "" || Txt_apellidoEntrenador.Text == "" || Txt_especialidadEntrenador.Text == "" || Cbo_equipo.SelectedIndex.Equals(-1))
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ingresoCorrecto = false;
                    }
                    else
                    {
                        cmd = new OdbcCommand("INSERT INTO tbl_entrenadores(nombre_entrenador, apellido_entrenador, especialidad_entrenador, estado_entrenador) VALUES ('"
                            + Txt_nombreEntrenador.Text + "', '" + Txt_apellidoEntrenador.Text + "', '" + Txt_especialidadEntrenador.Text + "' , 1)", nueva.conectar());
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                    }
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                    ingresoCorrecto = false;
                }

                if (ingresoCorrecto)
                {
                    MessageBox.Show("Entrenador Ingresado Correctamente");
                    Txt_nombreEntrenador.Text = "";
                    Txt_apellidoEntrenador.Text = "";
                    Txt_especialidadEntrenador.Text = "";
                    Cbo_equipo.Text = "";
                    habilitarTodo();

                    int iLastId = 0;
                    OdbcCommand sql = new OdbcCommand("SELECT PK_idEntrenador FROM tbl_entrenadores ORDER by PK_idEntrenador DESC LIMIT 1", nueva.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {
                        iLastId = almacena.GetInt32(0);
                    }
                    almacena.Close();
                    sql.Connection.Close();


                    cmd = new OdbcCommand("INSERT INTO tbl_equipos_entrenadores(PK_idEntrenador, PK_idEquipo) VALUES ("
                            + iLastId.ToString() + ", " + lIdEquipo[Cbo_equipo.SelectedIndex].ToString() + " )", nueva.conectar());
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Ingreso de Entrenador", "tbl_entrenadores", frm_login.IP[2].ToString());


                }
            }
            else if (boton_modificar == true)
            {
                bool ingresoCorrecto = true;
                try
                {

                    if (Txt_nombreEntrenador.Text == "" || Txt_apellidoEntrenador.Text == "" || Txt_especialidadEntrenador.Text == "" || Cbo_equipo.SelectedIndex.Equals(-1))
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ingresoCorrecto = false;
                    }
                    else
                    {
                        if (Rdb_habilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_entrenadores SET nombre_entrenador='" + Txt_nombreEntrenador.Text
                               + "', apellido_entrenador='" + Txt_apellidoEntrenador.Text
                               + "', especialidad_entrenador='" + Txt_especialidadEntrenador.Text
                               + "' , estado_entrenador=1 "
                               + " WHERE PK_idEntrenador="
                               + Txt_codigoEntrenador.Text
                                , nueva.conectar());
                            cmd.ExecuteNonQuery();
                            cmd.Connection.Close();

                            cmd = new OdbcCommand("UPDATE tbl_equipos_entrenadores SET PK_idEquipo=" + lIdEquipo[Cbo_equipo.SelectedIndex].ToString() +
                          " WHERE PK_idEntrenador =" + Txt_codigoEntrenador.Text, nueva.conectar());
                            cmd.ExecuteNonQuery();
                            cmd.Connection.Close();
                        }
                        else if (Rbd_deshabilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_entrenadores SET nombre_entrenador='" + Txt_nombreEntrenador.Text
                             + "', apellido_entrenador='" + Txt_apellidoEntrenador.Text
                             + "', especialidad_entrenador='" + Txt_especialidadEntrenador.Text
                             + "' , estado_entrenador=0 "
                             + " WHERE PK_idEntrenador="
                             + Txt_codigoEntrenador.Text
                              , nueva.conectar());
                            cmd.ExecuteNonQuery();
                            cmd.Connection.Close();

                            cmd = new OdbcCommand("UPDATE tbl_equipos_entrenadores SET PK_idEquipo=" + lIdEquipo[Cbo_equipo.SelectedIndex].ToString() +
                          " WHERE PK_idEntrenador =" + Txt_codigoEntrenador.Text, nueva.conectar());
                            cmd.ExecuteNonQuery();
                            cmd.Connection.Close();
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                    ingresoCorrecto = false;
                }

                if (ingresoCorrecto)
                {
                    MessageBox.Show("Entrenador Modificado Correctamente");
                    Txt_nombreEntrenador.Text = "";
                    Txt_apellidoEntrenador.Text = "";
                    Txt_especialidadEntrenador.Text = "";
                    Cbo_equipo.Text = "";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Modificacion de Entrenador", "tbl_entrenadores", frm_login.IP[2].ToString());

                }
            }
            else if (boton_eliminar == true)
            {
                bool ingresoCorrecto = true;
                try
                {
                    cmd = new OdbcCommand("UPDATE tbl_entrenadores SET estado_entrenador=0 WHERE PK_idEntrenador ="
                   + Txt_codigoEntrenador.Text, nueva.conectar());
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                    ingresoCorrecto = false;
                }

                if (ingresoCorrecto)
                {
                    MessageBox.Show("Entrenador Eliminado Correctamente");
                    Txt_nombreEntrenador.Text = "";
                    Txt_apellidoEntrenador.Text = "";
                    Txt_especialidadEntrenador.Text = "";
                    Cbo_equipo.Text = "";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Eliminacion de Entrenador", "tbl_entrenadores", frm_login.IP[2].ToString());

                }
            }
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_entrenadores entrenadores = new frm_entrenadores();
            entrenadores.Show();
            this.Close();
        }

        void limpiarForm()
        {
            Btn_ingresar.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_modificar.Enabled = true;
            Btn_Regresar.Enabled = true;
            Btn_eliminar.Enabled = true;
            Btn_salir.Enabled = true;
            Txt_apellidoEntrenador.Text = "";
            Txt_codigoEntrenador.Text = "";
            Txt_especialidadEntrenador.Text = "";
            Txt_nombreEntrenador.Text = "";
            Gpb_estado.Enabled = false;

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            Btn_guardar.Enabled = false;
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\" + "ayudamantenimiento.chm", "mantenimiento.html");
        }
    }
}
