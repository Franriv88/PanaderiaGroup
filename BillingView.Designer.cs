namespace Proyecto_Panadería
{
    partial class BillingView
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
            this.pictureClientBox = new System.Windows.Forms.PictureBox();
            this.pictureMailBox = new System.Windows.Forms.PictureBox();
            this.clientNameInputText = new System.Windows.Forms.TextBox();
            this.clientLastNameInputText = new System.Windows.Forms.TextBox();
            this.clientEmailAddressText = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClientBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureClientBox
            // 
            this.pictureClientBox.Location = new System.Drawing.Point(86, 86);
            this.pictureClientBox.Name = "pictureClientBox";
            this.pictureClientBox.Size = new System.Drawing.Size(100, 50);
            this.pictureClientBox.TabIndex = 0;
            this.pictureClientBox.TabStop = false;
            // 
            // pictureMailBox
            // 
            this.pictureMailBox.Location = new System.Drawing.Point(86, 208);
            this.pictureMailBox.Name = "pictureMailBox";
            this.pictureMailBox.Size = new System.Drawing.Size(100, 50);
            this.pictureMailBox.TabIndex = 1;
            this.pictureMailBox.TabStop = false;
            // 
            // clientNameInputText
            // 
            this.clientNameInputText.Location = new System.Drawing.Point(240, 99);
            this.clientNameInputText.Name = "clientNameInputText";
            this.clientNameInputText.Size = new System.Drawing.Size(100, 20);
            this.clientNameInputText.TabIndex = 2;
            this.clientNameInputText.Text = "Nombre";
            // 
            // clientLastNameInputText
            // 
            this.clientLastNameInputText.Location = new System.Drawing.Point(369, 99);
            this.clientLastNameInputText.Name = "clientLastNameInputText";
            this.clientLastNameInputText.Size = new System.Drawing.Size(100, 20);
            this.clientLastNameInputText.TabIndex = 3;
            this.clientLastNameInputText.Text = "Apellido";
            // 
            // clientEmailAddressText
            // 
            this.clientEmailAddressText.Location = new System.Drawing.Point(240, 229);
            this.clientEmailAddressText.Name = "clientEmailAddressText";
            this.clientEmailAddressText.Size = new System.Drawing.Size(100, 20);
            this.clientEmailAddressText.TabIndex = 4;
            this.clientEmailAddressText.Text = "@gmail.com";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(349, 319);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Enviar";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Regresar";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(681, 356);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Salir";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // BillingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.clientEmailAddressText);
            this.Controls.Add(this.clientLastNameInputText);
            this.Controls.Add(this.clientNameInputText);
            this.Controls.Add(this.pictureMailBox);
            this.Controls.Add(this.pictureClientBox);
            this.Name = "BillingView";
            this.Text = "BillingView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureClientBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMailBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureClientBox;
        private System.Windows.Forms.PictureBox pictureMailBox;
        private System.Windows.Forms.TextBox clientNameInputText;
        private System.Windows.Forms.TextBox clientLastNameInputText;
        private System.Windows.Forms.TextBox clientEmailAddressText;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
    }
}