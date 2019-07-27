/*La forma empleados puede Ingresar, Guardar, Modificar y Eliminar trabajadores
 *Se creó variables booleanas para el momento de guardar, se sepa si se ingreso nuevo,
 * se modificó o si se eliminó un registro, esto solo es para poder interactuar con el usuario.
 * los registros se ingresan en la tabla tbl_empleados en la base de datos polideportivo.
*/

//Autor: Alejandro Barreda
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
    public partial class frm_adminEmpleados : Form
    {
        //Autor: Alejandro Barreda
        bool ingreso_presionado = false;
        bool modificar_presionado = false;
        bool eliminar_presionado = false;
        OdbcCommand cmd;

        public frm_adminEmpleados()
        {
          
            InitializeComponent();
        }

        private void frm_adminEmpleados_Load(object sender, EventArgs e)
        {
            Txt_codigoEmpleado.Enabled = false;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_empleados empleados = new frm_empleados();
            empleados.Show();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        //FUNCIONES PARA PODER BLOQUER O PERMITIR EDICIÓN Y SELECCION DE PARTE DEL USUARIO
        void habilitarBotones()
        {
            Txt_nombreEmpleado.Enabled = true;
            Txt_apellidoEmpleado.Enabled = true;
            Txt_direccionEmpleado.Enabled = true;
            Txt_dpiEmpleado.Enabled = true;
            Txt_telefonoEmpleado.Enabled = true;
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
            Txt_nombreEmpleado.Enabled = true;
            Txt_apellidoEmpleado.Enabled = true;
            Txt_direccionEmpleado.Enabled = true;
            Txt_dpiEmpleado.Enabled = true;
            Txt_telefonoEmpleado.Enabled = true;
            Gpb_estado.Enabled = true;
            Btn_eliminar.Enabled = true;
            Btn_ingresar.Enabled = true;
            Btn_modificar.Enabled = true;
        }


        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            bloquearBotones();
            Txt_nombreEmpleado.Text= "";
            Txt_apellidoEmpleado.Text = "";
            Txt_direccionEmpleado.Text = "";
            Txt_dpiEmpleado.Text = "";
            Txt_telefonoEmpleado.Text = "";
            Gpb_estado.Enabled = false;
            ingreso_presionado = true;
        }
        
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (ingreso_presionado == true)
            {

                bool ingresoCorrecto = true;
                try
                {

                    if (Txt_nombreEmpleado.Text == "" || Txt_apellidoEmpleado.Text == "" || Txt_direccionEmpleado.Text=="" || Txt_telefonoEmpleado.Text == "")
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ingresoCorrecto = false;
                    }
                    else
                    {
                        cmd = new OdbcCommand("INSERT INTO tbl_empleados(nombre_empleado, apellido_empleado, direccion_empleado, dpi_empleado, telefono_empleado, estado_empleado) VALUES ('" + Txt_nombreEmpleado.Text + "', '" +Txt_apellidoEmpleado.Text+"','"+ Txt_direccionEmpleado.Text +
                           "','" + Txt_dpiEmpleado.Text + "','" +Txt_telefonoEmpleado.Text+"', 1)", conexion.conectar());
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
                    MessageBox.Show("Empleado Ingresado Correctamente");
                    Txt_nombreEmpleado.Text = "";
                    Txt_apellidoEmpleado.Text = "";
                    Txt_direccionEmpleado.Text = "";
                    Txt_dpiEmpleado.Text = "";
                    Txt_telefonoEmpleado.Text = "";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();
                }
            }
            else if (modificar_presionado == true)
            {
                bool ingresoCorrecto = true;
                try
                {

                    if (Txt_nombreEmpleado.Text == "" || Txt_apellidoEmpleado.Text == "" || Txt_direccionEmpleado.Text == "" || Txt_telefonoEmpleado.Text == "")
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ingresoCorrecto = false;
                    }
                    else
                    {
                        if (Rdb_habilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_empleados SET nombre_empleado='" + Txt_nombreEmpleado.Text + "', apellido_empleado='" + Txt_apellidoEmpleado.Text +
                                  "', direccion_empleado='" + Txt_direccionEmpleado.Text + "', dpi_empleado='" + Txt_dpiEmpleado.Text + "', telefono_empleado='" + Txt_telefonoEmpleado.Text + "', estado_equipo=1", conexion.conectar());
                            cmd.ExecuteNonQuery();


                        }
                        else if (Rbd_deshabilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_empleados SET nombre_empleado='" + Txt_nombreEmpleado.Text + "', apellido_empleado='" + Txt_apellidoEmpleado.Text +
                                "', direccion_empleado='" + Txt_direccionEmpleado.Text + "', dpi_empleado='" + Txt_dpiEmpleado.Text + "', telefono_empleado='" + Txt_telefonoEmpleado.Text + "', estado_equipo=0", conexion.conectar());
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
                    MessageBox.Show("Empleado Modificado Correctamente");
                    Txt_codigoEmpleado.Text = " ";
                    Txt_nombreEmpleado.Text = " ";
                    Txt_apellidoEmpleado.Text = " ";
                    Txt_direccionEmpleado.Text = " ";
                    Txt_dpiEmpleado.Text = " ";
                    Txt_telefonoEmpleado.Text = " ";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();
                }
            }
            else if (eliminar_presionado == true)
            {
                bool ingresoCorrecto = true;
                try
                {
                    cmd = new OdbcCommand("UPDATE tbl_empleados SET estado_empleado=0 WHERE PK_idEmpleado ='"
                   + Txt_codigoEmpleado.Text + "'", conexion.conectar());
                    cmd.ExecuteNonQuery();
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                    ingresoCorrecto = false;
                }

                if (ingresoCorrecto)
                {
                    MessageBox.Show("Empleado Eliminado Correctamente");
                    Txt_codigoEmpleado.Text = " ";
                    Txt_nombreEmpleado.Text = " ";
                    Txt_direccionEmpleado.Text = " ";
                    Txt_dpiEmpleado.Text = " ";
                    Txt_telefonoEmpleado.Text = " ";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();
                }
            }
        }

        private void Txt_dpiEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_empleados empleados = new frm_empleados();
            empleados.Show();
            this.Close();
        }
    }
}
