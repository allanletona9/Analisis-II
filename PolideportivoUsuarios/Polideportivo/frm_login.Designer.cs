namespace Polideportivo
{
    partial class frm_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.Lbl_clave = new System.Windows.Forms.Label();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.Btn_entrar = new System.Windows.Forms.Button();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.Txt_clave = new System.Windows.Forms.TextBox();
            this.Cb_ver_password = new System.Windows.Forms.CheckBox();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_deportespro = new System.Windows.Forms.Label();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_clave
            // 
            this.Lbl_clave.AutoSize = true;
            this.Lbl_clave.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_clave.Location = new System.Drawing.Point(144, 114);
            this.Lbl_clave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_clave.Name = "Lbl_clave";
            this.Lbl_clave.Size = new System.Drawing.Size(57, 23);
            this.Lbl_clave.TabIndex = 1;
            this.Lbl_clave.Text = "Clave:";
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.Location = new System.Drawing.Point(124, 81);
            this.Lbl_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(77, 23);
            this.Lbl_usuario.TabIndex = 2;
            this.Lbl_usuario.Text = "Usuario:";
            // 
            // Btn_entrar
            // 
            this.Btn_entrar.BackColor = System.Drawing.Color.Teal;
            this.Btn_entrar.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_entrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_entrar.Location = new System.Drawing.Point(128, 162);
            this.Btn_entrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_entrar.Name = "Btn_entrar";
            this.Btn_entrar.Size = new System.Drawing.Size(120, 38);
            this.Btn_entrar.TabIndex = 3;
            this.Btn_entrar.Text = "Entrar";
            this.Btn_entrar.UseVisualStyleBackColor = false;
            this.Btn_entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_usuario.Location = new System.Drawing.Point(205, 81);
            this.Txt_usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(130, 30);
            this.Txt_usuario.TabIndex = 4;
            // 
            // Txt_clave
            // 
            this.Txt_clave.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_clave.Location = new System.Drawing.Point(205, 114);
            this.Txt_clave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_clave.Name = "Txt_clave";
            this.Txt_clave.Size = new System.Drawing.Size(130, 30);
            this.Txt_clave.TabIndex = 5;
            // 
            // Cb_ver_password
            // 
            this.Cb_ver_password.AutoSize = true;
            this.Cb_ver_password.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_ver_password.Location = new System.Drawing.Point(353, 99);
            this.Cb_ver_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cb_ver_password.Name = "Cb_ver_password";
            this.Cb_ver_password.Size = new System.Drawing.Size(101, 27);
            this.Cb_ver_password.TabIndex = 7;
            this.Cb_ver_password.Text = "Ver clave";
            this.Cb_ver_password.UseVisualStyleBackColor = true;
            this.Cb_ver_password.CheckedChanged += new System.EventHandler(this.Cb_ver_password_CheckedChanged);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.Teal;
            this.Btn_cancelar.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_cancelar.Location = new System.Drawing.Point(252, 162);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(120, 38);
            this.Btn_cancelar.TabIndex = 8;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
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
            this.Pnl_titulo.Size = new System.Drawing.Size(497, 35);
            this.Pnl_titulo.TabIndex = 9;
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
            this.Btn_cerrar.Location = new System.Drawing.Point(457, 4);
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
            this.Lbl_deportespro.Size = new System.Drawing.Size(179, 25);
            this.Lbl_deportespro.TabIndex = 7;
            this.Lbl_deportespro.Text = "DEPORTES-PRO";
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_ayuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_ayuda.Image = global::Polideportivo.Properties.Resources.icons8_ayuda_30;
            this.Btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ayuda.Location = new System.Drawing.Point(402, 39);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(85, 37);
            this.Btn_ayuda.TabIndex = 185;
            this.Btn_ayuda.Text = "Ayuda";
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(497, 240);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Cb_ver_password);
            this.Controls.Add(this.Txt_clave);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.Btn_entrar);
            this.Controls.Add(this.Lbl_usuario);
            this.Controls.Add(this.Lbl_clave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_clave;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.Button Btn_entrar;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.TextBox Txt_clave;
        private System.Windows.Forms.CheckBox Cb_ver_password;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Label Lbl_deportespro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}

