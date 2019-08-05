namespace Polideportivo_Administrativo.Procesos
{
    partial class frm_asignacionEquiposCampeonato
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
            this.Lbl_asignacionEquipos = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Dgv_asignacion = new System.Windows.Forms.DataGridView();
            this.Cbo_equipos = new System.Windows.Forms.ComboBox();
            this.Cbo_deportes = new System.Windows.Forms.ComboBox();
            this.Gpb_deportesEquipos = new System.Windows.Forms.GroupBox();
            this.Btn_ingresarEquipo = new System.Windows.Forms.Button();
            this.Cbo_campeonatos = new System.Windows.Forms.ComboBox();
            this.Lbl_campeonatos = new System.Windows.Forms.Label();
            this.Lbl_equipos = new System.Windows.Forms.Label();
            this.Lbl_deportes = new System.Windows.Forms.Label();
            this.Btn_eliminarEquipo = new System.Windows.Forms.Button();
            this.Btn_finalizarAsignacion = new System.Windows.Forms.Button();
            this.Btn_salida = new System.Windows.Forms.Button();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).BeginInit();
            this.Gpb_deportesEquipos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Pnl_titulo.Controls.Add(this.Btn_cerrar);
            this.Pnl_titulo.Controls.Add(this.Lbl_asignacionEquipos);
            this.Pnl_titulo.Controls.Add(this.pictureBox2);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(1084, 49);
            this.Pnl_titulo.TabIndex = 7;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_48;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_cerrar.Location = new System.Drawing.Point(1026, 0);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(46, 43);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_asignacionEquipos
            // 
            this.Lbl_asignacionEquipos.AutoSize = true;
            this.Lbl_asignacionEquipos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_asignacionEquipos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_asignacionEquipos.Location = new System.Drawing.Point(45, 12);
            this.Lbl_asignacionEquipos.Name = "Lbl_asignacionEquipos";
            this.Lbl_asignacionEquipos.Size = new System.Drawing.Size(457, 24);
            this.Lbl_asignacionEquipos.TabIndex = 2;
            this.Lbl_asignacionEquipos.Text = "ASIGNACION DE EQUIPOS A CAMPEONATOS";
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
            // Dgv_asignacion
            // 
            this.Dgv_asignacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_asignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asignacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column4,
            this.Column2});
            this.Dgv_asignacion.Location = new System.Drawing.Point(186, 245);
            this.Dgv_asignacion.Name = "Dgv_asignacion";
            this.Dgv_asignacion.Size = new System.Drawing.Size(597, 321);
            this.Dgv_asignacion.TabIndex = 8;
            // 
            // Cbo_equipos
            // 
            this.Cbo_equipos.FormattingEnabled = true;
            this.Cbo_equipos.Location = new System.Drawing.Point(330, 50);
            this.Cbo_equipos.Name = "Cbo_equipos";
            this.Cbo_equipos.Size = new System.Drawing.Size(121, 25);
            this.Cbo_equipos.TabIndex = 9;
            // 
            // Cbo_deportes
            // 
            this.Cbo_deportes.FormattingEnabled = true;
            this.Cbo_deportes.Location = new System.Drawing.Point(25, 50);
            this.Cbo_deportes.Name = "Cbo_deportes";
            this.Cbo_deportes.Size = new System.Drawing.Size(121, 25);
            this.Cbo_deportes.TabIndex = 10;
            this.Cbo_deportes.SelectedIndexChanged += new System.EventHandler(this.Cbo_deportes_SelectedIndexChanged);
            // 
            // Gpb_deportesEquipos
            // 
            this.Gpb_deportesEquipos.Controls.Add(this.Btn_ingresarEquipo);
            this.Gpb_deportesEquipos.Controls.Add(this.Cbo_campeonatos);
            this.Gpb_deportesEquipos.Controls.Add(this.Lbl_campeonatos);
            this.Gpb_deportesEquipos.Controls.Add(this.Lbl_equipos);
            this.Gpb_deportesEquipos.Controls.Add(this.Lbl_deportes);
            this.Gpb_deportesEquipos.Controls.Add(this.Cbo_deportes);
            this.Gpb_deportesEquipos.Controls.Add(this.Cbo_equipos);
            this.Gpb_deportesEquipos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_deportesEquipos.Location = new System.Drawing.Point(186, 109);
            this.Gpb_deportesEquipos.Name = "Gpb_deportesEquipos";
            this.Gpb_deportesEquipos.Size = new System.Drawing.Size(597, 118);
            this.Gpb_deportesEquipos.TabIndex = 11;
            this.Gpb_deportesEquipos.TabStop = false;
            this.Gpb_deportesEquipos.Text = "Deportes y Equipos";
            // 
            // Btn_ingresarEquipo
            // 
            this.Btn_ingresarEquipo.Location = new System.Drawing.Point(487, 40);
            this.Btn_ingresarEquipo.Name = "Btn_ingresarEquipo";
            this.Btn_ingresarEquipo.Size = new System.Drawing.Size(89, 42);
            this.Btn_ingresarEquipo.TabIndex = 15;
            this.Btn_ingresarEquipo.Text = "Ingresar Equipo";
            this.Btn_ingresarEquipo.UseVisualStyleBackColor = true;
            this.Btn_ingresarEquipo.Click += new System.EventHandler(this.Btn_ingresarEquipo_Click_1);
            // 
            // Cbo_campeonatos
            // 
            this.Cbo_campeonatos.FormattingEnabled = true;
            this.Cbo_campeonatos.Location = new System.Drawing.Point(175, 50);
            this.Cbo_campeonatos.Name = "Cbo_campeonatos";
            this.Cbo_campeonatos.Size = new System.Drawing.Size(121, 25);
            this.Cbo_campeonatos.TabIndex = 14;
            // 
            // Lbl_campeonatos
            // 
            this.Lbl_campeonatos.AutoSize = true;
            this.Lbl_campeonatos.Location = new System.Drawing.Point(184, 30);
            this.Lbl_campeonatos.Name = "Lbl_campeonatos";
            this.Lbl_campeonatos.Size = new System.Drawing.Size(103, 17);
            this.Lbl_campeonatos.TabIndex = 13;
            this.Lbl_campeonatos.Text = "Campeonatos";
            // 
            // Lbl_equipos
            // 
            this.Lbl_equipos.AutoSize = true;
            this.Lbl_equipos.Location = new System.Drawing.Point(368, 30);
            this.Lbl_equipos.Name = "Lbl_equipos";
            this.Lbl_equipos.Size = new System.Drawing.Size(58, 17);
            this.Lbl_equipos.TabIndex = 12;
            this.Lbl_equipos.Text = "Equipos";
            // 
            // Lbl_deportes
            // 
            this.Lbl_deportes.AutoSize = true;
            this.Lbl_deportes.Location = new System.Drawing.Point(52, 30);
            this.Lbl_deportes.Name = "Lbl_deportes";
            this.Lbl_deportes.Size = new System.Drawing.Size(66, 17);
            this.Lbl_deportes.TabIndex = 11;
            this.Lbl_deportes.Text = "Deportes";
            // 
            // Btn_eliminarEquipo
            // 
            this.Btn_eliminarEquipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminarEquipo.Location = new System.Drawing.Point(800, 269);
            this.Btn_eliminarEquipo.Name = "Btn_eliminarEquipo";
            this.Btn_eliminarEquipo.Size = new System.Drawing.Size(131, 35);
            this.Btn_eliminarEquipo.TabIndex = 16;
            this.Btn_eliminarEquipo.Text = "Eliminar Equipo";
            this.Btn_eliminarEquipo.UseVisualStyleBackColor = true;
            this.Btn_eliminarEquipo.Click += new System.EventHandler(this.Btn_eliminarEquipo_Click);
            // 
            // Btn_finalizarAsignacion
            // 
            this.Btn_finalizarAsignacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_finalizarAsignacion.Location = new System.Drawing.Point(800, 464);
            this.Btn_finalizarAsignacion.Name = "Btn_finalizarAsignacion";
            this.Btn_finalizarAsignacion.Size = new System.Drawing.Size(131, 46);
            this.Btn_finalizarAsignacion.TabIndex = 17;
            this.Btn_finalizarAsignacion.Text = "Finalizar Asignacion";
            this.Btn_finalizarAsignacion.UseVisualStyleBackColor = true;
            this.Btn_finalizarAsignacion.Click += new System.EventHandler(this.Btn_finalizarAsignacion_Click);
            // 
            // Btn_salida
            // 
            this.Btn_salida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salida.Location = new System.Drawing.Point(800, 531);
            this.Btn_salida.Name = "Btn_salida";
            this.Btn_salida.Size = new System.Drawing.Size(131, 35);
            this.Btn_salida.TabIndex = 18;
            this.Btn_salida.Text = "Salir";
            this.Btn_salida.UseVisualStyleBackColor = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Codigo Campeonato";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Campeonato";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Codigo Equipo";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Equipo";
            this.Column2.Name = "Column2";
            // 
            // frm_asignacionEquiposCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.Btn_salida);
            this.Controls.Add(this.Btn_finalizarAsignacion);
            this.Controls.Add(this.Btn_eliminarEquipo);
            this.Controls.Add(this.Gpb_deportesEquipos);
            this.Controls.Add(this.Dgv_asignacion);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_asignacionEquiposCampeonato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de Equipos a Campeonatos";
            this.Load += new System.EventHandler(this.frm_asignacionEquiposCampeonato_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).EndInit();
            this.Gpb_deportesEquipos.ResumeLayout(false);
            this.Gpb_deportesEquipos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_asignacionEquipos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView Dgv_asignacion;
        private System.Windows.Forms.ComboBox Cbo_equipos;
        private System.Windows.Forms.ComboBox Cbo_deportes;
        private System.Windows.Forms.GroupBox Gpb_deportesEquipos;
        private System.Windows.Forms.Button Btn_ingresarEquipo;
        private System.Windows.Forms.ComboBox Cbo_campeonatos;
        private System.Windows.Forms.Label Lbl_campeonatos;
        private System.Windows.Forms.Label Lbl_equipos;
        private System.Windows.Forms.Label Lbl_deportes;
        private System.Windows.Forms.Button Btn_eliminarEquipo;
        private System.Windows.Forms.Button Btn_finalizarAsignacion;
        private System.Windows.Forms.Button Btn_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}