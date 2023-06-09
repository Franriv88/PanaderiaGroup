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
            this.loginButton = new System.Windows.Forms.Button();
            this.userNameInputText = new System.Windows.Forms.TextBox();
            this.PswInputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.AccessibleName = "loginButton";
            this.loginButton.Location = new System.Drawing.Point(354, 338);
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PswInputText);
            this.Controls.Add(this.userNameInputText);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginButton;
        private TextBox userNameInputText;
        private TextBox PswInputText;
    }
}