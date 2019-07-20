namespace Polideportivo_Administrativo.Mantenimientos
{
    partial class frm_adminEquipos
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
            this.Lbl_administracionArbitros = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Txt_descripcionEquipo = new System.Windows.Forms.TextBox();
            this.Txt_nombreEquipo = new System.Windows.Forms.TextBox();
            this.Lbl_descripcionEquipo = new System.Windows.Forms.Label();
            this.Lbl_nombreEquipo = new System.Windows.Forms.Label();
            this.Gpb_estado = new System.Windows.Forms.GroupBox();
            this.Rbd_deshabilitado = new System.Windows.Forms.RadioButton();
            this.Rdb_habilitado = new System.Windows.Forms.RadioButton();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Gpb_estado.SuspendLayout();
            this.SuspendLayout();
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
            this.Pnl_titulo.TabIndex = 9;
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
            this.Lbl_administracionArbitros.Size = new System.Drawing.Size(314, 24);
            this.Lbl_administracionArbitros.TabIndex = 2;
            this.Lbl_administracionArbitros.Text = "ADMINISTRACION DE EQUIPOS";
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
            // Txt_descripcionEquipo
            // 
            this.Txt_descripcionEquipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcionEquipo.Location = new System.Drawing.Point(414, 302);
            this.Txt_descripcionEquipo.Name = "Txt_descripcionEquipo";
            this.Txt_descripcionEquipo.Size = new System.Drawing.Size(230, 23);
            this.Txt_descripcionEquipo.TabIndex = 154;
            // 
            // Txt_nombreEquipo
            // 
            this.Txt_nombreEquipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreEquipo.Location = new System.Drawing.Point(414, 248);
            this.Txt_nombreEquipo.Name = "Txt_nombreEquipo";
            this.Txt_nombreEquipo.Size = new System.Drawing.Size(230, 23);
            this.Txt_nombreEquipo.TabIndex = 153;
            // 
            // Lbl_descripcionEquipo
            // 
            this.Lbl_descripcionEquipo.AutoSize = true;
            this.Lbl_descripcionEquipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcionEquipo.Location = new System.Drawing.Point(265, 305);
            this.Lbl_descripcionEquipo.Name = "Lbl_descripcionEquipo";
            this.Lbl_descripcionEquipo.Size = new System.Drawing.Size(132, 17);
            this.Lbl_descripcionEquipo.TabIndex = 152;
            this.Lbl_descripcionEquipo.Text = "Descripcion Equipo";
            // 
            // Lbl_nombreEquipo
            // 
            this.Lbl_nombreEquipo.AutoSize = true;
            this.Lbl_nombreEquipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreEquipo.Location = new System.Drawing.Point(265, 251);
            this.Lbl_nombreEquipo.Name = "Lbl_nombreEquipo";
            this.Lbl_nombreEquipo.Size = new System.Drawing.Size(110, 17);
            this.Lbl_nombreEquipo.TabIndex = 151;
            this.Lbl_nombreEquipo.Text = "Nombre Equipo";
            // 
            // Gpb_estado
            // 
            this.Gpb_estado.Controls.Add(this.Rbd_deshabilitado);
            this.Gpb_estado.Controls.Add(this.Rdb_habilitado);
            this.Gpb_estado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_estado.Location = new System.Drawing.Point(238, 370);
            this.Gpb_estado.Name = "Gpb_estado";
            this.Gpb_estado.Size = new System.Drawing.Size(434, 100);
            this.Gpb_estado.TabIndex = 150;
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
            this.Btn_salir.Location = new System.Drawing.Point(582, 111);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(90, 75);
            this.Btn_salir.TabIndex = 149;
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
            this.Btn_ingresar.Location = new System.Drawing.Point(238, 111);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(90, 75);
            this.Btn_ingresar.TabIndex = 148;
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
            this.Btn_modificar.Location = new System.Drawing.Point(410, 111);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(90, 75);
            this.Btn_modificar.TabIndex = 147;
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
            this.Btn_eliminar.Location = new System.Drawing.Point(496, 111);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(90, 75);
            this.Btn_eliminar.TabIndex = 146;
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
            this.Btn_guardar.Location = new System.Drawing.Point(325, 111);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(90, 75);
            this.Btn_guardar.TabIndex = 145;
            this.Btn_guardar.Text = "GUARDAR";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // frm_adminEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 580);
            this.Controls.Add(this.Txt_descripcionEquipo);
            this.Controls.Add(this.Txt_nombreEquipo);
            this.Controls.Add(this.Lbl_descripcionEquipo);
            this.Controls.Add(this.Lbl_nombreEquipo);
            this.Controls.Add(this.Gpb_estado);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_adminEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_adminEquipos";
            this.Load += new System.EventHandler(this.frm_adminEquipos_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Gpb_estado.ResumeLayout(false);
            this.Gpb_estado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_administracionArbitros;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Txt_descripcionEquipo;
        private System.Windows.Forms.TextBox Txt_nombreEquipo;
        private System.Windows.Forms.Label Lbl_descripcionEquipo;
        private System.Windows.Forms.Label Lbl_nombreEquipo;
        private System.Windows.Forms.GroupBox Gpb_estado;
        private System.Windows.Forms.RadioButton Rbd_deshabilitado;
        private System.Windows.Forms.RadioButton Rdb_habilitado;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_ingresar;
        public System.Windows.Forms.Button Btn_modificar;
        public System.Windows.Forms.Button Btn_eliminar;
        public System.Windows.Forms.Button Btn_guardar;
    }
}