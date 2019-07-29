namespace Polideportivo
{
    partial class SeleccionarEquipo
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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_seleccionar_equipo = new System.Windows.Forms.Label();
            this.Cbo_seleccionar_equipo = new System.Windows.Forms.ComboBox();
            this.Btn_avanzar = new System.Windows.Forms.Button();
            this.Btn_regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Lbl_titulo.Location = new System.Drawing.Point(55, 45);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(329, 44);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "Nombre entrenador";
            // 
            // Lbl_seleccionar_equipo
            // 
            this.Lbl_seleccionar_equipo.AutoSize = true;
            this.Lbl_seleccionar_equipo.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_seleccionar_equipo.Location = new System.Drawing.Point(56, 135);
            this.Lbl_seleccionar_equipo.Name = "Lbl_seleccionar_equipo";
            this.Lbl_seleccionar_equipo.Size = new System.Drawing.Size(246, 35);
            this.Lbl_seleccionar_equipo.TabIndex = 3;
            this.Lbl_seleccionar_equipo.Text = "Seleccionar equipo:";
            // 
            // Cbo_seleccionar_equipo
            // 
            this.Cbo_seleccionar_equipo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_seleccionar_equipo.FormattingEnabled = true;
            this.Cbo_seleccionar_equipo.Location = new System.Drawing.Point(308, 132);
            this.Cbo_seleccionar_equipo.Name = "Cbo_seleccionar_equipo";
            this.Cbo_seleccionar_equipo.Size = new System.Drawing.Size(287, 44);
            this.Cbo_seleccionar_equipo.TabIndex = 4;
            this.Cbo_seleccionar_equipo.SelectedIndexChanged += new System.EventHandler(this.Cbo_seleccionar_equipo_SelectedIndexChanged);
            // 
            // Btn_avanzar
            // 
            this.Btn_avanzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.Btn_avanzar.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_avanzar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_avanzar.Location = new System.Drawing.Point(415, 228);
            this.Btn_avanzar.Name = "Btn_avanzar";
            this.Btn_avanzar.Size = new System.Drawing.Size(180, 58);
            this.Btn_avanzar.TabIndex = 5;
            this.Btn_avanzar.Text = "Avanzar";
            this.Btn_avanzar.UseVisualStyleBackColor = false;
            this.Btn_avanzar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_regresar
            // 
            this.Btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.Btn_regresar.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_regresar.Location = new System.Drawing.Point(62, 228);
            this.Btn_regresar.Name = "Btn_regresar";
            this.Btn_regresar.Size = new System.Drawing.Size(180, 58);
            this.Btn_regresar.TabIndex = 6;
            this.Btn_regresar.Text = "Regresar";
            this.Btn_regresar.UseVisualStyleBackColor = false;
            this.Btn_regresar.Click += new System.EventHandler(this.Btn_regresar_Click);
            // 
            // SeleccionarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(681, 344);
            this.Controls.Add(this.Btn_regresar);
            this.Controls.Add(this.Btn_avanzar);
            this.Controls.Add(this.Cbo_seleccionar_equipo);
            this.Controls.Add(this.Lbl_seleccionar_equipo);
            this.Controls.Add(this.Lbl_titulo);
            this.Name = "SeleccionarEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SeleccionarEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl_seleccionar_equipo;
        private System.Windows.Forms.ComboBox Cbo_seleccionar_equipo;
        private System.Windows.Forms.Button Btn_avanzar;
        private System.Windows.Forms.Button Btn_regresar;
    }
}