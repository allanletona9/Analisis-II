namespace Polideportivo
{
    partial class CambiarClave
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
            this.Txt_clave_anterior = new System.Windows.Forms.TextBox();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Lbl_clave_anterior = new System.Windows.Forms.Label();
            this.Lbl_nueva_clave = new System.Windows.Forms.Label();
            this.Txt_nueva_clave = new System.Windows.Forms.TextBox();
            this.Txt_repetir = new System.Windows.Forms.TextBox();
            this.Lbl_repetir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_clave_anterior
            // 
            this.Txt_clave_anterior.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_clave_anterior.Location = new System.Drawing.Point(320, 46);
            this.Txt_clave_anterior.Name = "Txt_clave_anterior";
            this.Txt_clave_anterior.Size = new System.Drawing.Size(193, 42);
            this.Txt_clave_anterior.TabIndex = 8;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.Btn_actualizar.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_actualizar.Location = new System.Drawing.Point(261, 230);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(180, 58);
            this.Btn_actualizar.TabIndex = 7;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // Lbl_clave_anterior
            // 
            this.Lbl_clave_anterior.AutoSize = true;
            this.Lbl_clave_anterior.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_clave_anterior.Location = new System.Drawing.Point(129, 46);
            this.Lbl_clave_anterior.Name = "Lbl_clave_anterior";
            this.Lbl_clave_anterior.Size = new System.Drawing.Size(185, 35);
            this.Lbl_clave_anterior.TabIndex = 6;
            this.Lbl_clave_anterior.Text = "Clave anterior:";
            // 
            // Lbl_nueva_clave
            // 
            this.Lbl_nueva_clave.AutoSize = true;
            this.Lbl_nueva_clave.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nueva_clave.Location = new System.Drawing.Point(151, 105);
            this.Lbl_nueva_clave.Name = "Lbl_nueva_clave";
            this.Lbl_nueva_clave.Size = new System.Drawing.Size(163, 35);
            this.Lbl_nueva_clave.TabIndex = 9;
            this.Lbl_nueva_clave.Text = "Nueva clave:";
            // 
            // Txt_nueva_clave
            // 
            this.Txt_nueva_clave.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nueva_clave.Location = new System.Drawing.Point(320, 102);
            this.Txt_nueva_clave.Name = "Txt_nueva_clave";
            this.Txt_nueva_clave.Size = new System.Drawing.Size(193, 42);
            this.Txt_nueva_clave.TabIndex = 10;
            // 
            // Txt_repetir
            // 
            this.Txt_repetir.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_repetir.Location = new System.Drawing.Point(320, 164);
            this.Txt_repetir.Name = "Txt_repetir";
            this.Txt_repetir.Size = new System.Drawing.Size(193, 42);
            this.Txt_repetir.TabIndex = 12;
            // 
            // Lbl_repetir
            // 
            this.Lbl_repetir.AutoSize = true;
            this.Lbl_repetir.Font = new System.Drawing.Font("Candara", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_repetir.Location = new System.Drawing.Point(205, 167);
            this.Lbl_repetir.Name = "Lbl_repetir";
            this.Lbl_repetir.Size = new System.Drawing.Size(109, 35);
            this.Lbl_repetir.TabIndex = 11;
            this.Lbl_repetir.Text = "Repetir:";
            // 
            // CambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(677, 322);
            this.Controls.Add(this.Txt_repetir);
            this.Controls.Add(this.Lbl_repetir);
            this.Controls.Add(this.Txt_nueva_clave);
            this.Controls.Add(this.Lbl_nueva_clave);
            this.Controls.Add(this.Txt_clave_anterior);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Lbl_clave_anterior);
            this.Name = "CambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar clave";
            this.Load += new System.EventHandler(this.CambiarClave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_clave_anterior;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Label Lbl_clave_anterior;
        private System.Windows.Forms.Label Lbl_nueva_clave;
        private System.Windows.Forms.TextBox Txt_nueva_clave;
        private System.Windows.Forms.TextBox Txt_repetir;
        private System.Windows.Forms.Label Lbl_repetir;
    }
}