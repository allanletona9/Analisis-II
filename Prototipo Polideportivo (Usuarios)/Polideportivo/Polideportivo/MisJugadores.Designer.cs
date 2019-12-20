namespace Polideportivo
{
    partial class MisJugadores
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
            this.Lbl_nombre_equipo = new System.Windows.Forms.Label();
            this.Lbl_cat_deporte = new System.Windows.Forms.Label();
            this.Dgv_listado_jugadores = new System.Windows.Forms.DataGridView();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Cbo_campeonato = new System.Windows.Forms.ComboBox();
            this.Lbl_campeonato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listado_jugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_nombre_equipo
            // 
            this.Lbl_nombre_equipo.AutoSize = true;
            this.Lbl_nombre_equipo.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre_equipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Lbl_nombre_equipo.Location = new System.Drawing.Point(43, 66);
            this.Lbl_nombre_equipo.Name = "Lbl_nombre_equipo";
            this.Lbl_nombre_equipo.Size = new System.Drawing.Size(260, 44);
            this.Lbl_nombre_equipo.TabIndex = 1;
            this.Lbl_nombre_equipo.Text = "Nombre equipo";
            // 
            // Lbl_cat_deporte
            // 
            this.Lbl_cat_deporte.AutoSize = true;
            this.Lbl_cat_deporte.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cat_deporte.Location = new System.Drawing.Point(45, 126);
            this.Lbl_cat_deporte.Name = "Lbl_cat_deporte";
            this.Lbl_cat_deporte.Size = new System.Drawing.Size(230, 35);
            this.Lbl_cat_deporte.TabIndex = 3;
            this.Lbl_cat_deporte.Text = "Categoria deporte";
            // 
            // Dgv_listado_jugadores
            // 
            this.Dgv_listado_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_listado_jugadores.Location = new System.Drawing.Point(37, 199);
            this.Dgv_listado_jugadores.Name = "Dgv_listado_jugadores";
            this.Dgv_listado_jugadores.RowTemplate.Height = 28;
            this.Dgv_listado_jugadores.Size = new System.Drawing.Size(1003, 411);
            this.Dgv_listado_jugadores.TabIndex = 4;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Lbl_titulo.Location = new System.Drawing.Point(375, 20);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(293, 44);
            this.Lbl_titulo.TabIndex = 5;
            this.Lbl_titulo.Text = "Listado jugadores";
            // 
            // Cbo_campeonato
            // 
            this.Cbo_campeonato.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_campeonato.FormattingEnabled = true;
            this.Cbo_campeonato.Items.AddRange(new object[] {
            "Campeonato 1",
            "Campeonato 2",
            "Campeonato 3"});
            this.Cbo_campeonato.Location = new System.Drawing.Point(795, 120);
            this.Cbo_campeonato.Name = "Cbo_campeonato";
            this.Cbo_campeonato.Size = new System.Drawing.Size(244, 43);
            this.Cbo_campeonato.TabIndex = 11;
            // 
            // Lbl_campeonato
            // 
            this.Lbl_campeonato.AutoSize = true;
            this.Lbl_campeonato.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_campeonato.Location = new System.Drawing.Point(614, 126);
            this.Lbl_campeonato.Name = "Lbl_campeonato";
            this.Lbl_campeonato.Size = new System.Drawing.Size(175, 35);
            this.Lbl_campeonato.TabIndex = 10;
            this.Lbl_campeonato.Text = "Campeonato:";
            // 
            // MisJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.Cbo_campeonato);
            this.Controls.Add(this.Lbl_campeonato);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.Dgv_listado_jugadores);
            this.Controls.Add(this.Lbl_cat_deporte);
            this.Controls.Add(this.Lbl_nombre_equipo);
            this.Name = "MisJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MisJugadores";
            this.Load += new System.EventHandler(this.MisJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listado_jugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_nombre_equipo;
        private System.Windows.Forms.Label Lbl_cat_deporte;
        private System.Windows.Forms.DataGridView Dgv_listado_jugadores;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.ComboBox Cbo_campeonato;
        private System.Windows.Forms.Label Lbl_campeonato;
    }
}