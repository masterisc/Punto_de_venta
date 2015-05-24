using System;
using System.Drawing;
using System.Windows.Forms;

namespace puntodeventa
{
	public partial class CantidadProducto : Form
	{
		int cantidad;
		
		public CantidadProducto()
		{
			InitializeComponent();
		}
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)  && e.KeyChar != '.')
			{
      			MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      			e.Handled = true;
      			return;
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			cantidad = int.Parse(textBox1.Text.Trim());
			this.Hide();
		}
		public int Cantidad()
		{
			return this.cantidad;
		}
	}
}
