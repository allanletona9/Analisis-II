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
            this.Gpb_estado.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_descripcionSancion
            // 
            this.Txt_descripcionSancion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcionSancion.Location = new System.Drawing.Point(396, 328);
            this.Txt_descripcionSancion.Name = "Txt_descripcionSancion";
            this.Txt_descripcionSancion.Size = new System.Drawing.Size(230, 23);
            this.Txt_descripcionSancion.TabIndex = 155;
            // 
            // Txt_nombreSancion
            // 
            this.Txt_nombreSancion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreSancion.Location = new System.Drawing.Point(396, 274);
            this.Txt_nombreSancion.Name = "Txt_nombreSancion";
            this.Txt_nombreSancion.Size = new System.Drawing.Size(230, 23);
            this.Txt_nombreSancion.TabIndex = 154;
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(252, 331);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(138, 17);
            this.Lbl_descripcion.TabIndex = 153;
            this.Lbl_descripcion.Text = "Descripcion Sancion";
            // 
            // Lbl_sancion
            // 
            this.Lbl_sancion.AutoSize = true;
            this.Lbl_sancion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sancion.Location = new System.Drawing.Point(252, 277);
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
            this.Gpb_estado.Location = new System.Drawing.Point(218, 391);
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
            this.Btn_salir.Location = new System.Drawing.Point(562, 105);
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
            this.Btn_ingresar.Location = new System.Drawing.Point(218, 105);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(90, 75);
            this.Btn_ingresar.TabIndex = 149;
            this.Btn_ingresar.Text = "INGRESAR ";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
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
            this.Btn_modificar.Location = new System.Drawing.Point(390, 105);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(90, 75);
            this.Btn_modificar.TabIndex = 148;
            this.Btn_modificar.Text = "MODIFICAR ";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_modificar.UseVisualStyleBackColor = false;
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
            this.Btn_eliminar.Location = new System.Drawing.Point(476, 105);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(90, 75);
            this.Btn_eliminar.TabIndex = 147;
            this.Btn_eliminar.Text = "ELIMINAR";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
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
            this.Btn_guardar.Location = new System.Drawing.Point(305, 105);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(90, 75);
            this.Btn_guardar.TabIndex = 146;
            this.Btn_guardar.Text = "GUARDAR";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.DarkRed;
            this.Pnl_titulo.Controls.Add(this.Btn_cerrar);
            this.Pnl_titulo.Controls.Add(this.Lbl_administracionArbitros);
            this.Pnl_titulo.Controls.Add(this.pictureBox2);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(910, 49);
            this.Pnl_titulo.TabIndex = 145;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_48;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.DarkRed;
            this.Btn_cerrar.Location = new System.Drawing.Point(864, 3);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(46, 43);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_administracionArbitros
            // 
            this.Lbl_administracionArbitros.AutoSize = true;
            this.Lbl_administracionArbitros.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_administracionArbitros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_administracionArbitros.Location = new System.Drawing.Point(45, 12);
            this.Lbl_administracionArbitros.Name = "Lbl_administracionArbitros";
            this.Lbl_administracionArbitros.Size = new System.Drawing.Size(345, 24);
            this.Lbl_administracionArbitros.TabIndex = 2;
            this.Lbl_administracionArbitros.Text = "ADMINISTRACION DE SANCIONES";
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
            // Txt_codigoSancion
            // 
            this.Txt_codigoSancion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigoSancion.Location = new System.Drawing.Point(397, 229);
            this.Txt_codigoSancion.Name = "Txt_codigoSancion";
            this.Txt_codigoSancion.Size = new System.Drawing.Size(230, 23);
            this.Txt_codigoSancion.TabIndex = 158;
            // 
            // Lbl_codigoSancion
            // 
            this.Lbl_codigoSancion.AutoSize = true;
            this.Lbl_codigoSancion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigoSancion.Location = new System.Drawing.Point(252, 232);
            this.Lbl_codigoSancion.Name = "Lbl_codigoSancion";
            this.Lbl_codigoSancion.Size = new System.Drawing.Size(113, 17);
            this.Lbl_codigoSancion.TabIndex = 157;
            this.Lbl_codigoSancion.Text = "Codigo Sancion";
            // 
            // frm_adminSanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 580);
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

        private System.Windows.Forms.TextBox Txt_descripcionSancion;
        private System.Windows.Forms.TextBox Txt_nombreSancion;
        private System.Windows.Forms.Label Lbl_descripcion;
        private System.Windows.Forms.Label Lbl_sancion;
        private System.Windows.Forms.GroupBox Gpb_estado;
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
    }
}