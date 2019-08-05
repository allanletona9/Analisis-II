namespace Polideportivo_Administrativo.Procesos
{
    partial class frm_nuevoCalendarioAutomatico
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
            this.Lbl_calendarioP = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Tb_horaInicial = new System.Windows.Forms.TrackBar();
            this.Tb_horaFinal = new System.Windows.Forms.TrackBar();
            this.Lbl_horaInicial = new System.Windows.Forms.Label();
            this.Lbl_horaFinal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rb_ida = new System.Windows.Forms.RadioButton();
            this.Rb_idaVuelta = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_generarAutomatico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_duracion_jornada = new System.Windows.Forms.TextBox();
            this.Txt_descanso_jornada = new System.Windows.Forms.TextBox();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tb_horaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tb_horaFinal)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Pnl_titulo.Controls.Add(this.Btn_cerrar);
            this.Pnl_titulo.Controls.Add(this.Lbl_calendarioP);
            this.Pnl_titulo.Controls.Add(this.pictureBox2);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(1014, 57);
            this.Pnl_titulo.TabIndex = 11;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_48;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Btn_cerrar.Location = new System.Drawing.Point(958, 5);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(45, 48);
            this.Btn_cerrar.TabIndex = 7;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_calendarioP
            // 
            this.Lbl_calendarioP.AutoSize = true;
            this.Lbl_calendarioP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_calendarioP.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_calendarioP.Location = new System.Drawing.Point(68, 14);
            this.Lbl_calendarioP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_calendarioP.Name = "Lbl_calendarioP";
            this.Lbl_calendarioP.Size = new System.Drawing.Size(448, 37);
            this.Lbl_calendarioP.TabIndex = 2;
            this.Lbl_calendarioP.Text = "CALENDARIO AUTOMATICO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Polideportivo_Administrativo.Properties.Resources.icons8_modo_deportes_24;
            this.pictureBox2.Location = new System.Drawing.Point(13, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 42);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Tb_horaInicial
            // 
            this.Tb_horaInicial.Location = new System.Drawing.Point(329, 40);
            this.Tb_horaInicial.Maximum = 23;
            this.Tb_horaInicial.Name = "Tb_horaInicial";
            this.Tb_horaInicial.Size = new System.Drawing.Size(586, 69);
            this.Tb_horaInicial.TabIndex = 12;
            this.Tb_horaInicial.Scroll += new System.EventHandler(this.Tb_horaInicial_Scroll);
            // 
            // Tb_horaFinal
            // 
            this.Tb_horaFinal.Location = new System.Drawing.Point(329, 135);
            this.Tb_horaFinal.Maximum = 23;
            this.Tb_horaFinal.Name = "Tb_horaFinal";
            this.Tb_horaFinal.Size = new System.Drawing.Size(586, 69);
            this.Tb_horaFinal.TabIndex = 13;
            this.Tb_horaFinal.Value = 23;
            this.Tb_horaFinal.Scroll += new System.EventHandler(this.Tb_horaFinal_Scroll);
            // 
            // Lbl_horaInicial
            // 
            this.Lbl_horaInicial.AutoSize = true;
            this.Lbl_horaInicial.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_horaInicial.Location = new System.Drawing.Point(47, 40);
            this.Lbl_horaInicial.Name = "Lbl_horaInicial";
            this.Lbl_horaInicial.Size = new System.Drawing.Size(210, 35);
            this.Lbl_horaInicial.TabIndex = 14;
            this.Lbl_horaInicial.Text = "Hora inicial: 0:00";
            // 
            // Lbl_horaFinal
            // 
            this.Lbl_horaFinal.AutoSize = true;
            this.Lbl_horaFinal.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_horaFinal.Location = new System.Drawing.Point(47, 135);
            this.Lbl_horaFinal.Name = "Lbl_horaFinal";
            this.Lbl_horaFinal.Size = new System.Drawing.Size(206, 35);
            this.Lbl_horaFinal.TabIndex = 15;
            this.Lbl_horaFinal.Text = "Hora final: 23:00";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Tb_horaFinal);
            this.panel1.Controls.Add(this.Lbl_horaFinal);
            this.panel1.Controls.Add(this.Tb_horaInicial);
            this.panel1.Controls.Add(this.Lbl_horaInicial);
            this.panel1.Location = new System.Drawing.Point(30, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 232);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Txt_descanso_jornada);
            this.panel2.Controls.Add(this.Txt_duracion_jornada);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(30, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 131);
            this.panel2.TabIndex = 25;
            // 
            // Rb_ida
            // 
            this.Rb_ida.AutoSize = true;
            this.Rb_ida.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_ida.Location = new System.Drawing.Point(64, 22);
            this.Rb_ida.Name = "Rb_ida";
            this.Rb_ida.Size = new System.Drawing.Size(77, 39);
            this.Rb_ida.TabIndex = 26;
            this.Rb_ida.TabStop = true;
            this.Rb_ida.Text = "Ida";
            this.Rb_ida.UseVisualStyleBackColor = true;
            // 
            // Rb_idaVuelta
            // 
            this.Rb_idaVuelta.AutoSize = true;
            this.Rb_idaVuelta.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_idaVuelta.Location = new System.Drawing.Point(64, 67);
            this.Rb_idaVuelta.Name = "Rb_idaVuelta";
            this.Rb_idaVuelta.Size = new System.Drawing.Size(174, 39);
            this.Rb_idaVuelta.TabIndex = 27;
            this.Rb_idaVuelta.TabStop = true;
            this.Rb_idaVuelta.Text = "Ida y vuelta";
            this.Rb_idaVuelta.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Rb_idaVuelta);
            this.panel3.Controls.Add(this.Rb_ida);
            this.panel3.Location = new System.Drawing.Point(683, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 131);
            this.panel3.TabIndex = 28;
            // 
            // Btn_generarAutomatico
            // 
            this.Btn_generarAutomatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_generarAutomatico.Location = new System.Drawing.Point(758, 514);
            this.Btn_generarAutomatico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_generarAutomatico.Name = "Btn_generarAutomatico";
            this.Btn_generarAutomatico.Size = new System.Drawing.Size(216, 63);
            this.Btn_generarAutomatico.TabIndex = 29;
            this.Btn_generarAutomatico.Text = "Generar";
            this.Btn_generarAutomatico.UseVisualStyleBackColor = true;
            this.Btn_generarAutomatico.Click += new System.EventHandler(this.Btn_generarAutomatico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 35);
            this.label1.TabIndex = 30;
            this.label1.Text = "Fecha inicial:";
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.CustomFormat = "yyyy-MM-dd";
            this.Dtp_fecha.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fecha.Location = new System.Drawing.Point(187, 18);
            this.Dtp_fecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.ShowUpDown = true;
            this.Dtp_fecha.Size = new System.Drawing.Size(172, 42);
            this.Dtp_fecha.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Dtp_fecha);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(30, 502);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 84);
            this.panel4.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "Duracion jornada (Dias):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 35);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descanso entre jornadas (Dias):";
            // 
            // Txt_duracion_jornada
            // 
            this.Txt_duracion_jornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_duracion_jornada.Location = new System.Drawing.Point(439, 20);
            this.Txt_duracion_jornada.Name = "Txt_duracion_jornada";
            this.Txt_duracion_jornada.Size = new System.Drawing.Size(153, 39);
            this.Txt_duracion_jornada.TabIndex = 17;
            // 
            // Txt_descanso_jornada
            // 
            this.Txt_descanso_jornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descanso_jornada.Location = new System.Drawing.Point(439, 69);
            this.Txt_descanso_jornada.Name = "Txt_descanso_jornada";
            this.Txt_descanso_jornada.Size = new System.Drawing.Size(153, 39);
            this.Txt_descanso_jornada.TabIndex = 18;
            // 
            // frm_nuevoCalendarioAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 618);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Btn_generarAutomatico);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_nuevoCalendarioAutomatico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_nuevoCalendarioAutomatico";
            this.Load += new System.EventHandler(this.frm_nuevoCalendarioAutomatico_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tb_horaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tb_horaFinal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_calendarioP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar Tb_horaInicial;
        private System.Windows.Forms.TrackBar Tb_horaFinal;
        private System.Windows.Forms.Label Lbl_horaInicial;
        private System.Windows.Forms.Label Lbl_horaFinal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Rb_ida;
        private System.Windows.Forms.RadioButton Rb_idaVuelta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_generarAutomatico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Txt_descanso_jornada;
        private System.Windows.Forms.TextBox Txt_duracion_jornada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}