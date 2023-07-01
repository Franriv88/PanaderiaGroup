using System.Windows.Forms;

namespace Proyecto_Panadería
{
    partial class UserFormView
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userLastNameTextBox = new System.Windows.Forms.TextBox();
            this.userUserNameTextBox = new System.Windows.Forms.TextBox();
            this.userPswTextBox = new System.Windows.Forms.TextBox();
            this.userIsAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.userSaveButton = new System.Windows.Forms.Button();
            this.userBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(102, 89);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.Text = "Name";
            // 
            // userLastNameTextBox
            // 
            this.userLastNameTextBox.Location = new System.Drawing.Point(102, 115);
            this.userLastNameTextBox.Name = "userLastNameTextBox";
            this.userLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userLastNameTextBox.TabIndex = 1;
            this.userLastNameTextBox.Text = "LastName";
            // 
            // userUserNameTextBox
            // 
            this.userUserNameTextBox.Location = new System.Drawing.Point(102, 141);
            this.userUserNameTextBox.Name = "userUserNameTextBox";
            this.userUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userUserNameTextBox.TabIndex = 2;
            this.userUserNameTextBox.Text = "UserName";
            // 
            // userPswTextBox
            // 
            this.userPswTextBox.Location = new System.Drawing.Point(102, 168);
            this.userPswTextBox.Name = "userPswTextBox";
            this.userPswTextBox.Size = new System.Drawing.Size(100, 20);
            this.userPswTextBox.TabIndex = 3;
            this.userPswTextBox.Text = "Password";
            // 
            // userIsAdminCheckBox
            // 
            this.userIsAdminCheckBox.AutoSize = true;
            this.userIsAdminCheckBox.Location = new System.Drawing.Point(102, 195);
            this.userIsAdminCheckBox.Name = "userIsAdminCheckBox";
            this.userIsAdminCheckBox.Size = new System.Drawing.Size(62, 17);
            this.userIsAdminCheckBox.TabIndex = 4;
            this.userIsAdminCheckBox.Text = "isAdmin";
            this.userIsAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // userSaveButton
            // 
            this.userSaveButton.Location = new System.Drawing.Point(102, 219);
            this.userSaveButton.Name = "userSaveButton";
            this.userSaveButton.Size = new System.Drawing.Size(75, 23);
            this.userSaveButton.TabIndex = 5;
            this.userSaveButton.Text = "Accept";
            this.userSaveButton.UseVisualStyleBackColor = true;
            this.userSaveButton.Click += new System.EventHandler(this.userSaveButton_Click);
            // 
            // userBackButton
            // 
            this.userBackButton.Location = new System.Drawing.Point(12, 54);
            this.userBackButton.Name = "userBackButton";
            this.userBackButton.Size = new System.Drawing.Size(75, 23);
            this.userBackButton.TabIndex = 6;
            this.userBackButton.Text = "Back";
            this.userBackButton.UseVisualStyleBackColor = true;
            this.userBackButton.Click += new System.EventHandler(this.userBackButton_Click);
            // 
            // UserFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userBackButton);
            this.Controls.Add(this.userSaveButton);
            this.Controls.Add(this.userIsAdminCheckBox);
            this.Controls.Add(this.userPswTextBox);
            this.Controls.Add(this.userUserNameTextBox);
            this.Controls.Add(this.userLastNameTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserFormView";
            this.Text = "UserFormView";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userNameTextBox;
        private TextBox userLastNameTextBox;
        private TextBox userUserNameTextBox;
        private TextBox userPswTextBox;
        private CheckBox userIsAdminCheckBox;
        private Button userSaveButton;
        private Button userBackButton;
    }
}