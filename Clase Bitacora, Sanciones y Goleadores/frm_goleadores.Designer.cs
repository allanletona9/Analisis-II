namespace Polideportivo_Administrativo.Procesos
{
    partial class frm_goleadores
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
            this.lbl_deportes = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Gpb_consulta = new System.Windows.Forms.GroupBox();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.Cbo_jugadores = new System.Windows.Forms.ComboBox();
            this.Cbo_equipos = new System.Windows.Forms.ComboBox();
            this.Lbl_jugador = new System.Windows.Forms.Label();
            this.Lbl_equipo = new System.Windows.Forms.Label();
            this.Dgv_goleadores = new System.Windows.Forms.DataGridView();
            this.PK_IdJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_nuevaConsulta = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Gpb_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_goleadores)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Pnl_titulo.Controls.Add(this.Btn_cerrar);
            this.Pnl_titulo.Controls.Add(this.lbl_deportes);
            this.Pnl_titulo.Controls.Add(this.pictureBox2);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(976, 37);
            this.Pnl_titulo.TabIndex = 9;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_48;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_cerrar.Location = new System.Drawing.Point(943, 3);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(30, 31);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // lbl_deportes
            // 
            this.lbl_deportes.AutoSize = true;
            this.lbl_deportes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deportes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_deportes.Location = new System.Drawing.Point(45, 7);
            this.lbl_deportes.Name = "lbl_deportes";
            this.lbl_deportes.Size = new System.Drawing.Size(150, 24);
            this.lbl_deportes.TabIndex = 2;
            this.lbl_deportes.Text = "GOLEADORES";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_modo_deportes_24;
            this.pictureBox2.Location = new System.Drawing.Point(12, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Gpb_consulta
            // 
            this.Gpb_consulta.Controls.Add(this.Btn_Consultar);
            this.Gpb_consulta.Controls.Add(this.Cbo_jugadores);
            this.Gpb_consulta.Controls.Add(this.Cbo_equipos);
            this.Gpb_consulta.Controls.Add(this.Lbl_jugador);
            this.Gpb_consulta.Controls.Add(this.Lbl_equipo);
            this.Gpb_consulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_consulta.Location = new System.Drawing.Point(191, 109);
            this.Gpb_consulta.Name = "Gpb_consulta";
            this.Gpb_consulta.Size = new System.Drawing.Size(542, 118);
            this.Gpb_consulta.TabIndex = 10;
            this.Gpb_consulta.TabStop = false;
            this.Gpb_consulta.Text = "Consulta";
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Location = new System.Drawing.Point(411, 51);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(93, 25);
            this.Btn_Consultar.TabIndex = 4;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // Cbo_jugadores
            // 
            this.Cbo_jugadores.FormattingEnabled = true;
            this.Cbo_jugadores.Location = new System.Drawing.Point(224, 51);
            this.Cbo_jugadores.Name = "Cbo_jugadores";
            this.Cbo_jugadores.Size = new System.Drawing.Size(121, 25);
            this.Cbo_jugadores.TabIndex = 3;
            // 
            // Cbo_equipos
            // 
            this.Cbo_equipos.FormattingEnabled = true;
            this.Cbo_equipos.Location = new System.Drawing.Point(43, 51);
            this.Cbo_equipos.Name = "Cbo_equipos";
            this.Cbo_equipos.Size = new System.Drawing.Size(121, 25);
            this.Cbo_equipos.TabIndex = 2;
            // 
            // Lbl_jugador
            // 
            this.Lbl_jugador.AutoSize = true;
            this.Lbl_jugador.Location = new System.Drawing.Point(251, 31);
            this.Lbl_jugador.Name = "Lbl_jugador";
            this.Lbl_jugador.Size = new System.Drawing.Size(62, 17);
            this.Lbl_jugador.TabIndex = 1;
            this.Lbl_jugador.Text = "Jugador";
            // 
            // Lbl_equipo
            // 
            this.Lbl_equipo.AutoSize = true;
            this.Lbl_equipo.Location = new System.Drawing.Point(75, 31);
            this.Lbl_equipo.Name = "Lbl_equipo";
            this.Lbl_equipo.Size = new System.Drawing.Size(53, 17);
            this.Lbl_equipo.TabIndex = 0;
            this.Lbl_equipo.Text = "Equipo";
            // 
            // Dgv_goleadores
            // 
            this.Dgv_goleadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_goleadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_IdJugador,
            this.Nombre,
            this.Apellido,
            this.Goles});
            this.Dgv_goleadores.Location = new System.Drawing.Point(243, 265);
            this.Dgv_goleadores.Name = "Dgv_goleadores";
            this.Dgv_goleadores.Size = new System.Drawing.Size(443, 337);
            this.Dgv_goleadores.TabIndex = 11;
            // 
            // PK_IdJugador
            // 
            this.PK_IdJugador.HeaderText = "Codigo Jugador";
            this.PK_IdJugador.Name = "PK_IdJugador";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Goles
            // 
            this.Goles.HeaderText = "Goles";
            this.Goles.Name = "Goles";
            // 
            // Btn_nuevaConsulta
            // 
            this.Btn_nuevaConsulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nuevaConsulta.Location = new System.Drawing.Point(739, 503);
            this.Btn_nuevaConsulta.Name = "Btn_nuevaConsulta";
            this.Btn_nuevaConsulta.Size = new System.Drawing.Size(221, 38);
            this.Btn_nuevaConsulta.TabIndex = 12;
            this.Btn_nuevaConsulta.Text = "Nueva Consulta";
            this.Btn_nuevaConsulta.UseVisualStyleBackColor = true;
            this.Btn_nuevaConsulta.Click += new System.EventHandler(this.Btn_nuevaConsulta_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.Location = new System.Drawing.Point(739, 564);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(221, 38);
            this.Btn_salir.TabIndex = 13;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // frm_goleadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 690);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_nuevaConsulta);
            this.Controls.Add(this.Dgv_goleadores);
            this.Controls.Add(this.Gpb_consulta);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_goleadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_goleadores";
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Gpb_consulta.ResumeLayout(false);
            this.Gpb_consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_goleadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label lbl_deportes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox Gpb_consulta;
        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.ComboBox Cbo_jugadores;
        private System.Windows.Forms.ComboBox Cbo_equipos;
        private System.Windows.Forms.Label Lbl_jugador;
        private System.Windows.Forms.Label Lbl_equipo;
        private System.Windows.Forms.DataGridView Dgv_goleadores;
        private System.Windows.Forms.Button Btn_nuevaConsulta;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_IdJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goles;
    }
}