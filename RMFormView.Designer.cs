using System.Windows.Forms;

namespace Proyecto_Panadería
{
    partial class RMFormView
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
            this.rmNameInput = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rmButtonSave = new System.Windows.Forms.Button();
            this.rmBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rmNameInput
            // 
            this.rmNameInput.Location = new System.Drawing.Point(64, 84);
            this.rmNameInput.Name = "rmNameInput";
            this.rmNameInput.Size = new System.Drawing.Size(100, 20);
            this.rmNameInput.TabIndex = 0;
            this.rmNameInput.Text = "Name";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Unitary",
            "Kg",
            "Liters"});
            this.listBox1.Location = new System.Drawing.Point(64, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 43);
            this.listBox1.TabIndex = 1;
            // 
            // rmButtonSave
            // 
            this.rmButtonSave.Location = new System.Drawing.Point(64, 161);
            this.rmButtonSave.Name = "rmButtonSave";
            this.rmButtonSave.Size = new System.Drawing.Size(75, 23);
            this.rmButtonSave.TabIndex = 2;
            this.rmButtonSave.Text = "Save";
            this.rmButtonSave.UseVisualStyleBackColor = true;
            this.rmButtonSave.Click += new System.EventHandler(this.rmButtonSave_Click);
            // 
            // rmBackButton
            // 
            this.rmBackButton.Location = new System.Drawing.Point(713, 415);
            this.rmBackButton.Name = "rmBackButton";
            this.rmBackButton.Size = new System.Drawing.Size(75, 23);
            this.rmBackButton.TabIndex = 3;
            this.rmBackButton.Text = "back";
            this.rmBackButton.UseVisualStyleBackColor = true;
            this.rmBackButton.Click += new System.EventHandler(this.rmBackButton_Click);
            // 
            // RMFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rmBackButton);
            this.Controls.Add(this.rmButtonSave);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rmNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RMFormView";
            this.Text = "RMFormView";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox rmNameInput;
        private ListBox listBox1;
        private Button rmButtonSave;
        private Button rmBackButton;
    }
}