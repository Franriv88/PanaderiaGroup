namespace Proyecto_Panadería
{
    partial class SellerView
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
            this.dataGridSellerView = new System.Windows.Forms.DataGridView();
            this.confirmCartButton = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.listSellerView = new System.Windows.Forms.ListView();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.labelList = new System.Windows.Forms.Label();
            this.columnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSellerView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSellerView
            // 
            this.dataGridSellerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSellerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnX,
            this.Producto,
            this.Borrar});
            this.dataGridSellerView.Location = new System.Drawing.Point(484, 53);
            this.dataGridSellerView.Name = "dataGridSellerView";
            this.dataGridSellerView.Size = new System.Drawing.Size(273, 274);
            this.dataGridSellerView.TabIndex = 0;
            // 
            // confirmCartButton
            // 
            this.confirmCartButton.Location = new System.Drawing.Point(614, 293);
            this.confirmCartButton.Name = "confirmCartButton";
            this.confirmCartButton.Size = new System.Drawing.Size(75, 23);
            this.confirmCartButton.TabIndex = 1;
            this.confirmCartButton.Text = "Confirmar";
            this.confirmCartButton.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(104, 40);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(254, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(104, 21);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(43, 13);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Buscar:";
            // 
            // listSellerView
            // 
            this.listSellerView.HideSelection = false;
            this.listSellerView.Location = new System.Drawing.Point(104, 89);
            this.listSellerView.Name = "listSellerView";
            this.listSellerView.Size = new System.Drawing.Size(251, 273);
            this.listSellerView.TabIndex = 4;
            this.listSellerView.UseCompatibleStateImageBehavior = false;
            this.listSellerView.View = System.Windows.Forms.View.List;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Regresar";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(682, 358);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Salir";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(481, 37);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(29, 13);
            this.labelList.TabIndex = 7;
            this.labelList.Text = "Lista";
            // 
            // columnX
            // 
            this.columnX.HeaderText = "Cantidad";
            this.columnX.Name = "columnX";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "X";
            this.Borrar.Name = "Borrar";
            this.Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Borrar.Width = 30;
            // 
            // SellerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.listSellerView);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.confirmCartButton);
            this.Controls.Add(this.dataGridSellerView);
            this.Name = "SellerView";
            this.Text = "SellerView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSellerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSellerView;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
        private System.Windows.Forms.Button confirmCartButton;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ListView listSellerView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label labelList;
    }
}