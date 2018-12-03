namespace Derecho
{
	partial class FrmMain
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

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.statBarra = new System.Windows.Forms.StatusStrip();
			this.statMensaje = new System.Windows.Forms.ToolStripStatusLabel();
			this.TABs = new System.Windows.Forms.TabControl();
			this.tpMain = new System.Windows.Forms.TabPage();
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.erwinXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dLLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.archivoActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.portapapelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.statBarra.SuspendLayout();
			this.TABs.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statBarra);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.TABs);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 404);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
			// 
			// statBarra
			// 
			this.statBarra.Dock = System.Windows.Forms.DockStyle.None;
			this.statBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statMensaje});
			this.statBarra.Location = new System.Drawing.Point(0, 0);
			this.statBarra.Name = "statBarra";
			this.statBarra.Size = new System.Drawing.Size(800, 22);
			this.statBarra.TabIndex = 0;
			// 
			// statMensaje
			// 
			this.statMensaje.Name = "statMensaje";
			this.statMensaje.Size = new System.Drawing.Size(66, 17);
			this.statMensaje.Text = "Bienvenido";
			// 
			// TABs
			// 
			this.TABs.Controls.Add(this.tpMain);
			this.TABs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TABs.ImageList = this.imgList;
			this.TABs.Location = new System.Drawing.Point(0, 0);
			this.TABs.Name = "TABs";
			this.TABs.SelectedIndex = 0;
			this.TABs.Size = new System.Drawing.Size(800, 404);
			this.TABs.TabIndex = 0;
			// 
			// tpMain
			// 
			this.tpMain.ImageKey = "Codigo";
			this.tpMain.Location = new System.Drawing.Point(4, 39);
			this.tpMain.Name = "tpMain";
			this.tpMain.Padding = new System.Windows.Forms.Padding(3);
			this.tpMain.Size = new System.Drawing.Size(792, 361);
			this.tpMain.TabIndex = 0;
			this.tpMain.Text = "Principal";
			this.tpMain.UseVisualStyleBackColor = true;
			// 
			// imgList
			// 
			this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList.Images.SetKeyName(0, "Codigo");
			this.imgList.Images.SetKeyName(1, "Exportar");
			this.imgList.Images.SetKeyName(2, "Importar");
			this.imgList.Images.SetKeyName(3, "Salir");
			this.imgList.Images.SetKeyName(4, "CSharp");
			this.imgList.Images.SetKeyName(5, "DLL");
			this.imgList.Images.SetKeyName(6, "Oracle");
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.xToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// importarToolStripMenuItem
			// 
			this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erwinXMLToolStripMenuItem,
            this.dLLToolStripMenuItem});
			this.importarToolStripMenuItem.Image = global::Derecho.Recursos.Importar;
			this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
			this.importarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.importarToolStripMenuItem.Text = "Importar";
			// 
			// erwinXMLToolStripMenuItem
			// 
			this.erwinXMLToolStripMenuItem.Image = global::Derecho.Recursos.ERWin;
			this.erwinXMLToolStripMenuItem.Name = "erwinXMLToolStripMenuItem";
			this.erwinXMLToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.erwinXMLToolStripMenuItem.Text = "Erwin XML";
			this.erwinXMLToolStripMenuItem.Click += new System.EventHandler(this.erwinXMLToolStripMenuItem_Click);
			// 
			// dLLToolStripMenuItem
			// 
			this.dLLToolStripMenuItem.Image = global::Derecho.Recursos.DLL;
			this.dLLToolStripMenuItem.Name = "dLLToolStripMenuItem";
			this.dLLToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.dLLToolStripMenuItem.Text = "DLL";
			this.dLLToolStripMenuItem.Click += new System.EventHandler(this.dllToolStripMenuItem_Click);
			// 
			// exportarToolStripMenuItem
			// 
			this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoActualToolStripMenuItem,
            this.archivosToolStripMenuItem,
            this.portapapelesToolStripMenuItem});
			this.exportarToolStripMenuItem.Image = global::Derecho.Recursos.Exportar;
			this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
			this.exportarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exportarToolStripMenuItem.Text = "Exportar";
			// 
			// archivoActualToolStripMenuItem
			// 
			this.archivoActualToolStripMenuItem.Image = global::Derecho.Recursos.Archivo;
			this.archivoActualToolStripMenuItem.Name = "archivoActualToolStripMenuItem";
			this.archivoActualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.archivoActualToolStripMenuItem.Text = "Archivo Actual";
			this.archivoActualToolStripMenuItem.Click += new System.EventHandler(this.archivoActualToolStripMenuItem_Click);
			// 
			// archivosToolStripMenuItem
			// 
			this.archivosToolStripMenuItem.Image = global::Derecho.Recursos.Archivos;
			this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
			this.archivosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.archivosToolStripMenuItem.Text = "Todos los Archivos";
			this.archivosToolStripMenuItem.Click += new System.EventHandler(this.archivosToolStripMenuItem_Click);
			// 
			// portapapelesToolStripMenuItem
			// 
			this.portapapelesToolStripMenuItem.Image = global::Derecho.Recursos.Clipboard;
			this.portapapelesToolStripMenuItem.Name = "portapapelesToolStripMenuItem";
			this.portapapelesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
			this.portapapelesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
			this.portapapelesToolStripMenuItem.Text = "Portapapeles";
			this.portapapelesToolStripMenuItem.Click += new System.EventHandler(this.portapapelesToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Image = global::Derecho.Recursos.Salir;
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			// 
			// xToolStripMenuItem
			// 
			this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.xToolStripMenuItem.Image = global::Derecho.Recursos.Cerrar;
			this.xToolStripMenuItem.Name = "xToolStripMenuItem";
			this.xToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
			this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStripContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmMain";
			this.Text = "Derecho";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.statBarra.ResumeLayout(false);
			this.statBarra.PerformLayout();
			this.TABs.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.StatusStrip statBarra;
		private System.Windows.Forms.ToolStripStatusLabel statMensaje;
		private System.Windows.Forms.TabControl TABs;
		private System.Windows.Forms.TabPage tpMain;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem erwinXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ImageList imgList;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dLLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem portapapelesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoActualToolStripMenuItem;
	}
}

