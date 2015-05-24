using System;
using System.Drawing;
using System.Windows.Forms;

namespace puntodeventa
{

	public partial class Admin : Form
	{
		string usuario;
		public Admin(string usuario)
		{
			this.usuario = usuario;
			InitializeComponent();
			this.inicializarImagen();
		}
		void inicializarImagen()
		{
			LoginMySql iniciar = new LoginMySql();
			pictureBox2.Image = iniciar.mostrarImagenUsuario(usuario);	
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Realmente quieres cerrar sesión?", "AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
				
				MainForm frm1 = new MainForm();
				this.Hide();
				frm1.Show();
			}
			else{
				Admin frm = new Admin(this.usuario);
				this.Hide();
				frm.Show();
			}
		}
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			
		}
		void AgregarToolStripMenuItemClick(object sender, EventArgs e)
		{
				AProducto agregarproducto = new AProducto();
				agregarproducto.Owner = this;
				agregarproducto.ShowDialog();
			
		}
		void EditarToolStripMenuItemClick(object sender, EventArgs e)
		{
			MostrarProductos mostrarProductos = new MostrarProductos();
			mostrarProductos.Owner = this;
			mostrarProductos.ShowDialog();
		}
		void AgregarToolStripMenuItem1Click(object sender, EventArgs e)
		{
				AgregarCajero Acajero = new AgregarCajero();
				Acajero.Owner = this;
				Acajero.ShowDialog();
		}
		void EditarToolStripMenuItem1Click(object sender, EventArgs e)
		{
				Editacajero Ecajero = new Editacajero();
				Ecajero.Owner = this;
				Ecajero.ShowDialog();
		}
		void InventarioAlmacenToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void AdminFormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Realmente quieres cerrar sesion?", "AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
				
				MainForm frm1 = new MainForm();
				this.Hide();
				frm1.Show();
			}
			else{
				Admin frm = new Admin(this.usuario);
				this.Hide();
				frm.Show();
			}
		}
		void CambioDeContraseñaToolStripMenuItemClick(object sender, EventArgs e)
		{
			ContraAdmin passAdmin = new ContraAdmin(this.usuario);
			passAdmin.Owner = this;
			passAdmin.ShowDialog();
		}
	}
}
