using System;

namespace Proyecto_Panadería {
	public class Product {
		public int id { get; set; }
		public string name { get; set; }
		public int amount { get; set; }
		public double price { get; set; }
		public bool isDeleted { get; set; }

		public Product() {}

		public Product(int id, string name, int amount, double price) {
			this.id = id;
			this.name = name;
			this.amount = amount;
			this.price = price;
			this.isDeleted = false;
		}

		public Product(int id, string name, int amount, double price, bool isDeleted) {
			this.id = id;
			this.name = name;
			this.amount = amount;
			this.price = price;
			this.isDeleted = isDeleted;
		}
	}
}
