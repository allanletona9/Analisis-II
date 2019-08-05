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
            this.Cbo_jugador = new System.Windows.Forms.ComboBox();
            this.Lbl_goles = new System.Windows.Forms.Label();
            this.Txt_goles = new System.Windows.Forms.TextBox();
            this.Lbl_jugador = new System.Windows.Forms.Label();
            this.Dgv_goles = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_agrega = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Gpb_datosPartido = new System.Windows.Forms.GroupBox();
            this.Btn_Finalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_resultados = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cbo_equipos = new System.Windows.Forms.ComboBox();
            this.lbl_deporte = new System.Windows.Forms.Label();
            this.Cbo_deportes = new System.Windows.Forms.ComboBox();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_goles)).BeginInit();
            this.Gpb_datosPartido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_resultados)).BeginInit();
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
            this.Pnl_titulo.TabIndex = 8;
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
            this.Btn_cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_deportes
            // 
            this.lbl_deportes.AutoSize = true;
            this.lbl_deportes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deportes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_deportes.Location = new System.Drawing.Point(45, 7);
            this.lbl_deportes.Name = "lbl_deportes";
            this.lbl_deportes.Size = new System.Drawing.Size(273, 24);
            this.lbl_deportes.TabIndex = 2;
            this.lbl_deportes.Text = "CONTROL DE RESULTADOS";
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
            // Cbo_campeonatos
            // 
            this.Cbo_campeonatos.FormattingEnabled = true;
            this.Cbo_campeonatos.Location = new System.Drawing.Point(183, 45);
            this.Cbo_campeonatos.Name = "Cbo_campeonatos";
            this.Cbo_campeonatos.Size = new System.Drawing.Size(121, 25);
            this.Cbo_campeonatos.TabIndex = 9;
            this.Cbo_campeonatos.SelectedIndexChanged += new System.EventHandler(this.Cbo_campeonatos_SelectedIndexChanged);
            // 
            // Cbo_jornada
            // 
            this.Cbo_jornada.FormattingEnabled = true;
            this.Cbo_jornada.Location = new System.Drawing.Point(336, 45);
            this.Cbo_jornada.Name = "Cbo_jornada";
            this.Cbo_jornada.Size = new System.Drawing.Size(121, 25);
            this.Cbo_jornada.TabIndex = 10;
            this.Cbo_jornada.SelectedIndexChanged += new System.EventHandler(this.Cbo_jornada_SelectedIndexChanged);
            // 
            // Lbl_campeonato
            // 
            this.Lbl_campeonato.AutoSize = true;
            this.Lbl_campeonato.Location = new System.Drawing.Point(195, 29);
            this.Lbl_campeonato.Name = "Lbl_campeonato";
            this.Lbl_campeonato.Size = new System.Drawing.Size(98, 17);
            this.Lbl_campeonato.TabIndex = 11;
            this.Lbl_campeonato.Text = "Campeonato";
            // 
            // Lbl_jornada
            // 
            this.Lbl_jornada.AutoSize = true;
            this.Lbl_jornada.Location = new System.Drawing.Point(369, 29);
            this.Lbl_jornada.Name = "Lbl_jornada";
            this.Lbl_jornada.Size = new System.Drawing.Size(62, 17);
            this.Lbl_jornada.TabIndex = 12;
            this.Lbl_jornada.Text = "Jornada";
            // 
            // Cbo_jugador
            // 
            this.Cbo_jugador.FormattingEnabled = true;
            this.Cbo_jugador.Location = new System.Drawing.Point(651, 113);
            this.Cbo_jugador.Name = "Cbo_jugador";
            this.Cbo_jugador.Size = new System.Drawing.Size(121, 25);
            this.Cbo_jugador.TabIndex = 19;
            // 
            // Lbl_goles
            // 
            this.Lbl_goles.AutoSize = true;
            this.Lbl_goles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_goles.Location = new System.Drawing.Point(777, 92);
            this.Lbl_goles.Name = "Lbl_goles";
            this.Lbl_goles.Size = new System.Drawing.Size(44, 17);
            this.Lbl_goles.TabIndex = 21;
            this.Lbl_goles.Text = "Goles";
            // 
            // Txt_goles
            // 
            this.Txt_goles.Location = new System.Drawing.Point(778, 113);
            this.Txt_goles.Name = "Txt_goles";
            this.Txt_goles.Size = new System.Drawing.Size(42, 23);
            this.Txt_goles.TabIndex = 22;
            // 
            // Lbl_jugador
            // 
            this.Lbl_jugador.AutoSize = true;
            this.Lbl_jugador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_jugador.Location = new System.Drawing.Point(688, 92);
            this.Lbl_jugador.Name = "Lbl_jugador";
            this.Lbl_jugador.Size = new System.Drawing.Size(62, 17);
            this.Lbl_jugador.TabIndex = 25;
            this.Lbl_jugador.Text = "Jugador";
            // 
            // Dgv_goles
            // 
            this.Dgv_goles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_goles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_goles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3});
            this.Dgv_goles.Location = new System.Drawing.Point(515, 150);
            this.Dgv_goles.Name = "Dgv_goles";
            this.Dgv_goles.Size = new System.Drawing.Size(345, 211);
            this.Dgv_goles.TabIndex = 27;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Jugador";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Goles";
            this.Column3.Name = "Column3";
            // 
            // Btn_agrega
            // 
            this.Btn_agrega.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agrega.Location = new System.Drawing.Point(831, 113);
            this.Btn_agrega.Name = "Btn_agrega";
            this.Btn_agrega.Size = new System.Drawing.Size(29, 23);
            this.Btn_agrega.TabIndex = 29;
            this.Btn_agrega.Text = "+";
            this.Btn_agrega.UseVisualStyleBackColor = true;
            this.Btn_agrega.Click += new System.EventHandler(this.Btn_agrega_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Location = new System.Drawing.Point(866, 172);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(29, 23);
            this.Btn_eliminar.TabIndex = 35;
            this.Btn_eliminar.Text = "X";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Gpb_datosPartido
            // 
            this.Gpb_datosPartido.Controls.Add(this.Btn_Finalizar);
            this.Gpb_datosPartido.Controls.Add(this.label1);
            this.Gpb_datosPartido.Controls.Add(this.Dgv_resultados);
            this.Gpb_datosPartido.Controls.Add(this.Cbo_equipos);
            this.Gpb_datosPartido.Controls.Add(this.lbl_deporte);
            this.Gpb_datosPartido.Controls.Add(this.Cbo_deportes);
            this.Gpb_datosPartido.Controls.Add(this.Btn_eliminar);
            this.Gpb_datosPartido.Controls.Add(this.Cbo_campeonatos);
            this.Gpb_datosPartido.Controls.Add(this.Btn_agrega);
            this.Gpb_datosPartido.Controls.Add(this.Cbo_jornada);
            this.Gpb_datosPartido.Controls.Add(this.Dgv_goles);
            this.Gpb_datosPartido.Controls.Add(this.Lbl_jugador);
            this.Gpb_datosPartido.Controls.Add(this.Lbl_campeonato);
            this.Gpb_datosPartido.Controls.Add(this.Txt_goles);
            this.Gpb_datosPartido.Controls.Add(this.Lbl_jornada);
            this.Gpb_datosPartido.Controls.Add(this.Lbl_goles);
            this.Gpb_datosPartido.Controls.Add(this.Cbo_jugador);
            this.Gpb_datosPartido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosPartido.Location = new System.Drawing.Point(35, 43);
            this.Gpb_datosPartido.Name = "Gpb_datosPartido";
            this.Gpb_datosPartido.Size = new System.Drawing.Size(915, 624);
            this.Gpb_datosPartido.TabIndex = 37;
            this.Gpb_datosPartido.TabStop = false;
            this.Gpb_datosPartido.Text = "Datos del Partido";
            this.Gpb_datosPartido.Enter += new System.EventHandler(this.Gpb_datosPartido_Enter);
            // 
            // Btn_Finalizar
            // 
            this.Btn_Finalizar.Location = new System.Drawing.Point(626, 412);
            this.Btn_Finalizar.Name = "Btn_Finalizar";
            this.Btn_Finalizar.Size = new System.Drawing.Size(133, 40);
            this.Btn_Finalizar.TabIndex = 40;
            this.Btn_Finalizar.Text = "Finalizar";
            this.Btn_Finalizar.UseVisualStyleBackColor = true;
            this.Btn_Finalizar.Click += new System.EventHandler(this.Btn_Finalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Equipo";
            // 
            // Dgv_resultados
            // 
            this.Dgv_resultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_resultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column4,
            this.Column10});
            this.Dgv_resultados.Location = new System.Drawing.Point(14, 113);
            this.Dgv_resultados.Name = "Dgv_resultados";
            this.Dgv_resultados.Size = new System.Drawing.Size(473, 488);
            this.Dgv_resultados.TabIndex = 20;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Codigo";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Equipo";
            this.Column4.Name = "Column4";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Puntos/Goles";
            this.Column10.Name = "Column10";
            // 
            // Cbo_equipos
            // 
            this.Cbo_equipos.FormattingEnabled = true;
            this.Cbo_equipos.Location = new System.Drawing.Point(515, 113);
            this.Cbo_equipos.Name = "Cbo_equipos";
            this.Cbo_equipos.Size = new System.Drawing.Size(121, 25);
            this.Cbo_equipos.TabIndex = 38;
            this.Cbo_equipos.SelectedIndexChanged += new System.EventHandler(this.Cbo_equipos_SelectedIndexChanged);
            // 
            // lbl_deporte
            // 
            this.lbl_deporte.AutoSize = true;
            this.lbl_deporte.Location = new System.Drawing.Point(66, 25);
            this.lbl_deporte.Name = "lbl_deporte";
            this.lbl_deporte.Size = new System.Drawing.Size(61, 17);
            this.lbl_deporte.TabIndex = 19;
            this.lbl_deporte.Text = "Deporte";
            this.lbl_deporte.Click += new System.EventHandler(this.lbl_deporte_Click);
            // 
            // Cbo_deportes
            // 
            this.Cbo_deportes.FormattingEnabled = true;
            this.Cbo_deportes.Location = new System.Drawing.Point(30, 45);
            this.Cbo_deportes.Name = "Cbo_deportes";
            this.Cbo_deportes.Size = new System.Drawing.Size(121, 25);
            this.Cbo_deportes.TabIndex = 18;
            this.Cbo_deportes.SelectedIndexChanged += new System.EventHandler(this.Cbo_deportes_SelectedIndexChanged);
            // 
            // frm_controlResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 690);
            this.Controls.Add(this.Gpb_datosPartido);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_controlResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_controlResultados_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_goles)).EndInit();
            this.Gpb_datosPartido.ResumeLayout(false);
            this.Gpb_datosPartido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_resultados)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox Cbo_jugador;
        private System.Windows.Forms.Label Lbl_goles;
        private System.Windows.Forms.TextBox Txt_goles;
        private System.Windows.Forms.Label Lbl_jugador;
        private System.Windows.Forms.DataGridView Dgv_goles;
        private System.Windows.Forms.Button Btn_agrega;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.GroupBox Gpb_datosPartido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lbl_deporte;
        private System.Windows.Forms.ComboBox Cbo_deportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_resultados;
        private System.Windows.Forms.ComboBox Cbo_equipos;
        private System.Windows.Forms.Button Btn_Finalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}