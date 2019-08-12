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
using System.Net.NetworkInformation;
using System.Data.SqlClient;
using System.Net;

namespace Polideportivo_Administrativo.Mantenimientos
{
    public partial class frm_adminCampos : Form
    {
        conexion nueva = new conexion();
        bool boton_ingreso = false;
        bool boton_modificar = false;
        bool boton_eliminar = false;
        OdbcCommand cmd;

        public frm_adminCampos()
        {
            //Autor: ALEJANDRO BARREDA MENDOZA
            InitializeComponent();
            Rdb_habilitado.Checked = true;
            Btn_guardar.Enabled = false;
        }
        void habilitarBotones()
        {
            Txt_codigoCampo.Enabled = false;
            Txt_nombreCampo.Enabled = true;
            Txt_numeroCampo.Enabled = true;
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
            Txt_nombreCampo.Enabled = true;
            Txt_numeroCampo.Enabled = true;
            Gpb_estado.Enabled = true;
            Btn_eliminar.Enabled = true;
            Btn_ingresar.Enabled = true;
            Btn_modificar.Enabled = true;
        }

        private void frm_adminCampos_Load(object sender, EventArgs e)
        {
            llenarComboBox();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_equipos equipos = new frm_equipos();
            equipos.Show();
        }

        int scodigoCampo = 0;

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            bloquearBotones();
            Txt_codigoCampo.Text = "";
            Txt_nombreCampo.Text = "";
            Txt_numeroCampo.Text = "";
            Gpb_estado.Enabled = false;
            boton_ingreso = true;

            try
            {
                int scodigoCampo = 0;
                OdbcCommand sql = new OdbcCommand("SELECT MAX(PK_idCampo) FROM tbl_campo", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    scodigoCampo = almacena.GetInt16(0);
                }
                string sSumaCodigo = " ";
                sSumaCodigo = Convert.ToString(scodigoCampo + 1);

                Txt_codigoCampo.Text = sSumaCodigo;

                almacena.Close();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void llenarComboBox()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_deporte from tbl_deportes", nueva.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_deporte.Items.Add(almacena.GetValue(0));
                }
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

            bool bValidacionTipoDeporte;
            string scodigoTipoDeporte = "";
            if (Cbo_deporte.SelectedItem != null)
            {
                string snombreTipoDeporte = Cbo_deporte.SelectedItem.ToString();

                //consulta el codigo del tipo del deporte obteniendo el texto del combobox con el nombre del tipo de deporte
                try
                {

                    OdbcCommand sql = new OdbcCommand("Select PK_idDeporte from tbl_deportes where nombre_deporte = '" + snombreTipoDeporte + "'", nueva.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {

                        scodigoTipoDeporte = almacena.GetString(0);

                    }
                    almacena.Close();
                    sql.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                bValidacionTipoDeporte = true;
            }


            if (boton_ingreso == true)
            {

                bool ingresoCorrecto = true;
                try
                {

                    if ((Txt_nombreCampo.Text == "" || Txt_numeroCampo.Text == "" || Cbo_deporte.SelectedIndex.Equals(-1)))
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ingresoCorrecto = false;
                    }
                    else
                    {
                        cmd = new OdbcCommand("INSERT INTO tbl_campo(FK_idDeporte, nombre_campo, numero_campo, estado_campo) VALUES ('"+scodigoTipoDeporte+"','" + Txt_nombreCampo.Text + "', '" + Txt_numeroCampo.Text + "', 1)", nueva.conectar());
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
                    MessageBox.Show("Campo Ingresado Correctamente");
                    Txt_nombreCampo.Text = " ";
                    Txt_numeroCampo.Text = " ";
                    habilitarTodo();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Ingreso de Campo", "tbl_campo", frm_login.IP[2].ToString());

                }
            }
            else if (boton_modificar == true)
            {
                bool ingresoCorrecto = true;
                try
                {

                    if ((Txt_nombreCampo.Text == "" || Txt_numeroCampo.Text == "" || Cbo_deporte.SelectedIndex.Equals(-1)))
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ingresoCorrecto = false;
                    }
                    else
                    {
                        if (Rdb_habilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_campo SET FK_idDeporte='"+scodigoTipoDeporte+"',nombre_campo='" + Txt_nombreCampo.Text + "', numero_campo='" + Txt_numeroCampo.Text + "', estado_campo=1 WHERE PK_idCampo = '"+Txt_codigoCampo.Text+"'", nueva.conectar());
                            cmd.ExecuteNonQuery();
                            cmd.Connection.Close();


                        }
                        else if (Rbd_deshabilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_equipos SET FK_idDeporte='" + scodigoTipoDeporte + "', nombre_equipo='" + Txt_nombreCampo.Text + "', numero_campo='" + Txt_numeroCampo.Text + "', estado_campo=0 WHERE PK_idCampo = '" + Txt_codigoCampo.Text + "'", nueva.conectar());
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
                    MessageBox.Show("Campo Modificado Correctamente");
                    Txt_codigoCampo.Text = " ";
                    Txt_nombreCampo.Text = " ";
                    Txt_numeroCampo.Text = " ";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Modificacion de Campo", "tbl_campo", frm_login.IP[2].ToString());

                }
            }
            else if (boton_eliminar == true)
            {
                bool ingresoCorrecto = true;
                try
                {
                    cmd = new OdbcCommand("UPDATE tbl_campo SET estado_campo=0 WHERE PK_idCampo ='"
                   + Txt_codigoCampo.Text + "'", nueva.conectar());
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
                    MessageBox.Show("Campo Eliminado Correctamente");
                    Txt_codigoCampo.Text = " ";
                    Txt_nombreCampo.Text = " ";
                    Txt_numeroCampo.Text = " ";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Eliminacion de Campo", "tbl_campo", frm_login.IP[2].ToString());

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
            frm_campos campos = new frm_campos();
            campos.Show();
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
            Txt_codigoCampo.Text = "";
            Txt_nombreCampo.Text = "";
            Txt_numeroCampo.Text = " ";
            Gpb_estado.Enabled = false;

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            Btn_guardar.Enabled = false;
        }

        private void Txt_numeroCampo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayudas\\" + "ayudamantenimiento.chm", "mantenimiento.html");
        }
    }
}
