using System;
using System.Drawing;
using System.Windows.Forms;

namespace puntodeventa
{

	public partial class Load : Form
	{
		public Load()
		{
	
			InitializeComponent();

		}
		void Timer1Tick(object sender, EventArgs e)
		{
			this.Hide();
            MainForm pri = new MainForm();
            pri.Show();
            timer1.Stop();
		}
		void LoadLoad(object sender, EventArgs e)
		{
	
		}
	}
}
