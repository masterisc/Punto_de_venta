using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace puntodeventa
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			textBox2.PasswordChar = '●';
			textBox2.MaxLength = 10;
			comboBox1.SelectedIndex = 0;
		}
		
		void Usuario(object sender, EventArgs e)
		{ 		
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Desea salir?", "AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) 
			{
				Application.Exit();
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
	
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.ValidacionUsuario();			
		}
		void ValidacionUsuario()
		{
			string query = "";
			string usuario = textBox1.Text.Trim();
			string password = textBox2.Text.Trim();
			string tipo = comboBox1.Text;
			Hash hash = new Hash();
			password = hash.GetMd5Hash(password); 
			LoginMySql consulta = new LoginMySql();
			query = consulta.queryUsuario(usuario, password, tipo);
			if(query.Length == 0)
			{
				MessageBox.Show("Datos incorrectos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				textBox1.Focus();
			}
			if(query.Length > 0 && tipo == "Administrador")
			{
				Admin frm3 = new Admin(query);
    			frm3.Show();
    			this.Hide();
			}
			if(query.Length > 0 && tipo == "Cajero"){
				Cajero frm = new Cajero(query);
				frm.Show();
				this.Hide();
			}
			if(query.Length > 0 && tipo == "Soporte tecnico") {
				SuperUsuario frm2 = new SuperUsuario(query);
    			frm2.Show();
    			this.Hide();
				
			}
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void OlvidoContraseña(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Contacta a tu administrador", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
			textBox2.Focus();
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void ToolStripMenuItem4Click(object sender, EventArgs e)
		{
				MessageBox.Show("\t\tAutores: \n\t    Eduardo Mora Martínez\t\n\tOscar Alfredo Flores Solano\t\n\t    www.ejemplo.com.mx\t","INFORMACION GENERAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
				textBox1.Focus();
		}
		void ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			System.Environment.Exit(0);
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
				
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
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
	
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			System.Environment.Exit(0);
		}
	}
}

