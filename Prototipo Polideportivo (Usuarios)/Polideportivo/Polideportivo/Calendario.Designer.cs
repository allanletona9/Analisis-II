namespace Polideportivo
{
    partial class Calendario
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
            this.Lbl_cat_deporte = new System.Windows.Forms.Label();
            this.Lbl_nombre_equipo = new System.Windows.Forms.Label();
            this.Dgv_calendario = new System.Windows.Forms.DataGridView();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_campeonato = new System.Windows.Forms.Label();
            this.Cbo_campeonato = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_calendario)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_cat_deporte
            // 
            this.Lbl_cat_deporte.AutoSize = true;
            this.Lbl_cat_deporte.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cat_deporte.Location = new System.Drawing.Point(40, 125);
            this.Lbl_cat_deporte.Name = "Lbl_cat_deporte";
            this.Lbl_cat_deporte.Size = new System.Drawing.Size(230, 35);
            this.Lbl_cat_deporte.TabIndex = 5;
            this.Lbl_cat_deporte.Text = "Categoria deporte";
            // 
            // Lbl_nombre_equipo
            // 
            this.Lbl_nombre_equipo.AutoSize = true;
            this.Lbl_nombre_equipo.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre_equipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Lbl_nombre_equipo.Location = new System.Drawing.Point(38, 65);
            this.Lbl_nombre_equipo.Name = "Lbl_nombre_equipo";
            this.Lbl_nombre_equipo.Size = new System.Drawing.Size(260, 44);
            this.Lbl_nombre_equipo.TabIndex = 4;
            this.Lbl_nombre_equipo.Text = "Nombre equipo";
            // 
            // Dgv_calendario
            // 
            this.Dgv_calendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_calendario.Location = new System.Drawing.Point(46, 204);
            this.Dgv_calendario.Name = "Dgv_calendario";
            this.Dgv_calendario.RowTemplate.Height = 28;
            this.Dgv_calendario.Size = new System.Drawing.Size(988, 380);
            this.Dgv_calendario.TabIndex = 6;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Lbl_titulo.Location = new System.Drawing.Point(461, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(186, 44);
            this.Lbl_titulo.TabIndex = 7;
            this.Lbl_titulo.Text = "Calendario";
            // 
            // Lbl_campeonato
            // 
            this.Lbl_campeonato.AutoSize = true;
            this.Lbl_campeonato.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_campeonato.Location = new System.Drawing.Point(613, 125);
            this.Lbl_campeonato.Name = "Lbl_campeonato";
            this.Lbl_campeonato.Size = new System.Drawing.Size(175, 35);
            this.Lbl_campeonato.TabIndex = 8;
            this.Lbl_campeonato.Text = "Campeonato:";
            // 
            // Cbo_campeonato
            // 
            this.Cbo_campeonato.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_campeonato.FormattingEnabled = true;
            this.Cbo_campeonato.Items.AddRange(new object[] {
            "Campeonato 1",
            "Campeonato 2",
            "Campeonato 3"});
            this.Cbo_campeonato.Location = new System.Drawing.Point(794, 119);
            this.Cbo_campeonato.Name = "Cbo_campeonato";
            this.Cbo_campeonato.Size = new System.Drawing.Size(244, 43);
            this.Cbo_campeonato.TabIndex = 9;
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.Cbo_campeonato);
            this.Controls.Add(this.Lbl_campeonato);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.Dgv_calendario);
            this.Controls.Add(this.Lbl_cat_deporte);
            this.Controls.Add(this.Lbl_nombre_equipo);
            this.Name = "Calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.Calendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_calendario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_cat_deporte;
        private System.Windows.Forms.Label Lbl_nombre_equipo;
        private System.Windows.Forms.DataGridView Dgv_calendario;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label Lbl_campeonato;
        private System.Windows.Forms.ComboBox Cbo_campeonato;
    }
}