namespace Polideportivo_Administrativo.Procesos
{
    partial class frm_ConsultarCalendario
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
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_calendario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Cbo_campeonato = new System.Windows.Forms.ComboBox();
            this.Cbo_jornada = new System.Windows.Forms.ComboBox();
            this.Gpb_consultar = new System.Windows.Forms.GroupBox();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Lbl_jornada = new System.Windows.Forms.Label();
            this.Lbl_campeonato = new System.Windows.Forms.Label();
            this.Dgv_calendario = new System.Windows.Forms.DataGridView();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Gpb_consultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_calendario)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Pnl_titulo.Controls.Add(this.button1);
            this.Pnl_titulo.Controls.Add(this.Lbl_calendario);
            this.Pnl_titulo.Controls.Add(this.pictureBox2);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(1084, 49);
            this.Pnl_titulo.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Polideportivo_Administrativo.Properties.Resources.icons8_cerrar_ventana_48;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Location = new System.Drawing.Point(1015, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 43);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_calendario
            // 
            this.Lbl_calendario.AutoSize = true;
            this.Lbl_calendario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_calendario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_calendario.Location = new System.Drawing.Point(45, 12);
            this.Lbl_calendario.Name = "Lbl_calendario";
            this.Lbl_calendario.Size = new System.Drawing.Size(272, 24);
            this.Lbl_calendario.TabIndex = 2;
            this.Lbl_calendario.Text = "CONSULTAR CALENDARIO";
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
            // Cbo_campeonato
            // 
            this.Cbo_campeonato.FormattingEnabled = true;
            this.Cbo_campeonato.Location = new System.Drawing.Point(51, 52);
            this.Cbo_campeonato.Name = "Cbo_campeonato";
            this.Cbo_campeonato.Size = new System.Drawing.Size(121, 25);
            this.Cbo_campeonato.TabIndex = 10;
            // 
            // Cbo_jornada
            // 
            this.Cbo_jornada.FormattingEnabled = true;
            this.Cbo_jornada.Location = new System.Drawing.Point(238, 52);
            this.Cbo_jornada.Name = "Cbo_jornada";
            this.Cbo_jornada.Size = new System.Drawing.Size(121, 25);
            this.Cbo_jornada.TabIndex = 11;
            // 
            // Gpb_consultar
            // 
            this.Gpb_consultar.Controls.Add(this.Btn_consultar);
            this.Gpb_consultar.Controls.Add(this.Lbl_jornada);
            this.Gpb_consultar.Controls.Add(this.Lbl_campeonato);
            this.Gpb_consultar.Controls.Add(this.Cbo_campeonato);
            this.Gpb_consultar.Controls.Add(this.Cbo_jornada);
            this.Gpb_consultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_consultar.Location = new System.Drawing.Point(260, 97);
            this.Gpb_consultar.Name = "Gpb_consultar";
            this.Gpb_consultar.Size = new System.Drawing.Size(516, 116);
            this.Gpb_consultar.TabIndex = 12;
            this.Gpb_consultar.TabStop = false;
            this.Gpb_consultar.Text = "Consultar";
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.Location = new System.Drawing.Point(406, 52);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(90, 25);
            this.Btn_consultar.TabIndex = 14;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.UseVisualStyleBackColor = true;
            // 
            // Lbl_jornada
            // 
            this.Lbl_jornada.AutoSize = true;
            this.Lbl_jornada.Location = new System.Drawing.Point(235, 32);
            this.Lbl_jornada.Name = "Lbl_jornada";
            this.Lbl_jornada.Size = new System.Drawing.Size(135, 17);
            this.Lbl_jornada.TabIndex = 13;
            this.Lbl_jornada.Text = "Seleccione Jornada";
            // 
            // Lbl_campeonato
            // 
            this.Lbl_campeonato.AutoSize = true;
            this.Lbl_campeonato.Location = new System.Drawing.Point(28, 32);
            this.Lbl_campeonato.Name = "Lbl_campeonato";
            this.Lbl_campeonato.Size = new System.Drawing.Size(171, 17);
            this.Lbl_campeonato.TabIndex = 12;
            this.Lbl_campeonato.Text = "Seleccione Campeonato";
            // 
            // Dgv_calendario
            // 
            this.Dgv_calendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_calendario.Location = new System.Drawing.Point(229, 233);
            this.Dgv_calendario.Name = "Dgv_calendario";
            this.Dgv_calendario.Size = new System.Drawing.Size(588, 358);
            this.Dgv_calendario.TabIndex = 13;
            // 
            // frm_ConsultarCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.Dgv_calendario);
            this.Controls.Add(this.Gpb_consultar);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ConsultarCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Calendario";
            this.Load += new System.EventHandler(this.frm_ConsultarCalendario_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Gpb_consultar.ResumeLayout(false);
            this.Gpb_consultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_calendario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lbl_calendario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox Cbo_campeonato;
        private System.Windows.Forms.ComboBox Cbo_jornada;
        private System.Windows.Forms.GroupBox Gpb_consultar;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Label Lbl_jornada;
        private System.Windows.Forms.Label Lbl_campeonato;
        private System.Windows.Forms.DataGridView Dgv_calendario;
    }
}