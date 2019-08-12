﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Net;
using System.Net.NetworkInformation;

namespace Polideportivo_Administrativo.Mantenimientos
{
    public partial class frm_adminDeportescs : Form
    {
        conexion nueva = new conexion();
        bool boton_ingreso = false;
        bool boton_modificar = false;
        bool boton_eliminar = false;
        OdbcCommand cmd;

        public frm_adminDeportescs()
        {
            //Autor: ALEJANDRO BARREDA
            InitializeComponent();
            Rdb_habilitado.Checked = true;
            Btn_guardar.Enabled = false;
        }

        void habilitarBotones()
        {
            Txt_codigoDeporte.Enabled = false;
            Txt_nombreDeporte.Enabled = true;
            Txt_descripcionDeporte.Enabled = true;
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
            Txt_nombreDeporte.Enabled = true;
            Txt_descripcionDeporte.Enabled = true;
            Gpb_estado.Enabled = true;
            Btn_eliminar.Enabled = true;
            Btn_ingresar.Enabled = true;
            Btn_modificar.Enabled = true;
        }
        private void frm_adminDeportescs_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_equipos equipos = new frm_equipos();
            equipos.Show();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            bloquearBotones();
            Txt_nombreDeporte.Text = "";
            Txt_descripcionDeporte.Text = "";
            Gpb_estado.Enabled = false;
            boton_ingreso = true;

            try
            {
                int scodigoCampo = 0;
                OdbcCommand sql = new OdbcCommand("SELECT MAX(PK_idDeporte) FROM tbl_deportes", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    scodigoCampo = almacena.GetInt16(0);
                }
                string sSumaCodigo = " ";
                sSumaCodigo = Convert.ToString(scodigoCampo + 1);

                Txt_codigoDeporte.Text = sSumaCodigo;

                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

                    if ((Txt_nombreDeporte.Text == "" || Txt_descripcionDeporte.Text == ""))
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ingresoCorrecto = false;
                    }
                    else
                    {
                        cmd = new OdbcCommand("INSERT INTO tbl_deportes(nombre_deporte, descripcion_deporte, estado_deporte) VALUES ('" + Txt_nombreDeporte.Text + "', '" + Txt_descripcionDeporte.Text + "', 1)", nueva.conectar());
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
                    MessageBox.Show("Deporte Ingresado Correctamente");
                    Txt_nombreDeporte.Text = " ";
                    Txt_descripcionDeporte.Text = " ";
                    habilitarTodo();
                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Ingreso de Deporte", "tbl_deportes", frm_login.IP[2].ToString());

                }
            }
            else if (boton_modificar == true)
            {
                bool ingresoCorrecto = true;
                try
                {

                    if ((Txt_nombreDeporte.Text == "" || Txt_descripcionDeporte.Text == ""))
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ingresoCorrecto = false;
                    }
                    else
                    {
                        if (Rdb_habilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_deportes SET nombre_deporte='" + Txt_nombreDeporte.Text + "', descripcion_deporte='" + Txt_descripcionDeporte.Text + "', estado_deporte=1", nueva.conectar());
                            cmd.ExecuteNonQuery();
                            cmd.Connection.Close();

                        }
                        else if (Rbd_deshabilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_deportes SET nombre_deporte='" + Txt_nombreDeporte.Text + "', descripcion_deporte='" + Txt_descripcionDeporte.Text + "', estado_deporte=0", nueva.conectar());
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
                    MessageBox.Show("Deporte Modificado Correctamente");
                    Txt_codigoDeporte.Text = " ";
                    Txt_nombreDeporte.Text = " ";
                    Txt_descripcionDeporte.Text = " ";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Modificacion de Deporte", "tbl_deportes", frm_login.IP[2].ToString());

                }
            }
            else if (boton_eliminar == true)
            {
                bool ingresoCorrecto = true;
                try
                {
                    cmd = new OdbcCommand("UPDATE tbl_deportes SET estado_deporte=0 WHERE PK_idDeporte ='"
                   + Txt_codigoDeporte.Text + "'", nueva.conectar());
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
                    MessageBox.Show("Deporte Eliminado Correctamente");
                    Txt_codigoDeporte.Text = " ";
                    Txt_nombreDeporte.Text = " ";
                    Txt_descripcionDeporte.Text = " ";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Eliminacion de Deporte", "tbl_deportes", frm_login.IP[2].ToString());

                }
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            bloquearBotones();
            boton_modificar = true;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            bloquearBotones();
            boton_eliminar = true;
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_deportes deportes = new frm_deportes();
            deportes.Show();
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
            Txt_codigoDeporte.Text = "";
            Txt_descripcionDeporte.Text = "";
            Txt_nombreDeporte.Text = "";
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
