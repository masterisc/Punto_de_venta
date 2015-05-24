using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace puntodeventa
{
	public partial class Cajero : Form
	{
		string usuario;
		float total;
		
		public Cajero(string usuario)
		{
			this.total = 0;
			this.usuario = usuario;
			InitializeComponent();
			timer1.Enabled = true;
			this.inicializarCajero();
		}
		void inicializarCajero()
		{
			LoginMySql nombre = new LoginMySql();
			label2.Text = "Cajero: " + nombre.mostrarNombreUsuario(this.usuario);
			label4.Text = "";
		}
		void IdProducto(object sender, EventArgs e)
		{
			
		}
		void CerrarSesion(object sender, EventArgs e)
		{
			if (MessageBox.Show("Realmente quieres cerrar sesion?", "AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) 
			{
				label4.Text = "";
				label4.Text = "";
				label4.Text = "";
				MainForm frm1 = new MainForm();
				this.Hide();
				frm1.Show();
			}
		}
		void BotonPago(object sender, EventArgs e)
		{
			this.dataGridView1.Rows.Clear();
			label4.Text = "";
			label7.Text = "";
			label8.Text = "";
		}
		void CancelarVenta(object sender, EventArgs e)
		{
			if(MessageBox.Show("Desea cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.dataGridView1.Rows.Clear();
				label4.Text = "";
				label7.Text = "";
				label8.Text = "";		
			}
		}
		void ListaCompra(object sender, EventArgs e)
		{
	
		}
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
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
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			LFecha.Text = DateTime.Now.ToString();
		}
		void LFechaClick(object sender, EventArgs e)
		{
			
		}
		void CajeroLoad(object sender, EventArgs e)
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
		void Button4Click(object sender, EventArgs e)
		{
			LoginMySql buscar = new LoginMySql();
			MySqlDataReader reader = buscar.buscarProductoPorId(textBox2.Text.Trim());
			CantidadProducto cant = new CantidadProducto();
			cant.Owner = this;
			cant.ShowDialog();
			int cantidad = cant.Cantidad();
			while(reader.Read())
			{
            	this.dataGridView1.Rows.Add(reader.GetValue(0), cantidad, reader.GetValue(1), reader.GetValue(2));
            	this.total += ((Convert.ToSingle(reader.GetValue(2))) * cantidad);
                label4.Text = total.ToString();
                label7.Text = (total*0.16).ToString();
                label8.Text = (total+(total*0.16)).ToString();
			}
			textBox2.Text = "";
		}
	}
}
