namespace Polideportivo_Administrativo.Mantenimientos
{
    partial class frm_adminSanciones
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
            this.Txt_descripcionSancion = new System.Windows.Forms.TextBox();
            this.Txt_nombreSancion = new System.Windows.Forms.TextBox();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.Lbl_sancion = new System.Windows.Forms.Label();
            this.Gpb_estado = new System.Windows.Forms.GroupBox();
            this.Rbd_deshabilitado = new System.Windows.Forms.RadioButton();
            this.Rdb_habilitado = new System.Windows.Forms.RadioButton();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_administracionArbitros = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Txt_codigoSancion = new System.Windows.Forms.TextBox();
            this.Lbl_codigoSancion = new System.Windows.Forms.Label();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Gpb_estado.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_descripcionSancion
            // 
            this.Txt_descripcionSancion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcionSancion.Location = new System.Drawing.Point(435, 331);
            this.Txt_descripcionSancion.Name = "Txt_descripcionSancion";
            this.Txt_descripcionSancion.Size = new System.Drawing.Size(230, 23);
            this.Txt_descripcionSancion.TabIndex = 155;
            // 
            // Txt_nombreSancion
            // 
            this.Txt_nombreSancion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreSancion.Location = new System.Drawing.Point(435, 277);
            this.Txt_nombreSancion.Name = "Txt_nombreSancion";
            this.Txt_nombreSancion.Size = new System.Drawing.Size(230, 23);
            this.Txt_nombreSancion.TabIndex = 154;
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(291, 334);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(138, 17);
            this.Lbl_descripcion.TabIndex = 153;
            this.Lbl_descripcion.Text = "Descripcion Sancion";
            // 
            // Lbl_sancion
            // 
            this.Lbl_sancion.AutoSize = true;
            this.Lbl_sancion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sancion.Location = new System.Drawing.Point(291, 280);
            this.Lbl_sancion.Name = "Lbl_sancion";
            this.Lbl_sancion.Size = new System.Drawing.Size(116, 17);
            this.Lbl_sancion.TabIndex = 152;
            this.Lbl_sancion.Text = "Nombre Sancion";
            // 
            // Gpb_estado
            // 
            this.Gpb_estado.Controls.Add(this.Rbd_deshabilitado);
            this.Gpb_estado.Controls.Add(this.Rdb_habilitado);
            this.Gpb_estado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_estado.Location = new System.Drawing.Point(257, 394);
            this.Gpb_estado.Name = "Gpb_estado";
            this.Gpb_estado.Size = new System.Drawing.Size(434, 100);
            this.Gpb_estado.TabIndex = 151;
            this.Gpb_estado.TabStop = false;
            this.Gpb_estado.Text = "Estado";
            // 
            // Rbd_deshabilitado
            // 
            this.Rbd_deshabilitado.AutoSize = true;
            this.Rbd_deshabilitado.Location = new System.Drawing.Point(239, 48);
            this.Rbd_deshabilitado.Name = "Rbd_deshabilitado";
            this.Rbd_deshabilitado.Size = new System.Drawing.Size(116, 21);
            this.Rbd_deshabilitado.TabIndex = 1;
            this.Rbd_deshabilitado.TabStop = true;
            this.Rbd_deshabilitado.Text = "Deshabilitado";
            this.Rbd_deshabilitado.UseVisualStyleBackColor = true;
            // 
            // Rdb_habilitado
            // 
            this.Rdb_habilitado.AutoSize = true;
            this.Rdb_habilitado.Location = new System.Drawing.Point(83, 48);
            this.Rdb_habilitado.Name = "Rdb_habilitado";
            this.Rdb_habilitado.Size = new System.Drawing.Size(94, 21);
            this.Rdb_habilitado.TabIndex = 0;
            this.Rdb_habilitado.TabStop = true;
            this.Rdb_habilitado.Text = "Habilitado";
            this.Rdb_habilitado.UseVisualStyleBackColor = true;
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
            this.Btn_salir.Location = new System.Drawing.Point(706, 89);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(90, 75);
            this.Btn_salir.TabIndex = 150;
            this.Btn_salir.Text = "SALIR ";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ingresar.FlatAppearance.BorderSize = 0;
            this.Btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_ingresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Btn_ingresar.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_añadir_48;
            this.Btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_ingresar.Location = new System.Drawing.Point(189, 89);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(90, 75);
            this.Btn_ingresar.TabIndex = 149;
            this.Btn_ingresar.Text = "INGRESAR ";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_modificar.FlatAppearance.BorderSize = 0;
            this.Btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_modificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Btn_modificar.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_historial_de_pedidos_48;
            this.Btn_modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_modificar.Location = new System.Drawing.Point(361, 89);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(90, 75);
            this.Btn_modificar.TabIndex = 148;
            this.Btn_modificar.Text = "MODIFICAR ";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Btn_eliminar.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_eliminar_48;
            this.Btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_eliminar.Location = new System.Drawing.Point(447, 89);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(90, 75);
            this.Btn_eliminar.TabIndex = 147;
            this.Btn_eliminar.Text = "ELIMINAR";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
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
            this.Btn_guardar.Location = new System.Drawing.Point(276, 89);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(90, 75);
            this.Btn_guardar.TabIndex = 146;
            this.Btn_guardar.Text = "GUARDAR";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Pnl_titulo.Controls.Add(this.Btn_cerrar);
            this.Pnl_titulo.Controls.Add(this.Lbl_administracionArbitros);
            this.Pnl_titulo.Controls.Add(this.pictureBox2);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(949, 35);
            this.Pnl_titulo.TabIndex = 145;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_48;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.DarkSlateGray;
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
            this.Lbl_administracionArbitros.Location = new System.Drawing.Point(45, 9);
            this.Lbl_administracionArbitros.Name = "Lbl_administracionArbitros";
            this.Lbl_administracionArbitros.Size = new System.Drawing.Size(345, 24);
            this.Lbl_administracionArbitros.TabIndex = 2;
            this.Lbl_administracionArbitros.Text = "ADMINISTRACION DE SANCIONES";
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
            // Txt_codigoSancion
            // 
            this.Txt_codigoSancion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigoSancion.Location = new System.Drawing.Point(436, 232);
            this.Txt_codigoSancion.Name = "Txt_codigoSancion";
            this.Txt_codigoSancion.Size = new System.Drawing.Size(230, 23);
            this.Txt_codigoSancion.TabIndex = 158;
            // 
            // Lbl_codigoSancion
            // 
            this.Lbl_codigoSancion.AutoSize = true;
            this.Lbl_codigoSancion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigoSancion.Location = new System.Drawing.Point(291, 235);
            this.Lbl_codigoSancion.Name = "Lbl_codigoSancion";
            this.Lbl_codigoSancion.Size = new System.Drawing.Size(113, 17);
            this.Lbl_codigoSancion.TabIndex = 157;
            this.Lbl_codigoSancion.Text = "Codigo Sancion";
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Regresar.FlatAppearance.BorderSize = 0;
            this.Btn_Regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_Regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Regresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Btn_Regresar.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_retroceder_50;
            this.Btn_Regresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Regresar.Location = new System.Drawing.Point(533, 89);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(90, 75);
            this.Btn_Regresar.TabIndex = 179;
            this.Btn_Regresar.Text = "REGRESAR";
            this.Btn_Regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Regresar.UseVisualStyleBackColor = false;
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Btn_cancelar.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_cancelar_2_48;
            this.Btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_cancelar.Location = new System.Drawing.Point(620, 89);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(90, 75);
            this.Btn_cancelar.TabIndex = 180;
            this.Btn_cancelar.Text = "CANCELAR";
            this.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_ayuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_ayuda.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_ayuda_30;
            this.Btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ayuda.Location = new System.Drawing.Point(861, 38);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(85, 37);
            this.Btn_ayuda.TabIndex = 181;
            this.Btn_ayuda.Text = "Ayuda";
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // frm_adminSanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 607);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_Regresar);
            this.Controls.Add(this.Txt_codigoSancion);
            this.Controls.Add(this.Lbl_codigoSancion);
            this.Controls.Add(this.Txt_descripcionSancion);
            this.Controls.Add(this.Txt_nombreSancion);
            this.Controls.Add(this.Lbl_descripcion);
            this.Controls.Add(this.Lbl_sancion);
            this.Controls.Add(this.Gpb_estado);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_adminSanciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_adminSanciones";
            this.Load += new System.EventHandler(this.frm_adminSanciones_Load);
            this.Gpb_estado.ResumeLayout(false);
            this.Gpb_estado.PerformLayout();
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_descripcion;
        private System.Windows.Forms.Label Lbl_sancion;
        private System.Windows.Forms.RadioButton Rbd_deshabilitado;
        private System.Windows.Forms.RadioButton Rdb_habilitado;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_ingresar;
        public System.Windows.Forms.Button Btn_modificar;
        public System.Windows.Forms.Button Btn_eliminar;
        public System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_administracionArbitros;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox Txt_codigoSancion;
        private System.Windows.Forms.Label Lbl_codigoSancion;
        public System.Windows.Forms.TextBox Txt_descripcionSancion;
        public System.Windows.Forms.TextBox Txt_nombreSancion;
        public System.Windows.Forms.GroupBox Gpb_estado;
        public System.Windows.Forms.Button Btn_Regresar;
        public System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}