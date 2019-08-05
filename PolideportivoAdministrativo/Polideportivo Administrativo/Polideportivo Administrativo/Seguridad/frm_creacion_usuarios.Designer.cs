namespace Polideportivo_Administrativo.Seguridad
{
    partial class frm_creacion_usuarios
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
            this.Lbl_codigoEntrenador = new System.Windows.Forms.Label();
            this.Lbl_nombreEntrenador = new System.Windows.Forms.Label();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_administracionArbitros = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Pnl_datos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.puesto = new System.Windows.Forms.ComboBox();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Rdb_activo = new System.Windows.Forms.RadioButton();
            this.Rdb_inactivo = new System.Windows.Forms.RadioButton();
            this.Gpb_estado = new System.Windows.Forms.GroupBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_contraseña = new System.Windows.Forms.TextBox();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Pnl_datos.SuspendLayout();
            this.Gpb_estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_codigoEntrenador
            // 
            this.Lbl_codigoEntrenador.AutoSize = true;
            this.Lbl_codigoEntrenador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigoEntrenador.Location = new System.Drawing.Point(21, 47);
            this.Lbl_codigoEntrenador.Name = "Lbl_codigoEntrenador";
            this.Lbl_codigoEntrenador.Size = new System.Drawing.Size(115, 17);
            this.Lbl_codigoEntrenador.TabIndex = 205;
            this.Lbl_codigoEntrenador.Text = " Nombre Usuario";
            // 
            // Lbl_nombreEntrenador
            // 
            this.Lbl_nombreEntrenador.AutoSize = true;
            this.Lbl_nombreEntrenador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreEntrenador.Location = new System.Drawing.Point(21, 93);
            this.Lbl_nombreEntrenador.Name = "Lbl_nombreEntrenador";
            this.Lbl_nombreEntrenador.Size = new System.Drawing.Size(88, 17);
            this.Lbl_nombreEntrenador.TabIndex = 193;
            this.Lbl_nombreEntrenador.Text = " Contraseña";
            this.Lbl_nombreEntrenador.Click += new System.EventHandler(this.Lbl_nombreEntrenador_Click);
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.Teal;
            this.Pnl_titulo.Controls.Add(this.Btn_cerrar);
            this.Pnl_titulo.Controls.Add(this.Lbl_administracionArbitros);
            this.Pnl_titulo.Controls.Add(this.pictureBox2);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(949, 35);
            this.Pnl_titulo.TabIndex = 192;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_48;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.Teal;
            this.Btn_cerrar.Location = new System.Drawing.Point(916, 3);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(30, 29);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_administracionArbitros
            // 
            this.Lbl_administracionArbitros.AutoSize = true;
            this.Lbl_administracionArbitros.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_administracionArbitros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_administracionArbitros.Location = new System.Drawing.Point(45, 3);
            this.Lbl_administracionArbitros.Name = "Lbl_administracionArbitros";
            this.Lbl_administracionArbitros.Size = new System.Drawing.Size(224, 24);
            this.Lbl_administracionArbitros.TabIndex = 2;
            this.Lbl_administracionArbitros.Text = "Creacion de Usuarios";
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
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Btn_guardar.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_guardar_48;
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_guardar.Location = new System.Drawing.Point(321, 435);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(90, 75);
            this.Btn_guardar.TabIndex = 199;
            this.Btn_guardar.Text = "GUARDAR";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Pnl_datos
            // 
            this.Pnl_datos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pnl_datos.Controls.Add(this.Txt_contraseña);
            this.Pnl_datos.Controls.Add(this.Txt_Usuario);
            this.Pnl_datos.Controls.Add(this.label1);
            this.Pnl_datos.Controls.Add(this.puesto);
            this.Pnl_datos.Controls.Add(this.Lbl_codigoEntrenador);
            this.Pnl_datos.Controls.Add(this.Lbl_nombreEntrenador);
            this.Pnl_datos.Location = new System.Drawing.Point(251, 76);
            this.Pnl_datos.Name = "Pnl_datos";
            this.Pnl_datos.Size = new System.Drawing.Size(443, 180);
            this.Pnl_datos.TabIndex = 207;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 225;
            this.label1.Text = "Tipo";
            // 
            // puesto
            // 
            this.puesto.FormattingEnabled = true;
            this.puesto.Location = new System.Drawing.Point(168, 136);
            this.puesto.Name = "puesto";
            this.puesto.Size = new System.Drawing.Size(230, 21);
            this.puesto.TabIndex = 224;
            this.puesto.Text = " ";
            this.puesto.SelectedIndexChanged += new System.EventHandler(this.puesto_SelectedIndexChanged);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salir.FlatAppearance.BorderSize = 0;
            this.Btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_salir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Btn_salir.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_481;
            this.Btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_salir.Location = new System.Drawing.Point(490, 435);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(100, 75);
            this.Btn_salir.TabIndex = 224;
            this.Btn_salir.Text = "SALIR ";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Rdb_activo
            // 
            this.Rdb_activo.AutoSize = true;
            this.Rdb_activo.Location = new System.Drawing.Point(83, 48);
            this.Rdb_activo.Name = "Rdb_activo";
            this.Rdb_activo.Size = new System.Drawing.Size(68, 21);
            this.Rdb_activo.TabIndex = 0;
            this.Rdb_activo.TabStop = true;
            this.Rdb_activo.Text = "Activo";
            this.Rdb_activo.UseVisualStyleBackColor = true;
            // 
            // Rdb_inactivo
            // 
            this.Rdb_inactivo.AutoSize = true;
            this.Rdb_inactivo.Location = new System.Drawing.Point(239, 48);
            this.Rdb_inactivo.Name = "Rdb_inactivo";
            this.Rdb_inactivo.Size = new System.Drawing.Size(79, 21);
            this.Rdb_inactivo.TabIndex = 1;
            this.Rdb_inactivo.TabStop = true;
            this.Rdb_inactivo.Text = "Inactivo";
            this.Rdb_inactivo.UseVisualStyleBackColor = true;
            // 
            // Gpb_estado
            // 
            this.Gpb_estado.AccessibleDescription = "Estado";
            this.Gpb_estado.Controls.Add(this.Rdb_inactivo);
            this.Gpb_estado.Controls.Add(this.Rdb_activo);
            this.Gpb_estado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_estado.Location = new System.Drawing.Point(251, 291);
            this.Gpb_estado.Name = "Gpb_estado";
            this.Gpb_estado.Size = new System.Drawing.Size(443, 100);
            this.Gpb_estado.TabIndex = 223;
            this.Gpb_estado.TabStop = false;
            this.Gpb_estado.Text = "Estado";
            this.Gpb_estado.Enter += new System.EventHandler(this.Gpb_estado_Enter);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.Location = new System.Drawing.Point(167, 44);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(230, 23);
            this.Txt_Usuario.TabIndex = 226;
            // 
            // Txt_contraseña
            // 
            this.Txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_contraseña.Location = new System.Drawing.Point(168, 87);
            this.Txt_contraseña.Name = "Txt_contraseña";
            this.Txt_contraseña.PasswordChar = '*';
            this.Txt_contraseña.Size = new System.Drawing.Size(230, 23);
            this.Txt_contraseña.TabIndex = 227;
            // 
            // frm_creacion_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 607);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Gpb_estado);
            this.Controls.Add(this.Pnl_datos);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_creacion_usuarios";
            this.Text = "frm_creacion_usuarios";
            this.Load += new System.EventHandler(this.frm_creacion_usuarios_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Pnl_datos.ResumeLayout(false);
            this.Pnl_datos.PerformLayout();
            this.Gpb_estado.ResumeLayout(false);
            this.Gpb_estado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lbl_codigoEntrenador;
        public System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label Lbl_nombreEntrenador;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_administracionArbitros;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Pnl_datos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox puesto;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.RadioButton Rdb_activo;
        private System.Windows.Forms.RadioButton Rdb_inactivo;
        private System.Windows.Forms.GroupBox Gpb_estado;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_contraseña;
    }
}