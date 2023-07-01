namespace Proyecto_Panadería
{
    partial class RMFormBulkUpdateView
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
            this.rmBulkButtonBrowse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rmBulkButtonConfirm = new System.Windows.Forms.Button();
            this.rmBulkButtonBack = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rmBulkButtonBrowse
            // 
            this.rmBulkButtonBrowse.Location = new System.Drawing.Point(363, 64);
            this.rmBulkButtonBrowse.Name = "rmBulkButtonBrowse";
            this.rmBulkButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.rmBulkButtonBrowse.TabIndex = 0;
            this.rmBulkButtonBrowse.Text = "Browse";
            this.rmBulkButtonBrowse.UseVisualStyleBackColor = true;
            this.rmBulkButtonBrowse.Click += new System.EventHandler(this.rmBulkButtonBrowse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.rmName,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // rmBulkButtonConfirm
            // 
            this.rmBulkButtonConfirm.Location = new System.Drawing.Point(364, 190);
            this.rmBulkButtonConfirm.Name = "rmBulkButtonConfirm";
            this.rmBulkButtonConfirm.Size = new System.Drawing.Size(75, 23);
            this.rmBulkButtonConfirm.TabIndex = 2;
            this.rmBulkButtonConfirm.Text = "Confirm";
            this.rmBulkButtonConfirm.UseVisualStyleBackColor = true;
            this.rmBulkButtonConfirm.Click += new System.EventHandler(this.rmBulkButtonConfirm_Click);
            // 
            // rmBulkButtonBack
            // 
            this.rmBulkButtonBack.Location = new System.Drawing.Point(713, 415);
            this.rmBulkButtonBack.Name = "rmBulkButtonBack";
            this.rmBulkButtonBack.Size = new System.Drawing.Size(75, 23);
            this.rmBulkButtonBack.TabIndex = 3;
            this.rmBulkButtonBack.Text = "Back";
            this.rmBulkButtonBack.UseVisualStyleBackColor = true;
            this.rmBulkButtonBack.Click += new System.EventHandler(this.rmBulkButtonBack_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // rmName
            // 
            this.rmName.HeaderText = "Name";
            this.rmName.Name = "rmName";
            this.rmName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // RMFormBulkUpdateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rmBulkButtonBack);
            this.Controls.Add(this.rmBulkButtonConfirm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rmBulkButtonBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RMFormBulkUpdateView";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rmBulkButtonBrowse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button rmBulkButtonConfirm;
        private System.Windows.Forms.Button rmBulkButtonBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}