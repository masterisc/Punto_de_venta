/*
 * Created by SharpDevelop.
 * User: Oscar
 * Date: 22/05/2015
 * Time: 11:22 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace puntodeventa
{
	partial class ModificarCajero
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button Guardar;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox checkBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarCajero));
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.Guardar = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(21, 147);
			this.textBox6.MaxLength = 20;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 20);
			this.textBox6.TabIndex = 44;
			this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3KeyPress);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(21, 131);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 43;
			this.label6.Text = "Sueldo:";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(374, 202);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 25);
			this.button1.TabIndex = 40;
			this.button1.Text = "Nueva foto";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(349, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(164, 168);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 39;
			this.pictureBox1.TabStop = false;
			// 
			// linkLabel1
			// 
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(184, 224);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(100, 23);
			this.linkLabel1.TabIndex = 38;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Ayuda";
			this.linkLabel1.Visible = false;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(21, 188);
			this.textBox4.MaxLength = 10;
			this.textBox4.Name = "textBox4";
			this.textBox4.PasswordChar = '●';
			this.textBox4.Size = new System.Drawing.Size(116, 20);
			this.textBox4.TabIndex = 37;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(21, 105);
			this.textBox3.MaxLength = 20;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(132, 20);
			this.textBox3.TabIndex = 36;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3KeyPress);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(20, 65);
			this.textBox2.MaxLength = 50;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(133, 20);
			this.textBox2.TabIndex = 35;
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2KeyPress);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(20, 27);
			this.textBox1.MaxLength = 100;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(306, 20);
			this.textBox1.TabIndex = 34;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(21, 170);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 23);
			this.label4.TabIndex = 33;
			this.label4.Text = "Antigua contraseña:";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(20, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 13);
			this.label3.TabIndex = 32;
			this.label3.Text = "Teléfono:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(20, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 31;
			this.label2.Text = "Dirección:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(20, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 30;
			this.label1.Text = "Nombre:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(218, 287);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 31);
			this.button2.TabIndex = 29;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Guardar
			// 
			this.Guardar.Location = new System.Drawing.Point(45, 287);
			this.Guardar.Name = "Guardar";
			this.Guardar.Size = new System.Drawing.Size(75, 31);
			this.Guardar.TabIndex = 28;
			this.Guardar.Text = "Modificar";
			this.Guardar.UseVisualStyleBackColor = true;
			this.Guardar.Click += new System.EventHandler(this.GuardarClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(38, 215);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 45;
			this.button3.Text = "Validar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(184, 147);
			this.textBox5.MaxLength = 10;
			this.textBox5.Name = "textBox5";
			this.textBox5.PasswordChar = '●';
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 46;
			this.textBox5.Visible = false;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(184, 187);
			this.textBox7.MaxLength = 10;
			this.textBox7.Name = "textBox7";
			this.textBox7.PasswordChar = '●';
			this.textBox7.Size = new System.Drawing.Size(100, 20);
			this.textBox7.TabIndex = 47;
			this.textBox7.Visible = false;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(184, 131);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 13);
			this.label5.TabIndex = 48;
			this.label5.Text = "Nueva contraseña:";
			this.label5.Visible = false;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(184, 170);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 14);
			this.label7.TabIndex = 49;
			this.label7.Text = "Confirmar:";
			this.label7.Visible = false;
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Location = new System.Drawing.Point(21, 247);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(157, 34);
			this.checkBox1.TabIndex = 50;
			this.checkBox1.Text = "¿Olvidó su contraseña?";
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// ModificarCajero
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(534, 326);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Guardar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(550, 365);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(550, 365);
			this.Name = "ModificarCajero";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modificar Cajero";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
