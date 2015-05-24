using System;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using System.IO;

namespace puntodeventa
{
	public class LoginMySql : MySql
	{
		public LoginMySql()
		{
		}
		
		public string queryUsuario(string nombre, string password, string tipo_usuario)
		{
			string consulta = "";
			this.abrirConexion();
			string query = "Select *" +
				"From usuario " +
				"Where nombre = ?nombre " +
				"AND password = ?password " +
				"AND tipo_usuario = ?tipo_usuario";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("?nombre", nombre);
			myCommand.Parameters.AddWithValue("?password", password);
			myCommand.Parameters.AddWithValue("?tipo_usuario", tipo_usuario);
			MySqlDataReader myReader = myCommand.ExecuteReader();
			if (myReader.Read())
			{
				consulta = myReader["id_usuario"].ToString();
			}
			return consulta;
		}
		
		public void insertarUsuario(string nombre, string password, string tipo_usuario, float financiamiento, string dirección, string teléfono, byte[] imagen)
		{

			this.abrirConexion();
			string sql = "INSERT INTO usuario (nombre, password, tipo_usuario, financiamiento, dirección, teléfono, imagen)" +
				"VALUES (?nombre, ?password, ?tipo_usuario, ?financiamiento, ?dirección, ?teléfono, ?imagen)";

			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?nombre", nombre);
			myCommand.Parameters.AddWithValue("?password", password);
			myCommand.Parameters.AddWithValue("?tipo_usuario", tipo_usuario);
			myCommand.Parameters.AddWithValue("?financiamiento", financiamiento);
			myCommand.Parameters.AddWithValue("?dirección", dirección);
			myCommand.Parameters.AddWithValue("?teléfono", teléfono);
			myCommand.Parameters.AddWithValue("?imagen", imagen);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public void actualizarNombreU(string id, string nombre)
		{
			this.abrirConexion();
			
			string sql = "UPDATE usuario SET nombre = ?nombre WHERE id_usuario = ?id;";
			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?nombre", nombre);
			myCommand.Parameters.AddWithValue("?id", id);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public void actualizarDirU(string id, string dir)
		{
			this.abrirConexion();
			
			string sql = "UPDATE usuario SET dirección = ?dir WHERE id_usuario = ?id;";
			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?dir", dir);
			myCommand.Parameters.AddWithValue("?id", id);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public void actualizarTelU(string id, string tel)
		{
			this.abrirConexion();
			
			string sql = "UPDATE usuario SET teléfono = ?tel WHERE id_usuario = ?id;";
			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?tel", tel);
			myCommand.Parameters.AddWithValue("?id", id);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public void actualizarSueldoU(string id, float sueldo)
		{
			this.abrirConexion();
			
			string sql = "UPDATE usuario SET financiamiento = ?sueldo WHERE id_usuario = ?id;";
			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?sueldo", sueldo);
			myCommand.Parameters.AddWithValue("?id", id);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public void actualizarContraU(string id, string contra)
		{
			this.abrirConexion();
			
			string sql = "UPDATE usuario SET password = ?contra WHERE id_usuario = ?id;";
			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?contra", contra);
			myCommand.Parameters.AddWithValue("?id", id);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public void actualizarImagenUsuario(string id, byte[] imagen)
		{
			this.abrirConexion();
			
			string sql = "UPDATE usuario SET imagen = ?imagen WHERE id_usuario = ?id;";
			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?imagen", imagen);
			myCommand.Parameters.AddWithValue("?id", id);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public string mostrarNombreUsuario(string id)
		{
			this.abrirConexion();
			string query = "Select nombre From usuario Where id_usuario = ?id";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("?id", id);
			myCommand.ExecuteNonQuery();
			
			MySqlDataReader myReader = myCommand.ExecuteReader();
			myReader.Read();
			return myReader.GetString(0);
		}
		public string mostrarDirUsuario(string id)
		{
			this.abrirConexion();
			string query = "Select dirección From usuario Where id_usuario = ?id";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("?id", id);
			myCommand.ExecuteNonQuery();
			
			MySqlDataReader myReader = myCommand.ExecuteReader();
			myReader.Read();
			return myReader.GetString(0);
		}
		public string mostrarTelUsuario(string id)
		{
			this.abrirConexion();
			string query = "Select teléfono From usuario Where id_usuario = ?id";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("?id", id);
			myCommand.ExecuteNonQuery();
			
			MySqlDataReader myReader = myCommand.ExecuteReader();
			myReader.Read();
			return myReader.GetString(0);
		}
		public string mostrarSueldoUsuario(string id)
		{
			this.abrirConexion();
			string query = "Select financiamiento From usuario Where id_usuario = ?id";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("?id", id);
			myCommand.ExecuteNonQuery();
			
			MySqlDataReader myReader = myCommand.ExecuteReader();
			myReader.Read();
			return myReader.GetString(0);
		}
		public string mostarContraUsuario(string id)
		{
			this.abrirConexion();
			string query = "Select password From usuario Where id_usuario = ?id";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("?id", id);
			myCommand.ExecuteNonQuery();
			
			MySqlDataReader myReader = myCommand.ExecuteReader();
			myReader.Read();
			return myReader.GetString(0);
		}
		public MySqlDataReader mostrarAdministradores()
		{
			this.abrirConexion();
			string query = "Select id_usuario, nombre, financiamiento, dirección, teléfono From usuario Where tipo_usuario = 'Administrador'";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			MySqlDataReader myReader = myCommand.ExecuteReader();
			return myReader;
		}
		public MySqlDataReader mostrarCajeros()
		{
			this.abrirConexion();
			string query = "Select id_usuario, nombre, financiamiento, dirección, teléfono From usuario Where tipo_usuario = 'Cajero'";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			MySqlDataReader myReader = myCommand.ExecuteReader();
			return myReader;
		}
		public Image mostrarImagenUsuario(string id)
		{
			this.abrirConexion();
			string query = "Select imagen From usuario Where id_usuario = ?id";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("?id", id);
			myCommand.ExecuteNonQuery();
			byte[] imgArr = (byte[])myCommand.ExecuteScalar();
			imgArr = (byte[])myCommand.ExecuteScalar();
			using (var stream = new MemoryStream(imgArr))
			{
				Image img = Image.FromStream(stream);
				return img;
			}
		}
		public void insertarProducto(string nombre, string descripcion, int cantidad, string granel, float precio, float precio_venta, byte[] imagen)
		{
			this.abrirConexion();
			
			string sql = "INSERT INTO producto (nombre, descripción, cantidad, granel, precio, precio_venta, imagen) " +
				"VALUES (?nombre, ?descripción, ?cantidad, ?granel, ?precio, ?precio_venta, ?imagen)";
			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?nombre", nombre);
			myCommand.Parameters.AddWithValue("?descripción", descripcion);
			myCommand.Parameters.AddWithValue("?cantidad", cantidad);
			myCommand.Parameters.AddWithValue("?granel", granel);
			myCommand.Parameters.AddWithValue("?precio", precio);
			myCommand.Parameters.AddWithValue("?precio_venta", precio_venta);
			myCommand.Parameters.AddWithValue("?imagen", imagen);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public void actualizarNombreP(string id, string nombre)
		{
			this.abrirConexion();
			
			string sql = "UPDATE producto SET nombre = ?nombre WHERE id_producto = ?id;";
			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?nombre", nombre);
			myCommand.Parameters.AddWithValue("?id", id);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public void actualizarDescP(string id, string desc)
		{
			this.abrirConexion();
			
			string sql = "UPDATE producto SET descripción = ?desc WHERE id_producto = ?id;";
			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?desc", desc);
			myCommand.Parameters.AddWithValue("?id", id);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public void actualizarCantidadP(string id, int cantidad)
		{
			this.abrirConexion();
			
			string sql = "UPDATE producto SET cantidad = ?cantidad WHERE id_producto = ?id;";
			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?cantidad", cantidad);
			myCommand.Parameters.AddWithValue("?id", id);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public void actualizarGranelP(string id, string granel)
		{
			this.abrirConexion();
			
			string sql = "UPDATE producto SET granel = ?granel WHERE id_producto = ?id;";
			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?granel", granel);
			myCommand.Parameters.AddWithValue("?id", id);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public void actualizarPrecioP(string id, float precio)
		{
			this.abrirConexion();
			
			string sql = "UPDATE producto SET precio = ?precio WHERE id_producto = ?id;";
			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?precio", precio);
			myCommand.Parameters.AddWithValue("?id", id);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public void actualizarPrecioVP(string id, float preciov)
		{
			this.abrirConexion();
			
			string sql = "UPDATE producto SET precio_venta = ?precio_venta WHERE id_producto = ?id;";
			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?precio_venta", preciov);
			myCommand.Parameters.AddWithValue("?id", id);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public void actualizarImagenP(string id, byte[] imagen)
		{
			this.abrirConexion();
			
			string sql = "UPDATE producto SET imagen = ?imagen WHERE id_producto = ?id;";
			MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
			myCommand.Parameters.AddWithValue("?imagen", imagen);
			myCommand.Parameters.AddWithValue("?id", id);
			
			myCommand.ExecuteNonQuery();
			this.cerrarConexion();
		}
		public MySqlDataReader mostrarProductos()
		{
			this.abrirConexion();
			string query = "Select id_producto, nombre, descripción, cantidad, granel, precio, precio_venta From producto";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			MySqlDataReader myReader = myCommand.ExecuteReader();
			return myReader;
		}
		public string mostrarNombreP(string id)
		{
			this.abrirConexion();
			string query = "Select nombre From producto Where id_producto = ?id";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("?id", id);
			myCommand.ExecuteNonQuery();
			
			MySqlDataReader myReader = myCommand.ExecuteReader();
			myReader.Read();
			return myReader.GetString(0);
		}
		public string mostrarDescP(string id)
		{
			this.abrirConexion();
			string query = "Select descripción From producto Where id_producto = ?id";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("?id", id);
			myCommand.ExecuteNonQuery();
			
			MySqlDataReader myReader = myCommand.ExecuteReader();
			myReader.Read();
			return myReader.GetString(0);
		}
		public string mostrarCantidadP(string id)
		{
			this.abrirConexion();
			string query = "Select cantidad From producto Where id_producto = ?id";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("?id", id);
			myCommand.ExecuteNonQuery();
			
			MySqlDataReader myReader = myCommand.ExecuteReader();
			myReader.Read();
			return myReader.GetString(0);
		}
		public string mostrarGranelP(string id)
		{
			this.abrirConexion();
			string query = "Select granel From producto Where id_producto = ?id";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("?id", id);
			myCommand.ExecuteNonQuery();
			
			MySqlDataReader myReader = myCommand.ExecuteReader();
			myReader.Read();
			return myReader.GetString(0);
		}
		public string mostrarPrecioP(string id)
		{
			this.abrirConexion();
			string query = "Select precio From producto Where id_producto = ?id";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("?id", id);
			myCommand.ExecuteNonQuery();
			
			MySqlDataReader myReader = myCommand.ExecuteReader();
			myReader.Read();
			return myReader.GetString(0);
		}
		public MySqlDataReader buscarProductoPorId(string id)
		{
			this.abrirConexion();
			string query = "Select id_producto, nombre, precio_venta From producto Where id_producto = ?id";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("id",id);
			MySqlDataReader myReader = myCommand.ExecuteReader();
			return myReader;
		}
		public MySqlDataReader buscarProductoPorNombre(string nombre)
		{
			this.abrirConexion();
			string query = "Select id_producto, nombre, precio_venta From producto Where nombre LIKE '%?nombre%'";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("nombre",nombre);
			MySqlDataReader myReader = myCommand.ExecuteReader();
			return myReader;
		}
		public string mostrarPrecioVentaP(string id)
		{
			this.abrirConexion();
			string query = "Select precio_venta From producto Where id_producto = ?id";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("?id", id);
			myCommand.ExecuteNonQuery();
			
			MySqlDataReader myReader = myCommand.ExecuteReader();
			myReader.Read();
			return myReader.GetString(0);
		}
		public Image mostrarImagenProducto(string id)
		{
			this.abrirConexion();
			string query = "Select imagen From producto Where id_producto = ?id";
			MySqlCommand myCommand = new MySqlCommand(query, myConnection);
			myCommand.Parameters.AddWithValue("?id", id);
			myCommand.ExecuteNonQuery();
			byte[] imgArr = (byte[])myCommand.ExecuteScalar();
			imgArr = (byte[])myCommand.ExecuteScalar();
			using (var stream = new MemoryStream(imgArr))
			{
				Image img = Image.FromStream(stream);
				return img;
			}
		}
		public void EliminarUsuario(string id)
		{
			this.abrirConexion();
			string sql = "DELETE FROM `usuario` WHERE (`id_usuario`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		public void EliminarProducto(string codigo)
		{
			this.abrirConexion();
			string sql = "DELETE FROM `producto` WHERE (`id_producto`='" + codigo +"')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		public void EditarProducto(string nombreProducto,string descripcion,string precio)
		{
			this.abrirConexion();
			string sql = "UPDATE `producto` SET (`nombreProducto`='',`descripcion`='',`precio`='')  WHERE (`nombreProducto`='" + nombreProducto + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		private int ejecutarComando(string sql)
		{
			MySqlCommand myCommand = new MySqlCommand(sql, this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
	}
}