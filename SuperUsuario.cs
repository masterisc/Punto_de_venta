using System;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using MySql.Data.MySqlClient;

namespace puntodeventa
{

	public partial class SuperUsuario : Form
	{
		string usuario;
		public SuperUsuario(string usuario)
		{
			this.usuario = usuario;
			InitializeComponent();
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void ModCajero(object sender, EventArgs e)
		{
			
		}
		void ModAdmin(object sender, EventArgs e)
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
				SuperUsuario frm5 = new SuperUsuario(this.usuario);
				this.Hide();
				frm5.Show();
			}
		}
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			
		}
		void SuperUsuarioLoad(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void AgregarToolStripMenuItem1Click(object sender, EventArgs e)
		{
				AgregarCajero Acajero = new AgregarCajero();
				Acajero.Owner = this;
				Acajero.ShowDialog();
		}
		void ToolStripMenuItem2Click(object sender, EventArgs e)
		{
				AgregarAdmin Aadmin = new AgregarAdmin();
				Aadmin.Owner = this;
				Aadmin.ShowDialog();
		}
		void EditarToolStripMenuItem1Click(object sender, EventArgs e)
		{
				Editacajero Edcajero = new Editacajero();
				Edcajero.Owner = this;
				Edcajero.ShowDialog();
		}
		void ProductoToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void AgregarToolStripMenuItemClick(object sender, EventArgs e)
		{
			AProducto agregaproducto = new AProducto();
			agregaproducto.Owner = this;
			agregaproducto.ShowDialog();
		}
		void EditarToolStripMenuItemClick(object sender, EventArgs e)
		{
			MostrarProductos mostrarProductos = new MostrarProductos();
			mostrarProductos.Owner = this;
			mostrarProductos.ShowDialog();
		}
		void ToolStripMenuItem3Click(object sender, EventArgs e)
		{
			EditaAdmin editaadministrador = new	EditaAdmin();
			editaadministrador.Owner = this;
			editaadministrador.ShowDialog();
		}
		void CambioDeContraseñaToolStripMenuItemClick(object sender, EventArgs e)
		{
			ContraSuper passSuper = new ContraSuper(this.usuario);
			passSuper.Owner = this;
			passSuper.ShowDialog();
		}
		void InventarioAlmacenToolStripMenuItemClick(object sender, EventArgs e)
		{
			Document document = new Document(PageSize.LETTER);
			PdfWriter.GetInstance(document, new FileStream("Administradores.pdf", FileMode.OpenOrCreate));
			document.Open();
			
			LoginMySql mostrar = new LoginMySql();
			MySqlDataReader reader = mostrar.mostrarAdministradores();
			document.AddAuthor("Eduardo y Oscar");
			document.AddCreator("Punto de venta Carniceria");
			document.Add(new  Paragraph("Administradores"));
			while(reader.Read())
			{
				string nombre = reader.GetValue(0).ToString();
				string password = reader.GetValue(1).ToString();
				string sueldo = reader.GetValue(2).ToString();
				string direccion = reader.GetValue(3).ToString();
				string telefono = reader.GetValue(4).ToString();
				
				document.Add(new Paragraph(nombre + " - " + password + " - " + sueldo + " - " + direccion + " - " + telefono));
			}
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = "C:\\Users\\Cheyenne\\Desktop\\Proyecto\\puntodeventa\\bin\\Debug\\Administradores.pdf";
			proc.Start();
			proc.Close();
			document.Close();
		}
	}
}
