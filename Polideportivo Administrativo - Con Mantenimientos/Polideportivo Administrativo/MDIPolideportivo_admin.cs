﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polideportivo_Administrativo.Mantenimientos;
using Polideportivo_Administrativo.Procesos;

namespace Polideportivo_Administrativo
{
    public partial class MDIPolideportivo_admin : Form
    {
        private int childFormNumber = 0;

        public MDIPolideportivo_admin()
        {
            //Autor: Allan Letona
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDIPolideportivo_admin_Load(object sender, EventArgs e)
        {
            
            
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_login f = new frm_login();
            f.Show();
        }

        private void MDIPolideportivo_admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_login f = new frm_login();
            f.Show();
        }

        bool ventanaMostrarJugadores = false;
        frm_jugadores mostrarJugadores = new frm_jugadores();

        private void jugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_jugadores);
            if (ventanaMostrarJugadores == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarJugadores = new frm_jugadores();
                    mostrarJugadores.MdiParent = this;
                }

                mostrarJugadores.MdiParent = this;
                mostrarJugadores.Show();
                Application.DoEvents();
                ventanaMostrarJugadores = true;
            }
            else
            {
                mostrarJugadores.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMostrarEquipos = false;
        frm_equipos mostrarEquipos = new frm_equipos();

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_equipos);
            if (ventanaMostrarEquipos == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarEquipos = new frm_equipos();
                }

                mostrarEquipos.MdiParent = this;
                mostrarEquipos.Show();
                Application.DoEvents();
                ventanaMostrarEquipos = true;
            }
            else
            {
                mostrarEquipos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMostrarEntrenadores = false;
        frm_entrenadores mostrarEntrenadores = new frm_entrenadores();

        private void entrenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_jugadores);
            if (ventanaMostrarEntrenadores == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarEntrenadores = new frm_entrenadores();
                }

                mostrarEntrenadores.MdiParent = this;
                mostrarEntrenadores.Show();
                Application.DoEvents();
                ventanaMostrarEntrenadores = true;
            }
            else
            {
                mostrarEntrenadores.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMostrarCampeonatos = false;
        frm_campeonatos mostrarCampeonatos = new frm_campeonatos();

        private void campeonatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_jugadores);
            if (ventanaMostrarCampeonatos == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarCampeonatos = new frm_campeonatos();
                }

                mostrarCampeonatos.MdiParent = this;
                mostrarCampeonatos.Show();
                Application.DoEvents();
                ventanaMostrarCampeonatos = true;
            }
            else
            {
                mostrarCampeonatos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMostrarArbitros = false;
        frm_arbitros mostrarArbitros = new frm_arbitros();

        private void arbitrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_jugadores);
            if (ventanaMostrarArbitros == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarArbitros = new frm_arbitros();
                }

                mostrarArbitros.MdiParent = this;
                mostrarArbitros.Show();
                Application.DoEvents();
                ventanaMostrarArbitros = true;
            }
            else
            {
                mostrarArbitros.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMostrarEmpleados = false;
        frm_empleados mostrarEmpleados = new frm_empleados();

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_jugadores);
            if (ventanaMostrarEmpleados == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarEmpleados = new frm_empleados();
                }

                mostrarEmpleados.MdiParent = this;
                mostrarEmpleados.Show();
                Application.DoEvents();
                ventanaMostrarEmpleados = true;
            }
            else
            {
                mostrarEmpleados.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMostrarSanciones = false;
        frm_sanciones mostrarSanciones = new frm_sanciones();

        private void sancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_jugadores);
            if (ventanaMostrarSanciones == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarSanciones = new frm_sanciones();
                }

                mostrarSanciones.MdiParent = this;
                mostrarSanciones.Show();
                Application.DoEvents();
                ventanaMostrarSanciones = true;
            }
            else
            {
                mostrarSanciones.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMostrarDeportes = false;
        frm_deportes mostrarDeportes = new frm_deportes();

        private void deportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_jugadores);
            if (ventanaMostrarDeportes == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarDeportes = new frm_deportes();
                }

                mostrarDeportes.MdiParent = this;
                mostrarDeportes.Show();
                Application.DoEvents();
                ventanaMostrarDeportes = true;
            }
            else
            {
                mostrarDeportes.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaMostrarCampos = false;
        frm_campos mostrarCampos = new frm_campos();

        private void camposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_jugadores);
            if (ventanaMostrarCampos == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarCampos = new frm_campos();
                }

                mostrarCampos.MdiParent = this;
                mostrarCampos.Show();
                Application.DoEvents();
                ventanaMostrarCampos = true;
            }
            else
            {
                mostrarCampos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaAsignacion = false;
        frm_asignacionEquiposCampeonato mostrarAsignacion = new frm_asignacionEquiposCampeonato();

        private void asignacionDeEquiposParaCampeonatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_jugadores);
            if (ventanaAsignacion == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarAsignacion = new frm_asignacionEquiposCampeonato();
                }

                mostrarAsignacion.MdiParent = this;
                mostrarAsignacion.Show();
                Application.DoEvents();
                ventanaAsignacion = true;
            }
            else
            {
                mostrarAsignacion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaNuevoCalendario = false;
        frm_nuevoCalendario mostrarNuevoCalendario = new frm_nuevoCalendario();

        private void nuevoCalendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_jugadores);
            if (ventanaNuevoCalendario == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarNuevoCalendario = new frm_nuevoCalendario();
                }

                mostrarNuevoCalendario.MdiParent = this;
                mostrarNuevoCalendario.Show();
                Application.DoEvents();
                ventanaNuevoCalendario = true;
            }
            else
            {
                mostrarNuevoCalendario.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaConsultarCalendario = false;
        frm_ConsultarCalendario mostrarConsultarCalendario = new frm_ConsultarCalendario();

        private void consultarCalendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_jugadores);
            if (ventanaConsultarCalendario == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarConsultarCalendario = new frm_ConsultarCalendario();
                }

                mostrarConsultarCalendario.MdiParent = this;
                mostrarConsultarCalendario.Show();
                Application.DoEvents();
                ventanaConsultarCalendario = true;
            }
            else
            {
                mostrarConsultarCalendario.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaControlResultados = false;
        frm_controlResultados mostrarControlResultados = new frm_controlResultados();

        private void controlDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_jugadores);
            if (ventanaControlResultados == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarControlResultados = new frm_controlResultados();
                }

                mostrarControlResultados.MdiParent = this;
                mostrarControlResultados.Show();
                Application.DoEvents();
                ventanaControlResultados = true;
            }
            else
            {
                mostrarControlResultados.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaControlSanciones = false;
        frm_controlSanciones mostrarControlSanciones = new frm_controlSanciones();

        private void controlDeSancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_jugadores);
            if (ventanaControlSanciones == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarControlSanciones = new frm_controlSanciones();
                }

                mostrarControlSanciones.MdiParent = this;
                mostrarControlSanciones.Show();
                Application.DoEvents();
                ventanaControlSanciones = true;
            }
            else
            {
                mostrarControlSanciones.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
