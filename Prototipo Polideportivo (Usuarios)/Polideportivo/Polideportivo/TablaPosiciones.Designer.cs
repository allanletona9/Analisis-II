namespace Polideportivo
{
    partial class TablaPosiciones
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
            this.Dgv_posiciones = new System.Windows.Forms.DataGridView();
            this.Lbl_categoria_deporte = new System.Windows.Forms.Label();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Cbo_campeonato = new System.Windows.Forms.ComboBox();
            this.Lbl_campeonato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_posiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_posiciones
            // 
            this.Dgv_posiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_posiciones.Location = new System.Drawing.Point(41, 170);
            this.Dgv_posiciones.Name = "Dgv_posiciones";
            this.Dgv_posiciones.RowTemplate.Height = 28;
            this.Dgv_posiciones.Size = new System.Drawing.Size(988, 440);
            this.Dgv_posiciones.TabIndex = 7;
            // 
            // Lbl_categoria_deporte
            // 
            this.Lbl_categoria_deporte.AutoSize = true;
            this.Lbl_categoria_deporte.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_categoria_deporte.Location = new System.Drawing.Point(26, 82);
            this.Lbl_categoria_deporte.Name = "Lbl_categoria_deporte";
            this.Lbl_categoria_deporte.Size = new System.Drawing.Size(230, 35);
            this.Lbl_categoria_deporte.TabIndex = 6;
            this.Lbl_categoria_deporte.Text = "Categoria deporte";
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Lbl_titulo.Location = new System.Drawing.Point(24, 24);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(347, 44);
            this.Lbl_titulo.TabIndex = 5;
            this.Lbl_titulo.Text = "Nombre campeonato";
            // 
            // Cbo_campeonato
            // 
            this.Cbo_campeonato.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_campeonato.FormattingEnabled = true;
            this.Cbo_campeonato.Items.AddRange(new object[] {
            "Campeonato 1",
            "Campeonato 2",
            "Campeonato 3"});
            this.Cbo_campeonato.Location = new System.Drawing.Point(784, 76);
            this.Cbo_campeonato.Name = "Cbo_campeonato";
            this.Cbo_campeonato.Size = new System.Drawing.Size(244, 43);
            this.Cbo_campeonato.TabIndex = 11;
            // 
            // Lbl_campeonato
            // 
            this.Lbl_campeonato.AutoSize = true;
            this.Lbl_campeonato.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_campeonato.Location = new System.Drawing.Point(603, 82);
            this.Lbl_campeonato.Name = "Lbl_campeonato";
            this.Lbl_campeonato.Size = new System.Drawing.Size(175, 35);
            this.Lbl_campeonato.TabIndex = 10;
            this.Lbl_campeonato.Text = "Campeonato:";
            // 
            // TablaPosiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.Cbo_campeonato);
            this.Controls.Add(this.Lbl_campeonato);
            this.Controls.Add(this.Dgv_posiciones);
            this.Controls.Add(this.Lbl_categoria_deporte);
            this.Controls.Add(this.Lbl_titulo);
            this.Name = "TablaPosiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaPosiciones";
            this.Load += new System.EventHandler(this.TablaPosiciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_posiciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_posiciones;
        private System.Windows.Forms.Label Lbl_categoria_deporte;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.ComboBox Cbo_campeonato;
        private System.Windows.Forms.Label Lbl_campeonato;
    }
}