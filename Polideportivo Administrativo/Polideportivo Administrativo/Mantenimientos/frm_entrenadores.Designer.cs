﻿namespace Polideportivo_Administrativo.Mantenimientos
{
    partial class frm_entrenadores
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
            this.Lbl_buscar = new System.Windows.Forms.Label();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_salida = new System.Windows.Forms.Button();
            this.Btn_ingresarEntrenador = new System.Windows.Forms.Button();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Dgv_entrenadores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_entrenadores = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_entrenadores)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_buscar
            // 
            this.Lbl_buscar.AutoSize = true;
            this.Lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_buscar.Location = new System.Drawing.Point(745, 70);
            this.Lbl_buscar.Name = "Lbl_buscar";
            this.Lbl_buscar.Size = new System.Drawing.Size(49, 17);
            this.Lbl_buscar.TabIndex = 21;
            this.Lbl_buscar.Text = "Buscar";
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar.Location = new System.Drawing.Point(748, 98);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(166, 23);
            this.Txt_buscar.TabIndex = 20;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(748, 136);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(166, 29);
            this.Btn_buscar.TabIndex = 19;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_salida
            // 
            this.Btn_salida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salida.Location = new System.Drawing.Point(748, 554);
            this.Btn_salida.Name = "Btn_salida";
            this.Btn_salida.Size = new System.Drawing.Size(166, 32);
            this.Btn_salida.TabIndex = 18;
            this.Btn_salida.Text = "Salir";
            this.Btn_salida.UseVisualStyleBackColor = true;
            // 
            // Btn_ingresarEntrenador
            // 
            this.Btn_ingresarEntrenador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresarEntrenador.Location = new System.Drawing.Point(748, 205);
            this.Btn_ingresarEntrenador.Name = "Btn_ingresarEntrenador";
            this.Btn_ingresarEntrenador.Size = new System.Drawing.Size(166, 46);
            this.Btn_ingresarEntrenador.TabIndex = 17;
            this.Btn_ingresarEntrenador.Text = "Ingresar Nuevo Entrenador";
            this.Btn_ingresarEntrenador.UseVisualStyleBackColor = true;
            this.Btn_ingresarEntrenador.Click += new System.EventHandler(this.Btn_ingresarEntrenador_Click);
            // 
            // Btn_seleccionar
            // 
            this.Btn_seleccionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionar.Location = new System.Drawing.Point(748, 171);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(166, 28);
            this.Btn_seleccionar.TabIndex = 16;
            this.Btn_seleccionar.Text = "Seleccionar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            // 
            // Dgv_entrenadores
            // 
            this.Dgv_entrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_entrenadores.Location = new System.Drawing.Point(26, 70);
            this.Dgv_entrenadores.Name = "Dgv_entrenadores";
            this.Dgv_entrenadores.Size = new System.Drawing.Size(689, 516);
            this.Dgv_entrenadores.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Lbl_entrenadores);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 49);
            this.panel1.TabIndex = 14;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_48;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.DarkRed;
            this.Btn_cerrar.Location = new System.Drawing.Point(877, 3);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(46, 43);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_entrenadores
            // 
            this.Lbl_entrenadores.AutoSize = true;
            this.Lbl_entrenadores.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_entrenadores.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_entrenadores.Location = new System.Drawing.Point(45, 12);
            this.Lbl_entrenadores.Name = "Lbl_entrenadores";
            this.Lbl_entrenadores.Size = new System.Drawing.Size(168, 24);
            this.Lbl_entrenadores.TabIndex = 2;
            this.Lbl_entrenadores.Text = "ENTRENADORES";
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
            // frm_entrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 619);
            this.Controls.Add(this.Lbl_buscar);
            this.Controls.Add(this.Txt_buscar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_salida);
            this.Controls.Add(this.Btn_ingresarEntrenador);
            this.Controls.Add(this.Btn_seleccionar);
            this.Controls.Add(this.Dgv_entrenadores);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_entrenadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrenadores";
            this.Load += new System.EventHandler(this.frm_entrenadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_entrenadores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_salida;
        private System.Windows.Forms.Button Btn_ingresarEntrenador;
        private System.Windows.Forms.Button Btn_seleccionar;
        private System.Windows.Forms.DataGridView Dgv_entrenadores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_entrenadores;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}