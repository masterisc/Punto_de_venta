using System;
using MySql.Data.MySqlClient;

namespace puntodeventa
{
	public class MySql
	{
		protected MySqlConnection myConnection;
		
		public MySql()
		{
		}
		
		protected void abrirConexion()
		{
			string connectionString =
				"Server=localhost;" +
				"Database=carniceria;" +
				"User ID=root;" +
				"Password=root;" +
				"Pooling=false;";
			this.myConnection = new MySqlConnection(connectionString);
			this.myConnection.Open();
		}
		protected void cerrarConexion()
		{
			this.myConnection.Close();
			this.myConnection = null;
		}
	}
}
