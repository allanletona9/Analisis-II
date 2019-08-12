namespace Polideportivo
{
    partial class frm_seleccionarEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_seleccionarEquipo));
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_seleccionar_equipo = new System.Windows.Forms.Label();
            this.Cbo_seleccionar_equipo = new System.Windows.Forms.ComboBox();
            this.Btn_avanzar = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_deportespro = new System.Windows.Forms.Label();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Lbl_titulo.Location = new System.Drawing.Point(133, 102);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(329, 44);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "Nombre entrenador";
            // 
            // Lbl_seleccionar_equipo
            // 
            this.Lbl_seleccionar_equipo.AutoSize = true;
            this.Lbl_seleccionar_equipo.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_seleccionar_equipo.Location = new System.Drawing.Point(134, 192);
            this.Lbl_seleccionar_equipo.Name = "Lbl_seleccionar_equipo";
            this.Lbl_seleccionar_equipo.Size = new System.Drawing.Size(246, 35);
            this.Lbl_seleccionar_equipo.TabIndex = 3;
            this.Lbl_seleccionar_equipo.Text = "Seleccionar equipo:";
            // 
            // Cbo_seleccionar_equipo
            // 
            this.Cbo_seleccionar_equipo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_seleccionar_equipo.FormattingEnabled = true;
            this.Cbo_seleccionar_equipo.Location = new System.Drawing.Point(386, 189);
            this.Cbo_seleccionar_equipo.Name = "Cbo_seleccionar_equipo";
            this.Cbo_seleccionar_equipo.Size = new System.Drawing.Size(287, 44);
            this.Cbo_seleccionar_equipo.TabIndex = 4;
            this.Cbo_seleccionar_equipo.SelectedIndexChanged += new System.EventHandler(this.Cbo_seleccionar_equipo_SelectedIndexChanged);
            // 
            // Btn_avanzar
            // 
            this.Btn_avanzar.BackColor = System.Drawing.Color.Teal;
            this.Btn_avanzar.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_avanzar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_avanzar.Location = new System.Drawing.Point(443, 270);
            this.Btn_avanzar.Name = "Btn_avanzar";
            this.Btn_avanzar.Size = new System.Drawing.Size(180, 58);
            this.Btn_avanzar.TabIndex = 5;
            this.Btn_avanzar.Text = "Avanzar";
            this.Btn_avanzar.UseVisualStyleBackColor = false;
            this.Btn_avanzar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.BackColor = System.Drawing.Color.Teal;
            this.Btn_regresar.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_regresar.Location = new System.Drawing.Point(200, 270);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(180, 58);
            this.Btn_regresar.TabIndex = 6;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = false;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
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
            this.Pnl_titulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(844, 54);
            this.Pnl_titulo.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 42);
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
            this.Btn_cerrar.Location = new System.Drawing.Point(783, 4);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(45, 45);
            this.Btn_cerrar.TabIndex = 10;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // Lbl_deportespro
            // 
            this.Lbl_deportespro.AutoSize = true;
            this.Lbl_deportespro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_deportespro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lbl_deportespro.Location = new System.Drawing.Point(68, 14);
            this.Lbl_deportespro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_deportespro.Name = "Lbl_deportespro";
            this.Lbl_deportespro.Size = new System.Drawing.Size(269, 37);
            this.Lbl_deportespro.TabIndex = 7;
            this.Lbl_deportespro.Text = "DEPORTES-PRO";
            // 
            // frm_seleccionarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(844, 414);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_avanzar);
            this.Controls.Add(this.Cbo_seleccionar_equipo);
            this.Controls.Add(this.Lbl_seleccionar_equipo);
            this.Controls.Add(this.Lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_seleccionarEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SeleccionarEquipo_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl_seleccionar_equipo;
        private System.Windows.Forms.ComboBox Cbo_seleccionar_equipo;
        private System.Windows.Forms.Button Btn_avanzar;
        private System.Windows.Forms.Button Btn_regresar;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_deportespro;
    }
}