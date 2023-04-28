namespace Tp
{
    partial class l_registrate
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
            this.label1 = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.Label();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.l_nombre = new System.Windows.Forms.Label();
            this.l_email = new System.Windows.Forms.Label();
            this.l_contraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.Font = new System.Drawing.Font("Gadugi", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.Location = new System.Drawing.Point(257, 9);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(283, 52);
            this.Registro.TabIndex = 1;
            this.Registro.Text = "¡REGISTRATE!";
            this.Registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // txb_nombre
            // 
            this.txb_nombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txb_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_nombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nombre.Location = new System.Drawing.Point(12, 125);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(324, 32);
            this.txb_nombre.TabIndex = 2;
            this.txb_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(12, 214);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(324, 32);
            this.txt_email.TabIndex = 3;
            this.txt_email.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.Location = new System.Drawing.Point(12, 313);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(324, 32);
            this.txt_contraseña.TabIndex = 4;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.txt_contraseña_TextChanged);
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.LightGreen;
            this.button_ok.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.Location = new System.Drawing.Point(657, 350);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(111, 59);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "CONFIRMAR";
            this.button_ok.UseVisualStyleBackColor = false;
            // 
            // l_nombre
            // 
            this.l_nombre.AutoSize = true;
            this.l_nombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nombre.Location = new System.Drawing.Point(8, 90);
            this.l_nombre.Name = "l_nombre";
            this.l_nombre.Size = new System.Drawing.Size(199, 23);
            this.l_nombre.TabIndex = 6;
            this.l_nombre.Text = "Nombre y apellido:";
            this.l_nombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_email.Location = new System.Drawing.Point(8, 188);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(67, 23);
            this.l_email.TabIndex = 7;
            this.l_email.Text = "Email:";
            // 
            // l_contraseña
            // 
            this.l_contraseña.AutoSize = true;
            this.l_contraseña.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_contraseña.Location = new System.Drawing.Point(8, 277);
            this.l_contraseña.Name = "l_contraseña";
            this.l_contraseña.Size = new System.Drawing.Size(130, 23);
            this.l_contraseña.TabIndex = 8;
            this.l_contraseña.Text = "Contraseña:";
            // 
            // l_registrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_contraseña);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.l_nombre);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "l_registrate";
            this.Text = "Form_registro";
            this.Load += new System.EventHandler(this.l_registrate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Registro;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label l_nombre;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label l_contraseña;
    }
}

