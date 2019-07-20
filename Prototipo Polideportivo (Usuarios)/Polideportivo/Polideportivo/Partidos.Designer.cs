namespace Polideportivo
{
    partial class Partidos
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
            this.Lbl_jornada = new System.Windows.Forms.Label();
            this.Cbo_jornada = new System.Windows.Forms.ComboBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.Lbl_puntaje_equipo1 = new System.Windows.Forms.Label();
            this.Lbl_puntaje_equipo2 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl_estado_partido = new System.Windows.Forms.Label();
            this.Lbl_campo = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl_4 = new System.Windows.Forms.Label();
            this.Lbl_nombre_arbitro = new System.Windows.Forms.Label();
            this.Lbl_5 = new System.Windows.Forms.Label();
            this.Btn_sanciones = new System.Windows.Forms.Button();
            this.Btn_goleadores = new System.Windows.Forms.Button();
            this.Lbl_6 = new System.Windows.Forms.Label();
            this.Lbl_7 = new System.Windows.Forms.Label();
            this.Cbo_campeonato = new System.Windows.Forms.ComboBox();
            this.Lbl_campeonato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_jornada
            // 
            this.Lbl_jornada.AutoSize = true;
            this.Lbl_jornada.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_jornada.Location = new System.Drawing.Point(484, 31);
            this.Lbl_jornada.Name = "Lbl_jornada";
            this.Lbl_jornada.Size = new System.Drawing.Size(118, 35);
            this.Lbl_jornada.TabIndex = 4;
            this.Lbl_jornada.Text = "Jornada:";
            // 
            // Cbo_jornada
            // 
            this.Cbo_jornada.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_jornada.FormattingEnabled = true;
            this.Cbo_jornada.Items.AddRange(new object[] {
            "Jornada 1",
            "Jornada 2",
            "Jornada 3",
            "Jornada 4"});
            this.Cbo_jornada.Location = new System.Drawing.Point(608, 31);
            this.Cbo_jornada.Name = "Cbo_jornada";
            this.Cbo_jornada.Size = new System.Drawing.Size(230, 43);
            this.Cbo_jornada.TabIndex = 5;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.btn_consultar.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_consultar.Location = new System.Drawing.Point(867, 21);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(180, 58);
            this.btn_consultar.TabIndex = 6;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_puntaje_equipo1
            // 
            this.Lbl_puntaje_equipo1.AutoSize = true;
            this.Lbl_puntaje_equipo1.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_puntaje_equipo1.Location = new System.Drawing.Point(555, 398);
            this.Lbl_puntaje_equipo1.Name = "Lbl_puntaje_equipo1";
            this.Lbl_puntaje_equipo1.Size = new System.Drawing.Size(209, 35);
            this.Lbl_puntaje_equipo1.TabIndex = 7;
            this.Lbl_puntaje_equipo1.Text = "Puntaje equipo 1";
            // 
            // Lbl_puntaje_equipo2
            // 
            this.Lbl_puntaje_equipo2.AutoSize = true;
            this.Lbl_puntaje_equipo2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_puntaje_equipo2.Location = new System.Drawing.Point(555, 445);
            this.Lbl_puntaje_equipo2.Name = "Lbl_puntaje_equipo2";
            this.Lbl_puntaje_equipo2.Size = new System.Drawing.Size(212, 35);
            this.Lbl_puntaje_equipo2.TabIndex = 8;
            this.Lbl_puntaje_equipo2.Text = "Puntaje equipo 2";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(344, 136);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(199, 35);
            this.Lbl1.TabIndex = 9;
            this.Lbl1.Text = "Estado partido:";
            // 
            // Lbl_estado_partido
            // 
            this.Lbl_estado_partido.AutoSize = true;
            this.Lbl_estado_partido.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado_partido.Location = new System.Drawing.Point(556, 136);
            this.Lbl_estado_partido.Name = "Lbl_estado_partido";
            this.Lbl_estado_partido.Size = new System.Drawing.Size(133, 35);
            this.Lbl_estado_partido.TabIndex = 10;
            this.Lbl_estado_partido.Text = "Pendiente";
            // 
            // Lbl_campo
            // 
            this.Lbl_campo.AutoSize = true;
            this.Lbl_campo.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_campo.Location = new System.Drawing.Point(556, 181);
            this.Lbl_campo.Name = "Lbl_campo";
            this.Lbl_campo.Size = new System.Drawing.Size(115, 35);
            this.Lbl_campo.TabIndex = 12;
            this.Lbl_campo.Text = "Campo 1";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(435, 181);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(106, 35);
            this.Lbl2.TabIndex = 11;
            this.Lbl2.Text = "Campo:";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(556, 235);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(157, 35);
            this.Lbl_fecha.TabIndex = 14;
            this.Lbl_fecha.Text = "XX/XX/XXXX";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(448, 235);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(91, 35);
            this.Lbl3.TabIndex = 13;
            this.Lbl3.Text = "Fecha:";
            // 
            // Lbl_4
            // 
            this.Lbl_4.AutoSize = true;
            this.Lbl_4.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_4.Location = new System.Drawing.Point(432, 286);
            this.Lbl_4.Name = "Lbl_4";
            this.Lbl_4.Size = new System.Drawing.Size(111, 35);
            this.Lbl_4.TabIndex = 15;
            this.Lbl_4.Text = "Arbitro:";
            this.Lbl_4.Click += new System.EventHandler(this.label10_Click);
            // 
            // Lbl_nombre_arbitro
            // 
            this.Lbl_nombre_arbitro.AutoSize = true;
            this.Lbl_nombre_arbitro.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre_arbitro.Location = new System.Drawing.Point(555, 286);
            this.Lbl_nombre_arbitro.Name = "Lbl_nombre_arbitro";
            this.Lbl_nombre_arbitro.Size = new System.Drawing.Size(201, 35);
            this.Lbl_nombre_arbitro.TabIndex = 16;
            this.Lbl_nombre_arbitro.Text = "Nombre arbitro";
            // 
            // Lbl_5
            // 
            this.Lbl_5.AutoSize = true;
            this.Lbl_5.Font = new System.Drawing.Font("Candara", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_5.Location = new System.Drawing.Point(467, 347);
            this.Lbl_5.Name = "Lbl_5";
            this.Lbl_5.Size = new System.Drawing.Size(135, 35);
            this.Lbl_5.TabIndex = 17;
            this.Lbl_5.Text = "Resultado";
            // 
            // Btn_sanciones
            // 
            this.Btn_sanciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.Btn_sanciones.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sanciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_sanciones.Location = new System.Drawing.Point(30, 556);
            this.Btn_sanciones.Name = "Btn_sanciones";
            this.Btn_sanciones.Size = new System.Drawing.Size(373, 58);
            this.Btn_sanciones.TabIndex = 18;
            this.Btn_sanciones.Text = "Consultar sanciones";
            this.Btn_sanciones.UseVisualStyleBackColor = false;
            // 
            // Btn_goleadores
            // 
            this.Btn_goleadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.Btn_goleadores.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_goleadores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_goleadores.Location = new System.Drawing.Point(675, 556);
            this.Btn_goleadores.Name = "Btn_goleadores";
            this.Btn_goleadores.Size = new System.Drawing.Size(372, 58);
            this.Btn_goleadores.TabIndex = 19;
            this.Btn_goleadores.Text = "Consultar goleadores";
            this.Btn_goleadores.UseVisualStyleBackColor = false;
            // 
            // Lbl_6
            // 
            this.Lbl_6.AutoSize = true;
            this.Lbl_6.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_6.Location = new System.Drawing.Point(417, 398);
            this.Lbl_6.Name = "Lbl_6";
            this.Lbl_6.Size = new System.Drawing.Size(122, 35);
            this.Lbl_6.TabIndex = 20;
            this.Lbl_6.Text = "Equipo 1:";
            // 
            // Lbl_7
            // 
            this.Lbl_7.AutoSize = true;
            this.Lbl_7.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_7.Location = new System.Drawing.Point(417, 445);
            this.Lbl_7.Name = "Lbl_7";
            this.Lbl_7.Size = new System.Drawing.Size(126, 35);
            this.Lbl_7.TabIndex = 21;
            this.Lbl_7.Text = "Equipo 2:";
            // 
            // Cbo_campeonato
            // 
            this.Cbo_campeonato.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_campeonato.FormattingEnabled = true;
            this.Cbo_campeonato.Items.AddRange(new object[] {
            "Campeonato 1",
            "Campeonato 2",
            "Campeonato 3"});
            this.Cbo_campeonato.Location = new System.Drawing.Point(205, 28);
            this.Cbo_campeonato.Name = "Cbo_campeonato";
            this.Cbo_campeonato.Size = new System.Drawing.Size(244, 43);
            this.Cbo_campeonato.TabIndex = 23;
            // 
            // Lbl_campeonato
            // 
            this.Lbl_campeonato.AutoSize = true;
            this.Lbl_campeonato.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_campeonato.Location = new System.Drawing.Point(24, 34);
            this.Lbl_campeonato.Name = "Lbl_campeonato";
            this.Lbl_campeonato.Size = new System.Drawing.Size(175, 35);
            this.Lbl_campeonato.TabIndex = 22;
            this.Lbl_campeonato.Text = "Campeonato:";
            // 
            // Partidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.Cbo_campeonato);
            this.Controls.Add(this.Lbl_campeonato);
            this.Controls.Add(this.Lbl_7);
            this.Controls.Add(this.Lbl_6);
            this.Controls.Add(this.Btn_goleadores);
            this.Controls.Add(this.Btn_sanciones);
            this.Controls.Add(this.Lbl_5);
            this.Controls.Add(this.Lbl_nombre_arbitro);
            this.Controls.Add(this.Lbl_4);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl_campo);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl_estado_partido);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Lbl_puntaje_equipo2);
            this.Controls.Add(this.Lbl_puntaje_equipo1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.Cbo_jornada);
            this.Controls.Add(this.Lbl_jornada);
            this.Name = "Partidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partidos";
            this.Load += new System.EventHandler(this.Partidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_jornada;
        private System.Windows.Forms.ComboBox Cbo_jornada;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label Lbl_puntaje_equipo1;
        private System.Windows.Forms.Label Lbl_puntaje_equipo2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl_estado_partido;
        private System.Windows.Forms.Label Lbl_campo;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl_4;
        private System.Windows.Forms.Label Lbl_nombre_arbitro;
        private System.Windows.Forms.Label Lbl_5;
        private System.Windows.Forms.Button Btn_sanciones;
        private System.Windows.Forms.Button Btn_goleadores;
        private System.Windows.Forms.Label Lbl_6;
        private System.Windows.Forms.Label Lbl_7;
        private System.Windows.Forms.ComboBox Cbo_campeonato;
        private System.Windows.Forms.Label Lbl_campeonato;
    }
}