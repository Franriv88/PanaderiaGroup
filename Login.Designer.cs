using System.Windows.Forms;

namespace Proyecto_Panadería
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginButton = new System.Windows.Forms.Button();
            this.userNameInputText = new System.Windows.Forms.TextBox();
            this.PswInputText = new System.Windows.Forms.TextBox();
            this.GIF = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.AccessibleName = "loginButton";
            this.loginButton.Location = new System.Drawing.Point(363, 328);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userNameInputText
            // 
            this.userNameInputText.AccessibleDescription = "";
            this.userNameInputText.AccessibleName = "userName";
            this.userNameInputText.Location = new System.Drawing.Point(354, 188);
            this.userNameInputText.Name = "userNameInputText";
            this.userNameInputText.Size = new System.Drawing.Size(100, 20);
            this.userNameInputText.TabIndex = 1;
            this.userNameInputText.Text = "userName";
            // 
            // PswInputText
            // 
            this.PswInputText.AccessibleName = "Psw";
            this.PswInputText.Location = new System.Drawing.Point(354, 239);
            this.PswInputText.Name = "PswInputText";
            this.PswInputText.PasswordChar = '*';
            this.PswInputText.Size = new System.Drawing.Size(100, 20);
            this.PswInputText.TabIndex = 2;
            this.PswInputText.Text = "Password";
            // 
            // GIF
            // 
            this.GIF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GIF.BackgroundImage")));
            this.GIF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GIF.Image = ((System.Drawing.Image)(resources.GetObject("GIF.Image")));
            this.GIF.Location = new System.Drawing.Point(0, 0);
            this.GIF.Name = "GIF";
            this.GIF.Size = new System.Drawing.Size(800, 450);
            this.GIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GIF.TabIndex = 3;
            this.GIF.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(194, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 157);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.PswInputText);
            this.Controls.Add(this.userNameInputText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GIF);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.GIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginButton;
        private TextBox userNameInputText;
        private TextBox PswInputText;
        private PictureBox GIF;
        private PictureBox pictureBox1;
    }
}