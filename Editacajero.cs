using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace puntodeventa
{

	public partial class Editacajero : Form
	{
		public Editacajero()
		{
			InitializeComponent();
		}
		void Button4Click(object sender, EventArgs e)
		{
			this.Hide();
		}
		void Button3Click(object sender, EventArgs e)
		{
			if(this.dataGridView1.RowCount == 0)
			{
				MessageBox.Show("             Tabla vacia"+"\nIntentá con el boton Mostrar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else{
				ModificarCajero editCajero = new ModificarCajero(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
				editCajero.Owner = this;
				editCajero.ShowDialog();
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Datos();
		}
		public void Datos()
		{
			LoginMySql mostrar = new LoginMySql();
			MySqlDataReader reader = mostrar.mostrarCajeros();
			this.dataGridView1.Rows.Clear();
			while(reader.Read())
			{
				LoginMySql image = new LoginMySql();
				Image imagen = image.mostrarImagenUsuario(reader.GetValue(0).ToString());
            	this.dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3),reader.GetValue(4), imagen);
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			if((MessageBox.Show("Quieres borrar el Cajero?", "AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) && this.dataGridView1.RowCount > 0)
			{
				LoginMySql borrar = new LoginMySql();
				borrar.EliminarUsuario(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
				MessageBox.Show("Cajero eliminado");
				this.Datos();
			}
		}
	}
}
