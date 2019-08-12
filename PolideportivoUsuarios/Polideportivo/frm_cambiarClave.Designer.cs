namespace Polideportivo
{
    partial class frm_cambiarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cambiarClave));
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_Buscar = new System.Windows.Forms.Panel();
            this.Lbl_nombreEntrenador = new System.Windows.Forms.Label();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.Txt_contraseña = new System.Windows.Forms.TextBox();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_deportespro = new System.Windows.Forms.Label();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Pnl_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 232;
            this.label2.Text = " Estado";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.Location = new System.Drawing.Point(224, 36);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.ReadOnly = true;
            this.Txt_Usuario.Size = new System.Drawing.Size(230, 29);
            this.Txt_Usuario.TabIndex = 231;
            this.Txt_Usuario.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 230;
            this.label1.Text = " Nueva Contraseña";
            // 
            // Pnl_Buscar
            // 
            this.Pnl_Buscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pnl_Buscar.Controls.Add(this.Lbl_nombreEntrenador);
            this.Pnl_Buscar.Controls.Add(this.Txt_Usuario);
            this.Pnl_Buscar.Controls.Add(this.Btn_guardar);
            this.Pnl_Buscar.Controls.Add(this.label2);
            this.Pnl_Buscar.Controls.Add(this.label1);
            this.Pnl_Buscar.Controls.Add(this.Txt_estado);
            this.Pnl_Buscar.Controls.Add(this.Txt_contraseña);
            this.Pnl_Buscar.Location = new System.Drawing.Point(49, 73);
            this.Pnl_Buscar.Name = "Pnl_Buscar";
            this.Pnl_Buscar.Size = new System.Drawing.Size(711, 202);
            this.Pnl_Buscar.TabIndex = 229;
            this.Pnl_Buscar.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Buscar_Paint);
            // 
            // Lbl_nombreEntrenador
            // 
            this.Lbl_nombreEntrenador.AutoSize = true;
            this.Lbl_nombreEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreEntrenador.Location = new System.Drawing.Point(127, 38);
            this.Lbl_nombreEntrenador.Name = "Lbl_nombreEntrenador";
            this.Lbl_nombreEntrenador.Size = new System.Drawing.Size(79, 24);
            this.Lbl_nombreEntrenador.TabIndex = 225;
            this.Lbl_nombreEntrenador.Text = " Usuario";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.Teal;
            this.Btn_guardar.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_guardar.Location = new System.Drawing.Point(507, 78);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(120, 38);
            this.Btn_guardar.TabIndex = 235;
            this.Btn_guardar.Text = " Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Txt_estado
            // 
            this.Txt_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.Location = new System.Drawing.Point(224, 78);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.ReadOnly = true;
            this.Txt_estado.Size = new System.Drawing.Size(230, 29);
            this.Txt_estado.TabIndex = 227;
            this.Txt_estado.Text = " ";
            // 
            // Txt_contraseña
            // 
            this.Txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_contraseña.Location = new System.Drawing.Point(224, 120);
            this.Txt_contraseña.Name = "Txt_contraseña";
            this.Txt_contraseña.Size = new System.Drawing.Size(230, 29);
            this.Txt_contraseña.TabIndex = 226;
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.Teal;
            this.Btn_ingresar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_ingresar.Location = new System.Drawing.Point(695, 385);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(120, 38);
            this.Btn_ingresar.TabIndex = 236;
            this.Btn_ingresar.Text = "Ver Usuarios";
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 209);
            this.dataGridView1.TabIndex = 233;
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
            this.Pnl_titulo.Size = new System.Drawing.Size(854, 35);
            this.Pnl_titulo.TabIndex = 237;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 8);
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
            this.Btn_cerrar.Location = new System.Drawing.Point(815, 3);
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
            this.Lbl_deportespro.Size = new System.Drawing.Size(149, 25);
            this.Lbl_deportespro.TabIndex = 7;
            this.Lbl_deportespro.Text = "Cambiar clave";
            this.Lbl_deportespro.Click += new System.EventHandler(this.Lbl_deportespro_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_ayuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_ayuda.Image = global::Polideportivo.Properties.Resources.icons8_ayuda_30;
            this.Btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ayuda.Location = new System.Drawing.Point(766, 38);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(85, 37);
            this.Btn_ayuda.TabIndex = 238;
            this.Btn_ayuda.Text = "Ayuda";
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // frm_cambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(854, 529);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Pnl_Buscar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_cambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar clave";
            this.Load += new System.EventHandler(this.CambiarClave_Load);
            this.Pnl_Buscar.ResumeLayout(false);
            this.Pnl_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_Buscar;
        private System.Windows.Forms.Label Lbl_nombreEntrenador;
        private System.Windows.Forms.TextBox Txt_estado;
        private System.Windows.Forms.TextBox Txt_contraseña;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_deportespro;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}