namespace Derecho
{
	partial class Editor
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
			this.tbTexto = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gbEdicion = new System.Windows.Forms.GroupBox();
			this.bReemplazar = new System.Windows.Forms.Button();
			this.bBuscar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbReemplazar = new System.Windows.Forms.TextBox();
			this.tbBuscar = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
			this.splitMain.Panel1.SuspendLayout();
			this.splitMain.Panel2.SuspendLayout();
			this.splitMain.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gbEdicion.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitMain
			// 
			this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitMain.Location = new System.Drawing.Point(0, 0);
			this.splitMain.Name = "splitMain";
			// 
			// splitMain.Panel1
			// 
			this.splitMain.Panel1.Controls.Add(this.tbTexto);
			// 
			// splitMain.Panel2
			// 
			this.splitMain.Panel2.Controls.Add(this.panel1);
			this.splitMain.Size = new System.Drawing.Size(898, 530);
			this.splitMain.SplitterDistance = 661;
			this.splitMain.TabIndex = 0;
			// 
			// tbTexto
			// 
			this.tbTexto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbTexto.Location = new System.Drawing.Point(0, 0);
			this.tbTexto.Multiline = true;
			this.tbTexto.Name = "tbTexto";
			this.tbTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbTexto.Size = new System.Drawing.Size(661, 530);
			this.tbTexto.TabIndex = 0;
			this.tbTexto.WordWrap = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.gbEdicion);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(233, 530);
			this.panel1.TabIndex = 0;
			// 
			// gbEdicion
			// 
			this.gbEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbEdicion.Controls.Add(this.bReemplazar);
			this.gbEdicion.Controls.Add(this.bBuscar);
			this.gbEdicion.Controls.Add(this.label2);
			this.gbEdicion.Controls.Add(this.label1);
			this.gbEdicion.Controls.Add(this.tbReemplazar);
			this.gbEdicion.Controls.Add(this.tbBuscar);
			this.gbEdicion.Location = new System.Drawing.Point(3, 3);
			this.gbEdicion.Name = "gbEdicion";
			this.gbEdicion.Size = new System.Drawing.Size(227, 143);
			this.gbEdicion.TabIndex = 0;
			this.gbEdicion.TabStop = false;
			this.gbEdicion.Text = "Buscar y Reemplazar";
			// 
			// bReemplazar
			// 
			this.bReemplazar.Location = new System.Drawing.Point(145, 110);
			this.bReemplazar.Name = "bReemplazar";
			this.bReemplazar.Size = new System.Drawing.Size(76, 23);
			this.bReemplazar.TabIndex = 2;
			this.bReemplazar.Text = "Reemplazar";
			this.bReemplazar.UseVisualStyleBackColor = true;
			this.bReemplazar.Click += new System.EventHandler(this.bReemplazar_Click);
			// 
			// bBuscar
			// 
			this.bBuscar.Location = new System.Drawing.Point(6, 110);
			this.bBuscar.Name = "bBuscar";
			this.bBuscar.Size = new System.Drawing.Size(63, 23);
			this.bBuscar.TabIndex = 2;
			this.bBuscar.Text = "Buscar";
			this.bBuscar.UseVisualStyleBackColor = true;
			this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Reemplazar";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Buscar";
			// 
			// tbReemplazar
			// 
			this.tbReemplazar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbReemplazar.Location = new System.Drawing.Point(6, 84);
			this.tbReemplazar.Name = "tbReemplazar";
			this.tbReemplazar.Size = new System.Drawing.Size(215, 20);
			this.tbReemplazar.TabIndex = 0;
			// 
			// tbBuscar
			// 
			this.tbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbBuscar.Location = new System.Drawing.Point(6, 45);
			this.tbBuscar.Name = "tbBuscar";
			this.tbBuscar.Size = new System.Drawing.Size(215, 20);
			this.tbBuscar.TabIndex = 0;
			// 
			// Editor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitMain);
			this.Name = "Editor";
			this.Size = new System.Drawing.Size(898, 530);
			this.splitMain.Panel1.ResumeLayout(false);
			this.splitMain.Panel1.PerformLayout();
			this.splitMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
			this.splitMain.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.gbEdicion.ResumeLayout(false);
			this.gbEdicion.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitMain;
		private System.Windows.Forms.TextBox tbTexto;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox gbEdicion;
		private System.Windows.Forms.Button bReemplazar;
		private System.Windows.Forms.Button bBuscar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbReemplazar;
		private System.Windows.Forms.TextBox tbBuscar;
	}
}
