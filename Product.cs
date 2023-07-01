using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Panadería {
	public class Product {
		public int id { get; set; }
		public string name { get; set; }
		public int unit { get; set; }
		public double price { get; set; }
		public bool isDeleted { get; set; }

		public Product() {}

		public Product(int id, string name, int unit, double price) {
			this.id = id;
			this.name = name;
			this.unit = unit;
			this.price = price;
			this.isDeleted = false;
		}

		public Product(int id, string name, int unit, double price, bool isDeleted) {
			this.id = id;
			this.name = name;
			this.unit = unit;
			this.price = price;
			this.isDeleted = isDeleted;
		}

		private static string getUnitType(int unit) {
			return unit == 1 ? "Kg" : "Unitary";
        }

		public string[] toArray() {
			return new string[] {
				this.id.ToString(),
				this.name.ToUpper(),
				this.price.ToString("C"),
				Product.getUnitType(this.unit),
				this.isDeleted? "True" : "False"
			};
		}
	}
}
