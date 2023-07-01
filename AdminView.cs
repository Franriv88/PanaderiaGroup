using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Panadería
{
    public partial class AdminView : Form
    {
        public PanaderiaSystem panaderiaSystem;
        public int currentSelectedProductId;
        public TransfDelegate AddProductTransfDelegate;
        public TransfDelegate AddRMTransfDelegate;
        public TransfDelegate AddUserTransfDelegate;
        public TransfDelegate BulkUpdateRMTransfDelegate;

        public delegate void TransfDelegate();
        public AdminView(PanaderiaSystem panaderiaSystem)
        {
            InitializeComponent();
            this.panaderiaSystem = panaderiaSystem;
            this.refreshDataProducts();
            this.refreshDataRawMaterials();
            this.refreshDataUsers();
        }

        //---------------------------------------------------------------------------------------------//
        //Products section//
        //---------------------------------------------------------------------------------------------//

        private void refreshDataProducts() {
            this.dataGridProduct.Rows.Clear();
            foreach (Product product in this.panaderiaSystem.getProductList()) {
                this.dataGridProduct.Rows.Add(product.toArray());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dataGridProduct.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Error selecting product: You can only select one at a time");
                    return;
                }

                this.currentSelectedProductId = Int32.Parse(this.dataGridProduct[0, e.RowIndex].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Error selecting product");
            }
        }

        private void productDeleteButton_Click(object sender, EventArgs e)
        {
            if (!this.panaderiaSystem.deleteProduct(this.currentSelectedProductId))
            {
                MessageBox.Show("Error removing product");
                return;
            }
            this.refreshDataProducts();
        }

        private void productAddButton_Click(object sender, EventArgs e)
        {
            this.AddProductTransfDelegate();
        }

        //---------------------------------------------------------------------------------------------//
        //Raw Materials section//
        //---------------------------------------------------------------------------------------------//

        private void refreshDataRawMaterials()
        {
            this.dataGridRawMaterials.Rows.Clear();
            foreach (RawMaterial rawMaterial in this.panaderiaSystem.getRawMaterialList())
            {
                this.dataGridRawMaterials.Rows.Add(rawMaterial.toArray());
            }
        }

        private void rmAddButton_Click(object sender, EventArgs e)
        {
            this.AddRMTransfDelegate();
        }

        private void rmBulkUpdateButton_Click(object sender, EventArgs e)
        {
            this.BulkUpdateRMTransfDelegate();
        }

        //---------------------------------------------------------------------------------------------//
        //Users section//
        //---------------------------------------------------------------------------------------------//
        private void refreshDataUsers()
        {
            this.dataGridUser.Rows.Clear();
            foreach (User user in this.panaderiaSystem.getUsersList())
            {
                this.dataGridUser.Rows.Add(user.toArray());
            }
        }

        private void userAddButton_Click(object sender, EventArgs e)
        {
            this.AddUserTransfDelegate();
        }
    }
}
