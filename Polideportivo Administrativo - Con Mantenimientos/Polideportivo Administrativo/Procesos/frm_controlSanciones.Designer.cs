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
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Lbl_sancion = new System.Windows.Forms.Label();
            this.Lbl_jugadores = new System.Windows.Forms.Label();
            this.Lbl_equipos = new System.Windows.Forms.Label();
            this.Cbo_sanciones = new System.Windows.Forms.ComboBox();
            this.Cbo_jugadores = new System.Windows.Forms.ComboBox();
            this.Cbo_equipos = new System.Windows.Forms.ComboBox();
            this.Dgv_sanciones = new System.Windows.Forms.DataGridView();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_finalizar = new System.Windows.Forms.Button();
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
            this.Pnl_titulo.Size = new System.Drawing.Size(976, 35);
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
            this.Btn_cerrar.Size = new System.Drawing.Size(30, 29);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_sancionesControl
            // 
            this.Lbl_sancionesControl.AutoSize = true;
            this.Lbl_sancionesControl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sancionesControl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_sancionesControl.Location = new System.Drawing.Point(45, 5);
            this.Lbl_sancionesControl.Name = "Lbl_sancionesControl";
            this.Lbl_sancionesControl.Size = new System.Drawing.Size(267, 24);
            this.Lbl_sancionesControl.TabIndex = 2;
            this.Lbl_sancionesControl.Text = "CONTROL DE SANCIONES";
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
            // Gpb_jugadores
            // 
            this.Gpb_jugadores.Controls.Add(this.Btn_agregar);
            this.Gpb_jugadores.Controls.Add(this.Lbl_sancion);
            this.Gpb_jugadores.Controls.Add(this.Lbl_jugadores);
            this.Gpb_jugadores.Controls.Add(this.Lbl_equipos);
            this.Gpb_jugadores.Controls.Add(this.Cbo_sanciones);
            this.Gpb_jugadores.Controls.Add(this.Cbo_jugadores);
            this.Gpb_jugadores.Controls.Add(this.Cbo_equipos);
            this.Gpb_jugadores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_jugadores.Location = new System.Drawing.Point(252, 116);
            this.Gpb_jugadores.Name = "Gpb_jugadores";
            this.Gpb_jugadores.Size = new System.Drawing.Size(557, 130);
            this.Gpb_jugadores.TabIndex = 10;
            this.Gpb_jugadores.TabStop = false;
            this.Gpb_jugadores.Text = "Jugadores";
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Location = new System.Drawing.Point(468, 55);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(73, 31);
            this.Btn_agregar.TabIndex = 6;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            // 
            // Lbl_sancion
            // 
            this.Lbl_sancion.AutoSize = true;
            this.Lbl_sancion.Location = new System.Drawing.Point(356, 41);
            this.Lbl_sancion.Name = "Lbl_sancion";
            this.Lbl_sancion.Size = new System.Drawing.Size(59, 17);
            this.Lbl_sancion.TabIndex = 5;
            this.Lbl_sancion.Text = "Sancion";
            // 
            // Lbl_jugadores
            // 
            this.Lbl_jugadores.AutoSize = true;
            this.Lbl_jugadores.Location = new System.Drawing.Point(208, 41);
            this.Lbl_jugadores.Name = "Lbl_jugadores";
            this.Lbl_jugadores.Size = new System.Drawing.Size(62, 17);
            this.Lbl_jugadores.TabIndex = 4;
            this.Lbl_jugadores.Text = "Jugador";
            // 
            // Lbl_equipos
            // 
            this.Lbl_equipos.AutoSize = true;
            this.Lbl_equipos.Location = new System.Drawing.Point(72, 41);
            this.Lbl_equipos.Name = "Lbl_equipos";
            this.Lbl_equipos.Size = new System.Drawing.Size(53, 17);
            this.Lbl_equipos.TabIndex = 3;
            this.Lbl_equipos.Text = "Equipo";
            // 
            // Cbo_sanciones
            // 
            this.Cbo_sanciones.FormattingEnabled = true;
            this.Cbo_sanciones.Location = new System.Drawing.Point(321, 61);
            this.Cbo_sanciones.Name = "Cbo_sanciones";
            this.Cbo_sanciones.Size = new System.Drawing.Size(121, 25);
            this.Cbo_sanciones.TabIndex = 2;
            // 
            // Cbo_jugadores
            // 
            this.Cbo_jugadores.FormattingEnabled = true;
            this.Cbo_jugadores.Location = new System.Drawing.Point(178, 61);
            this.Cbo_jugadores.Name = "Cbo_jugadores";
            this.Cbo_jugadores.Size = new System.Drawing.Size(121, 25);
            this.Cbo_jugadores.TabIndex = 1;
            // 
            // Cbo_equipos
            // 
            this.Cbo_equipos.FormattingEnabled = true;
            this.Cbo_equipos.Location = new System.Drawing.Point(37, 61);
            this.Cbo_equipos.Name = "Cbo_equipos";
            this.Cbo_equipos.Size = new System.Drawing.Size(121, 25);
            this.Cbo_equipos.TabIndex = 0;
            // 
            // Dgv_sanciones
            // 
            this.Dgv_sanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_sanciones.Location = new System.Drawing.Point(252, 267);
            this.Dgv_sanciones.Name = "Dgv_sanciones";
            this.Dgv_sanciones.Size = new System.Drawing.Size(479, 287);
            this.Dgv_sanciones.TabIndex = 11;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Location = new System.Drawing.Point(737, 276);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(75, 28);
            this.Btn_eliminar.TabIndex = 12;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_finalizar
            // 
            this.Btn_finalizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_finalizar.Location = new System.Drawing.Point(737, 324);
            this.Btn_finalizar.Name = "Btn_finalizar";
            this.Btn_finalizar.Size = new System.Drawing.Size(75, 29);
            this.Btn_finalizar.TabIndex = 13;
            this.Btn_finalizar.Text = "Finalizar";
            this.Btn_finalizar.UseVisualStyleBackColor = true;
            // 
            // frm_controlSanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 690);
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
    }
}