namespace Polideportivo
{
    partial class frm_Partido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Partido));
            this.Lbl_jornada = new System.Windows.Forms.Label();
            this.Cbo_jornada = new System.Windows.Forms.ComboBox();
            this.Lbl_puntaje_equipo1 = new System.Windows.Forms.Label();
            this.Lbl_puntaje_equipo2 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl_estado_partido = new System.Windows.Forms.Label();
            this.Lbl_campo = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl_5 = new System.Windows.Forms.Label();
            this.Btn_sanciones = new System.Windows.Forms.Button();
            this.Btn_goleadores = new System.Windows.Forms.Button();
            this.Lbl_nombre_equipo1 = new System.Windows.Forms.Label();
            this.Lbl_nombre_equipo2 = new System.Windows.Forms.Label();
            this.Cbo_campeonato = new System.Windows.Forms.ComboBox();
            this.Lbl_campeonato = new System.Windows.Forms.Label();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_deportespro = new System.Windows.Forms.Label();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_jornada
            // 
            this.Lbl_jornada.AutoSize = true;
            this.Lbl_jornada.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_jornada.Location = new System.Drawing.Point(425, 62);
            this.Lbl_jornada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_jornada.Name = "Lbl_jornada";
            this.Lbl_jornada.Size = new System.Drawing.Size(79, 23);
            this.Lbl_jornada.TabIndex = 4;
            this.Lbl_jornada.Text = "Jornada:";
            // 
            // Cbo_jornada
            // 
            this.Cbo_jornada.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_jornada.FormattingEnabled = true;
            this.Cbo_jornada.Items.AddRange(new object[] {
            "Jornada 1",
            "Jornada 2",
            "Jornada 3",
            "Jornada 4"});
            this.Cbo_jornada.Location = new System.Drawing.Point(507, 62);
            this.Cbo_jornada.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_jornada.Name = "Cbo_jornada";
            this.Cbo_jornada.Size = new System.Drawing.Size(155, 31);
            this.Cbo_jornada.TabIndex = 5;
            this.Cbo_jornada.SelectedIndexChanged += new System.EventHandler(this.Cbo_jornada_SelectedIndexChanged);
            // 
            // Lbl_puntaje_equipo1
            // 
            this.Lbl_puntaje_equipo1.AutoSize = true;
            this.Lbl_puntaje_equipo1.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_puntaje_equipo1.Location = new System.Drawing.Point(394, 263);
            this.Lbl_puntaje_equipo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_puntaje_equipo1.Name = "Lbl_puntaje_equipo1";
            this.Lbl_puntaje_equipo1.Size = new System.Drawing.Size(143, 23);
            this.Lbl_puntaje_equipo1.TabIndex = 7;
            this.Lbl_puntaje_equipo1.Text = "Puntaje equipo 1";
            // 
            // Lbl_puntaje_equipo2
            // 
            this.Lbl_puntaje_equipo2.AutoSize = true;
            this.Lbl_puntaje_equipo2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_puntaje_equipo2.Location = new System.Drawing.Point(394, 293);
            this.Lbl_puntaje_equipo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_puntaje_equipo2.Name = "Lbl_puntaje_equipo2";
            this.Lbl_puntaje_equipo2.Size = new System.Drawing.Size(145, 23);
            this.Lbl_puntaje_equipo2.TabIndex = 8;
            this.Lbl_puntaje_equipo2.Text = "Puntaje equipo 2";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(253, 124);
            this.Lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(134, 23);
            this.Lbl1.TabIndex = 9;
            this.Lbl1.Text = "Estado partido:";
            // 
            // Lbl_estado_partido
            // 
            this.Lbl_estado_partido.AutoSize = true;
            this.Lbl_estado_partido.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado_partido.Location = new System.Drawing.Point(395, 124);
            this.Lbl_estado_partido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_estado_partido.Name = "Lbl_estado_partido";
            this.Lbl_estado_partido.Size = new System.Drawing.Size(92, 23);
            this.Lbl_estado_partido.TabIndex = 10;
            this.Lbl_estado_partido.Text = "Pendiente";
            // 
            // Lbl_campo
            // 
            this.Lbl_campo.AutoSize = true;
            this.Lbl_campo.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_campo.Location = new System.Drawing.Point(395, 153);
            this.Lbl_campo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_campo.Name = "Lbl_campo";
            this.Lbl_campo.Size = new System.Drawing.Size(78, 23);
            this.Lbl_campo.TabIndex = 12;
            this.Lbl_campo.Text = "Campo 1";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(314, 153);
            this.Lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(73, 23);
            this.Lbl2.TabIndex = 11;
            this.Lbl2.Text = "Campo:";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(395, 188);
            this.Lbl_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(108, 23);
            this.Lbl_fecha.TabIndex = 14;
            this.Lbl_fecha.Text = "XX/XX/XXXX";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(323, 188);
            this.Lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(61, 23);
            this.Lbl3.TabIndex = 13;
            this.Lbl3.Text = "Fecha:";
            // 
            // Lbl_5
            // 
            this.Lbl_5.AutoSize = true;
            this.Lbl_5.Font = new System.Drawing.Font("Candara", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_5.Location = new System.Drawing.Point(335, 229);
            this.Lbl_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_5.Name = "Lbl_5";
            this.Lbl_5.Size = new System.Drawing.Size(91, 23);
            this.Lbl_5.TabIndex = 17;
            this.Lbl_5.Text = "Resultado";
            // 
            // Btn_sanciones
            // 
            this.Btn_sanciones.BackColor = System.Drawing.Color.Teal;
            this.Btn_sanciones.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sanciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_sanciones.Location = new System.Drawing.Point(44, 397);
            this.Btn_sanciones.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_sanciones.Name = "Btn_sanciones";
            this.Btn_sanciones.Size = new System.Drawing.Size(249, 38);
            this.Btn_sanciones.TabIndex = 18;
            this.Btn_sanciones.Text = "Consultar sanciones";
            this.Btn_sanciones.UseVisualStyleBackColor = false;
            this.Btn_sanciones.Click += new System.EventHandler(this.Btn_sanciones_Click);
            // 
            // Btn_goleadores
            // 
            this.Btn_goleadores.BackColor = System.Drawing.Color.Teal;
            this.Btn_goleadores.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_goleadores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_goleadores.Location = new System.Drawing.Point(474, 397);
            this.Btn_goleadores.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_goleadores.Name = "Btn_goleadores";
            this.Btn_goleadores.Size = new System.Drawing.Size(248, 38);
            this.Btn_goleadores.TabIndex = 19;
            this.Btn_goleadores.Text = "Mejores jugadores";
            this.Btn_goleadores.UseVisualStyleBackColor = false;
            this.Btn_goleadores.Click += new System.EventHandler(this.Btn_goleadores_Click);
            // 
            // Lbl_nombre_equipo1
            // 
            this.Lbl_nombre_equipo1.AutoSize = true;
            this.Lbl_nombre_equipo1.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre_equipo1.Location = new System.Drawing.Point(219, 263);
            this.Lbl_nombre_equipo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nombre_equipo1.Name = "Lbl_nombre_equipo1";
            this.Lbl_nombre_equipo1.Size = new System.Drawing.Size(83, 23);
            this.Lbl_nombre_equipo1.TabIndex = 20;
            this.Lbl_nombre_equipo1.Text = "Equipo 1:";
            // 
            // Lbl_nombre_equipo2
            // 
            this.Lbl_nombre_equipo2.AutoSize = true;
            this.Lbl_nombre_equipo2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre_equipo2.Location = new System.Drawing.Point(219, 293);
            this.Lbl_nombre_equipo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nombre_equipo2.Name = "Lbl_nombre_equipo2";
            this.Lbl_nombre_equipo2.Size = new System.Drawing.Size(86, 23);
            this.Lbl_nombre_equipo2.TabIndex = 21;
            this.Lbl_nombre_equipo2.Text = "Equipo 2:";
            // 
            // Cbo_campeonato
            // 
            this.Cbo_campeonato.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_campeonato.FormattingEnabled = true;
            this.Cbo_campeonato.Items.AddRange(new object[] {
            "Campeonato 1",
            "Campeonato 2",
            "Campeonato 3"});
            this.Cbo_campeonato.Location = new System.Drawing.Point(239, 60);
            this.Cbo_campeonato.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_campeonato.Name = "Cbo_campeonato";
            this.Cbo_campeonato.Size = new System.Drawing.Size(164, 31);
            this.Cbo_campeonato.TabIndex = 23;
            // 
            // Lbl_campeonato
            // 
            this.Lbl_campeonato.AutoSize = true;
            this.Lbl_campeonato.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_campeonato.Location = new System.Drawing.Point(118, 64);
            this.Lbl_campeonato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_campeonato.Name = "Lbl_campeonato";
            this.Lbl_campeonato.Size = new System.Drawing.Size(119, 23);
            this.Lbl_campeonato.TabIndex = 22;
            this.Lbl_campeonato.Text = "Campeonato:";
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.Teal;
            this.Pnl_titulo.Controls.Add(this.pictureBox2);
            this.Pnl_titulo.Controls.Add(this.Btn_cerrar);
            this.Pnl_titulo.Controls.Add(this.Lbl_deportespro);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(763, 35);
            this.Pnl_titulo.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackColor = System.Drawing.Color.Teal;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.Teal;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(724, 4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(30, 29);
            this.Btn_cerrar.TabIndex = 10;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_deportespro
            // 
            this.Lbl_deportespro.AutoSize = true;
            this.Lbl_deportespro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_deportespro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_deportespro.Location = new System.Drawing.Point(45, 9);
            this.Lbl_deportespro.Name = "Lbl_deportespro";
            this.Lbl_deportespro.Size = new System.Drawing.Size(80, 25);
            this.Lbl_deportespro.TabIndex = 7;
            this.Lbl_deportespro.Text = "Partido";
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_ayuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_ayuda.Image = global::Polideportivo.Properties.Resources.icons8_ayuda_30;
            this.Btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ayuda.Location = new System.Drawing.Point(675, 39);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(85, 37);
            this.Btn_ayuda.TabIndex = 185;
            this.Btn_ayuda.Text = "Ayuda";
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // frm_Partido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(763, 449);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.Cbo_campeonato);
            this.Controls.Add(this.Lbl_campeonato);
            this.Controls.Add(this.Lbl_nombre_equipo2);
            this.Controls.Add(this.Lbl_nombre_equipo1);
            this.Controls.Add(this.Btn_goleadores);
            this.Controls.Add(this.Btn_sanciones);
            this.Controls.Add(this.Lbl_5);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl_campo);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl_estado_partido);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Lbl_puntaje_equipo2);
            this.Controls.Add(this.Lbl_puntaje_equipo1);
            this.Controls.Add(this.Cbo_jornada);
            this.Controls.Add(this.Lbl_jornada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Partido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partidos";
            this.Load += new System.EventHandler(this.Partidos_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_jornada;
        private System.Windows.Forms.ComboBox Cbo_jornada;
        private System.Windows.Forms.Label Lbl_puntaje_equipo1;
        private System.Windows.Forms.Label Lbl_puntaje_equipo2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl_estado_partido;
        private System.Windows.Forms.Label Lbl_campo;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl_5;
        private System.Windows.Forms.Button Btn_sanciones;
        private System.Windows.Forms.Button Btn_goleadores;
        private System.Windows.Forms.Label Lbl_nombre_equipo1;
        private System.Windows.Forms.Label Lbl_nombre_equipo2;
        private System.Windows.Forms.ComboBox Cbo_campeonato;
        private System.Windows.Forms.Label Lbl_campeonato;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_deportespro;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}