namespace Polideportivo_Administrativo.Mantenimientos
{
    partial class frm_jugadores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_jugadores = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Dgv_jugadores = new System.Windows.Forms.DataGridView();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Btn_ingresarJugador = new System.Windows.Forms.Button();
            this.Btn_salida = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Lbl_buscar = new System.Windows.Forms.Label();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_jugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Lbl_jugadores);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 64);
            this.panel1.TabIndex = 6;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_48;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.DarkRed;
            this.Btn_cerrar.Location = new System.Drawing.Point(1179, 4);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(61, 56);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_jugadores
            // 
            this.Lbl_jugadores.AutoSize = true;
            this.Lbl_jugadores.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_jugadores.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_jugadores.Location = new System.Drawing.Point(60, 16);
            this.Lbl_jugadores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_jugadores.Name = "Lbl_jugadores";
            this.Lbl_jugadores.Size = new System.Drawing.Size(134, 24);
            this.Lbl_jugadores.TabIndex = 2;
            this.Lbl_jugadores.Text = "JUGADORES";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_modo_deportes_24;
            this.pictureBox2.Location = new System.Drawing.Point(16, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 35);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Dgv_jugadores
            // 
            this.Dgv_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_jugadores.Location = new System.Drawing.Point(53, 114);
            this.Dgv_jugadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgv_jugadores.Name = "Dgv_jugadores";
            this.Dgv_jugadores.Size = new System.Drawing.Size(919, 675);
            this.Dgv_jugadores.TabIndex = 7;
            // 
            // Btn_seleccionar
            // 
            this.Btn_seleccionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionar.Location = new System.Drawing.Point(1007, 246);
            this.Btn_seleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(221, 37);
            this.Btn_seleccionar.TabIndex = 8;
            this.Btn_seleccionar.Text = "Seleccionar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            // 
            // Btn_ingresarJugador
            // 
            this.Btn_ingresarJugador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresarJugador.Location = new System.Drawing.Point(1007, 347);
            this.Btn_ingresarJugador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_ingresarJugador.Name = "Btn_ingresarJugador";
            this.Btn_ingresarJugador.Size = new System.Drawing.Size(221, 60);
            this.Btn_ingresarJugador.TabIndex = 9;
            this.Btn_ingresarJugador.Text = "Ingresar Nuevo Jugador";
            this.Btn_ingresarJugador.UseVisualStyleBackColor = true;
            this.Btn_ingresarJugador.Click += new System.EventHandler(this.Btn_ingresarJugador_Click);
            // 
            // Btn_salida
            // 
            this.Btn_salida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salida.Location = new System.Drawing.Point(1007, 747);
            this.Btn_salida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_salida.Name = "Btn_salida";
            this.Btn_salida.Size = new System.Drawing.Size(221, 42);
            this.Btn_salida.TabIndex = 10;
            this.Btn_salida.Text = "Salir";
            this.Btn_salida.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(1007, 200);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(221, 38);
            this.Btn_buscar.TabIndex = 11;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar.Location = new System.Drawing.Point(1007, 150);
            this.Txt_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(220, 23);
            this.Txt_buscar.TabIndex = 12;
            // 
            // Lbl_buscar
            // 
            this.Lbl_buscar.AutoSize = true;
            this.Lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_buscar.Location = new System.Drawing.Point(1003, 114);
            this.Lbl_buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_buscar.Name = "Lbl_buscar";
            this.Lbl_buscar.Size = new System.Drawing.Size(49, 17);
            this.Lbl_buscar.TabIndex = 13;
            this.Lbl_buscar.Text = "Buscar";
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(1007, 294);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(221, 43);
            this.Btn_actualizar.TabIndex = 23;
            this.Btn_actualizar.Text = "Actualizar Tabla";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // frm_jugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 860);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Lbl_buscar);
            this.Controls.Add(this.Txt_buscar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_salida);
            this.Controls.Add(this.Btn_ingresarJugador);
            this.Controls.Add(this.Btn_seleccionar);
            this.Controls.Add(this.Dgv_jugadores);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_jugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jugadores";
            this.Load += new System.EventHandler(this.frm_jugadores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_jugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_jugadores;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView Dgv_jugadores;
        private System.Windows.Forms.Button Btn_seleccionar;
        private System.Windows.Forms.Button Btn_ingresarJugador;
        private System.Windows.Forms.Button Btn_salida;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label Lbl_buscar;
        private System.Windows.Forms.Button Btn_actualizar;
    }
}