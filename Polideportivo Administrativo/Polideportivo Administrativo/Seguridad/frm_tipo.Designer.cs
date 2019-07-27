namespace Polideportivo_Administrativo.Seguridad
{
    partial class frm_tipo
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lbl_administracionArbitros = new System.Windows.Forms.Label();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.Gpb_estado = new System.Windows.Forms.GroupBox();
            this.Rdb_entrenador = new System.Windows.Forms.RadioButton();
            this.Rdb_empleado = new System.Windows.Forms.RadioButton();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Pnl_titulo.SuspendLayout();
            this.Gpb_estado.SuspendLayout();
            this.SuspendLayout();
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
            // Lbl_administracionArbitros
            // 
            this.Lbl_administracionArbitros.AutoSize = true;
            this.Lbl_administracionArbitros.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_administracionArbitros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_administracionArbitros.Location = new System.Drawing.Point(45, 3);
            this.Lbl_administracionArbitros.Name = "Lbl_administracionArbitros";
            this.Lbl_administracionArbitros.Size = new System.Drawing.Size(170, 24);
            this.Lbl_administracionArbitros.TabIndex = 2;
            this.Lbl_administracionArbitros.Text = "Tipo De Acceso";
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
            this.Pnl_titulo.TabIndex = 220;
            // 
            // Gpb_estado
            // 
            this.Gpb_estado.Controls.Add(this.Rdb_entrenador);
            this.Gpb_estado.Controls.Add(this.Rdb_empleado);
            this.Gpb_estado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_estado.Location = new System.Drawing.Point(264, 73);
            this.Gpb_estado.Name = "Gpb_estado";
            this.Gpb_estado.Size = new System.Drawing.Size(434, 100);
            this.Gpb_estado.TabIndex = 221;
            this.Gpb_estado.TabStop = false;
            // 
            // Rdb_entrenador
            // 
            this.Rdb_entrenador.AutoSize = true;
            this.Rdb_entrenador.Location = new System.Drawing.Point(239, 48);
            this.Rdb_entrenador.Name = "Rdb_entrenador";
            this.Rdb_entrenador.Size = new System.Drawing.Size(97, 21);
            this.Rdb_entrenador.TabIndex = 1;
            this.Rdb_entrenador.TabStop = true;
            this.Rdb_entrenador.Text = "Entrenador";
            this.Rdb_entrenador.UseVisualStyleBackColor = true;
            // 
            // Rdb_empleado
            // 
            this.Rdb_empleado.AutoSize = true;
            this.Rdb_empleado.Location = new System.Drawing.Point(83, 48);
            this.Rdb_empleado.Name = "Rdb_empleado";
            this.Rdb_empleado.Size = new System.Drawing.Size(97, 21);
            this.Rdb_empleado.TabIndex = 0;
            this.Rdb_empleado.TabStop = true;
            this.Rdb_empleado.Text = " Empleado";
            this.Rdb_empleado.UseVisualStyleBackColor = true;
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
            this.Btn_ingresar.Location = new System.Drawing.Point(765, 83);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(100, 75);
            this.Btn_ingresar.TabIndex = 173;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // tipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 215);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Gpb_estado);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tipo";
            this.Text = " ";
            this.Load += new System.EventHandler(this.tipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.Gpb_estado.ResumeLayout(false);
            this.Gpb_estado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Lbl_administracionArbitros;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.GroupBox Gpb_estado;
        private System.Windows.Forms.RadioButton Rdb_entrenador;
        private System.Windows.Forms.RadioButton Rdb_empleado;
        private System.Windows.Forms.Button Btn_ingresar;
    }
}