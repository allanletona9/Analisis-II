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
   
    public partial class frm_campos : Form
    {
        conexion nueva= new conexion();
        public frm_campos()
        {
            //Autor: Alejandro Barreda
            InitializeComponent();
            llenarGridCampos();
        }
        void llenarGridCampos()
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idCampo AS Codigo, nombre_campo AS Nombre, numero_campo AS Numero FROM tbl_campo WHERE estado_campo=1", nueva.conectar());
                dat.Fill(ds);
                Dgv_campos.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ingresarCampo_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_adminCampos adminCampos = new frm_adminCampos();
            adminCampos.Show();
        }

        private void frm_campos_Load(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT PK_idCampo AS Codigo, nombre_campo AS Nombre, numero_campo AS Numero FROM tbl_campo WHERE PK_idCampo='" + Txt_buscar.Text + "' OR nombre_campo = '" + Txt_buscar.Text + "'", nueva.conectar());
                dat.Fill(ds);
                Dgv_campos.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            frm_adminCampos sudocampos = new frm_adminCampos();


            sudocampos.Txt_codigoCampo.Text = Convert.ToString(Dgv_campos.CurrentRow.Cells[0].Value);
            sudocampos.Txt_nombreCampo.Text = Convert.ToString(Dgv_campos.CurrentRow.Cells[1].Value);
            sudocampos.Txt_numeroCampo.Text = Convert.ToString(Dgv_campos.CurrentRow.Cells[2].Value);

            this.Close();
            sudocampos.Txt_codigoCampo.Enabled = false;
            sudocampos.Txt_nombreCampo.Enabled = false;
            sudocampos.Txt_numeroCampo.Enabled = false;
            sudocampos.Gpb_estado.Enabled = false;
            sudocampos.Show();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            llenarGridCampos();
        }

        private void Btn_salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
