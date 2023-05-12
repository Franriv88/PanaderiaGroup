using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Panadería {
	internal class PanaderiaSystem {
		public List<User> users;
		public List<Product> products;
		public AccessDB db;

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

		public bool addProduct() {
			//TODO: Define whats the thing that we need in the product class
			return true;
		}

	}
}
