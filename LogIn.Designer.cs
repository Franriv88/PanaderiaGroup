namespace Proyecto_Panadería
{
    partial class LogIn
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
            this.labelLogIN = new System.Windows.Forms.Label();
            this.labelUsurio = new System.Windows.Forms.Label();
            this.claveBox = new System.Windows.Forms.TextBox();
            this.boton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogIN
            // 
            this.labelLogIN.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.labelLogIN.ForeColor = System.Drawing.Color.White;
            this.labelLogIN.Location = new System.Drawing.Point(597, 121);
            this.labelLogIN.Name = "labelLogIN";
            this.labelLogIN.Size = new System.Drawing.Size(129, 62);
            this.labelLogIN.TabIndex = 0;
            this.labelLogIN.Text = "LOG IN";
            // 
            // labelUsurio
            // 
            this.labelUsurio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelUsurio.ForeColor = System.Drawing.Color.White;
            this.labelUsurio.Location = new System.Drawing.Point(481, 211);
            this.labelUsurio.Name = "labelUsurio";
            this.labelUsurio.Size = new System.Drawing.Size(76, 33);
            this.labelUsurio.TabIndex = 1;
            this.labelUsurio.Text = "Usuario";
            // 
            // claveBox
            // 
            this.claveBox.Location = new System.Drawing.Point(563, 295);
            this.claveBox.Name = "claveBox";
            this.claveBox.Size = new System.Drawing.Size(234, 22);
            this.claveBox.TabIndex = 4;
            // 
            // boton
            // 
            this.boton.BackColor = System.Drawing.Color.Transparent;
            this.boton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.boton.FlatAppearance.BorderSize = 2;
            this.boton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.boton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.boton.ForeColor = System.Drawing.Color.White;
            this.boton.Location = new System.Drawing.Point(563, 384);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(201, 63);
            this.boton.TabIndex = 5;
            this.boton.Text = "Log In";
            this.boton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(453, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(563, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 22);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(507, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Crear un nuevo usuario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1328, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.claveBox);
            this.Controls.Add(this.labelUsurio);
            this.Controls.Add(this.labelLogIN);
            this.Name = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogIN;
        private System.Windows.Forms.Label labelUsurio;
        private System.Windows.Forms.TextBox claveBox;
        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}