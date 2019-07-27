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

namespace Polideportivo_Administrativo.Mantenimientos
{
    public partial class frm_adminCampeonatos : Form
    {
        bool bBoton_ingreso = false;
        bool bBoton_modificar = false;
        bool bBoton_eliminar = false;
        OdbcCommand cmd;

        public frm_adminCampeonatos()
        {
            //Autor: Allan Letona
            InitializeComponent();
        }

        void habilitarOpciones()
        {
            Txt_nombreCampeonato.Enabled = true;
            Txt_descripcionCampeonato.Enabled = true;
            Txt_precioCampeonato.Enabled = true;
            Txt_cantidadEquipos.Enabled = true;
            Gpb_estado.Enabled = true;
        }

        void bloquearBotones()
        {
            Btn_eliminar.Enabled = false;
            Btn_ingresar.Enabled = false;
            Btn_modificar.Enabled = false;
        }

        void habilitarTodo()
        {
            Txt_nombreCampeonato.Enabled = true;
            Txt_descripcionCampeonato.Enabled = true;
            Txt_precioCampeonato.Enabled = true;
            Txt_cantidadEquipos.Enabled = true;
            Gpb_estado.Enabled = true;
            Btn_eliminar.Enabled = true;
            Btn_ingresar.Enabled = true;
            Btn_modificar.Enabled = true;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_adminCampeonatos_Load(object sender, EventArgs e)
        {
            Txt_codigoCampeonato.Enabled = false;
            llenarComboBox();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            habilitarOpciones();
            bloquearBotones();
            Txt_nombreCampeonato.Text = "";
            Txt_descripcionCampeonato.Text = "";
            Txt_precioCampeonato.Text = "";
            Txt_cantidadEquipos.Text = "";
            Gpb_estado.Enabled = false;
            bBoton_ingreso = true;
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            habilitarOpciones();
            Cbo_deportes.Enabled = true;
            bloquearBotones();
            bBoton_modificar = true;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            habilitarOpciones();
            bloquearBotones();
            bBoton_eliminar = true;
        }

        void llenarComboBox()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_deporte from tbl_deportes", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_deportes.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            bool bValidacionTipoPago = false;
            bool bIngresoCorrecto = true;

            string scodigoTipoDeporte = "";
            if (Cbo_deportes.SelectedItem != null)
            {
                string snombreTipoDeporte = Cbo_deportes.SelectedItem.ToString();

                //consulta el codigo del tipo del deporte obteniendo el texto del combobox con el nombre del tipo de deporte
                try
                {

                    OdbcCommand sql = new OdbcCommand("Select PK_idDeporte from tbl_deportes where nombre_deporte = '" + snombreTipoDeporte + "'", conexion.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {
          
                        scodigoTipoDeporte = almacena.GetString(0);

                    }
                    almacena.Close();
                    conexion.cerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                bValidacionTipoPago = true;
            }

            if (bBoton_ingreso == true)
            {
                
                try
                {

                    if ((Txt_nombreCampeonato.Text == "" || Txt_descripcionCampeonato.Text == "" || Txt_precioCampeonato.Text == ""|| Txt_cantidadEquipos.Text == ""))
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bIngresoCorrecto = false;
                    }
                    else
                    {
                        cmd = new OdbcCommand("INSERT INTO tbl_campeonatos(FK_idDeporte, nombre_campeonato, descripcion_campeonato, precio_campeonato, cantidad_equipos, estado_campeonato) VALUES ('" + scodigoTipoDeporte + "', '" + Txt_nombreCampeonato.Text + "', '" + Txt_descripcionCampeonato.Text + "', '" + Txt_precioCampeonato.Text + "', '" + Txt_cantidadEquipos.Text + "', 1)", conexion.conectar());
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                    bIngresoCorrecto = false;
                }

                if (bIngresoCorrecto)
                {
                    MessageBox.Show("Campeonato Ingresado Correctamente");
                    Txt_nombreCampeonato.Text = "";
                    Txt_descripcionCampeonato.Text = "";
                    Txt_precioCampeonato.Text = "";
                    Txt_cantidadEquipos.Text = "";
                    habilitarTodo();
                }
            }
            else if (bBoton_modificar == true)
            {
                //bool bIngresoCorrecto = true;
                try
                {

                    if ((Txt_nombreCampeonato.Text == "" || Txt_descripcionCampeonato.Text == "" || Txt_precioCampeonato.Text == "" || Txt_cantidadEquipos.Text == "" ))
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bIngresoCorrecto = false;
                    }
                    else
                    {
                        if (Rdb_habilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_campeonatos SET FK_idDeporte='" + scodigoTipoDeporte+ "', nombre_campeonato='" + Txt_nombreCampeonato.Text + "', descripcion_campeonato='" + Txt_descripcionCampeonato.Text + "', precio_campeonato='" + Txt_precioCampeonato.Text + "', cantidad_equipos='" + Txt_cantidadEquipos.Text + "', estado_campeonato=1 WHERE PK_idCampeonato = '" + Txt_codigoCampeonato.Text + "'", conexion.conectar());
                            cmd.ExecuteNonQuery();


                        }
                        else if (Rbd_deshabilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_campeonatos SET FK_idDeporte='" + scodigoTipoDeporte + "', nombre_campeonato='" + Txt_nombreCampeonato.Text + "', descripcion_campeonato='" + Txt_descripcionCampeonato.Text + "', precio_campeonato='" + Txt_precioCampeonato.Text + "', cantidad_equipos='" + Txt_cantidadEquipos.Text + "', estado_campeonato=0 WHERE PK_idCampeonato = '" + Txt_codigoCampeonato.Text + "'", conexion.conectar());
                            cmd.ExecuteNonQuery();
                        }

                    }
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                    bIngresoCorrecto = false;
                }

                if (bIngresoCorrecto)
                {
                    MessageBox.Show("Campeonato Modificado Correctamente");
                    Txt_nombreCampeonato.Text = "";
                    Txt_descripcionCampeonato.Text = "";
                    Txt_precioCampeonato.Text = "";
                    Txt_cantidadEquipos.Text = "";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();
                }
            }
            else if (bBoton_eliminar == true)
            {
                //bool ingresoCorrecto = true;
                try
                {
                    cmd = new OdbcCommand("UPDATE tbl_campeonatos SET estado_campeonato=0 WHERE PK_idCampeonato ='"
                   + Txt_codigoCampeonato.Text + "'", conexion.conectar());
                    cmd.ExecuteNonQuery();
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                    bIngresoCorrecto = false;
                }

                if (bIngresoCorrecto)
                {
                    MessageBox.Show("Campeonato Eliminado Correctamente");
                    Txt_nombreCampeonato.Text = "";
                    Txt_descripcionCampeonato.Text = "";
                    Txt_precioCampeonato.Text = "";
                    Txt_cantidadEquipos.Text = "";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();
                }
            }
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_campeonatos campeonatos = new frm_campeonatos();
            campeonatos.Show();
            this.Close();
        }
    }
}
