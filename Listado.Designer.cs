namespace Derecho
{
	partial class Listado
	{
		/// <summary> 
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitMain = new System.Windows.Forms.SplitContainer();
			this.lstMain = new System.Windows.Forms.ListView();
			this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
			this.splitMain.Panel1.SuspendLayout();
			this.splitMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitMain
			// 
			this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitMain.Location = new System.Drawing.Point(0, 0);
			this.splitMain.Name = "splitMain";
			// 
			// splitMain.Panel1
			// 
			this.splitMain.Panel1.Controls.Add(this.lstMain);
			this.splitMain.Size = new System.Drawing.Size(962, 609);
			this.splitMain.SplitterDistance = 670;
			this.splitMain.TabIndex = 0;
			// 
			// lstMain
			// 
			this.lstMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNombre,
            this.colDescripcion});
			this.lstMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstMain.Location = new System.Drawing.Point(0, 0);
			this.lstMain.Name = "lstMain";
			this.lstMain.Size = new System.Drawing.Size(670, 609);
			this.lstMain.TabIndex = 0;
			this.lstMain.UseCompatibleStateImageBehavior = false;
			this.lstMain.View = System.Windows.Forms.View.Details;
			this.lstMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMain_MouseDoubleClick);
			// 
			// colNombre
			// 
			this.colNombre.Text = "Nombre";
			this.colNombre.Width = 181;
			// 
			// colDescripcion
			// 
			this.colDescripcion.Text = "Descripción";
			this.colDescripcion.Width = 475;
			// 
			// Listado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitMain);
			this.Name = "Listado";
			this.Size = new System.Drawing.Size(962, 609);
			this.splitMain.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
			this.splitMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitMain;
		private System.Windows.Forms.ListView lstMain;
		private System.Windows.Forms.ColumnHeader colNombre;
		private System.Windows.Forms.ColumnHeader colDescripcion;
	}
}
