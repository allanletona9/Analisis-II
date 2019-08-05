using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Data.SqlClient;
using System.Net;


namespace Polideportivo_Administrativo.Mantenimientos
{
    public partial class frm_adminArbitros : Form
    {
        conexion nueva = new conexion();
        bool boton_ingreso = false;
        bool boton_modificar = false;
        bool boton_eliminar = false;
        OdbcCommand cmd;
        List<int> lIdDeporte = new List<int>();

        public frm_adminArbitros()
        {
           
            //Autor: Eduardo Colon
            InitializeComponent();
            llenarComboBox();
            Rdb_habilitado.Checked = true;
        }

        private void llenarComboBox()
        {
            OdbcCommand sql = new OdbcCommand("Select PK_idDeporte, nombre_deporte from tbl_deportes WHERE estado_deporte=1", nueva.conectar());
            OdbcDataReader almacena = sql.ExecuteReader();
            while (almacena.Read() == true)
            {
                Cbo_deporte.Items.Add(almacena.GetString(1));
                lIdDeporte.Add(almacena.GetInt32(0));
            }
            almacena.Close();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_adminArbitros_Load(object sender, EventArgs e)
        {
            Txt_codigoArbitro.Enabled = false;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Txt_codigoArbitro_TextChanged(object sender, EventArgs e)
        {

        }

        void habilitarBotones()
        {
            Txt_nombreArbitro.Enabled = true;
            Txt_apellidoArbitro.Enabled = true;
            Cbo_deporte.Enabled = true;
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
            Txt_nombreArbitro.Enabled = true;
            Txt_apellidoArbitro.Enabled = true;
            Cbo_deporte.Enabled = true;
            Gpb_estado.Enabled = true;
            Btn_eliminar.Enabled = true;
            Btn_ingresar.Enabled = true;
            Btn_modificar.Enabled = true;
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            bloquearBotones();
            Txt_nombreArbitro.Text = "";
            Txt_apellidoArbitro.Text = "";
            Cbo_deporte.Text = "";
            Gpb_estado.Enabled = false;
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

            string host = Dns.GetHostName();
            IPAddress[] IP = Dns.GetHostAddresses(host);
            string sFecha = DateTime.Now.ToString("yyy/MM/dd");
            string sHora = DateTime.Now.ToString("hh:mm:ss");

            if (boton_ingreso == true)
            {

                bool ingresoCorrecto = true;
                try
                {

                    if (Txt_nombreArbitro.Text == "" || Txt_apellidoArbitro.Text == "")
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ingresoCorrecto = false;
                    }
                    else
                    {
                        cmd = new OdbcCommand("INSERT INTO tbl_arbitros(nombre_arbitro, apellido_arbitro, estado_arbitro) VALUES ('"
                            + Txt_nombreArbitro.Text + "', '" + Txt_apellidoArbitro.Text + "' , 1)", nueva.conectar());
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
                    MessageBox.Show("Arbitro Ingresado Correctamente");
                    Txt_nombreArbitro.Text = "";
                    Txt_apellidoArbitro.Text = "";
                    Cbo_deporte.Text = "";
                    habilitarTodo();

                    int iLastId = 0;
                    OdbcCommand sql = new OdbcCommand("SELECT PK_idArbitro FROM tbl_arbitros ORDER by PK_idArbitro DESC LIMIT 1", nueva.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {
                        iLastId = almacena.GetInt32(0);
                    }
                    almacena.Close();


                    cmd = new OdbcCommand("INSERT INTO tbl_arbitros_deportes(PK_idArbitro, PK_idDeporte) VALUES ("
                            + iLastId.ToString() + ", " + lIdDeporte[Cbo_deporte.SelectedIndex].ToString() + " )", nueva.conectar());
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, "Ingreso de Arbitro", "tbl_entrenadores", frm_login.IP[2].ToString());
                }
            }
            else if (boton_modificar == true)
            {
                bool ingresoCorrecto = true;
                try
                {

                    if (Txt_nombreArbitro.Text == "" || Txt_apellidoArbitro.Text == "")
                    {
                        MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ingresoCorrecto = false;
                    }
                    else
                    {
                        if (Rdb_habilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_arbitros SET nombre_arbitro='" + Txt_nombreArbitro.Text
                               + "', apellido_arbitro='" + Txt_apellidoArbitro.Text
                               + "' , estado_arbitro=1 "
                               + " WHERE PK_idArbitro="
                               + Txt_codigoArbitro.Text
                                , nueva.conectar());
                            cmd.ExecuteNonQuery();
                            cmd.Connection.Close();


                            cmd = new OdbcCommand("UPDATE tbl_arbitros_deportes SET PK_idDeporte=" + lIdDeporte[Cbo_deporte.SelectedIndex].ToString() +
                          " WHERE PK_idArbitro =" + Txt_codigoArbitro.Text, nueva.conectar());
                            cmd.ExecuteNonQuery();
                            cmd.Connection.Close();

                        }
                        else if (Rbd_deshabilitado.Checked == true)
                        {
                            cmd = new OdbcCommand("UPDATE tbl_arbitros SET nombre_arbitro='" + Txt_nombreArbitro.Text
                               + "', apellido_arbitro='" + Txt_apellidoArbitro.Text
                               + "' , estado_arbitro=0 "
                               + " WHERE PK_idArbitro="
                               + Txt_codigoArbitro.Text
                                , nueva.conectar());
                            cmd.ExecuteNonQuery();
                            cmd.Connection.Close();


                            cmd = new OdbcCommand("UPDATE tbl_arbitros_deportes SET PK_idDeporte=" + lIdDeporte[Cbo_deporte.SelectedIndex].ToString() +
                          " WHERE PK_idArbitro =" + Txt_codigoArbitro.Text, nueva.conectar());
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
                    MessageBox.Show("Arbitro Modificado Correctamente");
                    Txt_nombreArbitro.Text = "";
                    Txt_apellidoArbitro.Text = "";
                    Cbo_deporte.Text = "";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, frm_login.nombre_usuarioparabitacora, "Modificacion de arbitro", frm_login.IP[2].ToString());

                }
            }
            else if (boton_eliminar == true)
            {
                bool ingresoCorrecto = true;
                try
                {
                    cmd = new OdbcCommand("UPDATE tbl_arbitros SET estado_arbitro=0 WHERE PK_idArbitro="
                   + Txt_codigoArbitro.Text, nueva.conectar());
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
                    MessageBox.Show("Arbitro Eliminado Correctamente");
                    Txt_nombreArbitro.Text = "";
                    Txt_apellidoArbitro.Text = "";
                    Cbo_deporte.Text = "";
                    Rdb_habilitado.Checked = false;
                    Rbd_deshabilitado.Checked = false;
                    habilitarTodo();

                    //REGISTRO BITACORA MANTENIMIENTOS-----------------------------------------
                    Bitacora.CrearBitacoraMantenimiento(frm_login.nombre_usuarioparabitacora, frm_login.nombre_usuarioparabitacora, "Eliminacion de Arbitro", frm_login.IP[2].ToString());

                }
            }
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_arbitros arbitros = new frm_arbitros();
            arbitros.Show();
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
            Txt_codigoArbitro.Text = " ";
            Txt_apellidoArbitro.Text = "";
            Txt_nombreArbitro.Text = "";
            Gpb_estado.Enabled = false;
            Txt_codigoArbitro.Enabled = true;
        }


        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
    }
}
