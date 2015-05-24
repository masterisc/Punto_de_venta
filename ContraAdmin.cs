using System;
using System.Drawing;
using System.Windows.Forms;

namespace puntodeventa
{
	public partial class ContraAdmin : Form
	{
		string usuario;
		public ContraAdmin(string usuario)
		{
			this.usuario = usuario;
			InitializeComponent();
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(String.Compare(textBox1.Text.Trim(),textBox2.Text.Trim()) != 0)
			{
				MessageBox.Show("No coinciden las contraseñas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		 		textBox1.Focus();
			}
			else
			{
				LoginMySql pass = new LoginMySql();
				Hash hash = new Hash();
				pass.actualizarContraU(this.usuario, hash.GetMd5Hash(textBox1.Text.Trim()));
				MessageBox.Show("Contraseña modificada");
				this.Hide();
			}
		}
	}
}
