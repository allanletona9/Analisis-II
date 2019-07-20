namespace Polideportivo_Administrativo.Procesos
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
            this.Lbl_campos = new System.Windows.Forms.Label();
            this.Cbo_campos = new System.Windows.Forms.ComboBox();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Cbo_equiposVisitantes = new System.Windows.Forms.ComboBox();
            this.Lbl_equipoVisitante = new System.Windows.Forms.Label();
            this.Lbl_equipoLocal = new System.Windows.Forms.Label();
            this.Lbl_jornadas = new System.Windows.Forms.Label();
            this.Lbl_campeonatos = new System.Windows.Forms.Label();
            this.Cbo_equiposLocales = new System.Windows.Forms.ComboBox();
            this.Cbo_jornadas = new System.Windows.Forms.ComboBox();
            this.Cbo_campeonatos = new System.Windows.Forms.ComboBox();
            this.C = new System.Windows.Forms.DataGridView();
            this.Btn_programacionFinalizada = new System.Windows.Forms.Button();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Gpb_catalogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C)).BeginInit();
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
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(1084, 49);
            this.Pnl_titulo.TabIndex = 10;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_48;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_cerrar.Location = new System.Drawing.Point(1035, 3);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(46, 43);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_calendarioP
            // 
            this.Lbl_calendarioP.AutoSize = true;
            this.Lbl_calendarioP.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_calendarioP.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_calendarioP.Location = new System.Drawing.Point(45, 12);
            this.Lbl_calendarioP.Name = "Lbl_calendarioP";
            this.Lbl_calendarioP.Size = new System.Drawing.Size(364, 24);
            this.Lbl_calendarioP.TabIndex = 2;
            this.Lbl_calendarioP.Text = "PROGRAMACION DE CALENDARIO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_modo_deportes_24;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Rdb_manual
            // 
            this.Rdb_manual.AutoSize = true;
            this.Rdb_manual.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_manual.Location = new System.Drawing.Point(299, 200);
            this.Rdb_manual.Name = "Rdb_manual";
            this.Rdb_manual.Size = new System.Drawing.Size(74, 21);
            this.Rdb_manual.TabIndex = 11;
            this.Rdb_manual.TabStop = true;
            this.Rdb_manual.Text = "Manual";
            this.Rdb_manual.UseVisualStyleBackColor = true;
            // 
            // Rdb_automatico
            // 
            this.Rdb_automatico.AutoSize = true;
            this.Rdb_automatico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_automatico.Location = new System.Drawing.Point(453, 200);
            this.Rdb_automatico.Name = "Rdb_automatico";
            this.Rdb_automatico.Size = new System.Drawing.Size(104, 21);
            this.Rdb_automatico.TabIndex = 12;
            this.Rdb_automatico.TabStop = true;
            this.Rdb_automatico.Text = "Automatico";
            this.Rdb_automatico.UseVisualStyleBackColor = true;
            // 
            // Lbl_seleccion
            // 
            this.Lbl_seleccion.AutoSize = true;
            this.Lbl_seleccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_seleccion.Location = new System.Drawing.Point(73, 202);
            this.Lbl_seleccion.Name = "Lbl_seleccion";
            this.Lbl_seleccion.Size = new System.Drawing.Size(148, 17);
            this.Lbl_seleccion.TabIndex = 13;
            this.Lbl_seleccion.Text = "Seleccione su opcion:";
            this.Lbl_seleccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gpb_catalogos
            // 
            this.Gpb_catalogos.Controls.Add(this.Lbl_campos);
            this.Gpb_catalogos.Controls.Add(this.Cbo_campos);
            this.Gpb_catalogos.Controls.Add(this.Btn_agregar);
            this.Gpb_catalogos.Controls.Add(this.label6);
            this.Gpb_catalogos.Controls.Add(this.dateTimePicker1);
            this.Gpb_catalogos.Controls.Add(this.Cbo_equiposVisitantes);
            this.Gpb_catalogos.Controls.Add(this.Lbl_equipoVisitante);
            this.Gpb_catalogos.Controls.Add(this.Lbl_equipoLocal);
            this.Gpb_catalogos.Controls.Add(this.Lbl_jornadas);
            this.Gpb_catalogos.Controls.Add(this.Lbl_campeonatos);
            this.Gpb_catalogos.Controls.Add(this.Cbo_equiposLocales);
            this.Gpb_catalogos.Controls.Add(this.Cbo_jornadas);
            this.Gpb_catalogos.Controls.Add(this.Cbo_campeonatos);
            this.Gpb_catalogos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_catalogos.Location = new System.Drawing.Point(35, 257);
            this.Gpb_catalogos.Name = "Gpb_catalogos";
            this.Gpb_catalogos.Size = new System.Drawing.Size(568, 218);
            this.Gpb_catalogos.TabIndex = 14;
            this.Gpb_catalogos.TabStop = false;
            this.Gpb_catalogos.Text = "Catalogos";
            // 
            // Lbl_campos
            // 
            this.Lbl_campos.AutoSize = true;
            this.Lbl_campos.Location = new System.Drawing.Point(352, 126);
            this.Lbl_campos.Name = "Lbl_campos";
            this.Lbl_campos.Size = new System.Drawing.Size(59, 17);
            this.Lbl_campos.TabIndex = 12;
            this.Lbl_campos.Text = "Campo";
            // 
            // Cbo_campos
            // 
            this.Cbo_campos.FormattingEnabled = true;
            this.Cbo_campos.Location = new System.Drawing.Point(324, 146);
            this.Cbo_campos.Name = "Cbo_campos";
            this.Cbo_campos.Size = new System.Drawing.Size(121, 25);
            this.Cbo_campos.TabIndex = 11;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Location = new System.Drawing.Point(418, 185);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(130, 27);
            this.Btn_agregar.TabIndex = 10;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Cbo_equiposVisitantes
            // 
            this.Cbo_equiposVisitantes.FormattingEnabled = true;
            this.Cbo_equiposVisitantes.Location = new System.Drawing.Point(174, 146);
            this.Cbo_equiposVisitantes.Name = "Cbo_equiposVisitantes";
            this.Cbo_equiposVisitantes.Size = new System.Drawing.Size(121, 25);
            this.Cbo_equiposVisitantes.TabIndex = 7;
            // 
            // Lbl_equipoVisitante
            // 
            this.Lbl_equipoVisitante.AutoSize = true;
            this.Lbl_equipoVisitante.Location = new System.Drawing.Point(183, 126);
            this.Lbl_equipoVisitante.Name = "Lbl_equipoVisitante";
            this.Lbl_equipoVisitante.Size = new System.Drawing.Size(112, 17);
            this.Lbl_equipoVisitante.TabIndex = 6;
            this.Lbl_equipoVisitante.Text = "Equipo Visitante";
            // 
            // Lbl_equipoLocal
            // 
            this.Lbl_equipoLocal.AutoSize = true;
            this.Lbl_equipoLocal.Location = new System.Drawing.Point(38, 126);
            this.Lbl_equipoLocal.Name = "Lbl_equipoLocal";
            this.Lbl_equipoLocal.Size = new System.Drawing.Size(92, 17);
            this.Lbl_equipoLocal.TabIndex = 5;
            this.Lbl_equipoLocal.Text = "Equipo Local";
            // 
            // Lbl_jornadas
            // 
            this.Lbl_jornadas.AutoSize = true;
            this.Lbl_jornadas.Location = new System.Drawing.Point(196, 38);
            this.Lbl_jornadas.Name = "Lbl_jornadas";
            this.Lbl_jornadas.Size = new System.Drawing.Size(62, 17);
            this.Lbl_jornadas.TabIndex = 4;
            this.Lbl_jornadas.Text = "Jornada";
            // 
            // Lbl_campeonatos
            // 
            this.Lbl_campeonatos.AutoSize = true;
            this.Lbl_campeonatos.Location = new System.Drawing.Point(33, 38);
            this.Lbl_campeonatos.Name = "Lbl_campeonatos";
            this.Lbl_campeonatos.Size = new System.Drawing.Size(103, 17);
            this.Lbl_campeonatos.TabIndex = 3;
            this.Lbl_campeonatos.Text = "Campeonatos";
            // 
            // Cbo_equiposLocales
            // 
            this.Cbo_equiposLocales.FormattingEnabled = true;
            this.Cbo_equiposLocales.Location = new System.Drawing.Point(24, 146);
            this.Cbo_equiposLocales.Name = "Cbo_equiposLocales";
            this.Cbo_equiposLocales.Size = new System.Drawing.Size(121, 25);
            this.Cbo_equiposLocales.TabIndex = 2;
            // 
            // Cbo_jornadas
            // 
            this.Cbo_jornadas.FormattingEnabled = true;
            this.Cbo_jornadas.Location = new System.Drawing.Point(167, 58);
            this.Cbo_jornadas.Name = "Cbo_jornadas";
            this.Cbo_jornadas.Size = new System.Drawing.Size(121, 25);
            this.Cbo_jornadas.TabIndex = 1;
            // 
            // Cbo_campeonatos
            // 
            this.Cbo_campeonatos.FormattingEnabled = true;
            this.Cbo_campeonatos.Location = new System.Drawing.Point(24, 58);
            this.Cbo_campeonatos.Name = "Cbo_campeonatos";
            this.Cbo_campeonatos.Size = new System.Drawing.Size(121, 25);
            this.Cbo_campeonatos.TabIndex = 0;
            // 
            // C
            // 
            this.C.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.C.Location = new System.Drawing.Point(623, 65);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(449, 573);
            this.C.TabIndex = 15;
            // 
            // Btn_programacionFinalizada
            // 
            this.Btn_programacionFinalizada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_programacionFinalizada.Location = new System.Drawing.Point(418, 597);
            this.Btn_programacionFinalizada.Name = "Btn_programacionFinalizada";
            this.Btn_programacionFinalizada.Size = new System.Drawing.Size(199, 41);
            this.Btn_programacionFinalizada.TabIndex = 16;
            this.Btn_programacionFinalizada.Text = "Programacion Finalizada";
            this.Btn_programacionFinalizada.UseVisualStyleBackColor = true;
            // 
            // frm_nuevoCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.Btn_programacionFinalizada);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Gpb_catalogos);
            this.Controls.Add(this.Lbl_seleccion);
            this.Controls.Add(this.Rdb_automatico);
            this.Controls.Add(this.Rdb_manual);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_nuevoCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Calendario";
            this.Load += new System.EventHandler(this.frm_nuevoCalendario_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Gpb_catalogos.ResumeLayout(false);
            this.Gpb_catalogos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
        private System.Windows.Forms.DataGridView C;
        private System.Windows.Forms.Button Btn_programacionFinalizada;
        private System.Windows.Forms.Label Lbl_campos;
        private System.Windows.Forms.ComboBox Cbo_campos;
    }
}