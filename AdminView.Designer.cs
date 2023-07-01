using System.Windows.Forms;

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
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductIsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAddButton = new System.Windows.Forms.Button();
            this.productEditButton = new System.Windows.Forms.Button();
            this.productDeleteButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.tabRawMaterial = new System.Windows.Forms.TabPage();
            this.rmBulkUpdateButton = new System.Windows.Forms.Button();
            this.rmAddButton = new System.Windows.Forms.Button();
            this.dataGridRawMaterials = new System.Windows.Forms.DataGridView();
            this.RMId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RMAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RMUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIsAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAddButton = new System.Windows.Forms.Button();
            this.userEditbutton = new System.Windows.Forms.Button();
            this.userDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabProduct.SuspendLayout();
            this.tabRawMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRawMaterials)).BeginInit();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.ProductPrice,
            this.ProductUnit,
            this.ProductIsDeleted});
            this.dataGridProduct.Location = new System.Drawing.Point(6, 6);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.Size = new System.Drawing.Size(543, 325);
            this.dataGridProduct.TabIndex = 0;
            this.dataGridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // ProductUnit
            // 
            this.ProductUnit.HeaderText = "Unit";
            this.ProductUnit.Name = "ProductUnit";
            this.ProductUnit.ReadOnly = true;
            // 
            // ProductIsDeleted
            // 
            this.ProductIsDeleted.HeaderText = "IsDeleted";
            this.ProductIsDeleted.Name = "ProductIsDeleted";
            this.ProductIsDeleted.ReadOnly = true;
            // 
            // productAddButton
            // 
            this.productAddButton.Location = new System.Drawing.Point(589, 6);
            this.productAddButton.Name = "productAddButton";
            this.productAddButton.Size = new System.Drawing.Size(75, 23);
            this.productAddButton.TabIndex = 1;
            this.productAddButton.Text = "Add";
            this.productAddButton.UseVisualStyleBackColor = true;
            this.productAddButton.Click += new System.EventHandler(this.productAddButton_Click);
            // 
            // productEditButton
            // 
            this.productEditButton.Location = new System.Drawing.Point(589, 35);
            this.productEditButton.Name = "productEditButton";
            this.productEditButton.Size = new System.Drawing.Size(75, 23);
            this.productEditButton.TabIndex = 2;
            this.productEditButton.Text = "Edit";
            this.productEditButton.UseVisualStyleBackColor = true;
            // 
            // productDeleteButton
            // 
            this.productDeleteButton.Location = new System.Drawing.Point(589, 308);
            this.productDeleteButton.Name = "productDeleteButton";
            this.productDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.productDeleteButton.TabIndex = 3;
            this.productDeleteButton.Text = "Delete";
            this.productDeleteButton.UseVisualStyleBackColor = true;
            this.productDeleteButton.Click += new System.EventHandler(this.productDeleteButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabRawMaterial);
            this.tabControl1.Controls.Add(this.tabReport);
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 363);
            this.tabControl1.TabIndex = 4;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.productAddButton);
            this.tabProduct.Controls.Add(this.productDeleteButton);
            this.tabProduct.Controls.Add(this.productEditButton);
            this.tabProduct.Controls.Add(this.dataGridProduct);
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(670, 337);
            this.tabProduct.TabIndex = 0;
            this.tabProduct.Text = "Products";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // tabRawMaterial
            // 
            this.tabRawMaterial.Controls.Add(this.rmBulkUpdateButton);
            this.tabRawMaterial.Controls.Add(this.rmAddButton);
            this.tabRawMaterial.Controls.Add(this.dataGridRawMaterials);
            this.tabRawMaterial.Location = new System.Drawing.Point(4, 22);
            this.tabRawMaterial.Name = "tabRawMaterial";
            this.tabRawMaterial.Padding = new System.Windows.Forms.Padding(3);
            this.tabRawMaterial.Size = new System.Drawing.Size(670, 337);
            this.tabRawMaterial.TabIndex = 2;
            this.tabRawMaterial.Text = "Raw Materials";
            this.tabRawMaterial.UseVisualStyleBackColor = true;
            // 
            // rmBulkUpdateButton
            // 
            this.rmBulkUpdateButton.Location = new System.Drawing.Point(589, 35);
            this.rmBulkUpdateButton.Name = "rmBulkUpdateButton";
            this.rmBulkUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.rmBulkUpdateButton.TabIndex = 2;
            this.rmBulkUpdateButton.Text = "Bulk Update";
            this.rmBulkUpdateButton.UseVisualStyleBackColor = true;
            this.rmBulkUpdateButton.Click += new System.EventHandler(this.rmBulkUpdateButton_Click);
            // 
            // rmAddButton
            // 
            this.rmAddButton.Location = new System.Drawing.Point(589, 6);
            this.rmAddButton.Name = "rmAddButton";
            this.rmAddButton.Size = new System.Drawing.Size(75, 23);
            this.rmAddButton.TabIndex = 1;
            this.rmAddButton.Text = "Add";
            this.rmAddButton.UseVisualStyleBackColor = true;
            this.rmAddButton.Click += new System.EventHandler(this.rmAddButton_Click);
            // 
            // dataGridRawMaterials
            // 
            this.dataGridRawMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRawMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RMId,
            this.RMName,
            this.RMAmount,
            this.RMUnit});
            this.dataGridRawMaterials.Location = new System.Drawing.Point(6, 6);
            this.dataGridRawMaterials.Name = "dataGridRawMaterials";
            this.dataGridRawMaterials.Size = new System.Drawing.Size(444, 325);
            this.dataGridRawMaterials.TabIndex = 0;
            // 
            // RMId
            // 
            this.RMId.HeaderText = "Id";
            this.RMId.Name = "RMId";
            this.RMId.ReadOnly = true;
            // 
            // RMName
            // 
            this.RMName.HeaderText = "Name";
            this.RMName.Name = "RMName";
            this.RMName.ReadOnly = true;
            // 
            // RMAmount
            // 
            this.RMAmount.HeaderText = "Amount";
            this.RMAmount.Name = "RMAmount";
            this.RMAmount.ReadOnly = true;
            // 
            // RMUnit
            // 
            this.RMUnit.HeaderText = "Unit";
            this.RMUnit.Name = "RMUnit";
            this.RMUnit.ReadOnly = true;
            // 
            // tabReport
            // 
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(670, 337);
            this.tabReport.TabIndex = 3;
            this.tabReport.Text = "Reports";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.userDeleteButton);
            this.tabUser.Controls.Add(this.userEditbutton);
            this.tabUser.Controls.Add(this.userAddButton);
            this.tabUser.Controls.Add(this.dataGridUser);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(670, 337);
            this.tabUser.TabIndex = 4;
            this.tabUser.Text = "Users";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // dataGridUser
            // 
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.userName,
            this.userLastName,
            this.userUserName,
            this.userIsAdmin});
            this.dataGridUser.Location = new System.Drawing.Point(6, 6);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.Size = new System.Drawing.Size(532, 325);
            this.dataGridUser.TabIndex = 0;
            // 
            // userId
            // 
            this.userId.HeaderText = "Id";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.HeaderText = "Name";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // userLastName
            // 
            this.userLastName.HeaderText = "LastName";
            this.userLastName.Name = "userLastName";
            this.userLastName.ReadOnly = true;
            // 
            // userUserName
            // 
            this.userUserName.HeaderText = "UserName";
            this.userUserName.Name = "userUserName";
            this.userUserName.ReadOnly = true;
            // 
            // userIsAdmin
            // 
            this.userIsAdmin.HeaderText = "IsAdmin";
            this.userIsAdmin.Name = "userIsAdmin";
            this.userIsAdmin.ReadOnly = true;
            // 
            // userAddButton
            // 
            this.userAddButton.Location = new System.Drawing.Point(589, 6);
            this.userAddButton.Name = "userAddButton";
            this.userAddButton.Size = new System.Drawing.Size(75, 23);
            this.userAddButton.TabIndex = 1;
            this.userAddButton.Text = "Add";
            this.userAddButton.UseVisualStyleBackColor = true;
            this.userAddButton.Click += new System.EventHandler(this.userAddButton_Click);
            // 
            // userEditbutton
            // 
            this.userEditbutton.Location = new System.Drawing.Point(589, 36);
            this.userEditbutton.Name = "userEditbutton";
            this.userEditbutton.Size = new System.Drawing.Size(75, 23);
            this.userEditbutton.TabIndex = 2;
            this.userEditbutton.Text = "Edit";
            this.userEditbutton.UseVisualStyleBackColor = true;
            // 
            // userDeleteButton
            // 
            this.userDeleteButton.Location = new System.Drawing.Point(589, 307);
            this.userDeleteButton.Name = "userDeleteButton";
            this.userDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.userDeleteButton.TabIndex = 3;
            this.userDeleteButton.Text = "Delete";
            this.userDeleteButton.UseVisualStyleBackColor = true;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            this.tabRawMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRawMaterials)).EndInit();
            this.tabUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.Button productAddButton;
        private System.Windows.Forms.Button productEditButton;
        private System.Windows.Forms.Button productDeleteButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabRawMaterial;
        private System.Windows.Forms.TabPage tabReport;
        private TabPage tabUser;
        private DataGridView dataGridRawMaterials;
        private Button rmBulkUpdateButton;
        private Button rmAddButton;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductUnit;
        private DataGridViewTextBoxColumn ProductIsDeleted;
        private DataGridViewTextBoxColumn RMId;
        private DataGridViewTextBoxColumn RMName;
        private DataGridViewTextBoxColumn RMAmount;
        private DataGridViewTextBoxColumn RMUnit;
        private DataGridView dataGridUser;
        private Button userDeleteButton;
        private Button userEditbutton;
        private Button userAddButton;
        private DataGridViewTextBoxColumn userId;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn userLastName;
        private DataGridViewTextBoxColumn userUserName;
        private DataGridViewTextBoxColumn userIsAdmin;
    }
}