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

namespace Polideportivo_Administrativo.Mantenimientos
{
    public partial class frm_adminSanciones : Form
    {
        bool bBoton_ingreso = false;
        bool bBoton_modificar = false;
        bool bBoton_eliminar = false;
        OdbcCommand cmd;

        public frm_adminSanciones()
        {
            //Autor: Allan Letona
            InitializeComponent();
        }

        private void frm_adminSanciones_Load(object sender, EventArgs e)
        {
            Txt_codigoSancion.Enabled = false;
        }

        void habilitarOpciones()
        {
            Txt_nombreSancion.Enabled = true;
            Txt_descripcionSancion.Enabled = true;
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
            Txt_nombreSancion.Enabled = true;
            Txt_descripcionSancion.Enabled = true;
            Gpb_estado.Enabled = true;
            Btn_eliminar.Enabled = true;
            Btn_ingresar.Enabled = true;
            Btn_modificar.Enabled = true;
        }


        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            habilitarOpciones();
            bloquearBotones();
            Txt_nombreSancion.Text = "";
            Txt_descripcionSancion.Text = "";
            Gpb_estado.Enabled = false;
            bBoton_ingreso = true;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            bool bIngresoCorrecto = true;
            if (bBoton_ingreso == true)
            {
                
                try
                {

                    if ((Txt_nombreSancion.Text == "" || Txt_descripcionSancion.Text == ""))
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bIngresoCorrecto = false;
                    }
                    else
                    {
                        cmd = new OdbcCommand("INSERT INTO tbl_sanciones(nombre_sancion, descripcion_sancion, estado_sancion) VALUES ('" + Txt_nombreSancion.Text + "', '" + Txt_descripcionSancion.Text + "', 1)", conexion.conectar());
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
                    MessageBox.Show("Sancion Ingresada Correctamente");
                    Txt_nombreSancion.Text = " ";
                    Txt_descripcionSancion.Text = " ";
                    habilitarTodo();
                }
            }
            else if (bBoton_modificar == true)
            {
                //bool ingresoCorrecto = true;
                try
                {

                    if ((Txt_nombreSancion.Text == "" || Txt_descripcionSancion.Text == ""))
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bIngresoCorrecto = false;
                    }
                    else
                    {
                        if (Rdb_habilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_sanciones SET nombre_sancion='" + Txt_nombreSancion.Text + "', descripcion_sancion='" + Txt_descripcionSancion.Text + "', estado_sancion=1 WHERE PK_idSancion = '"+Txt_codigoSancion.Text+"'", conexion.conectar());
                            cmd.ExecuteNonQuery();


                        }
                        else if (Rbd_deshabilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_sanciones SET nombre_sancion='" + Txt_nombreSancion.Text + "', descripcion_equipo='" + Txt_descripcionSancion.Text + "', estado_sancion=0  WHERE PK_idSancion = '" + Txt_codigoSancion.Text + "'", conexion.conectar());
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
                    MessageBox.Show("Sancion Modificada Correctamente");
                    Txt_codigoSancion.Text = " ";
                    Txt_nombreSancion.Text = " ";
                    Txt_descripcionSancion.Text = " ";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();
                }
            }
            else if (bBoton_eliminar == true)
            {
               // bool ingresoCorrecto = true;
                try
                {
                    cmd = new OdbcCommand("UPDATE tbl_sanciones SET estado_sancion=0 WHERE PK_idSancion ='"
                   + Txt_codigoSancion.Text + "'", conexion.conectar());
                    cmd.ExecuteNonQuery();
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                    bIngresoCorrecto = false;
                }

                if (bIngresoCorrecto)
                {
                    MessageBox.Show("Sancion Eliminada Correctamente");
                    Txt_codigoSancion.Text = " ";
                    Txt_nombreSancion.Text = " ";
                    Txt_descripcionSancion.Text = " ";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();
                }
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            habilitarOpciones();
            bloquearBotones();
            bBoton_modificar = true;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            habilitarOpciones();
            bloquearBotones();
            bBoton_eliminar = true;
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_sanciones sanciones = new frm_sanciones();
            sanciones.Show();
            this.Close();
        }
    }
}
