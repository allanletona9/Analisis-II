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
    public partial class frm_empleados : Form
    {
        public frm_empleados()
        {
            //Autor: Alejandro Barreda
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminEmpleados adminEmpleados = new frm_adminEmpleados();
            adminEmpleados.Show();
        }

        void llenarGridEmpleados()
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idEmpleado AS Codigo, nombre_empleado AS Nombre, apellido_empleado AS apellido, direccion_empleado AS direccion, dpi_empleado AS DPI, telefono_empleado AS telefono FROM tbl_empleados WHERE estado_empleado=1", conexion.conectar());
                dat.Fill(ds);
                Dgv_empleados.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }
        private void frm_empleados_Load(object sender, EventArgs e)
        {
            llenarGridEmpleados();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idEmpleado AS Codigo, nombre_empleado AS Nombre, apellido_empleado AS apellido, direccion_empleado AS direccion, dpi_empleado AS DPI, telefono_empleado AS telefono FROM tbl_empleados WHERE PK_idEmpleado='" + Txt_buscar.Text + "' OR nombre_empleado = '" + Txt_buscar.Text + "'", conexion.conectar());
                dat.Fill(ds);
                Dgv_empleados.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            frm_adminEmpleados adminEmpleados = new frm_adminEmpleados();


            adminEmpleados.Txt_codigoEmpleado.Text = Convert.ToString(Dgv_empleados.CurrentRow.Cells[0].Value);
            adminEmpleados.Txt_nombreEmpleado.Text = Convert.ToString(Dgv_empleados.CurrentRow.Cells[1].Value);
            adminEmpleados.Txt_apellidoEmpleado.Text = Convert.ToString(Dgv_empleados.CurrentRow.Cells[2].Value);
            adminEmpleados.Txt_direccionEmpleado.Text = Convert.ToString(Dgv_empleados.CurrentRow.Cells[3].Value);
            adminEmpleados.Txt_dpiEmpleado.Text = Convert.ToString(Dgv_empleados.CurrentRow.Cells[4].Value);
            adminEmpleados.Txt_telefonoEmpleado.Text = Convert.ToString(Dgv_empleados.CurrentRow.Cells[5].Value);
            
            this.Close();
            adminEmpleados.Txt_nombreEmpleado.Enabled = false;
            adminEmpleados.Txt_apellidoEmpleado.Enabled = false;
            adminEmpleados.Txt_direccionEmpleado.Enabled = false;
            adminEmpleados.Txt_dpiEmpleado.Enabled = false;
            adminEmpleados.Txt_telefonoEmpleado.Enabled = false;
            adminEmpleados.Gpb_estado.Enabled = false;
            adminEmpleados.Show();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            llenarGridEmpleados();
        }

        private void Btn_salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}