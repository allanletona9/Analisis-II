namespace Polideportivo
{
    partial class Sanciones
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
            this.Dgv_sanciones = new System.Windows.Forms.DataGridView();
            this.Cbo_campeonato = new System.Windows.Forms.ComboBox();
            this.Lbl_campeonato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Lbl_titulo.Location = new System.Drawing.Point(441, 40);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(175, 44);
            this.Lbl_titulo.TabIndex = 6;
            this.Lbl_titulo.Text = "Sanciones";
            this.Lbl_titulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // Dgv_sanciones
            // 
            this.Dgv_sanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_sanciones.Location = new System.Drawing.Point(35, 165);
            this.Dgv_sanciones.Name = "Dgv_sanciones";
            this.Dgv_sanciones.RowTemplate.Height = 28;
            this.Dgv_sanciones.Size = new System.Drawing.Size(1002, 439);
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
            this.Cbo_campeonato.Location = new System.Drawing.Point(790, 93);
            this.Cbo_campeonato.Name = "Cbo_campeonato";
            this.Cbo_campeonato.Size = new System.Drawing.Size(244, 43);
            this.Cbo_campeonato.TabIndex = 11;
            // 
            // Lbl_campeonato
            // 
            this.Lbl_campeonato.AutoSize = true;
            this.Lbl_campeonato.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_campeonato.Location = new System.Drawing.Point(609, 99);
            this.Lbl_campeonato.Name = "Lbl_campeonato";
            this.Lbl_campeonato.Size = new System.Drawing.Size(175, 35);
            this.Lbl_campeonato.TabIndex = 10;
            this.Lbl_campeonato.Text = "Campeonato:";
            // 
            // Sanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.Cbo_campeonato);
            this.Controls.Add(this.Lbl_campeonato);
            this.Controls.Add(this.Dgv_sanciones);
            this.Controls.Add(this.Lbl_titulo);
            this.Name = "Sanciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sanciones";
            this.Load += new System.EventHandler(this.Sanciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sanciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.DataGridView Dgv_sanciones;
        private System.Windows.Forms.ComboBox Cbo_campeonato;
        private System.Windows.Forms.Label Lbl_campeonato;
    }
}