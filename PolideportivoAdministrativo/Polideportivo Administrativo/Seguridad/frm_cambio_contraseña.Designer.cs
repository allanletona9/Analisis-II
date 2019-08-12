namespace Polideportivo_Administrativo.Seguridad
{
    partial class frm_cambio_contraseña
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
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Lbl_codigoEntrenador = new System.Windows.Forms.Label();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.Txt_contraseña = new System.Windows.Forms.TextBox();
            this.Lbl_nombreEntrenador = new System.Windows.Forms.Label();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Pnl_Buscar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Pnl_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Pnl_titulo.TabIndex = 175;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_48;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.DarkRed;
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
            this.Lbl_administracionArbitros.Location = new System.Drawing.Point(45, 8);
            this.Lbl_administracionArbitros.Name = "Lbl_administracionArbitros";
            this.Lbl_administracionArbitros.Size = new System.Drawing.Size(253, 24);
            this.Lbl_administracionArbitros.TabIndex = 2;
            this.Lbl_administracionArbitros.Text = "Cambio de Contraseña";
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
            // Txt_codigo
            // 
            this.Txt_codigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigo.Location = new System.Drawing.Point(249, 45);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(279, 23);
            this.Txt_codigo.TabIndex = 216;
            // 
            // Lbl_codigoEntrenador
            // 
            this.Lbl_codigoEntrenador.AutoSize = true;
            this.Lbl_codigoEntrenador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigoEntrenador.Location = new System.Drawing.Point(94, 45);
            this.Lbl_codigoEntrenador.Name = "Lbl_codigoEntrenador";
            this.Lbl_codigoEntrenador.Size = new System.Drawing.Size(119, 17);
            this.Lbl_codigoEntrenador.TabIndex = 215;
            this.Lbl_codigoEntrenador.Text = "Nombre a Buscar";
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
            this.Btn_guardar.Location = new System.Drawing.Point(721, 228);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(100, 82);
            this.Btn_guardar.TabIndex = 213;
            this.Btn_guardar.Text = "GUARDAR";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Txt_estado
            // 
            this.Txt_estado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.Location = new System.Drawing.Point(298, 263);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.ReadOnly = true;
            this.Txt_estado.Size = new System.Drawing.Size(230, 23);
            this.Txt_estado.TabIndex = 212;
            this.Txt_estado.Text = " ";
            // 
            // Txt_contraseña
            // 
            this.Txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_contraseña.Location = new System.Drawing.Point(298, 317);
            this.Txt_contraseña.Name = "Txt_contraseña";
            this.Txt_contraseña.Size = new System.Drawing.Size(230, 23);
            this.Txt_contraseña.TabIndex = 210;
            // 
            // Lbl_nombreEntrenador
            // 
            this.Lbl_nombreEntrenador.AutoSize = true;
            this.Lbl_nombreEntrenador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreEntrenador.Location = new System.Drawing.Point(143, 210);
            this.Lbl_nombreEntrenador.Name = "Lbl_nombreEntrenador";
            this.Lbl_nombreEntrenador.Size = new System.Drawing.Size(58, 17);
            this.Lbl_nombreEntrenador.TabIndex = 207;
            this.Lbl_nombreEntrenador.Text = " Usuario";
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
            this.Btn_modificar.Location = new System.Drawing.Point(672, 16);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(100, 77);
            this.Btn_modificar.TabIndex = 217;
            this.Btn_modificar.Text = "Buscar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Pnl_Buscar
            // 
            this.Pnl_Buscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pnl_Buscar.Controls.Add(this.Btn_modificar);
            this.Pnl_Buscar.Controls.Add(this.Txt_codigo);
            this.Pnl_Buscar.Controls.Add(this.Lbl_codigoEntrenador);
            this.Pnl_Buscar.Location = new System.Drawing.Point(49, 52);
            this.Pnl_Buscar.Name = "Pnl_Buscar";
            this.Pnl_Buscar.Size = new System.Drawing.Size(810, 111);
            this.Pnl_Buscar.TabIndex = 218;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 219;
            this.label1.Text = " Nueva Contraseña";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.Location = new System.Drawing.Point(298, 204);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.ReadOnly = true;
            this.Txt_Usuario.Size = new System.Drawing.Size(230, 23);
            this.Txt_Usuario.TabIndex = 220;
            this.Txt_Usuario.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 221;
            this.label2.Text = " Estado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 400);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 195);
            this.dataGridView1.TabIndex = 222;
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
            this.Btn_ingresar.Location = new System.Drawing.Point(721, 450);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(100, 75);
            this.Btn_ingresar.TabIndex = 223;
            this.Btn_ingresar.Text = "Ver Usuarios ";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_ayuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_ayuda.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_ayuda_30;
            this.Btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ayuda.Location = new System.Drawing.Point(861, 41);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(85, 37);
            this.Btn_ayuda.TabIndex = 224;
            this.Btn_ayuda.Text = "Ayuda";
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // frm_cambio_contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 607);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pnl_Buscar);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.Txt_estado);
            this.Controls.Add(this.Lbl_nombreEntrenador);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Txt_contraseña);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cambio_contraseña";
            this.Text = "frm_cambio_contraseña";
            this.Load += new System.EventHandler(this.frm_cambio_contraseña_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Pnl_Buscar.ResumeLayout(false);
            this.Pnl_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_administracionArbitros;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label Lbl_codigoEntrenador;
        public System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.TextBox Txt_estado;
        private System.Windows.Forms.TextBox Txt_contraseña;
        private System.Windows.Forms.Label Lbl_nombreEntrenador;
        public System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Panel Pnl_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}