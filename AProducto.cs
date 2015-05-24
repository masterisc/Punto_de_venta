using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace puntodeventa
{

	public partial class AProducto : Form
	{
		string dir;
		byte[] byteArray;
		
		public AProducto()
		{
			dir = "";
			InitializeComponent();

		}
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && this.dir.Length == 0)
			{
				MessageBox.Show("Campos vacios!!!","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				textBox1.Focus();
			}
			else 
				if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || this.dir.Length == 0)
				{
					MessageBox.Show("Faltan campos!!!","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					textBox1.Focus();
				}
				else
					if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox5.Text.Length > 0 && textBox6.Text.Length > 0 && this.dir.Length > 0)
						this.guardarProducto();
			return;
		}
		void guardarProducto()
		{
			string nombre = textBox1.Text.Trim();
			string descripcion = textBox2.Text.Trim();
			int cantidad;
			if(textBox3.Text.Trim().Length == 0)
				cantidad = 0;
			else cantidad = int.Parse(textBox3.Text.Trim());
			string granel = textBox4.Text.Trim();
			float precio;
			if(textBox5.Text.Trim().Length == 0)
				precio = 0;
			else precio = Convert.ToSingle(textBox5.Text.Trim());
			float precio_venta;
			if(textBox6.Text.Trim().Length == 0)
				precio_venta = 0;
			else precio_venta = Convert.ToSingle(textBox6.Text.Trim());
			//guardar en base de datos
			LoginMySql insertar = new LoginMySql();
			insertar.insertarProducto(nombre, descripcion, cantidad, granel, precio, precio_venta, this.byteArray);
			MessageBox.Show("Producto agregado");
			this.limpiar();
		}
		void limpiar()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";	
			pictureBox1.Image = null;
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back) && !(char.IsDigit(e.KeyChar)))
			{
      			MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      			e.Handled = true;
      			return;
			}
		}
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar)) {
						e.Handled = false;
					}
					else if (Char.IsControl(e.KeyChar)) {
						e.Handled = false;
					}
					else {
						e.Handled = true;
					}
		}
		void TextBox3KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != '.')
			{
      			MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      			e.Handled = true;
      			return;
			}
		}
		void TextBox4KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != '-')
			{
      			MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      			e.Handled = true;
      			return;
			}
		}
		void TextBox5KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsNumber(e.KeyChar)) {
						e.Handled = false;
					}
					else if (Char.IsControl(e.KeyChar)) {
						e.Handled = false;
					}
					else {
						e.Handled = true;
					}
		}
		void TextBox6KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsNumber(e.KeyChar)) {
						e.Handled = false;
					}
					else if (Char.IsControl(e.KeyChar)) {
						e.Handled = false;
					}
					else {
						e.Handled = true;
					}
		}
		void TextBox6TextChanged(object sender, EventArgs e)
		{
	
		}
		void AProductoLoad(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.InitialDirectory = "C:\\Users\\FAMILIA\\Pictures";
			open.Filter = "Imagenes (*.png *.jpg *.ico)|*.jpg|All files(*.*)|*.*";
			open.FilterIndex = 1;
		
			if (open.ShowDialog() == DialogResult.OK) {
				pictureBox1.Image = Bitmap.FromFile(open.FileName);
				
				MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                this.byteArray = ms.GetBuffer();
                ms.Close();
								
				this.dir = Path.GetFullPath(open.FileName).Replace(@"\", @"\\");
			}
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
	}
}
