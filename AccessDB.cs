using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Panadería {
	internal class AccessDB {
		private string connectionString;

		public AccessDB() {
			connectionString = Properties.Resources.ConnectionStr;
		}

		public List<User> userInitialize() {
			List<User> users = new List<User>();

			string queryString = "Select * from dbo.User";
			using (SqlConnection connection = new SqlConnection(connectionString)) {
				SqlCommand command = new SqlCommand(queryString, connection);

				try {
					connection.Open();
					SqlDataReader reader = command.ExecuteREader();
					User userAssistant;

					while (reader.Read()) {
						//TODO: define user
						userAssistant = new User(reader.GetInt32(0));
						users.Add(userAssistant);
					}
				} catch (Exception ex) {
					Console.WriteLine(ex.Message);
				}
			}

			return users;
		}

		public List<Product> productInitialize() {
			List<Product> products = new List<Product>();

			string queryString = "Select * from dbo.product";
			using (SqlConnection connection = new SqlConnection(connectionString)) {
				SqlCommand command = new SqlCommand(queryString, connection);

				try {
					connection.Open();
					SqlDataReader reader = command.ExecuteREader();
					Product productAssistant;

					while (reader.Read()) {
						//TODO: define product
						productAssistant = new Product(reader.GetInt32(0));
						products.Add(productAssistant);
					}
				} catch (Exception ex) {
					Console.WriteLine(ex.Message);
				}
			}

			return products;
		}
	}
}
