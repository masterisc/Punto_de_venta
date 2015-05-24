using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace puntodeventa
{

	public partial class EditaProducto : Form
	{
		public EditaProducto()
		{
			InitializeComponent();
		}
		void Button3Click(object sender, EventArgs e)
		{
			
		}
		void Button4Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar)) {
						e.Handled = false;
					}
					else if (Char.IsControl(e.KeyChar)) {
						e.Handled = false;
					}
					else if (Char.IsSeparator(e.KeyChar)) {
						e.Handled = false;
					}
					else {
						e.Handled = true;
					}
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			LoginMySql mostrar = new LoginMySql();
			MySqlDataReader reader = mostrar.mostrarProductos();
			this.dataGridView1.Rows.Clear();
			while(reader.Read())
			{
				LoginMySql image = new LoginMySql();
				Image imagen = image.mostrarImagenProducto(reader.GetValue(0).ToString());
           		this.dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3),reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), imagen);
			}
		}
		void EditaProductoLoad(object sender, EventArgs e)
		{
	
		}
	}
}
