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
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_Buscar = new System.Windows.Forms.Panel();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Lbl_codigoEntrenador = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lbl_nombreEntrenador = new System.Windows.Forms.Label();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.Txt_contraseña = new System.Windows.Forms.TextBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Pnl_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.Btn_modificar.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_modificar.Location = new System.Drawing.Point(650, 45);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(120, 38);
            this.Btn_modificar.TabIndex = 7;
            this.Btn_modificar.Text = "Buscar";
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 232;
            this.label2.Text = " Estado";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Usuario.Location = new System.Drawing.Point(298, 191);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.ReadOnly = true;
            this.Txt_Usuario.Size = new System.Drawing.Size(230, 23);
            this.Txt_Usuario.TabIndex = 231;
            this.Txt_Usuario.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 230;
            this.label1.Text = " Nueva Contraseña";
            // 
            // Pnl_Buscar
            // 
            this.Pnl_Buscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pnl_Buscar.Controls.Add(this.Txt_codigo);
            this.Pnl_Buscar.Controls.Add(this.Lbl_codigoEntrenador);
            this.Pnl_Buscar.Controls.Add(this.Btn_modificar);
            this.Pnl_Buscar.Location = new System.Drawing.Point(49, 39);
            this.Pnl_Buscar.Name = "Pnl_Buscar";
            this.Pnl_Buscar.Size = new System.Drawing.Size(810, 111);
            this.Pnl_Buscar.TabIndex = 229;
            this.Pnl_Buscar.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Buscar_Paint);
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigo.Location = new System.Drawing.Point(249, 45);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(279, 23);
            this.Txt_codigo.TabIndex = 216;
            // 
            // Lbl_codigoEntrenador
            // 
            this.Lbl_codigoEntrenador.AutoSize = true;
            this.Lbl_codigoEntrenador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigoEntrenador.Location = new System.Drawing.Point(94, 45);
            this.Lbl_codigoEntrenador.Name = "Lbl_codigoEntrenador";
            this.Lbl_codigoEntrenador.Size = new System.Drawing.Size(116, 17);
            this.Lbl_codigoEntrenador.TabIndex = 215;
            this.Lbl_codigoEntrenador.Text = "Codigo A Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 209);
            this.dataGridView1.TabIndex = 233;
            // 
            // Lbl_nombreEntrenador
            // 
            this.Lbl_nombreEntrenador.AutoSize = true;
            this.Lbl_nombreEntrenador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreEntrenador.Location = new System.Drawing.Point(143, 197);
            this.Lbl_nombreEntrenador.Name = "Lbl_nombreEntrenador";
            this.Lbl_nombreEntrenador.Size = new System.Drawing.Size(58, 17);
            this.Lbl_nombreEntrenador.TabIndex = 225;
            this.Lbl_nombreEntrenador.Text = " Usuario";
            // 
            // Txt_estado
            // 
            this.Txt_estado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.Location = new System.Drawing.Point(298, 250);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.ReadOnly = true;
            this.Txt_estado.Size = new System.Drawing.Size(230, 23);
            this.Txt_estado.TabIndex = 227;
            this.Txt_estado.Text = " ";
            // 
            // Txt_contraseña
            // 
            this.Txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_contraseña.Location = new System.Drawing.Point(298, 304);
            this.Txt_contraseña.Name = "Txt_contraseña";
            this.Txt_contraseña.Size = new System.Drawing.Size(230, 23);
            this.Txt_contraseña.TabIndex = 226;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.Btn_guardar.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_guardar.Location = new System.Drawing.Point(699, 250);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(120, 38);
            this.Btn_guardar.TabIndex = 235;
            this.Btn_guardar.Text = " Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.Btn_ingresar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_ingresar.Location = new System.Drawing.Point(699, 440);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(120, 38);
            this.Btn_ingresar.TabIndex = 236;
            this.Btn_ingresar.Text = "Ver Usuarios";
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // CambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(933, 568);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pnl_Buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lbl_nombreEntrenador);
            this.Controls.Add(this.Txt_estado);
            this.Controls.Add(this.Txt_contraseña);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar clave";
            this.Load += new System.EventHandler(this.CambiarClave_Load);
            this.Pnl_Buscar.ResumeLayout(false);
            this.Pnl_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_Buscar;
        public System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label Lbl_codigoEntrenador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Lbl_nombreEntrenador;
        private System.Windows.Forms.TextBox Txt_estado;
        private System.Windows.Forms.TextBox Txt_contraseña;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_ingresar;
    }
}