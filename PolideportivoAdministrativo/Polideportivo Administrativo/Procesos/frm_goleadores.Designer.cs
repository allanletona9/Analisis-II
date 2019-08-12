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
            this.Cbo_jugadores = new System.Windows.Forms.ComboBox();
            this.Cbo_equipos = new System.Windows.Forms.ComboBox();
            this.Lbl_jugador = new System.Windows.Forms.Label();
            this.Lbl_equipo = new System.Windows.Forms.Label();
            this.Dgv_goleadores = new System.Windows.Forms.DataGridView();
            this.PK_IdJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_ayuda = new System.Windows.Forms.Button();
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
            this.Gpb_consulta.Controls.Add(this.Cbo_jugadores);
            this.Gpb_consulta.Controls.Add(this.Cbo_equipos);
            this.Gpb_consulta.Controls.Add(this.Lbl_jugador);
            this.Gpb_consulta.Controls.Add(this.Lbl_equipo);
            this.Gpb_consulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_consulta.Location = new System.Drawing.Point(202, 94);
            this.Gpb_consulta.Name = "Gpb_consulta";
            this.Gpb_consulta.Size = new System.Drawing.Size(542, 118);
            this.Gpb_consulta.TabIndex = 10;
            this.Gpb_consulta.TabStop = false;
            this.Gpb_consulta.Text = "Consulta";
            // 
            // Cbo_jugadores
            // 
            this.Cbo_jugadores.FormattingEnabled = true;
            this.Cbo_jugadores.Location = new System.Drawing.Point(298, 51);
            this.Cbo_jugadores.Name = "Cbo_jugadores";
            this.Cbo_jugadores.Size = new System.Drawing.Size(121, 25);
            this.Cbo_jugadores.TabIndex = 3;
            this.Cbo_jugadores.SelectedIndexChanged += new System.EventHandler(this.Cbo_jugadores_SelectedIndexChanged);
            // 
            // Cbo_equipos
            // 
            this.Cbo_equipos.FormattingEnabled = true;
            this.Cbo_equipos.Location = new System.Drawing.Point(97, 51);
            this.Cbo_equipos.Name = "Cbo_equipos";
            this.Cbo_equipos.Size = new System.Drawing.Size(121, 25);
            this.Cbo_equipos.TabIndex = 2;
            this.Cbo_equipos.SelectedIndexChanged += new System.EventHandler(this.Cbo_equipos_SelectedIndexChanged);
            // 
            // Lbl_jugador
            // 
            this.Lbl_jugador.AutoSize = true;
            this.Lbl_jugador.Location = new System.Drawing.Point(325, 31);
            this.Lbl_jugador.Name = "Lbl_jugador";
            this.Lbl_jugador.Size = new System.Drawing.Size(62, 17);
            this.Lbl_jugador.TabIndex = 1;
            this.Lbl_jugador.Text = "Jugador";
            // 
            // Lbl_equipo
            // 
            this.Lbl_equipo.AutoSize = true;
            this.Lbl_equipo.Location = new System.Drawing.Point(129, 31);
            this.Lbl_equipo.Name = "Lbl_equipo";
            this.Lbl_equipo.Size = new System.Drawing.Size(53, 17);
            this.Lbl_equipo.TabIndex = 0;
            this.Lbl_equipo.Text = "Equipo";
            // 
            // Dgv_goleadores
            // 
            this.Dgv_goleadores.AllowUserToAddRows = false;
            this.Dgv_goleadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_goleadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_goleadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_IdJugador,
            this.Nombre,
            this.Apellido,
            this.Goles});
            this.Dgv_goleadores.Location = new System.Drawing.Point(148, 245);
            this.Dgv_goleadores.Name = "Dgv_goleadores";
            this.Dgv_goleadores.Size = new System.Drawing.Size(640, 377);
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
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_ayuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_ayuda.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_ayuda_30;
            this.Btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ayuda.Location = new System.Drawing.Point(888, 43);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(85, 37);
            this.Btn_ayuda.TabIndex = 182;
            this.Btn_ayuda.Text = "Ayuda";
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // frm_goleadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 690);
            this.Controls.Add(this.Btn_ayuda);
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
        private System.Windows.Forms.ComboBox Cbo_jugadores;
        private System.Windows.Forms.ComboBox Cbo_equipos;
        private System.Windows.Forms.Label Lbl_jugador;
        private System.Windows.Forms.Label Lbl_equipo;
        private System.Windows.Forms.DataGridView Dgv_goleadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_IdJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goles;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}