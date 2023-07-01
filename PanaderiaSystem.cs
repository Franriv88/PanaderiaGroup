using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Panadería {
	public class PanaderiaSystem
    {
        public AccessDB db;
        public List<User> users;
		public List<Product> products;
		public List<RawMaterial> rawMaterials;

		public User currentUser;

		public PanaderiaSystem()
        {
            this.db = new AccessDB();
            this.users = new List<User>();
			this.products = new List<Product>();
			this.rawMaterials = new List<RawMaterial>();
			this.attributesInitialize();
		}

		private void attributesInitialize() {
			this.users = this.db.userInitialize();
			this.products = this.db.productInitialize();
			this.rawMaterials = this.db.rawMaterialInitialize();
		}

		public bool loginUser(string userName, string psw) {
			try {
				int userIndex = this.users.FindIndex(user => user.userName.Equals(userName));
				if (userIndex == -1) return false;

				User auxUser = this.users[userIndex];
				if (auxUser.isDeleted) return false;

				if (!auxUser.password.Equals(psw)) return false;

				this.currentUser = auxUser;
                return true;
            }
			catch (Exception) {
				return false;
			}
		}

		public List<Product> getProductList() {
			return this.products.ToList();
		}

		public bool deleteProduct(int productId) {
			try {
				int productIndex = this.products.FindIndex(auxProduct => auxProduct.id == productId);
				if (productIndex == -1) return false;

                Product currentProduct = this.products[productIndex];
                if (currentProduct.isDeleted) return false;

                currentProduct.isDeleted = true;
				this.db.updateProduct(currentProduct);
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public bool addProduct() {
			//TODO: Define whats the thing that we need in the product class
			return true;
		}

		public void saveRawMaterial(RawMaterial rawMaterial)
        {
            try
            {
                this.db.addRawMaterial(rawMaterial);
                this.rawMaterials = this.db.rawMaterialInitialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to add raw material");
            }
        }

        public List<RawMaterial> getRawMaterialList()
        {
            return this.rawMaterials.ToList();
        }

		public void bulkUploadRawMaterial(List<RawMaterial> rawMaterials)
		{
			try
			{
				this.db.bulkUploadRawMaterial(rawMaterials);
				this.rawMaterials = this.db.rawMaterialInitialize();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error to upload bulk raw materials");
			}
		}


        public List<User> getUsersList()
        {
            return this.users.ToList();
        }
        public void saveUser(User user)
        {
            try
            {
                this.db.addUser(user);
                this.users = this.db.userInitialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error to add raw material");
            }
        }

    }
}
