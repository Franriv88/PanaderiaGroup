using System;

namespace Proyecto_Panadería {
	public class AccessDB {
		private string connectionString;

		public AccessDB() {
			connectionString = Properties.Resources.ConnectionStr;
		}

		public List<User> UserInitialize() {
			List<User> users = new List<User>();

			string queryString = "Select * from dbo.User";
			using (SqlConnection connection = new SqlConnection(connectionString)) {
				SqlCommand command = new SqlCommand(queryString, connection);

				try {
					connection.Open();
					SqlDataReader reader = command.ExecuteREader();
					User userAssistant;

					while (reader.Read()) {
						userAssistant = new User(reader.GetInt32(0));
						users.Add(userAssistant);
					}
				} catch (Exception ex) {
					Console.WriteLine(ex.Message);
				}
			}

			return users;
		}
	}
}
