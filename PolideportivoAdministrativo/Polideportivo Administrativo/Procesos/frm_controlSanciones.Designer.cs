namespace Polideportivo_Administrativo.Procesos
{
    partial class frm_controlSanciones
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
            this.Lbl_sancionesControl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Gpb_jugadores = new System.Windows.Forms.GroupBox();
            this.Cbo_jornadas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Txt_motivo = new System.Windows.Forms.RichTextBox();
            this.Lbl_sancion = new System.Windows.Forms.Label();
            this.Lbl_jugadores = new System.Windows.Forms.Label();
            this.Lbl_equipos = new System.Windows.Forms.Label();
            this.Cbo_sanciones = new System.Windows.Forms.ComboBox();
            this.Cbo_jugadores = new System.Windows.Forms.ComboBox();
            this.Cbo_equipos = new System.Windows.Forms.ComboBox();
            this.Dgv_sanciones = new System.Windows.Forms.DataGridView();
            this.PK_IdJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PK_IdSancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_finalizar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Gpb_jugadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Pnl_titulo.Controls.Add(this.Btn_cerrar);
            this.Pnl_titulo.Controls.Add(this.Lbl_sancionesControl);
            this.Pnl_titulo.Controls.Add(this.pictureBox2);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(1084, 37);
            this.Pnl_titulo.TabIndex = 9;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_48;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_cerrar.Location = new System.Drawing.Point(1051, 2);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(30, 31);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_sancionesControl
            // 
            this.Lbl_sancionesControl.AutoSize = true;
            this.Lbl_sancionesControl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sancionesControl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_sancionesControl.Location = new System.Drawing.Point(45, 6);
            this.Lbl_sancionesControl.Name = "Lbl_sancionesControl";
            this.Lbl_sancionesControl.Size = new System.Drawing.Size(267, 24);
            this.Lbl_sancionesControl.TabIndex = 2;
            this.Lbl_sancionesControl.Text = "CONTROL DE SANCIONES";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_modo_deportes_24;
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Gpb_jugadores
            // 
            this.Gpb_jugadores.Controls.Add(this.Cbo_jornadas);
            this.Gpb_jugadores.Controls.Add(this.label2);
            this.Gpb_jugadores.Controls.Add(this.label1);
            this.Gpb_jugadores.Controls.Add(this.Btn_agregar);
            this.Gpb_jugadores.Controls.Add(this.Txt_motivo);
            this.Gpb_jugadores.Controls.Add(this.Lbl_sancion);
            this.Gpb_jugadores.Controls.Add(this.Lbl_jugadores);
            this.Gpb_jugadores.Controls.Add(this.Lbl_equipos);
            this.Gpb_jugadores.Controls.Add(this.Cbo_sanciones);
            this.Gpb_jugadores.Controls.Add(this.Cbo_jugadores);
            this.Gpb_jugadores.Controls.Add(this.Cbo_equipos);
            this.Gpb_jugadores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_jugadores.Location = new System.Drawing.Point(129, 78);
            this.Gpb_jugadores.Name = "Gpb_jugadores";
            this.Gpb_jugadores.Size = new System.Drawing.Size(814, 168);
            this.Gpb_jugadores.TabIndex = 10;
            this.Gpb_jugadores.TabStop = false;
            this.Gpb_jugadores.Text = "Jugadores";
            // 
            // Cbo_jornadas
            // 
            this.Cbo_jornadas.FormattingEnabled = true;
            this.Cbo_jornadas.Location = new System.Drawing.Point(129, 111);
            this.Cbo_jornadas.Name = "Cbo_jornadas";
            this.Cbo_jornadas.Size = new System.Drawing.Size(121, 25);
            this.Cbo_jornadas.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Jornada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Motivo de Sancion";
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Location = new System.Drawing.Point(735, 89);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(73, 31);
            this.Btn_agregar.TabIndex = 6;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Txt_motivo
            // 
            this.Txt_motivo.Location = new System.Drawing.Point(465, 44);
            this.Txt_motivo.Name = "Txt_motivo";
            this.Txt_motivo.Size = new System.Drawing.Size(261, 87);
            this.Txt_motivo.TabIndex = 6;
            this.Txt_motivo.Text = "";
            // 
            // Lbl_sancion
            // 
            this.Lbl_sancion.AutoSize = true;
            this.Lbl_sancion.Location = new System.Drawing.Point(336, 24);
            this.Lbl_sancion.Name = "Lbl_sancion";
            this.Lbl_sancion.Size = new System.Drawing.Size(59, 17);
            this.Lbl_sancion.TabIndex = 5;
            this.Lbl_sancion.Text = "Sancion";
            // 
            // Lbl_jugadores
            // 
            this.Lbl_jugadores.AutoSize = true;
            this.Lbl_jugadores.Location = new System.Drawing.Point(188, 24);
            this.Lbl_jugadores.Name = "Lbl_jugadores";
            this.Lbl_jugadores.Size = new System.Drawing.Size(62, 17);
            this.Lbl_jugadores.TabIndex = 4;
            this.Lbl_jugadores.Text = "Jugador";
            // 
            // Lbl_equipos
            // 
            this.Lbl_equipos.AutoSize = true;
            this.Lbl_equipos.Location = new System.Drawing.Point(52, 24);
            this.Lbl_equipos.Name = "Lbl_equipos";
            this.Lbl_equipos.Size = new System.Drawing.Size(53, 17);
            this.Lbl_equipos.TabIndex = 3;
            this.Lbl_equipos.Text = "Equipo";
            // 
            // Cbo_sanciones
            // 
            this.Cbo_sanciones.FormattingEnabled = true;
            this.Cbo_sanciones.Location = new System.Drawing.Point(301, 44);
            this.Cbo_sanciones.Name = "Cbo_sanciones";
            this.Cbo_sanciones.Size = new System.Drawing.Size(121, 25);
            this.Cbo_sanciones.TabIndex = 2;
            // 
            // Cbo_jugadores
            // 
            this.Cbo_jugadores.FormattingEnabled = true;
            this.Cbo_jugadores.Location = new System.Drawing.Point(158, 44);
            this.Cbo_jugadores.Name = "Cbo_jugadores";
            this.Cbo_jugadores.Size = new System.Drawing.Size(121, 25);
            this.Cbo_jugadores.TabIndex = 1;
            this.Cbo_jugadores.SelectedIndexChanged += new System.EventHandler(this.Cbo_jugadores_SelectedIndexChanged);
            // 
            // Cbo_equipos
            // 
            this.Cbo_equipos.FormattingEnabled = true;
            this.Cbo_equipos.Location = new System.Drawing.Point(17, 44);
            this.Cbo_equipos.Name = "Cbo_equipos";
            this.Cbo_equipos.Size = new System.Drawing.Size(121, 25);
            this.Cbo_equipos.TabIndex = 0;
            this.Cbo_equipos.SelectedIndexChanged += new System.EventHandler(this.Cbo_equipos_SelectedIndexChanged);
            // 
            // Dgv_sanciones
            // 
            this.Dgv_sanciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_sanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_sanciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_IdJugador,
            this.Column2,
            this.PK_IdSancion,
            this.Column1,
            this.Column3});
            this.Dgv_sanciones.Location = new System.Drawing.Point(129, 252);
            this.Dgv_sanciones.Name = "Dgv_sanciones";
            this.Dgv_sanciones.Size = new System.Drawing.Size(814, 343);
            this.Dgv_sanciones.TabIndex = 11;
            // 
            // PK_IdJugador
            // 
            this.PK_IdJugador.HeaderText = "Codigo Jugador";
            this.PK_IdJugador.Name = "PK_IdJugador";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Jugador";
            this.Column2.Name = "Column2";
            // 
            // PK_IdSancion
            // 
            this.PK_IdSancion.HeaderText = "Codigo Sancion";
            this.PK_IdSancion.Name = "PK_IdSancion";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Motivo de Sancion";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jornada";
            this.Column3.Name = "Column3";
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Location = new System.Drawing.Point(960, 290);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(75, 28);
            this.Btn_eliminar.TabIndex = 12;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_finalizar
            // 
            this.Btn_finalizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_finalizar.Location = new System.Drawing.Point(960, 324);
            this.Btn_finalizar.Name = "Btn_finalizar";
            this.Btn_finalizar.Size = new System.Drawing.Size(75, 29);
            this.Btn_finalizar.TabIndex = 13;
            this.Btn_finalizar.Text = "Finalizar";
            this.Btn_finalizar.UseVisualStyleBackColor = true;
            this.Btn_finalizar.Click += new System.EventHandler(this.Btn_finalizar_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_ayuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_ayuda.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_ayuda_30;
            this.Btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ayuda.Location = new System.Drawing.Point(996, 39);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(85, 37);
            this.Btn_ayuda.TabIndex = 181;
            this.Btn_ayuda.Text = "Ayuda";
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // frm_controlSanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_finalizar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Dgv_sanciones);
            this.Controls.Add(this.Gpb_jugadores);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_controlSanciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Sanciones";
            this.Load += new System.EventHandler(this.frm_controlSanciones_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Gpb_jugadores.ResumeLayout(false);
            this.Gpb_jugadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sanciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_sancionesControl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox Gpb_jugadores;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Label Lbl_sancion;
        private System.Windows.Forms.Label Lbl_jugadores;
        private System.Windows.Forms.Label Lbl_equipos;
        private System.Windows.Forms.ComboBox Cbo_sanciones;
        private System.Windows.Forms.ComboBox Cbo_jugadores;
        private System.Windows.Forms.ComboBox Cbo_equipos;
        private System.Windows.Forms.DataGridView Dgv_sanciones;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_finalizar;
        private System.Windows.Forms.RichTextBox Txt_motivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_IdJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_IdSancion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox Cbo_jornadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}