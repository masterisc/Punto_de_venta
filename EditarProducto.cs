using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace puntodeventa
{
	public partial class EditarProducto : Form
	{
		string dir;
		byte[] byteArray;
		string id;
		bool imagen;
		
		public EditarProducto(string primary)
		{
			InitializeComponent();
			dir = "";
			id = primary;
			imagen = false;
			this.inicializarComponentes();
		}
		void inicializarComponentes()
		{
			LoginMySql iniciar = new LoginMySql();
			textBox1.Text = iniciar.mostrarNombreP(id);
			textBox2.Text = iniciar.mostrarDescP(id);
			textBox3.Text = iniciar.mostrarCantidadP(id);
			textBox4.Text = iniciar.mostrarGranelP(id);
			textBox5.Text = iniciar.mostrarPrecioP(id);
			textBox6.Text = iniciar.mostrarPrecioVentaP(id);
			pictureBox1.Image = iniciar.mostrarImagenProducto(id);
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && this.dir.Length == 0)
			{
				MessageBox.Show("Campos vacios!!!","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				textBox1.Focus();
			}
			else 
				if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
				{
					MessageBox.Show("Faltan campos!!!","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					textBox1.Focus();
				}
				else
					if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox5.Text.Length > 0 && textBox6.Text.Length > 0)
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
			insertar.actualizarNombreP(id, nombre);
			insertar.actualizarDescP(id, descripcion);
			insertar.actualizarCantidadP(id, cantidad);
			insertar.actualizarGranelP(id, granel);
			insertar.actualizarPrecioP(id, precio);
			insertar.actualizarPrecioVP(id, precio_venta);
			if(this.imagen)
			{
				insertar.actualizarImagenP(id, this.byteArray);
			}
			MessageBox.Show("Producto editado");
			this.Hide();
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
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
				this.imagen = true;
			}
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
	}
}
