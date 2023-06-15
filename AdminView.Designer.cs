namespace Proyecto_Panadería
{
    partial class AdminView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAddButton = new System.Windows.Forms.Button();
            this.productEditButton = new System.Windows.Forms.Button();
            this.productDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.name,
            this.price,
            this.unit_m,
            this.isDeleted});
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // unit_m
            // 
            this.unit_m.HeaderText = "unit_m";
            this.unit_m.Name = "unit_m";
            // 
            // isDeleted
            // 
            this.isDeleted.HeaderText = "isDeleted";
            this.isDeleted.Name = "isDeleted";
            // 
            // productAddButton
            // 
            this.productAddButton.Location = new System.Drawing.Point(615, 72);
            this.productAddButton.Name = "productAddButton";
            this.productAddButton.Size = new System.Drawing.Size(75, 23);
            this.productAddButton.TabIndex = 1;
            this.productAddButton.Text = "Add";
            this.productAddButton.UseVisualStyleBackColor = true;
            // 
            // productEditButton
            // 
            this.productEditButton.Location = new System.Drawing.Point(615, 115);
            this.productEditButton.Name = "productEditButton";
            this.productEditButton.Size = new System.Drawing.Size(75, 23);
            this.productEditButton.TabIndex = 2;
            this.productEditButton.Text = "Edit";
            this.productEditButton.UseVisualStyleBackColor = true;
            // 
            // productDeleteButton
            // 
            this.productDeleteButton.Location = new System.Drawing.Point(615, 362);
            this.productDeleteButton.Name = "productDeleteButton";
            this.productDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.productDeleteButton.TabIndex = 3;
            this.productDeleteButton.Text = "Delete";
            this.productDeleteButton.UseVisualStyleBackColor = true;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.productDeleteButton);
            this.Controls.Add(this.productEditButton);
            this.Controls.Add(this.productAddButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminView";
            this.Text = "AdminView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDeleted;
        private System.Windows.Forms.Button productAddButton;
        private System.Windows.Forms.Button productEditButton;
        private System.Windows.Forms.Button productDeleteButton;
    }
}