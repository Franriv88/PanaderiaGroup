using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Panadería {
	public class PanaderiaSystem {
		public List<User> users;
		public List<Product> products;
		public AccessDB db;

		public User currentUser;

		public PanaderiaSystem() {
			this.users = new List<User>();
			this.products = new List<Product>();
			this.db = new AccessDB();
			this.attributesInitialize();
		}

		private void attributesInitialize() {
			this.users = db.userInitialize();
			this.products = db.productInitialize();
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

		public bool addProduct() {
			//TODO: Define whats the thing that we need in the product class
			return true;
		}

	}
}
