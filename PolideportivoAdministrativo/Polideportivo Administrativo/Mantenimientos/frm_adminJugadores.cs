using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Data.SqlClient;
using System.Net;


namespace Polideportivo_Administrativo.Mantenimientos
{
    
    public partial class frm_adminJugadores : Form
    {
        conexion nueva = new conexion();
        bool boton_ingreso = false;
        bool boton_modificar = false;
        bool boton_eliminar = false;
        OdbcCommand cmd;
        byte[] ficheroBLOB = null;
        List<int> lIdEquipo = new List<int>();


        public frm_adminJugadores()
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

        private void frm_adminJugadores_Load(object sender, EventArgs e)
        {
            Txt_codigoJugador.Enabled = false;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        void habilitarBotones()
        {
            Txt_codigoJugador.Enabled = false;
            Txt_nombreJugador.Enabled = true;
            Txt_apellidoJugador.Enabled = true;
            Txt_dpi.Enabled = true;
            Txt_numeroCamisola.Enabled = true;
            Txt_telefono.Enabled = true;
            Cbo_equipo.Enabled = true;
            Dtp_fechanacimiento.Enabled = true;

            Gbp_estado.Enabled = true;
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
            Txt_nombreJugador.Enabled = true;
            Txt_apellidoJugador.Enabled = true;
            Txt_dpi.Enabled = true;
            Txt_numeroCamisola.Enabled = true;
            Txt_telefono.Enabled = true;
            Cbo_equipo.Enabled = true;
            Dtp_fechanacimiento.Enabled = true;
            Gbp_estado.Enabled = true;
            Btn_eliminar.Enabled = true;
            Btn_ingresar.Enabled = true;
            Btn_modificar.Enabled = true;
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            bloquearBotones();
            Txt_nombreJugador.Text = "";
            Txt_apellidoJugador.Text = "";
            Txt_dpi.Text = "";
            Txt_numeroCamisola.Text = "";
            Txt_telefono.Text = "";
            Gbp_estado.Enabled = false;
            boton_ingreso = true;

            try
            {
                int scodigoCampo = 0;
                OdbcCommand sql = new OdbcCommand("SELECT MAX(PK_idJugador) FROM tbl_jugadores", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    scodigoCampo = almacena.GetInt16(0);
                }
                string sSumaCodigo = " ";
                sSumaCodigo = Convert.ToString(scodigoCampo + 1);

                Txt_codigoJugador.Text = sSumaCodigo;

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
            string sFechaNacimiento = Dtp_fechanacimiento.Value.ToString("yyyy-MM-dd");
            string host = Dns.GetHostName();
            IPAddress[] IP = Dns.GetHostAddresses(host);
            string sFecha = DateTime.Now.ToString("yyy/MM/dd");
            string sHora = DateTime.Now.ToString("hh:mm:ss");

            if (boton_ingreso == true)
            {

                bool ingresoCorrecto = true;
                try
                {
                   
                    if (Txt_nombreJugador.Text == "" || Txt_apellidoJugador.Text == "" || Txt_dpi.Text == "" || Txt_numeroCamisola.Text == "" || Txt_telefono.Text == "" || Cbo_equipo.SelectedIndex.Equals(-1))
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ingresoCorrecto = false;
                    }
                    else
                    {
                        cmd = new OdbcCommand("INSERT INTO tbl_jugadores(nombre_jugador, apellido_jugador, dpi_jugador, fecha_nacimiento_jugador, telefono_jugador, numeroCamisola_jugador, estado_jugador) VALUES ('" 
                            + Txt_nombreJugador.Text + "', '" + Txt_apellidoJugador.Text + "', " + Txt_dpi.Text 
                            + ", '" + sFechaNacimiento + "', " + Txt_telefono.Text + ", " + Txt_numeroCamisola.Text + ", 1)", nueva.conectar());
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
                    MessageBox.Show("Jugador Ingresado Correctamente");
                    Txt_nombreJugador.Text = "";
                    Txt_apellidoJugador.Text = "";
                    Txt_dpi.Text = "";
                    Txt_numeroCamisola.Text = "";
                    Txt_telefono.Text = "";
                    habilitarTodo();

                    int iLastId = 0;
                    OdbcCommand sql = new OdbcCommand("SELECT PK_idJugador FROM tbl_jugadores ORDER by PK_idJugador DESC LIMIT 1", nueva.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {
                        iLastId = almacena.GetInt32(0);
                    }
                    almacena.Close();
                    sql.Connection.Close();

                    cmd = new OdbcCommand("INSERT INTO tbl_equipos_jugadores(PK_idJugador, PK_idEquipo) VALUES ("
                            + iLastId.ToString() + ", " + lIdEquipo[Cbo_equipo.SelectedIndex].ToString() +" )" , nueva.conectar());
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Ingreso de Jugador", "tbl_jugadores", frm_login.IP[2].ToString());


                }
            }
            else if (boton_modificar == true)
            {
                bool ingresoCorrecto = true;
                try
                {
                    
                    if (Txt_nombreJugador.Text == "" || Txt_apellidoJugador.Text == "" || Txt_dpi.Text == "" || Txt_numeroCamisola.Text == "" || Txt_telefono.Text == "" || Cbo_equipo.SelectedIndex.Equals(-1))
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ingresoCorrecto = false;
                    }
                    else
                    {
                        if (Rdb_habilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_jugadores SET nombre_jugador='" + Txt_nombreJugador.Text
                               + "', apellido_jugador='" + Txt_apellidoJugador.Text
                               + "', dpi_jugador=" + Txt_dpi.Text
                               + " , fecha_nacimiento_jugador='" + Dtp_fechanacimiento.Text
                               + "' , numeroCamisola_jugador=" + Txt_numeroCamisola.Text
                               + " , telefono_jugador=" + Txt_telefono.Text
                               + " , estado_jugador=1 "
                               + " WHERE PK_idJugador="
                               + Txt_codigoJugador.Text
                                , nueva.conectar());
                            cmd.ExecuteNonQuery();
                            cmd.Connection.Close();


                            cmd = new OdbcCommand("UPDATE tbl_equipos_jugadores SET PK_idEquipo=" + lIdEquipo[Cbo_equipo.SelectedIndex].ToString() +
                          " WHERE PK_idJugador =" + Txt_codigoJugador.Text, nueva.conectar());
                            cmd.ExecuteNonQuery();
                            cmd.Connection.Close();
                        }
                        else if (Rbd_deshabilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_jugadores SET nombre_jugador='" + Txt_nombreJugador.Text
                               + "', apellido_jugador='" + Txt_apellidoJugador.Text
                               + "', dpi_jugador=" + Txt_dpi.Text
                               + " , fecha_nacimiento_jugador='" + Dtp_fechanacimiento.Text
                               + "', numeroCamisola_jugador=" + Txt_numeroCamisola.Text
                               + ", telefono_jugador=" + Txt_telefono.Text
                               + " , estado_jugador=0 "
                               + " WHERE PK_idJugador="
                               + Txt_codigoJugador.Text
                               , nueva.conectar());
                            cmd.ExecuteNonQuery();
                            cmd.Connection.Close();

                            cmd = new OdbcCommand("UPDATE tbl_equipos_jugadores SET PK_idEquipo=" + lIdEquipo[Cbo_equipo.SelectedIndex].ToString()  +
                          " WHERE PK_idJugador =" + Txt_codigoJugador.Text, nueva.conectar());
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
                    MessageBox.Show("Jugador Modificado Correctamente");
                    Txt_nombreJugador.Text = "";
                    Txt_apellidoJugador.Text = "";
                    Txt_dpi.Text = "";
                    Txt_numeroCamisola.Text = "";
                    Txt_telefono.Text = "";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Modificacion de Jugador", "tbl_jugadores", frm_login.IP[2].ToString());

                }
            }
            else if (boton_eliminar == true)
            {
                bool ingresoCorrecto = true;
                try
                {
                    cmd = new OdbcCommand("UPDATE tbl_jugadores SET estado_jugador=0 WHERE PK_idJugador ="
                   + Txt_codigoJugador.Text, nueva.conectar());
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
                    MessageBox.Show("Jugador Eliminado Correctamente");
                    Txt_nombreJugador.Text = "";
                    Txt_apellidoJugador.Text = "";
                    Txt_dpi.Text = "";
                    Txt_numeroCamisola.Text = "";
                    Txt_telefono.Text = "";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Eliminacion de Jugador", "tbl_jugadores", frm_login.IP[2].ToString());

                }
            }
        }

   
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertarImagen()
        {
            string insert = "UPDATE tbl_jugadores SET foto_jugador= @imagen WHERE PK_idJugador=" + Txt_codigoJugador.Text;
            OdbcCommand cmd = new OdbcCommand(insert, nueva.conectar());
            cmd.Parameters.Add("@imagen", OdbcType.Image).Value = ficheroBLOB;
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        private void Btn_imagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    FileStream streamFicheroMemoria =new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    BinaryReader readerBinario = new BinaryReader(streamFicheroMemoria);
                    FileInfo fichero =  new FileInfo(openFileDialog1.FileName);
                    ficheroBLOB = readerBinario.ReadBytes((int)(fichero.Length));
                    MessageBox.Show(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_jugadores jugadores = new frm_jugadores();
            jugadores.Show();
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
            Txt_apellidoJugador.Text = "";
            Txt_codigoJugador.Text = "";
            Txt_dpi.Text = "";
            Txt_nombreJugador.Text = "";
            Txt_numeroCamisola.Text = "";
            Txt_telefono.Text = "";
            Gbp_estado.Enabled = false;

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            Btn_guardar.Enabled = false;
        }

        private void Txt_numeroCamisola_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\" + "ayudamantenimiento.chm", "mantenimiento.html");
        }
    }
}
