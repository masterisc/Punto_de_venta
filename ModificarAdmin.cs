using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace puntodeventa
{
	public partial class ModificarAdmin : Form
	{
		string dir;
		byte[] byteArray;
		string id;
		bool imagen;
		string contra;
		bool pass;
		
		public ModificarAdmin(string primary)
		{
			InitializeComponent();
			dir = "";
			id = primary;
			imagen = false;
			pass = false;
			this.inicializarComponentes();
		}
		void inicializarComponentes()
		{
			LoginMySql iniciar = new LoginMySql();
			textBox1.Text = iniciar.mostrarNombreUsuario(id);
			textBox2.Text = iniciar.mostrarDirUsuario(id);
			textBox3.Text = iniciar.mostrarTelUsuario(id);
			textBox6.Text = iniciar.mostrarSueldoUsuario(id);
			this.contra = iniciar.mostarContraUsuario(id);
			pictureBox1.Image = iniciar.mostrarImagenUsuario(id);
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("La clave tiene que ser alfanumérica" + "\n" + "con un mínimo de 5 dígitos y máximo 10 dígitos", "AYUDA CLAVE");
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
		void TextBox3KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != '.')
			{
      			MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      			e.Handled = true;
      			return;
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			this.ValidarContra();
		}
		void ValidarContra()
		{
			string validar = textBox4.Text.Trim();
			Hash pass = new Hash();
			validar = pass.GetMd5Hash(validar);
			StringComparer comparer = StringComparer.OrdinalIgnoreCase;
			if(0 == comparer.Compare(validar, contra))
			{
				//MessageBox.Show("Coinciden");
				this.pass = true;
				label5.Visible = true;
				textBox5.Visible = true;
				label7.Visible = true;
				textBox7.Visible = true;
				linkLabel1.Visible = true;
			}
			else
			{
				this.pass = false;
				label5.Visible = false;
				textBox5.Visible = false;
				label7.Visible = false;
				textBox7.Visible = false;
				linkLabel1.Visible = false;
			}
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if(checkBox1.Checked)
			{
				this.pass = true;
				label4.Visible = false;
				textBox4.Visible = false;
				button3.Visible = false;
				label5.Visible = true;
				textBox5.Visible = true;
				label7.Visible = true;
				textBox7.Visible = true;
				linkLabel1.Visible = true;
			}
			else
			{
				this.pass = true;
				label4.Visible = true;
				textBox4.Visible = true;
				button3.Visible = true;
				label5.Visible = false;
				textBox5.Visible = false;
				label7.Visible = false;
				textBox7.Visible = false;
				linkLabel1.Visible = false;
			}
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
                imagen = true;
				this.dir = Path.GetFullPath(open.FileName).Replace(@"\", @"\\");
			}
		}
		void GuardarClick(object sender, EventArgs e)
		{
			if(textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox6.Text == "")
			{
				MessageBox.Show("Campos vacios!!!","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				textBox1.Focus();
			}
			else 
				if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "")
				{
					MessageBox.Show("Faltan campos!!!","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					textBox1.Focus();
				}
				else
					if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox6.Text.Length > 0)
					{	
						if((String.Compare(textBox5.Text.Trim(),textBox7.Text.Trim()) != 0) && pass)
						{
					   		MessageBox.Show("No coinciden las contraseñas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					   		textBox5.Focus();
						}
				        else
				        	this.guardarAdmin();
					}
			return;
		}
		void guardarAdmin()
		{
			string nombre = textBox1.Text.Trim();
			string password = textBox5.Text.Trim();
			Hash pass = new Hash();
			password = pass.GetMd5Hash(password);
			float sueldo;
			if(textBox6.Text.Trim().Length == 0)
				sueldo = 0;
			else sueldo = Convert.ToSingle(textBox6.Text.Trim());
			string dirección = textBox2.Text.Trim();
			string teléfono = textBox3.Text.Trim();
			//guardar en base de datos
			LoginMySql insertar = new LoginMySql();				
			insertar.actualizarNombreU(id, nombre);
			insertar.actualizarDirU(id, dirección);
			insertar.actualizarTelU(id, teléfono);
			insertar.actualizarSueldoU(id, sueldo);
			if(this.pass)
			{
				insertar.actualizarContraU(id, password);	
			}
			if(this.imagen)
			{
				insertar.actualizarImagenUsuario(id, this.byteArray);
			}
			MessageBox.Show("Administrador editado");
			this.Hide();
		}
		void TextBox7TextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
