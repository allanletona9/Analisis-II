namespace Polideportivo_Administrativo.Procesos
{
    partial class frm_controlResultados
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
            this.Cbo_campeonatos = new System.Windows.Forms.ComboBox();
            this.Cbo_jornada = new System.Windows.Forms.ComboBox();
            this.Lbl_campeonato = new System.Windows.Forms.Label();
            this.Lbl_jornada = new System.Windows.Forms.Label();
            this.Cbo_enfrentamientos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_local = new System.Windows.Forms.TextBox();
            this.Txt_visitante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.Cbo_jugador = new System.Windows.Forms.ComboBox();
            this.Cbo_jugador2 = new System.Windows.Forms.ComboBox();
            this.Lbl_goles = new System.Windows.Forms.Label();
            this.Txt_goles = new System.Windows.Forms.TextBox();
            this.Txt_goles2 = new System.Windows.Forms.TextBox();
            this.Lbl_goles2 = new System.Windows.Forms.Label();
            this.Lbl_jugador = new System.Windows.Forms.Label();
            this.Lbl_jugador2 = new System.Windows.Forms.Label();
            this.Dgv_golesLocal = new System.Windows.Forms.DataGridView();
            this.Dgv_golesVisita = new System.Windows.Forms.DataGridView();
            this.Btn_agrega1 = new System.Windows.Forms.Button();
            this.Btn_agrega2 = new System.Windows.Forms.Button();
            this.Btn_eliminar1 = new System.Windows.Forms.Button();
            this.Btn_eliminar2 = new System.Windows.Forms.Button();
            this.Gpb_datosPartido = new System.Windows.Forms.GroupBox();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_golesLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_golesVisita)).BeginInit();
            this.Gpb_datosPartido.SuspendLayout();
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
            this.Pnl_titulo.Size = new System.Drawing.Size(976, 35);
            this.Pnl_titulo.TabIndex = 8;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_48;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_cerrar.Location = new System.Drawing.Point(943, 0);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(30, 29);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_deportes
            // 
            this.lbl_deportes.AutoSize = true;
            this.lbl_deportes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deportes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_deportes.Location = new System.Drawing.Point(45, 3);
            this.lbl_deportes.Name = "lbl_deportes";
            this.lbl_deportes.Size = new System.Drawing.Size(273, 24);
            this.lbl_deportes.TabIndex = 2;
            this.lbl_deportes.Text = "CONTROL DE RESULTADOS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_modo_deportes_24;
            this.pictureBox2.Location = new System.Drawing.Point(12, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Cbo_campeonatos
            // 
            this.Cbo_campeonatos.FormattingEnabled = true;
            this.Cbo_campeonatos.Location = new System.Drawing.Point(37, 40);
            this.Cbo_campeonatos.Name = "Cbo_campeonatos";
            this.Cbo_campeonatos.Size = new System.Drawing.Size(121, 25);
            this.Cbo_campeonatos.TabIndex = 9;
            // 
            // Cbo_jornada
            // 
            this.Cbo_jornada.FormattingEnabled = true;
            this.Cbo_jornada.Location = new System.Drawing.Point(190, 40);
            this.Cbo_jornada.Name = "Cbo_jornada";
            this.Cbo_jornada.Size = new System.Drawing.Size(121, 25);
            this.Cbo_jornada.TabIndex = 10;
            // 
            // Lbl_campeonato
            // 
            this.Lbl_campeonato.AutoSize = true;
            this.Lbl_campeonato.Location = new System.Drawing.Point(49, 24);
            this.Lbl_campeonato.Name = "Lbl_campeonato";
            this.Lbl_campeonato.Size = new System.Drawing.Size(98, 17);
            this.Lbl_campeonato.TabIndex = 11;
            this.Lbl_campeonato.Text = "Campeonato";
            // 
            // Lbl_jornada
            // 
            this.Lbl_jornada.AutoSize = true;
            this.Lbl_jornada.Location = new System.Drawing.Point(223, 24);
            this.Lbl_jornada.Name = "Lbl_jornada";
            this.Lbl_jornada.Size = new System.Drawing.Size(62, 17);
            this.Lbl_jornada.TabIndex = 12;
            this.Lbl_jornada.Text = "Jornada";
            // 
            // Cbo_enfrentamientos
            // 
            this.Cbo_enfrentamientos.FormattingEnabled = true;
            this.Cbo_enfrentamientos.Location = new System.Drawing.Point(37, 110);
            this.Cbo_enfrentamientos.Name = "Cbo_enfrentamientos";
            this.Cbo_enfrentamientos.Size = new System.Drawing.Size(121, 25);
            this.Cbo_enfrentamientos.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enfrentamientos";
            // 
            // Txt_local
            // 
            this.Txt_local.Location = new System.Drawing.Point(190, 110);
            this.Txt_local.Name = "Txt_local";
            this.Txt_local.Size = new System.Drawing.Size(42, 23);
            this.Txt_local.TabIndex = 15;
            // 
            // Txt_visitante
            // 
            this.Txt_visitante.Location = new System.Drawing.Point(269, 110);
            this.Txt_visitante.Name = "Txt_visitante";
            this.Txt_visitante.Size = new System.Drawing.Size(42, 23);
            this.Txt_visitante.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Resultado";
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_aceptar.Location = new System.Drawing.Point(399, 527);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(221, 38);
            this.Btn_aceptar.TabIndex = 18;
            this.Btn_aceptar.Text = "Aceptar";
            this.Btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // Cbo_jugador
            // 
            this.Cbo_jugador.FormattingEnabled = true;
            this.Cbo_jugador.Location = new System.Drawing.Point(297, 282);
            this.Cbo_jugador.Name = "Cbo_jugador";
            this.Cbo_jugador.Size = new System.Drawing.Size(121, 21);
            this.Cbo_jugador.TabIndex = 19;
            // 
            // Cbo_jugador2
            // 
            this.Cbo_jugador2.FormattingEnabled = true;
            this.Cbo_jugador2.Location = new System.Drawing.Point(543, 282);
            this.Cbo_jugador2.Name = "Cbo_jugador2";
            this.Cbo_jugador2.Size = new System.Drawing.Size(121, 21);
            this.Cbo_jugador2.TabIndex = 20;
            // 
            // Lbl_goles
            // 
            this.Lbl_goles.AutoSize = true;
            this.Lbl_goles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_goles.Location = new System.Drawing.Point(421, 262);
            this.Lbl_goles.Name = "Lbl_goles";
            this.Lbl_goles.Size = new System.Drawing.Size(44, 17);
            this.Lbl_goles.TabIndex = 21;
            this.Lbl_goles.Text = "Goles";
            // 
            // Txt_goles
            // 
            this.Txt_goles.Location = new System.Drawing.Point(424, 282);
            this.Txt_goles.Name = "Txt_goles";
            this.Txt_goles.Size = new System.Drawing.Size(42, 20);
            this.Txt_goles.TabIndex = 22;
            // 
            // Txt_goles2
            // 
            this.Txt_goles2.Location = new System.Drawing.Point(670, 283);
            this.Txt_goles2.Name = "Txt_goles2";
            this.Txt_goles2.Size = new System.Drawing.Size(42, 20);
            this.Txt_goles2.TabIndex = 24;
            // 
            // Lbl_goles2
            // 
            this.Lbl_goles2.AutoSize = true;
            this.Lbl_goles2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_goles2.Location = new System.Drawing.Point(668, 264);
            this.Lbl_goles2.Name = "Lbl_goles2";
            this.Lbl_goles2.Size = new System.Drawing.Size(44, 17);
            this.Lbl_goles2.TabIndex = 23;
            this.Lbl_goles2.Text = "Goles";
            // 
            // Lbl_jugador
            // 
            this.Lbl_jugador.AutoSize = true;
            this.Lbl_jugador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_jugador.Location = new System.Drawing.Point(331, 264);
            this.Lbl_jugador.Name = "Lbl_jugador";
            this.Lbl_jugador.Size = new System.Drawing.Size(62, 17);
            this.Lbl_jugador.TabIndex = 25;
            this.Lbl_jugador.Text = "Jugador";
            // 
            // Lbl_jugador2
            // 
            this.Lbl_jugador2.AutoSize = true;
            this.Lbl_jugador2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_jugador2.Location = new System.Drawing.Point(572, 262);
            this.Lbl_jugador2.Name = "Lbl_jugador2";
            this.Lbl_jugador2.Size = new System.Drawing.Size(62, 17);
            this.Lbl_jugador2.TabIndex = 26;
            this.Lbl_jugador2.Text = "Jugador";
            // 
            // Dgv_golesLocal
            // 
            this.Dgv_golesLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_golesLocal.Location = new System.Drawing.Point(297, 330);
            this.Dgv_golesLocal.Name = "Dgv_golesLocal";
            this.Dgv_golesLocal.Size = new System.Drawing.Size(169, 191);
            this.Dgv_golesLocal.TabIndex = 27;
            // 
            // Dgv_golesVisita
            // 
            this.Dgv_golesVisita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_golesVisita.Location = new System.Drawing.Point(543, 330);
            this.Dgv_golesVisita.Name = "Dgv_golesVisita";
            this.Dgv_golesVisita.Size = new System.Drawing.Size(169, 191);
            this.Dgv_golesVisita.TabIndex = 28;
            // 
            // Btn_agrega1
            // 
            this.Btn_agrega1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agrega1.Location = new System.Drawing.Point(472, 280);
            this.Btn_agrega1.Name = "Btn_agrega1";
            this.Btn_agrega1.Size = new System.Drawing.Size(29, 23);
            this.Btn_agrega1.TabIndex = 29;
            this.Btn_agrega1.Text = "+";
            this.Btn_agrega1.UseVisualStyleBackColor = true;
            // 
            // Btn_agrega2
            // 
            this.Btn_agrega2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agrega2.Location = new System.Drawing.Point(718, 283);
            this.Btn_agrega2.Name = "Btn_agrega2";
            this.Btn_agrega2.Size = new System.Drawing.Size(29, 23);
            this.Btn_agrega2.TabIndex = 34;
            this.Btn_agrega2.Text = "+";
            this.Btn_agrega2.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar1
            // 
            this.Btn_eliminar1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar1.Location = new System.Drawing.Point(472, 330);
            this.Btn_eliminar1.Name = "Btn_eliminar1";
            this.Btn_eliminar1.Size = new System.Drawing.Size(29, 23);
            this.Btn_eliminar1.TabIndex = 35;
            this.Btn_eliminar1.Text = "X";
            this.Btn_eliminar1.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar2
            // 
            this.Btn_eliminar2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar2.Location = new System.Drawing.Point(718, 330);
            this.Btn_eliminar2.Name = "Btn_eliminar2";
            this.Btn_eliminar2.Size = new System.Drawing.Size(29, 23);
            this.Btn_eliminar2.TabIndex = 36;
            this.Btn_eliminar2.Text = "X";
            this.Btn_eliminar2.UseVisualStyleBackColor = true;
            // 
            // Gpb_datosPartido
            // 
            this.Gpb_datosPartido.Controls.Add(this.Cbo_enfrentamientos);
            this.Gpb_datosPartido.Controls.Add(this.Cbo_campeonatos);
            this.Gpb_datosPartido.Controls.Add(this.Cbo_jornada);
            this.Gpb_datosPartido.Controls.Add(this.Lbl_campeonato);
            this.Gpb_datosPartido.Controls.Add(this.Lbl_jornada);
            this.Gpb_datosPartido.Controls.Add(this.label3);
            this.Gpb_datosPartido.Controls.Add(this.Txt_local);
            this.Gpb_datosPartido.Controls.Add(this.Txt_visitante);
            this.Gpb_datosPartido.Controls.Add(this.label4);
            this.Gpb_datosPartido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosPartido.Location = new System.Drawing.Point(297, 100);
            this.Gpb_datosPartido.Name = "Gpb_datosPartido";
            this.Gpb_datosPartido.Size = new System.Drawing.Size(443, 147);
            this.Gpb_datosPartido.TabIndex = 37;
            this.Gpb_datosPartido.TabStop = false;
            this.Gpb_datosPartido.Text = "Datos del Partido";
            // 
            // frm_controlResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 690);
            this.Controls.Add(this.Gpb_datosPartido);
            this.Controls.Add(this.Btn_eliminar2);
            this.Controls.Add(this.Btn_eliminar1);
            this.Controls.Add(this.Btn_agrega2);
            this.Controls.Add(this.Btn_agrega1);
            this.Controls.Add(this.Dgv_golesVisita);
            this.Controls.Add(this.Dgv_golesLocal);
            this.Controls.Add(this.Lbl_jugador2);
            this.Controls.Add(this.Lbl_jugador);
            this.Controls.Add(this.Txt_goles2);
            this.Controls.Add(this.Lbl_goles2);
            this.Controls.Add(this.Txt_goles);
            this.Controls.Add(this.Lbl_goles);
            this.Controls.Add(this.Cbo_jugador2);
            this.Controls.Add(this.Cbo_jugador);
            this.Controls.Add(this.Btn_aceptar);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_controlResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Resultados";
            this.Load += new System.EventHandler(this.frm_controlResultados_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_golesLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_golesVisita)).EndInit();
            this.Gpb_datosPartido.ResumeLayout(false);
            this.Gpb_datosPartido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label lbl_deportes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox Cbo_campeonatos;
        private System.Windows.Forms.ComboBox Cbo_jornada;
        private System.Windows.Forms.Label Lbl_campeonato;
        private System.Windows.Forms.Label Lbl_jornada;
        private System.Windows.Forms.ComboBox Cbo_enfrentamientos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_local;
        private System.Windows.Forms.TextBox Txt_visitante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_aceptar;
        private System.Windows.Forms.ComboBox Cbo_jugador;
        private System.Windows.Forms.ComboBox Cbo_jugador2;
        private System.Windows.Forms.Label Lbl_goles;
        private System.Windows.Forms.TextBox Txt_goles;
        private System.Windows.Forms.TextBox Txt_goles2;
        private System.Windows.Forms.Label Lbl_goles2;
        private System.Windows.Forms.Label Lbl_jugador;
        private System.Windows.Forms.Label Lbl_jugador2;
        private System.Windows.Forms.DataGridView Dgv_golesLocal;
        private System.Windows.Forms.DataGridView Dgv_golesVisita;
        private System.Windows.Forms.Button Btn_agrega1;
        private System.Windows.Forms.Button Btn_agrega2;
        private System.Windows.Forms.Button Btn_eliminar1;
        private System.Windows.Forms.Button Btn_eliminar2;
        private System.Windows.Forms.GroupBox Gpb_datosPartido;
    }
}