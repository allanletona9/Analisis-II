﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Windows.Forms;

namespace Polideportivo_Administrativo.Mantenimientos
{
    public partial class frm_adminJugadores : Form
    {
        bool boton_ingreso = false;
        bool boton_modificar = false;
        bool boton_eliminar = false;
        OdbcCommand cmd;
        byte[] ficheroBLOB = null;
        List<int> lIdEquipo = new List<int>();


        public frm_adminJugadores()
        {
            //Autor: Alejandro Barreda
            InitializeComponent();
            llenarComboBox();
            Rdb_habilitado.Checked = true;
        }

        private void llenarComboBox()
        {
            OdbcCommand sql = new OdbcCommand("Select PK_idEquipo, nombre_equipo from tbl_equipos WHERE estado_equipo=1", conexion.conectar());
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
            if (boton_ingreso == true)
            {

                bool ingresoCorrecto = true;
                try
                {

                    if (Txt_nombreJugador.Text == "" || Txt_apellidoJugador.Text == "" || Txt_dpi.Text == "" || Txt_numeroCamisola.Text == "" || Txt_telefono.Text == "")
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ingresoCorrecto = false;
                    }
                    else
                    {
                        cmd = new OdbcCommand("INSERT INTO tbl_jugadores(nombre_jugador, apellido_jugador, dpi_jugador, fecha_nacimiento_jugador, telefono_jugador, numeroCamisola_jugador, estado_jugador) VALUES ('" 
                            + Txt_nombreJugador.Text + "', '" + Txt_apellidoJugador.Text + "', " + Txt_dpi.Text 
                            + ", '" + Dtp_fechanacimiento.Text + "', " + Txt_telefono.Text + ", " + Txt_numeroCamisola.Text + ", 1)", conexion.conectar());
                        cmd.ExecuteNonQuery();

                        
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
                    OdbcCommand sql = new OdbcCommand("SELECT PK_idJugador FROM tbl_jugadores ORDER by PK_idJugador DESC LIMIT 1", conexion.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {
                        iLastId = almacena.GetInt32(0);
                    }
                    almacena.Close();


                    cmd = new OdbcCommand("INSERT INTO tbl_equipos_jugadores(PK_idJugador, PK_idEquipo) VALUES ("
                            + iLastId.ToString() + ", " + lIdEquipo[Cbo_equipo.SelectedIndex].ToString() +" )" , conexion.conectar());
                    cmd.ExecuteNonQuery();

                }
            }
            else if (boton_modificar == true)
            {
                bool ingresoCorrecto = true;
                try
                {

                    if (Txt_nombreJugador.Text == "" || Txt_apellidoJugador.Text == "" || Txt_dpi.Text == "" || Txt_numeroCamisola.Text == "" || Txt_telefono.Text == "")
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
                                , conexion.conectar());
                            cmd.ExecuteNonQuery();


                            cmd = new OdbcCommand("UPDATE tbl_equipos_jugadores SET PK_idEquipo=" + lIdEquipo[Cbo_equipo.SelectedIndex].ToString() +
                          " WHERE PK_idJugador =" + Txt_codigoJugador.Text, conexion.conectar());
                            cmd.ExecuteNonQuery();
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
                               , conexion.conectar());
                            cmd.ExecuteNonQuery();

                            cmd = new OdbcCommand("UPDATE tbl_equipos_jugadores SET PK_idEquipo=" + lIdEquipo[Cbo_equipo.SelectedIndex].ToString()  +
                          " WHERE PK_idJugador =" + Txt_codigoJugador.Text, conexion.conectar());
                            cmd.ExecuteNonQuery();
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
                }
            }
            else if (boton_eliminar == true)
            {
                bool ingresoCorrecto = true;
                try
                {
                    cmd = new OdbcCommand("UPDATE tbl_jugadores SET estado_jugador=0 WHERE PK_idJugador ="
                   + Txt_codigoJugador.Text, conexion.conectar());
                    cmd.ExecuteNonQuery();
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
                }
            }
        }

   
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertarImagen()
        {
            string insert ="UPDATE tbl_jugadores SET foto_jugador= @imagen WHERE PK_idJugador=" + Txt_codigoJugador.Text;
            OdbcCommand cmd = new OdbcCommand(insert, conexion.conectar());
            cmd.Parameters.Add("@imagen", OdbcType.Image).Value = ficheroBLOB;
            cmd.ExecuteNonQuery();

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
    }
}
