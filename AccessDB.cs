using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Linq.Expressions;

namespace Proyecto_Panadería {
	public class AccessDB {
		private string connectionString;

		public AccessDB() {
			connectionString = Properties.Resources.ConnectionStr;
		}

		public List<User> userInitialize() {
			List<User> users = new List<User>();

			string queryString = "Select * from dbo.[user]";
			using (SqlConnection connection = new SqlConnection(connectionString)) {
				SqlCommand command = new SqlCommand(queryString, connection);

				try {
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();
					User userAssistant;

					while (reader.Read()) {
						int userId = reader.GetInt32(6);
						string userName = reader.GetString(0);
						string userLastName = reader.GetString(1);
						string userUserName = reader.GetString(2);
						string userPsw = reader.GetString(3);
						bool userIsAdmin = reader.GetBoolean(4);
						bool userIsDeleted = reader.GetBoolean(5);

						userAssistant = new User(userId, userName, userLastName, userUserName, userPsw, userIsAdmin, userIsDeleted);
						users.Add(userAssistant);
					}
				} catch (Exception ex) {
					Console.WriteLine(ex.Message);
				}
			}

			return users;
        }
        public void addUser(User user)
        {
            string queryString = "INSERT INTO [dbo].[user] ([name], [lastName], [userName], [password], [isAdmin], [isDeleted]) values (@name, @lastName, @userName, @password, @isAdmin, @isDeleted);";
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@lastName", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@userName", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@isAdmin", SqlDbType.Bit));
                command.Parameters.Add(new SqlParameter("@isDeleted", SqlDbType.Bit));
                command.Parameters["@name"].Value = user.name;
                command.Parameters["@lastName"].Value = user.lastName;
                command.Parameters["@userName"].Value = user.userName;
                command.Parameters["@password"].Value = user.password;
                command.Parameters["@isAdmin"].Value = user.isAdmin;
                command.Parameters["@isDeleted"].Value = user.isDeleted;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public List<Product> productInitialize() {
			List<Product> products = new List<Product>();

			string queryString = "Select * from dbo.product";
			using (SqlConnection connection = new SqlConnection(this.connectionString)) {
				SqlCommand command = new SqlCommand(queryString, connection);

				try {
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();
					Product productAssistant;

					while (reader.Read()) {
						int productId = reader.GetInt32(4);
						string productName = reader.GetString(0);
						int productUnit = reader.GetInt32(1);
						double productPrice = reader.GetDouble(2);
						bool productIsDeleted = reader.GetBoolean(3);
						productAssistant = new Product(productId, productName, productUnit, productPrice, productIsDeleted);
						products.Add(productAssistant);
					}
				} catch (Exception ex) {
					Console.WriteLine(ex.Message);
				}
			}

			return products;
		}

		public void updateProduct(Product product)
		{
			string queryString = "UPDATE dbo.product SET [name]=(@name), [unit]=(@unit), [price]=(@price), [isDeleted]=(@isDeleted) WHERE [id] = (@id)";

			using (SqlConnection connection = new SqlConnection(this.connectionString)) {
				SqlCommand command = new SqlCommand(queryString, connection);
				command.Parameters.AddWithValue("@name", product.name);
				command.Parameters.AddWithValue("@unit", product.unit);
				command.Parameters.AddWithValue("@price", product.price);
				command.Parameters.AddWithValue("@isDeleted", product.isDeleted);
				command.Parameters.AddWithValue("@id", product.id);
				try {
					connection.Open();
					command.ExecuteNonQuery();
				} catch (Exception ex) {
					Console.WriteLine(ex);
				}
			}
		}

		public List<RawMaterial> rawMaterialInitialize()
		{
			List<RawMaterial> rawMaterials = new List<RawMaterial>();

			string queryString = "Select * from dbo.rawMaterial";
			using (SqlConnection connection = new SqlConnection(this.connectionString))
			{
				SqlCommand command = new SqlCommand(queryString, connection);

				try
				{
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();
					RawMaterial rawMaterialAssistant;

					while (reader.Read())
					{
						int rawMaterialId = reader.GetInt32(0);
						string rawMaterialName = reader.GetString(1);
						int rawMaterialAmount = reader.GetInt32(2);
						int rawMaterialUnit = reader.GetInt32(3);
						rawMaterialAssistant = new RawMaterial(rawMaterialId, rawMaterialName, rawMaterialAmount, rawMaterialUnit);
						rawMaterials.Add(rawMaterialAssistant);
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			return rawMaterials;
		}

		public void addRawMaterial(RawMaterial rawMaterial) {
			string queryString = "INSERT INTO [dbo].[rawMaterial] ([name], [amount], [unit]) values (@name, @amount, @unit);";
			using (SqlConnection connection = new SqlConnection(this.connectionString)) {
				SqlCommand command = new SqlCommand(queryString, connection);
				command.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
				command.Parameters.Add(new SqlParameter("@amount", SqlDbType.Int));
				command.Parameters.Add(new SqlParameter("@unit", SqlDbType.Int));
				command.Parameters["@name"].Value = rawMaterial.name;
				command.Parameters["@amount"].Value = rawMaterial.amount;
				command.Parameters["@unit"].Value = rawMaterial.unit;

				try {
					connection.Open();
					command.ExecuteNonQuery();
				} catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
        }
        public void updateRawMaterial(RawMaterial rawMaterial)
        {
            string queryString = "UPDATE [dbo].[rawMaterial] SET [amount]=[amount] + (@amount) WHERE [id] = (@id)";
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@amount", rawMaterial.amount);
                command.Parameters.AddWithValue("@id", rawMaterial.id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public void bulkUploadRawMaterial(List<RawMaterial> rawMaterials) {
			foreach (RawMaterial rawMaterial in rawMaterials)
            {
				if (rawMaterial.id == 0) {
					rawMaterial.unit = 1;
					this.addRawMaterial(rawMaterial);
				}
				else
				{
					this.updateRawMaterial(rawMaterial);
				}

            }
		}
    }
}
