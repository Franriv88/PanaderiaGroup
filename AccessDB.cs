using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using System.Data.SqlClient;
using System.Xml;
using System.Linq.Expressions;

using Proyecto_Panadería.Properties;

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
					SqlDataReader reader = command.ExecuteReader();
					User userAssistant;

					while (reader.Read()) {
						//TODO: define user
						userAssistant = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(5), reader.GetBoolean(6));
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
					SqlDataReader reader = command.ExecuteReader();
					Product productAssistant;

					while (reader.Read()) {
						//TODO: define product
						productAssistant = new Product(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDouble(3), reader.GetBoolean(4));
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
