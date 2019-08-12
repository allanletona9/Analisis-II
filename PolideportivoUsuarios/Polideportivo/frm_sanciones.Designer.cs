namespace Polideportivo
{
    partial class frm_sanciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sanciones));
            this.Dgv_sanciones = new System.Windows.Forms.DataGridView();
            this.Cbo_campeonato = new System.Windows.Forms.ComboBox();
            this.Lbl_campeonato = new System.Windows.Forms.Label();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_deportespro = new System.Windows.Forms.Label();
            this.Cbo_jornadas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sanciones)).BeginInit();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_sanciones
            // 
            this.Dgv_sanciones.AllowUserToAddRows = false;
            this.Dgv_sanciones.AllowUserToDeleteRows = false;
            this.Dgv_sanciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_sanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_sanciones.Location = new System.Drawing.Point(23, 107);
            this.Dgv_sanciones.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_sanciones.Name = "Dgv_sanciones";
            this.Dgv_sanciones.ReadOnly = true;
            this.Dgv_sanciones.RowTemplate.Height = 28;
            this.Dgv_sanciones.Size = new System.Drawing.Size(668, 285);
            this.Dgv_sanciones.TabIndex = 7;
            // 
            // Cbo_campeonato
            // 
            this.Cbo_campeonato.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_campeonato.FormattingEnabled = true;
            this.Cbo_campeonato.Items.AddRange(new object[] {
            "Campeonato 1",
            "Campeonato 2",
            "Campeonato 3"});
            this.Cbo_campeonato.Location = new System.Drawing.Point(140, 54);
            this.Cbo_campeonato.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_campeonato.Name = "Cbo_campeonato";
            this.Cbo_campeonato.Size = new System.Drawing.Size(164, 31);
            this.Cbo_campeonato.TabIndex = 11;
            // 
            // Lbl_campeonato
            // 
            this.Lbl_campeonato.AutoSize = true;
            this.Lbl_campeonato.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_campeonato.Location = new System.Drawing.Point(19, 58);
            this.Lbl_campeonato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_campeonato.Name = "Lbl_campeonato";
            this.Lbl_campeonato.Size = new System.Drawing.Size(119, 23);
            this.Lbl_campeonato.TabIndex = 10;
            this.Lbl_campeonato.Text = "Campeonato:";
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.Teal;
            this.Pnl_titulo.Controls.Add(this.pictureBox2);
            this.Pnl_titulo.Controls.Add(this.Btn_cerrar);
            this.Pnl_titulo.Controls.Add(this.Lbl_deportespro);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(713, 35);
            this.Pnl_titulo.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackColor = System.Drawing.Color.Teal;
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.Teal;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(674, 3);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(30, 29);
            this.Btn_cerrar.TabIndex = 10;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_deportespro
            // 
            this.Lbl_deportespro.AutoSize = true;
            this.Lbl_deportespro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_deportespro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_deportespro.Location = new System.Drawing.Point(45, 9);
            this.Lbl_deportespro.Name = "Lbl_deportespro";
            this.Lbl_deportespro.Size = new System.Drawing.Size(113, 25);
            this.Lbl_deportespro.TabIndex = 7;
            this.Lbl_deportespro.Text = "Sanciones";
            // 
            // Cbo_jornadas
            // 
            this.Cbo_jornadas.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_jornadas.FormattingEnabled = true;
            this.Cbo_jornadas.Items.AddRange(new object[] {
            "Campeonato 1",
            "Campeonato 2",
            "Campeonato 3"});
            this.Cbo_jornadas.Location = new System.Drawing.Point(412, 54);
            this.Cbo_jornadas.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_jornadas.Name = "Cbo_jornadas";
            this.Cbo_jornadas.Size = new System.Drawing.Size(164, 31);
            this.Cbo_jornadas.TabIndex = 28;
            this.Cbo_jornadas.SelectedIndexChanged += new System.EventHandler(this.Cbo_jornadas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Jornada:";
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_ayuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_ayuda.Image = global::Polideportivo.Properties.Resources.icons8_ayuda_30;
            this.Btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ayuda.Location = new System.Drawing.Point(619, 38);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(85, 37);
            this.Btn_ayuda.TabIndex = 185;
            this.Btn_ayuda.Text = "Ayuda";
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // frm_sanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(713, 419);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Cbo_jornadas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.Cbo_campeonato);
            this.Controls.Add(this.Lbl_campeonato);
            this.Controls.Add(this.Dgv_sanciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_sanciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sanciones";
            this.Load += new System.EventHandler(this.Sanciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sanciones)).EndInit();
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_sanciones;
        private System.Windows.Forms.ComboBox Cbo_campeonato;
        private System.Windows.Forms.Label Lbl_campeonato;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_deportespro;
        private System.Windows.Forms.ComboBox Cbo_jornadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}