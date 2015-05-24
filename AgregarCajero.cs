using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace puntodeventa
{

	public partial class AgregarCajero : Form
	{
		string dir;
		byte[] byteArray;
		
		public AgregarCajero()
		{
			InitializeComponent();
			dir = "";
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("La clave tiene que ser alfanumérica" + "\n" + "con un mínimo de 5 dígitos y máximo 10 dígitos", "AYUDA CLAVE");
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		void GuardarClick(object sender, EventArgs e)
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
					{	
						if(String.Compare(textBox4.Text.Trim(),textBox5.Text.Trim()) != 0)
						{
					   		MessageBox.Show("No coinciden las contraseñas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					   		textBox4.Focus();
						}
				        else 
				        	this.guardarCajero();
					}
			return;
		}
		void guardarCajero()
		{
			string nombre = textBox1.Text.Trim();
			string password = textBox4.Text.Trim();
			Hash pass = new Hash();
			password = pass.GetMd5Hash(password);
			string tipo = "Cajero";
			float sueldo;
			if(textBox6.Text.Trim().Length == 0)
				sueldo = 0;
			else sueldo = Convert.ToSingle(textBox6.Text.Trim());
			string dirección = textBox2.Text.Trim();
			string teléfono = textBox3.Text.Trim();
			//guardar en base de datos
			LoginMySql insertar = new LoginMySql();
			insertar.insertarUsuario(nombre, password, tipo, sueldo, dirección, teléfono, this.byteArray);
			MessageBox.Show("Cajero agregado");
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
		void AgregarCajeroLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
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
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
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
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back) && !(char.IsDigit(e.KeyChar)))
			{
      			MessageBox.Show("Solo se permiten letras o numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      			e.Handled = true;
      			return;
			}
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
	
		}

		}
	}

