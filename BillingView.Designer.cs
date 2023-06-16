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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingView));
            this.pictureClientBox = new System.Windows.Forms.PictureBox();
            this.pictureMailBox = new System.Windows.Forms.PictureBox();
            this.clientNameInputText = new System.Windows.Forms.TextBox();
            this.clientEmailAddressText = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pdfPictureBox = new System.Windows.Forms.PictureBox();
            this.okPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClientBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMailBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureClientBox
            // 
            this.pictureClientBox.BackColor = System.Drawing.Color.Black;
            this.pictureClientBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureClientBox.Image")));
            this.pictureClientBox.Location = new System.Drawing.Point(92, 86);
            this.pictureClientBox.Name = "pictureClientBox";
            this.pictureClientBox.Size = new System.Drawing.Size(32, 33);
            this.pictureClientBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClientBox.TabIndex = 0;
            this.pictureClientBox.TabStop = false;
            // 
            // pictureMailBox
            // 
            this.pictureMailBox.BackColor = System.Drawing.Color.Black;
            this.pictureMailBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureMailBox.Image")));
            this.pictureMailBox.Location = new System.Drawing.Point(92, 158);
            this.pictureMailBox.Name = "pictureMailBox";
            this.pictureMailBox.Size = new System.Drawing.Size(25, 25);
            this.pictureMailBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMailBox.TabIndex = 1;
            this.pictureMailBox.TabStop = false;
            // 
            // clientNameInputText
            // 
            this.clientNameInputText.BackColor = System.Drawing.Color.Black;
            this.clientNameInputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientNameInputText.Location = new System.Drawing.Point(165, 102);
            this.clientNameInputText.Name = "clientNameInputText";
            this.clientNameInputText.Size = new System.Drawing.Size(120, 13);
            this.clientNameInputText.TabIndex = 2;
            this.clientNameInputText.Text = "Nombre";
            // 
            // clientEmailAddressText
            // 
            this.clientEmailAddressText.BackColor = System.Drawing.Color.Black;
            this.clientEmailAddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientEmailAddressText.ForeColor = System.Drawing.Color.Silver;
            this.clientEmailAddressText.Location = new System.Drawing.Point(135, 163);
            this.clientEmailAddressText.Name = "clientEmailAddressText";
            this.clientEmailAddressText.Size = new System.Drawing.Size(210, 13);
            this.clientEmailAddressText.TabIndex = 4;
            this.clientEmailAddressText.Text = "ejemplo@gmail.com";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(142)))), ((int)(((byte)(95)))));
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sendButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(190, 247);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(80, 25);
            this.sendButton.TabIndex = 5;
            this.sendButton.TabStop = false;
            this.sendButton.Text = "Confirmar";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(50, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 227);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(471, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(285, 267);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pdfPictureBox
            // 
            this.pdfPictureBox.BackColor = System.Drawing.Color.Black;
            this.pdfPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pdfPictureBox.Image")));
            this.pdfPictureBox.Location = new System.Drawing.Point(384, 208);
            this.pdfPictureBox.Name = "pdfPictureBox";
            this.pdfPictureBox.Size = new System.Drawing.Size(64, 64);
            this.pdfPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pdfPictureBox.TabIndex = 10;
            this.pdfPictureBox.TabStop = false;
            // 
            // okPictureBox
            // 
            this.okPictureBox.BackColor = System.Drawing.Color.Black;
            this.okPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("okPictureBox.Image")));
            this.okPictureBox.Location = new System.Drawing.Point(490, 208);
            this.okPictureBox.Name = "okPictureBox";
            this.okPictureBox.Size = new System.Drawing.Size(48, 52);
            this.okPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.okPictureBox.TabIndex = 11;
            this.okPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(142)))), ((int)(((byte)(95)))));
            this.label2.Location = new System.Drawing.Point(155, 106);
            this.label2.MinimumSize = new System.Drawing.Size(30, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "_____________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sr(a):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(142)))), ((int)(((byte)(95)))));
            this.label3.Location = new System.Drawing.Point(131, 167);
            this.label3.MinimumSize = new System.Drawing.Size(30, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "_________________________";
            // 
            // BillingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(142)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientNameInputText);
            this.Controls.Add(this.clientEmailAddressText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.okPictureBox);
            this.Controls.Add(this.pdfPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.pictureMailBox);
            this.Controls.Add(this.pictureClientBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillingView";
            this.Text = "BillingView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureClientBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMailBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureClientBox;
        private System.Windows.Forms.PictureBox pictureMailBox;
        private System.Windows.Forms.TextBox clientNameInputText;
        private System.Windows.Forms.TextBox clientEmailAddressText;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pdfPictureBox;
        private System.Windows.Forms.PictureBox okPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}