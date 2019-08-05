﻿namespace Polideportivo_Administrativo.Procesos
{
    partial class frm_nuevoCalendario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_calendarioP = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Rdb_manual = new System.Windows.Forms.RadioButton();
            this.Rdb_automatico = new System.Windows.Forms.RadioButton();
            this.Lbl_seleccion = new System.Windows.Forms.Label();
            this.Gpb_catalogos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_hora = new System.Windows.Forms.DateTimePicker();
            this.lbl_deporte = new System.Windows.Forms.Label();
            this.Cbo_deporte = new System.Windows.Forms.ComboBox();
            this.Lbl_campos = new System.Windows.Forms.Label();
            this.Cbo_campos = new System.Windows.Forms.ComboBox();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Cbo_equiposVisitantes = new System.Windows.Forms.ComboBox();
            this.Lbl_equipoVisitante = new System.Windows.Forms.Label();
            this.Lbl_equipoLocal = new System.Windows.Forms.Label();
            this.Lbl_jornadas = new System.Windows.Forms.Label();
            this.Lbl_campeonatos = new System.Windows.Forms.Label();
            this.Cbo_equiposLocales = new System.Windows.Forms.ComboBox();
            this.Cbo_jornadas = new System.Windows.Forms.ComboBox();
            this.Cbo_campeonatos = new System.Windows.Forms.ComboBox();
            this.Dgv_jornada = new System.Windows.Forms.DataGridView();
            this.Btn_programacionFinalizada = new System.Windows.Forms.Button();
            this.Btn_generarAutomatico = new System.Windows.Forms.Button();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Gpb_catalogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_jornada)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Pnl_titulo.Controls.Add(this.Btn_cerrar);
            this.Pnl_titulo.Controls.Add(this.Lbl_calendarioP);
            this.Pnl_titulo.Controls.Add(this.pictureBox2);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(1241, 57);
            this.Pnl_titulo.TabIndex = 10;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_48;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_cerrar.Location = new System.Drawing.Point(1177, 5);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(45, 48);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_calendarioP
            // 
            this.Lbl_calendarioP.AutoSize = true;
            this.Lbl_calendarioP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_calendarioP.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_calendarioP.Location = new System.Drawing.Point(68, 14);
            this.Lbl_calendarioP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_calendarioP.Name = "Lbl_calendarioP";
            this.Lbl_calendarioP.Size = new System.Drawing.Size(552, 37);
            this.Lbl_calendarioP.TabIndex = 2;
            this.Lbl_calendarioP.Text = "PROGRAMACION DE CALENDARIO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_modo_deportes_24;
            this.pictureBox2.Location = new System.Drawing.Point(13, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 42);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Rdb_manual
            // 
            this.Rdb_manual.AutoSize = true;
            this.Rdb_manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_manual.Location = new System.Drawing.Point(706, 89);
            this.Rdb_manual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rdb_manual.Name = "Rdb_manual";
            this.Rdb_manual.Size = new System.Drawing.Size(102, 29);
            this.Rdb_manual.TabIndex = 11;
            this.Rdb_manual.TabStop = true;
            this.Rdb_manual.Text = "Manual";
            this.Rdb_manual.UseVisualStyleBackColor = true;
            this.Rdb_manual.CheckedChanged += new System.EventHandler(this.Rdb_manual_CheckedChanged);
            // 
            // Rdb_automatico
            // 
            this.Rdb_automatico.AutoSize = true;
            this.Rdb_automatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_automatico.Location = new System.Drawing.Point(938, 89);
            this.Rdb_automatico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rdb_automatico.Name = "Rdb_automatico";
            this.Rdb_automatico.Size = new System.Drawing.Size(135, 29);
            this.Rdb_automatico.TabIndex = 12;
            this.Rdb_automatico.TabStop = true;
            this.Rdb_automatico.Text = "Automatico";
            this.Rdb_automatico.UseVisualStyleBackColor = true;
            this.Rdb_automatico.CheckedChanged += new System.EventHandler(this.Rdb_automatico_CheckedChanged);
            // 
            // Lbl_seleccion
            // 
            this.Lbl_seleccion.AutoSize = true;
            this.Lbl_seleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_seleccion.Location = new System.Drawing.Point(368, 92);
            this.Lbl_seleccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_seleccion.Name = "Lbl_seleccion";
            this.Lbl_seleccion.Size = new System.Drawing.Size(204, 25);
            this.Lbl_seleccion.TabIndex = 13;
            this.Lbl_seleccion.Text = "Seleccione su opcion:";
            this.Lbl_seleccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gpb_catalogos
            // 
            this.Gpb_catalogos.Controls.Add(this.label1);
            this.Gpb_catalogos.Controls.Add(this.Dtp_hora);
            this.Gpb_catalogos.Controls.Add(this.lbl_deporte);
            this.Gpb_catalogos.Controls.Add(this.Cbo_deporte);
            this.Gpb_catalogos.Controls.Add(this.Lbl_campos);
            this.Gpb_catalogos.Controls.Add(this.Cbo_campos);
            this.Gpb_catalogos.Controls.Add(this.Btn_agregar);
            this.Gpb_catalogos.Controls.Add(this.label6);
            this.Gpb_catalogos.Controls.Add(this.Dtp_fecha);
            this.Gpb_catalogos.Controls.Add(this.Cbo_equiposVisitantes);
            this.Gpb_catalogos.Controls.Add(this.Lbl_equipoVisitante);
            this.Gpb_catalogos.Controls.Add(this.Lbl_equipoLocal);
            this.Gpb_catalogos.Controls.Add(this.Lbl_jornadas);
            this.Gpb_catalogos.Controls.Add(this.Lbl_campeonatos);
            this.Gpb_catalogos.Controls.Add(this.Cbo_equiposLocales);
            this.Gpb_catalogos.Controls.Add(this.Cbo_jornadas);
            this.Gpb_catalogos.Controls.Add(this.Cbo_campeonatos);
            this.Gpb_catalogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_catalogos.Location = new System.Drawing.Point(62, 157);
            this.Gpb_catalogos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gpb_catalogos.Name = "Gpb_catalogos";
            this.Gpb_catalogos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gpb_catalogos.Size = new System.Drawing.Size(1075, 290);
            this.Gpb_catalogos.TabIndex = 14;
            this.Gpb_catalogos.TabStop = false;
            this.Gpb_catalogos.Text = "Catalogos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(929, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hora";
            // 
            // Dtp_hora
            // 
            this.Dtp_hora.CustomFormat = "HH:mm:00";
            this.Dtp_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_hora.Location = new System.Drawing.Point(902, 88);
            this.Dtp_hora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dtp_hora.Name = "Dtp_hora";
            this.Dtp_hora.ShowUpDown = true;
            this.Dtp_hora.Size = new System.Drawing.Size(165, 30);
            this.Dtp_hora.TabIndex = 15;
            // 
            // lbl_deporte
            // 
            this.lbl_deporte.AutoSize = true;
            this.lbl_deporte.Location = new System.Drawing.Point(45, 57);
            this.lbl_deporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_deporte.Name = "lbl_deporte";
            this.lbl_deporte.Size = new System.Drawing.Size(81, 25);
            this.lbl_deporte.TabIndex = 14;
            this.lbl_deporte.Text = "Deporte";
            // 
            // Cbo_deporte
            // 
            this.Cbo_deporte.FormattingEnabled = true;
            this.Cbo_deporte.Location = new System.Drawing.Point(36, 88);
            this.Cbo_deporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cbo_deporte.Name = "Cbo_deporte";
            this.Cbo_deporte.Size = new System.Drawing.Size(180, 33);
            this.Cbo_deporte.TabIndex = 13;
            this.Cbo_deporte.SelectedIndexChanged += new System.EventHandler(this.Cbo_deporte_SelectedIndexChanged);
            // 
            // Lbl_campos
            // 
            this.Lbl_campos.AutoSize = true;
            this.Lbl_campos.Location = new System.Drawing.Point(528, 194);
            this.Lbl_campos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_campos.Name = "Lbl_campos";
            this.Lbl_campos.Size = new System.Drawing.Size(76, 25);
            this.Lbl_campos.TabIndex = 12;
            this.Lbl_campos.Text = "Campo";
            // 
            // Cbo_campos
            // 
            this.Cbo_campos.FormattingEnabled = true;
            this.Cbo_campos.Location = new System.Drawing.Point(486, 225);
            this.Cbo_campos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cbo_campos.Name = "Cbo_campos";
            this.Cbo_campos.Size = new System.Drawing.Size(180, 33);
            this.Cbo_campos.TabIndex = 11;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Location = new System.Drawing.Point(872, 216);
            this.Btn_agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(195, 42);
            this.Btn_agregar.TabIndex = 10;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(718, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha";
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.CustomFormat = "yyyy-MM-dd";
            this.Dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fecha.Location = new System.Drawing.Point(713, 88);
            this.Dtp_fecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.ShowUpDown = true;
            this.Dtp_fecha.Size = new System.Drawing.Size(172, 30);
            this.Dtp_fecha.TabIndex = 8;
            // 
            // Cbo_equiposVisitantes
            // 
            this.Cbo_equiposVisitantes.FormattingEnabled = true;
            this.Cbo_equiposVisitantes.Location = new System.Drawing.Point(261, 225);
            this.Cbo_equiposVisitantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cbo_equiposVisitantes.Name = "Cbo_equiposVisitantes";
            this.Cbo_equiposVisitantes.Size = new System.Drawing.Size(180, 33);
            this.Cbo_equiposVisitantes.TabIndex = 7;
            // 
            // Lbl_equipoVisitante
            // 
            this.Lbl_equipoVisitante.AutoSize = true;
            this.Lbl_equipoVisitante.Location = new System.Drawing.Point(274, 194);
            this.Lbl_equipoVisitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_equipoVisitante.Name = "Lbl_equipoVisitante";
            this.Lbl_equipoVisitante.Size = new System.Drawing.Size(153, 25);
            this.Lbl_equipoVisitante.TabIndex = 6;
            this.Lbl_equipoVisitante.Text = "Equipo Visitante";
            // 
            // Lbl_equipoLocal
            // 
            this.Lbl_equipoLocal.AutoSize = true;
            this.Lbl_equipoLocal.Location = new System.Drawing.Point(57, 194);
            this.Lbl_equipoLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_equipoLocal.Name = "Lbl_equipoLocal";
            this.Lbl_equipoLocal.Size = new System.Drawing.Size(125, 25);
            this.Lbl_equipoLocal.TabIndex = 5;
            this.Lbl_equipoLocal.Text = "Equipo Local";
            // 
            // Lbl_jornadas
            // 
            this.Lbl_jornadas.AutoSize = true;
            this.Lbl_jornadas.Location = new System.Drawing.Point(521, 57);
            this.Lbl_jornadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_jornadas.Name = "Lbl_jornadas";
            this.Lbl_jornadas.Size = new System.Drawing.Size(84, 25);
            this.Lbl_jornadas.TabIndex = 4;
            this.Lbl_jornadas.Text = "Jornada";
            // 
            // Lbl_campeonatos
            // 
            this.Lbl_campeonatos.AutoSize = true;
            this.Lbl_campeonatos.Location = new System.Drawing.Point(277, 57);
            this.Lbl_campeonatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_campeonatos.Name = "Lbl_campeonatos";
            this.Lbl_campeonatos.Size = new System.Drawing.Size(135, 25);
            this.Lbl_campeonatos.TabIndex = 3;
            this.Lbl_campeonatos.Text = "Campeonatos";
            // 
            // Cbo_equiposLocales
            // 
            this.Cbo_equiposLocales.FormattingEnabled = true;
            this.Cbo_equiposLocales.Location = new System.Drawing.Point(36, 225);
            this.Cbo_equiposLocales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cbo_equiposLocales.Name = "Cbo_equiposLocales";
            this.Cbo_equiposLocales.Size = new System.Drawing.Size(180, 33);
            this.Cbo_equiposLocales.TabIndex = 2;
            // 
            // Cbo_jornadas
            // 
            this.Cbo_jornadas.FormattingEnabled = true;
            this.Cbo_jornadas.Location = new System.Drawing.Point(477, 88);
            this.Cbo_jornadas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cbo_jornadas.Name = "Cbo_jornadas";
            this.Cbo_jornadas.Size = new System.Drawing.Size(180, 33);
            this.Cbo_jornadas.TabIndex = 1;
            this.Cbo_jornadas.SelectedIndexChanged += new System.EventHandler(this.Cbo_jornadas_SelectedIndexChanged);
            // 
            // Cbo_campeonatos
            // 
            this.Cbo_campeonatos.FormattingEnabled = true;
            this.Cbo_campeonatos.Location = new System.Drawing.Point(263, 88);
            this.Cbo_campeonatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cbo_campeonatos.Name = "Cbo_campeonatos";
            this.Cbo_campeonatos.Size = new System.Drawing.Size(180, 33);
            this.Cbo_campeonatos.TabIndex = 0;
            this.Cbo_campeonatos.SelectedIndexChanged += new System.EventHandler(this.Cbo_campeonatos_SelectedIndexChanged);
            // 
            // Dgv_jornada
            // 
            this.Dgv_jornada.AllowUserToAddRows = false;
            this.Dgv_jornada.AllowUserToDeleteRows = false;
            this.Dgv_jornada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_jornada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_jornada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_jornada.Location = new System.Drawing.Point(62, 467);
            this.Dgv_jornada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dgv_jornada.Name = "Dgv_jornada";
            this.Dgv_jornada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_jornada.Size = new System.Drawing.Size(923, 269);
            this.Dgv_jornada.TabIndex = 15;
            // 
            // Btn_programacionFinalizada
            // 
            this.Btn_programacionFinalizada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_programacionFinalizada.Location = new System.Drawing.Point(1006, 619);
            this.Btn_programacionFinalizada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_programacionFinalizada.Name = "Btn_programacionFinalizada";
            this.Btn_programacionFinalizada.Size = new System.Drawing.Size(216, 63);
            this.Btn_programacionFinalizada.TabIndex = 16;
            this.Btn_programacionFinalizada.Text = "Finalizar";
            this.Btn_programacionFinalizada.UseVisualStyleBackColor = true;
            this.Btn_programacionFinalizada.Click += new System.EventHandler(this.Btn_programacionFinalizada_Click);
            // 
            // Btn_generarAutomatico
            // 
            this.Btn_generarAutomatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_generarAutomatico.Location = new System.Drawing.Point(1006, 524);
            this.Btn_generarAutomatico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_generarAutomatico.Name = "Btn_generarAutomatico";
            this.Btn_generarAutomatico.Size = new System.Drawing.Size(216, 63);
            this.Btn_generarAutomatico.TabIndex = 17;
            this.Btn_generarAutomatico.Text = "Generar automatico";
            this.Btn_generarAutomatico.UseVisualStyleBackColor = true;
            this.Btn_generarAutomatico.Click += new System.EventHandler(this.Btn_generarAutomatico_Click);
            // 
            // frm_nuevoCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 872);
            this.Controls.Add(this.Btn_generarAutomatico);
            this.Controls.Add(this.Btn_programacionFinalizada);
            this.Controls.Add(this.Dgv_jornada);
            this.Controls.Add(this.Gpb_catalogos);
            this.Controls.Add(this.Lbl_seleccion);
            this.Controls.Add(this.Rdb_automatico);
            this.Controls.Add(this.Rdb_manual);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_nuevoCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Calendario";
            this.Load += new System.EventHandler(this.frm_nuevoCalendario_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Gpb_catalogos.ResumeLayout(false);
            this.Gpb_catalogos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_jornada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_calendarioP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton Rdb_manual;
        private System.Windows.Forms.RadioButton Rdb_automatico;
        private System.Windows.Forms.Label Lbl_seleccion;
        private System.Windows.Forms.GroupBox Gpb_catalogos;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.ComboBox Cbo_equiposVisitantes;
        private System.Windows.Forms.Label Lbl_equipoVisitante;
        private System.Windows.Forms.Label Lbl_equipoLocal;
        private System.Windows.Forms.Label Lbl_jornadas;
        private System.Windows.Forms.Label Lbl_campeonatos;
        private System.Windows.Forms.ComboBox Cbo_equiposLocales;
        private System.Windows.Forms.ComboBox Cbo_jornadas;
        private System.Windows.Forms.ComboBox Cbo_campeonatos;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Dgv_jornada;
        private System.Windows.Forms.Button Btn_programacionFinalizada;
        private System.Windows.Forms.Label Lbl_campos;
        private System.Windows.Forms.ComboBox Cbo_campos;
        private System.Windows.Forms.Label lbl_deporte;
        private System.Windows.Forms.ComboBox Cbo_deporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_hora;
        private System.Windows.Forms.Button Btn_generarAutomatico;
    }
}