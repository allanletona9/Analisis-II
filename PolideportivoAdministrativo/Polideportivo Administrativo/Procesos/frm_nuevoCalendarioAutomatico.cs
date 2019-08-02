using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Windows.Forms;

namespace Polideportivo_Administrativo.Procesos

    //Autor : Eduardo Colon
{
    public partial class frm_nuevoCalendarioAutomatico : Form
    {
        string sIdCampeonato;
        List<int> lIdCampo = new List<int>();
        List<int> lidEquipoLocal = new List<int>();
        int iHoraInicial;
        int iHoraFinal;
        int iDuracionJornada;
        int iDescansoJornada;
        bool bExitoGlobal = true;

        public frm_nuevoCalendarioAutomatico(string sIdCampeonato, List<int> lidEquipoLocal, List<int> lIdCampo)
        {
            InitializeComponent();
            this.sIdCampeonato = sIdCampeonato;
            this.lidEquipoLocal = lidEquipoLocal;
            this.lIdCampo = lIdCampo;
            Rb_ida.Checked = true;
        }

        private void frm_nuevoCalendarioAutomatico_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Tb_horaInicial_Scroll(object sender, EventArgs e)
        {
            Lbl_horaInicial.Text = "Hora inicial: " + Tb_horaInicial.Value + ":00";
        }

        private void Tb_horaFinal_Scroll(object sender, EventArgs e)
        {
            Lbl_horaFinal.Text = "Hora final: " + Tb_horaFinal.Value + ":00";
        }

        private void Btn_generarAutomatico_Click(object sender, EventArgs e)
        {
            iHoraInicial = Tb_horaInicial.Value;
            iHoraFinal = Tb_horaFinal.Value;

            if(iHoraInicial >= iHoraFinal)
            {
                MessageBox.Show("La hora inicial debe ser anterior a la hora final", "Error");
            }
            else if(Txt_descanso_jornada.Text == "" || Txt_duracion_jornada.Text=="")
            {
                MessageBox.Show("Debe indicar la duracion de cada jornada y el descanso entre jornadas", "Error");
            }
            else
            {
                bool bCorrecto = true;

                try
                {
                    iDuracionJornada = int.Parse(Txt_duracion_jornada.Text);
                    iDescansoJornada = int.Parse(Txt_descanso_jornada.Text);
                
                }catch(Exception ex)
                {
                    MessageBox.Show("Debe ingresar numeros enteros", "Error");
                    bCorrecto = false;
                }

                if (bCorrecto)
                {

                    if (Rb_ida.Checked == true)
                    {
                        if (lidEquipoLocal.Count % 2 != 0)
                        {
                            generarCalendarioIdaImpar(0);
                        }
                        else
                        {
                            generarCalendarioIdaPar(0);
                        }
                    }
                    else
                    {
                        if (lidEquipoLocal.Count % 2 != 0)
                        {
                            generarCalendarioIdaVueltaImpar();
                        }
                        else
                        {
                            generarCalendarioIdaVueltaPar();
                        }
                    }

                }
            }
        }

        private void generarCalendarioIdaPar(int v)
        {
           
            int iNumeroRondas = lidEquipoLocal.Count - 1;
            int iPartidosPorRonda = lidEquipoLocal.Count / 2;

            partido[,] rondas = new partido[iNumeroRondas, iPartidosPorRonda];

            for(int i = 0,  k = 0; i < iNumeroRondas; i++)
            {
                for (int j = 0; j < iPartidosPorRonda; j++)
                {
                    rondas[i, j] = new partido();
                    rondas[i, j].iLocal = lidEquipoLocal[k];

                    k++;

                    if (k == iNumeroRondas)
                        k = 0;
                }
            }

            for (int i = 0; i < iNumeroRondas; i++)
            {
                if (i % 2 == 0)
                {
                    rondas[i,0].iVisitante = lidEquipoLocal[iNumeroRondas];
                }
                else
                {
                    rondas[i,0].iVisitante = rondas[i,0].iLocal;
                    rondas[i,0].iLocal = lidEquipoLocal[iNumeroRondas];
                }
            }

            int iEquipoMasAlto = iNumeroRondas;
            int iEquipoImparMasAlto = iEquipoMasAlto - 1;

            for (int i = 0, k = iEquipoImparMasAlto; i < iNumeroRondas; i++)
            {
                for (int j = 1; j < iPartidosPorRonda; j++)
                {
                    rondas[i,j].iVisitante = lidEquipoLocal[k];

                    k--;

                    if (k == -1)
                        k = iEquipoImparMasAlto;
                }
            }

            DateTime dtFechaActual = Dtp_fecha.Value;
            DateTime dtFechaAntigua = Dtp_fecha.Value;
            int iHoraActual = iHoraInicial;
            int iDiasJugados = 0;
            int iContadorCampos = 0;
            int iCampoActual = lIdCampo[iContadorCampos];
            bool bExito = true;
            bool verificarPartido = true;

            for (int i = 0; i < iNumeroRondas; i++)
            {
                Debug.WriteLine("JORNADA: " + (i + 1));

                for(int j = 0; j < iPartidosPorRonda; j++)
                {    
                    //HACER INSERT ACA
                     Debug.WriteLine(rondas[i, j].iLocal + " vs " + rondas[i, j].iVisitante + " DIA: " + dtFechaActual.ToShortDateString() + " CAMPO " + iCampoActual + " HORA " + iHoraActual );

                    if(verificarPartido)
                            verificarPartido = verificarCampoOcupado(iCampoActual, dtFechaActual.ToString("yyyy'-'MM'-'dd"), iHoraActual.ToString() + ":00:00");

                    if (!verificarPartido)
                        bExito = false;
                    
                    iHoraActual++;

                    if (iHoraActual == iHoraFinal)
                    {
                        iHoraActual = iHoraInicial;
                        
                        if(iContadorCampos < lIdCampo.Count -1)
                        {
                            iContadorCampos++;
                            iCampoActual = lIdCampo[iContadorCampos];
                        }
                        else
                        {
                            iContadorCampos = 0;
                            iCampoActual = lIdCampo[iContadorCampos];

                            dtFechaActual = dtFechaAntigua.AddDays(1);
                            dtFechaAntigua = dtFechaActual;
                            iDiasJugados++;



                            if(iDiasJugados == iDuracionJornada)
                            {
                                bExito = false;
                            }
                        }
                    }             
                }

                dtFechaActual = dtFechaAntigua.AddDays(iDescansoJornada);
                dtFechaAntigua = dtFechaActual;
                dtFechaActual = dtFechaAntigua.AddDays(iDuracionJornada - iDiasJugados);
                dtFechaAntigua = dtFechaActual;
                iDiasJugados = 0;
                iCampoActual = lIdCampo[0];

            }

            if (bExito)
            {
                DateTime dtFechaACtual2 = Dtp_fecha.Value;
                DateTime dtFechaAntigua2 = Dtp_fecha.Value;
                int iHoraActual2 = iHoraInicial;
                int iDiasJugados2 = 0;
                int iContadorCampos2 = 0;
                int iCampoActual2 = lIdCampo[iContadorCampos2];

                for (int i = 0; i < iNumeroRondas; i++)
                {
                    for (int j = 0; j < iPartidosPorRonda; j++)
                    {
                        int iJornada = 0;
                        if (v == 0 || v == 1)
                            iJornada = i + 1;
                        else
                            iJornada = i + 1 + iNumeroRondas;

                        insertarPartidoEncabezado(iJornada, iCampoActual2, dtFechaACtual2.ToString("yyyy'-'MM'-'dd"), iHoraActual2.ToString() + ":00:00");
                        insertarPartidoDetalle(rondas[i, j].iLocal, rondas[i, j].iVisitante);

                        iHoraActual2++;

                        if (iHoraActual2 == iHoraFinal)
                        {
                            iHoraActual2 = iHoraInicial;

                            if (iContadorCampos2 < lIdCampo.Count - 1)
                            {
                                iContadorCampos2++;
                                iCampoActual2 = lIdCampo[iContadorCampos2];
                            }
                            else
                            {
                                iContadorCampos2 = 0;
                                iCampoActual2 = lIdCampo[iContadorCampos2];

                                dtFechaACtual2 = dtFechaAntigua2.AddDays(1);
                                dtFechaAntigua2 = dtFechaACtual2;
                                iDiasJugados2++;
                            }
                        }
                    }

                    dtFechaACtual2 = dtFechaAntigua2.AddDays(iDescansoJornada);
                    dtFechaAntigua2 = dtFechaACtual2;
                    dtFechaACtual2 = dtFechaAntigua2.AddDays(iDuracionJornada - iDiasJugados2);
                    dtFechaAntigua2 = dtFechaACtual2;
                    iDiasJugados2 = 0;
                    iCampoActual2 = lIdCampo[0];

                }

                if (v == 1)
                    Dtp_fecha.Text = dtFechaACtual2.ToString("yyyy'-'MM'-'dd");
                
                    if (bExitoGlobal)
                    {
                        if (v == 0 || v == 2)
                            MessageBox.Show("Campeonato programado correctamente", "Exito");
                    }
                    else
                        MessageBox.Show("Ocurrio un error durante la planificacion del campeonato", "Error");

            }
            else
            {
                if(!verificarPartido)
                    MessageBox.Show("El campeonato interfiere con otras reservaciones a los campos", "Error");

                MessageBox.Show("El centro polideportivo no se da a basto para llevar a cabo el campeonato con la configuracion elegida", "Error");
            }

        }

        private void generarCalendarioIdaImpar(int v)
        {

            int iNumeroRondas = lidEquipoLocal.Count;
            int iPartidosPorRonda = lidEquipoLocal.Count / 2;

            partido[,] rondas = new partido[iNumeroRondas, iPartidosPorRonda];

            for (int i = 0, k = 0; i < iNumeroRondas; i++)
            {
                for (int j = -1; j < iPartidosPorRonda; j++)
                {
                    if(j >= 0)
                    {
                        rondas[i, j] = new partido();
                        rondas[i, j].iLocal = lidEquipoLocal[k];
                    }
                    

                    k++;

                    if (k == iNumeroRondas)
                        k = 0;
                }
            }

            int iEquipoMasAlto = iNumeroRondas -1;

            for (int i = 0, k = iEquipoMasAlto; i < iNumeroRondas; i++)
            {
                for (int j = 0; j < iPartidosPorRonda; j++)
                {
                    rondas[i, j].iVisitante = lidEquipoLocal[k];

                    k--;

                    if (k == -1)
                        k = iEquipoMasAlto;
                }
            }

            for (int i = 0; i < rondas.GetLength(0); i++)
            {
                Debug.WriteLine("Ronda: " + (i + 1));
                for (int j = 0; j < rondas.GetLength(1); j++)
                {
                    Debug.WriteLine(rondas[i, j].iLocal + " vs " + rondas[i, j].iVisitante);
                }
            }

            DateTime dtFechaActual = Dtp_fecha.Value;
            DateTime dtFechaAntigua = Dtp_fecha.Value;
            int iHoraActual = iHoraInicial;
            int iDiasJugados = 0;
            int iContadorCampos = 0;
            int iCampoActual = lIdCampo[iContadorCampos];
            bool bExito = true;
            bool verificarPartido = true;

            for (int i = 0; i < iNumeroRondas; i++)
            {
                Debug.WriteLine("JORNADA: " + (i + 1));

                for (int j = 0; j < iPartidosPorRonda; j++)
                {
                    //HACER INSERT ACA
                    Debug.WriteLine(rondas[i, j].iLocal + " vs " + rondas[i, j].iVisitante + " DIA: " + dtFechaActual.ToShortDateString() + " CAMPO " + iCampoActual + " HORA " + iHoraActual);

                    if (verificarPartido)
                        verificarPartido = verificarCampoOcupado(iCampoActual, dtFechaActual.ToString("yyyy'-'MM'-'dd"), iHoraActual.ToString() + ":00:00");

                    if (!verificarPartido)
                        bExito = false;

                    iHoraActual++;

                    if (iHoraActual == iHoraFinal)
                    {
                        iHoraActual = iHoraInicial;

                        if (iContadorCampos < lIdCampo.Count - 1)
                        {
                            iContadorCampos++;
                            iCampoActual = lIdCampo[iContadorCampos];
                        }
                        else
                        {
                            iContadorCampos = 0;
                            iCampoActual = lIdCampo[iContadorCampos];

                            dtFechaActual = dtFechaAntigua.AddDays(1);
                            dtFechaAntigua = dtFechaActual;
                            iDiasJugados++;



                            if (iDiasJugados == iDuracionJornada)
                            {
                                bExito = false;
                            }
                        }
                    }
                }

                dtFechaActual = dtFechaAntigua.AddDays(iDescansoJornada);
                dtFechaAntigua = dtFechaActual;
                dtFechaActual = dtFechaAntigua.AddDays(iDuracionJornada - iDiasJugados);
                dtFechaAntigua = dtFechaActual;
                iDiasJugados = 0;
                iCampoActual = lIdCampo[0];

            }

            if (bExito)
            {

                DateTime dtFechaACtual2 = Dtp_fecha.Value;
                DateTime dtFechaAntigua2 = Dtp_fecha.Value;
                int iHoraActual2 = iHoraInicial;
                int iDiasJugados2 = 0;
                int iContadorCampos2 = 0;
                int iCampoActual2 = lIdCampo[iContadorCampos2];

                for (int i = 0; i < iNumeroRondas; i++)
                {
                    for (int j = 0; j < iPartidosPorRonda; j++)
                    {

                        int iJornada = 0;
                        if (v == 0 || v == 1)
                            iJornada = i + 1;
                        else
                            iJornada = i + 1 + iNumeroRondas;

                        insertarPartidoEncabezado(iJornada, iCampoActual2, dtFechaACtual2.ToString("yyyy'-'MM'-'dd"), iHoraActual2.ToString() + ":00:00");
                        insertarPartidoDetalle(rondas[i, j].iLocal, rondas[i, j].iVisitante);

                        iHoraActual2++;

                        if (iHoraActual2 == iHoraFinal)
                        {
                            iHoraActual2 = iHoraInicial;

                            if (iContadorCampos2 < lIdCampo.Count - 1)
                            {
                                iContadorCampos2++;
                                iCampoActual2 = lIdCampo[iContadorCampos2];
                            }
                            else
                            {
                                iContadorCampos2 = 0;
                                iCampoActual2 = lIdCampo[iContadorCampos2];

                                dtFechaACtual2 = dtFechaAntigua2.AddDays(1);
                                dtFechaAntigua2 = dtFechaACtual2;
                                iDiasJugados2++;
                            }
                        }
                    }

                    dtFechaACtual2 = dtFechaAntigua2.AddDays(iDescansoJornada);
                    dtFechaAntigua2 = dtFechaACtual2;
                    dtFechaACtual2 = dtFechaAntigua2.AddDays(iDuracionJornada - iDiasJugados2);
                    dtFechaAntigua2 = dtFechaACtual2;
                    iDiasJugados2 = 0;
                    iCampoActual2 = lIdCampo[0];

                }

                if (v == 1)
                    Dtp_fecha.Text = dtFechaACtual2.ToString("yyyy'-'MM'-'dd");
                

                if (bExitoGlobal)
                {
                    if(v==0 || v ==2)
                        MessageBox.Show("Campeonato programado correctamente", "Exito");
                }
                else
                    MessageBox.Show("Ocurrio un error durante la planificacion del campeonato", "Error");

            }
            else
            {
                if (!verificarPartido)
                    MessageBox.Show("El campeonato interfiere con otras reservaciones a los campos", "Error");

                MessageBox.Show("El centro polideportivo no se da a basto para llevar a cabo el campeonato con la configuracion elegida", "Error");
            }

        }

        private void generarCalendarioIdaVueltaPar()
        {
            generarCalendarioIdaPar(1);
            generarCalendarioIdaPar(2);
        }

        private void generarCalendarioIdaVueltaImpar()
        {
            generarCalendarioIdaImpar(1);
            generarCalendarioIdaImpar(2);

        }

        private void insertarPartidoDetalle(int iIdLocal, int iIdVisitante)
        {
            int iIdPartido = 0;
            try
            {
                OdbcCommand sql = new OdbcCommand("Select PK_idPartido FROM tbl_partido_encabezado ORDER BY PK_idPartido DESC LIMIT 1"
           , conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    iIdPartido = almacena.GetInt32(0);
                }
                almacena.Close();
                conexion.cerrarConexion();

                //Insertar partido_detalle;

                OdbcCommand cmd = new OdbcCommand("INSERT INTO tbl_partido_detalle(PK_idPartido, PK_idEquipo) VALUES (" +
                iIdPartido.ToString() + " , " +
                iIdLocal + ")"
                , conexion.conectar());
                cmd.ExecuteNonQuery();

                cmd = new OdbcCommand("INSERT INTO tbl_partido_detalle(PK_idPartido, PK_idEquipo) VALUES (" +
                iIdPartido.ToString() + " , " +
                iIdVisitante + ")"
                , conexion.conectar());
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
            catch (OdbcException ex)
            {
                bExitoGlobal = false;
            }
        }

        private void insertarPartidoEncabezado(int iJornada, int idCampo, string sFecha, string sHora)
        {
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                cmd = new OdbcCommand("INSERT INTO tbl_partido_encabezado(PK_idCampeonato, PK_idJornada, FK_idCampo, fecha_partido, hora_partido, estado_partido) VALUES (" +
                sIdCampeonato + " , " +
                iJornada + " , " +
                idCampo + " , '" +
                sFecha + "' , '" +
                sHora + "' , " +
                "1" + ")"
                , conexion.conectar());
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString());
                bExitoGlobal = false;
            }

        }

        private bool verificarCampoOcupado(int idCampo, string fecha, string hora)
        {
            OdbcCommand sql = new OdbcCommand("SELECT PK_idPartido FROM tbl_partido_encabezado WHERE "
                    + " FK_idCampo  =" + idCampo + " AND "
                    + " fecha_partido  ='" + fecha + "' AND "
                    + " hora_partido  ='" + hora + "'"
                    , conexion.conectar());
            OdbcDataReader reader = sql.ExecuteReader();

            if (reader.HasRows)
                return false;

            reader.Close();
            sql.Connection.Close();

            return true;
        }

    }

    public class partido
    {
        public int iLocal = -1;
        public int iVisitante = -1;

    }
}
