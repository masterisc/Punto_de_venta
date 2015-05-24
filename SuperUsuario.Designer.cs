/*
 * Creado por SharpDevelop.
 * Usuario: FAMILIA
 * Fecha: 18/05/2015
 * Hora: 09:44 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace puntodeventa
{
	partial class SuperUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventarioTiendafisicoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventarioAlmacenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listaDeCajerosRegistradosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cambioDeContraseñaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cajeroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolStripMenuItem inventarioDeVentasToolStripMenuItem;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperUsuario));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventarioTiendafisicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventarioAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listaDeCajerosRegistradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventarioDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cambioDeContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.productoToolStripMenuItem,
			this.reporteToolStripMenuItem,
			this.soporteToolStripMenuItem,
			this.cajeroToolStripMenuItem,
			this.toolStripMenuItem1,
			this.administradorToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(364, 24);
			this.menuStrip1.TabIndex = 27;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// productoToolStripMenuItem
			// 
			this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.agregarToolStripMenuItem,
			this.editarToolStripMenuItem});
			this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
			this.productoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.productoToolStripMenuItem.Text = "Producto";
			this.productoToolStripMenuItem.Click += new System.EventHandler(this.ProductoToolStripMenuItemClick);
			// 
			// agregarToolStripMenuItem
			// 
			this.agregarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem.Image")));
			this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
			this.agregarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.agregarToolStripMenuItem.Text = "Agregar";
			this.agregarToolStripMenuItem.Click += new System.EventHandler(this.AgregarToolStripMenuItemClick);
			// 
			// editarToolStripMenuItem
			// 
			this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
			this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
			this.editarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.editarToolStripMenuItem.Text = "Editar";
			this.editarToolStripMenuItem.Click += new System.EventHandler(this.EditarToolStripMenuItemClick);
			// 
			// reporteToolStripMenuItem
			// 
			this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.inventarioTiendafisicoToolStripMenuItem,
			this.inventarioAlmacenToolStripMenuItem,
			this.listaDeCajerosRegistradosToolStripMenuItem,
			this.inventarioDeVentasToolStripMenuItem});
			this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
			this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.reporteToolStripMenuItem.Text = "Reporte";
			// 
			// inventarioTiendafisicoToolStripMenuItem
			// 
			this.inventarioTiendafisicoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventarioTiendafisicoToolStripMenuItem.Image")));
			this.inventarioTiendafisicoToolStripMenuItem.Name = "inventarioTiendafisicoToolStripMenuItem";
			this.inventarioTiendafisicoToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.inventarioTiendafisicoToolStripMenuItem.Text = "Inventario de tienda";
			// 
			// inventarioAlmacenToolStripMenuItem
			// 
			this.inventarioAlmacenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventarioAlmacenToolStripMenuItem.Image")));
			this.inventarioAlmacenToolStripMenuItem.Name = "inventarioAlmacenToolStripMenuItem";
			this.inventarioAlmacenToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.inventarioAlmacenToolStripMenuItem.Text = "Lista de administradores registrados";
			this.inventarioAlmacenToolStripMenuItem.Click += new System.EventHandler(this.InventarioAlmacenToolStripMenuItemClick);
			// 
			// listaDeCajerosRegistradosToolStripMenuItem
			// 
			this.listaDeCajerosRegistradosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaDeCajerosRegistradosToolStripMenuItem.Image")));
			this.listaDeCajerosRegistradosToolStripMenuItem.Name = "listaDeCajerosRegistradosToolStripMenuItem";
			this.listaDeCajerosRegistradosToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.listaDeCajerosRegistradosToolStripMenuItem.Text = "Lista de cajeros registrados";
			// 
			// inventarioDeVentasToolStripMenuItem
			// 
			this.inventarioDeVentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventarioDeVentasToolStripMenuItem.Image")));
			this.inventarioDeVentasToolStripMenuItem.Name = "inventarioDeVentasToolStripMenuItem";
			this.inventarioDeVentasToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.inventarioDeVentasToolStripMenuItem.Text = "Inventario de ventas";
			// 
			// soporteToolStripMenuItem
			// 
			this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cambioDeContraseñaToolStripMenuItem});
			this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
			this.soporteToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.soporteToolStripMenuItem.Text = "Contraseña";
			// 
			// cambioDeContraseñaToolStripMenuItem
			// 
			this.cambioDeContraseñaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cambioDeContraseñaToolStripMenuItem.Image")));
			this.cambioDeContraseñaToolStripMenuItem.Name = "cambioDeContraseñaToolStripMenuItem";
			this.cambioDeContraseñaToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.cambioDeContraseñaToolStripMenuItem.Text = "Cambio de contraseña (Usuario)";
			this.cambioDeContraseñaToolStripMenuItem.Click += new System.EventHandler(this.CambioDeContraseñaToolStripMenuItemClick);
			// 
			// cajeroToolStripMenuItem
			// 
			this.cajeroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.agregarToolStripMenuItem1,
			this.editarToolStripMenuItem1});
			this.cajeroToolStripMenuItem.Name = "cajeroToolStripMenuItem";
			this.cajeroToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.cajeroToolStripMenuItem.Text = "Cajero";
			// 
			// agregarToolStripMenuItem1
			// 
			this.agregarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem1.Image")));
			this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
			this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
			this.agregarToolStripMenuItem1.Text = "Agregar";
			this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.AgregarToolStripMenuItem1Click);
			// 
			// editarToolStripMenuItem1
			// 
			this.editarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem1.Image")));
			this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
			this.editarToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
			this.editarToolStripMenuItem1.Text = "Editar";
			this.editarToolStripMenuItem1.Click += new System.EventHandler(this.EditarToolStripMenuItem1Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItem2,
			this.toolStripMenuItem3});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(95, 20);
			this.toolStripMenuItem1.Text = "Administrador";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
			this.toolStripMenuItem2.Text = "Agregar";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(116, 22);
			this.toolStripMenuItem3.Text = "Editar";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3Click);
			// 
			// administradorToolStripMenuItem
			// 
			this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
			this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
			this.administradorToolStripMenuItem.Text = "Administrador";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(116, 66);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(126, 128);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(142, 219);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 54);
			this.button2.TabIndex = 25;
			this.button2.Text = "Cerrar Sesión";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// SuperUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(364, 309);
			this.ControlBox = false;
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(380, 348);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(380, 348);
			this.Name = "SuperUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Super Usuario";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
