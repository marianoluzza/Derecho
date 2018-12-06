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
			this.pestañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarOtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarALaDerechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarALaIzquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripCBTabs = new System.Windows.Forms.ToolStripComboBox();
			this.pLSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbClsStartRm = new System.Windows.Forms.TextBox();
			this.tbClsStartAdd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbTblStartAdd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbTblStartRm = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.chbCamelCaseTabla = new System.Windows.Forms.CheckBox();
			this.tbCamelCaseSepActTbl = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbCamelCaseSepNvoTbl = new System.Windows.Forms.TextBox();
			this.tbCamelCaseSepNvoCls = new System.Windows.Forms.TextBox();
			this.tbCamelCaseSepActCls = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.chbCamelCaseClase = new System.Windows.Forms.CheckBox();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.statBarra.SuspendLayout();
			this.TABs.SuspendLayout();
			this.tpMain.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
			this.tpMain.Controls.Add(this.groupBox1);
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
            this.xToolStripMenuItem,
            this.pestañaToolStripMenuItem});
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
            this.dLLToolStripMenuItem,
            this.pLSQLToolStripMenuItem});
			this.importarToolStripMenuItem.Image = global::Derecho.Recursos.Importar;
			this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
			this.importarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.importarToolStripMenuItem.Text = "Importar";
			// 
			// erwinXMLToolStripMenuItem
			// 
			this.erwinXMLToolStripMenuItem.Image = global::Derecho.Recursos.ERWin;
			this.erwinXMLToolStripMenuItem.Name = "erwinXMLToolStripMenuItem";
			this.erwinXMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.erwinXMLToolStripMenuItem.Text = "Erwin XML";
			this.erwinXMLToolStripMenuItem.Click += new System.EventHandler(this.erwinXMLToolStripMenuItem_Click);
			// 
			// dLLToolStripMenuItem
			// 
			this.dLLToolStripMenuItem.Image = global::Derecho.Recursos.DLL;
			this.dLLToolStripMenuItem.Name = "dLLToolStripMenuItem";
			this.dLLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
			this.archivoActualToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
			this.archivoActualToolStripMenuItem.Text = "Archivo Actual";
			this.archivoActualToolStripMenuItem.Click += new System.EventHandler(this.archivoActualToolStripMenuItem_Click);
			// 
			// archivosToolStripMenuItem
			// 
			this.archivosToolStripMenuItem.Image = global::Derecho.Recursos.Archivos;
			this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
			this.archivosToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
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
			// pestañaToolStripMenuItem
			// 
			this.pestañaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarActualToolStripMenuItem,
            this.cerrarOtrasToolStripMenuItem,
            this.cerrarALaDerechaToolStripMenuItem,
            this.cerrarALaIzquierdaToolStripMenuItem,
            this.cerrarTodasToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripCBTabs});
			this.pestañaToolStripMenuItem.Name = "pestañaToolStripMenuItem";
			this.pestañaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.pestañaToolStripMenuItem.Text = "Pestaña";
			// 
			// cerrarActualToolStripMenuItem
			// 
			this.cerrarActualToolStripMenuItem.Name = "cerrarActualToolStripMenuItem";
			this.cerrarActualToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.cerrarActualToolStripMenuItem.Text = "Cerrar actual";
			this.cerrarActualToolStripMenuItem.Click += new System.EventHandler(this.cerrarActualToolStripMenuItem_Click);
			// 
			// cerrarOtrasToolStripMenuItem
			// 
			this.cerrarOtrasToolStripMenuItem.Name = "cerrarOtrasToolStripMenuItem";
			this.cerrarOtrasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.cerrarOtrasToolStripMenuItem.Text = "Cerrar otras";
			this.cerrarOtrasToolStripMenuItem.Click += new System.EventHandler(this.cerrarOtrasToolStripMenuItem_Click);
			// 
			// cerrarALaDerechaToolStripMenuItem
			// 
			this.cerrarALaDerechaToolStripMenuItem.Name = "cerrarALaDerechaToolStripMenuItem";
			this.cerrarALaDerechaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.cerrarALaDerechaToolStripMenuItem.Text = "Cerrar a la derecha";
			this.cerrarALaDerechaToolStripMenuItem.Click += new System.EventHandler(this.cerrarALaDerechaToolStripMenuItem_Click);
			// 
			// cerrarALaIzquierdaToolStripMenuItem
			// 
			this.cerrarALaIzquierdaToolStripMenuItem.Name = "cerrarALaIzquierdaToolStripMenuItem";
			this.cerrarALaIzquierdaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.cerrarALaIzquierdaToolStripMenuItem.Text = "Cerrar a la izquierda";
			this.cerrarALaIzquierdaToolStripMenuItem.Click += new System.EventHandler(this.cerrarALaIzquierdaToolStripMenuItem_Click);
			// 
			// cerrarTodasToolStripMenuItem
			// 
			this.cerrarTodasToolStripMenuItem.Name = "cerrarTodasToolStripMenuItem";
			this.cerrarTodasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.cerrarTodasToolStripMenuItem.Text = "Cerrar todas";
			this.cerrarTodasToolStripMenuItem.Click += new System.EventHandler(this.cerrarTodasToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
			// 
			// toolStripCBTabs
			// 
			this.toolStripCBTabs.Name = "toolStripCBTabs";
			this.toolStripCBTabs.Size = new System.Drawing.Size(121, 23);
			// 
			// pLSQLToolStripMenuItem
			// 
			this.pLSQLToolStripMenuItem.Name = "pLSQLToolStripMenuItem";
			this.pLSQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.pLSQLToolStripMenuItem.Text = "PL-SQL";
			this.pLSQLToolStripMenuItem.Click += new System.EventHandler(this.pLSQLToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbCamelCaseSepNvoCls);
			this.groupBox1.Controls.Add(this.tbCamelCaseSepActCls);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.chbCamelCaseClase);
			this.groupBox1.Controls.Add(this.tbCamelCaseSepNvoTbl);
			this.groupBox1.Controls.Add(this.tbCamelCaseSepActTbl);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.chbCamelCaseTabla);
			this.groupBox1.Controls.Add(this.tbTblStartAdd);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbTblStartRm);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.tbClsStartAdd);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbClsStartRm);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(325, 219);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Convención de Nombres";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Remover Principio Clase";
			// 
			// tbClsStartRm
			// 
			this.tbClsStartRm.Location = new System.Drawing.Point(6, 46);
			this.tbClsStartRm.Name = "tbClsStartRm";
			this.tbClsStartRm.Size = new System.Drawing.Size(122, 20);
			this.tbClsStartRm.TabIndex = 1;
			// 
			// tbClsStartAdd
			// 
			this.tbClsStartAdd.Location = new System.Drawing.Point(148, 46);
			this.tbClsStartAdd.Name = "tbClsStartAdd";
			this.tbClsStartAdd.Size = new System.Drawing.Size(122, 20);
			this.tbClsStartAdd.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(148, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Añadir Principio Clase";
			// 
			// tbTblStartAdd
			// 
			this.tbTblStartAdd.Location = new System.Drawing.Point(148, 89);
			this.tbTblStartAdd.Name = "tbTblStartAdd";
			this.tbTblStartAdd.Size = new System.Drawing.Size(122, 20);
			this.tbTblStartAdd.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(148, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Añadir Principio Tabla";
			// 
			// tbTblStartRm
			// 
			this.tbTblStartRm.Location = new System.Drawing.Point(6, 89);
			this.tbTblStartRm.Name = "tbTblStartRm";
			this.tbTblStartRm.Size = new System.Drawing.Size(122, 20);
			this.tbTblStartRm.TabIndex = 5;
			this.tbTblStartRm.Text = "T_";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Remover Principio Tabla";
			// 
			// chbCamelCaseTabla
			// 
			this.chbCamelCaseTabla.AutoSize = true;
			this.chbCamelCaseTabla.Checked = true;
			this.chbCamelCaseTabla.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbCamelCaseTabla.Location = new System.Drawing.Point(6, 134);
			this.chbCamelCaseTabla.Name = "chbCamelCaseTabla";
			this.chbCamelCaseTabla.Size = new System.Drawing.Size(115, 17);
			this.chbCamelCaseTabla.TabIndex = 8;
			this.chbCamelCaseTabla.Text = "CamelCase Tabla?";
			this.chbCamelCaseTabla.UseVisualStyleBackColor = true;
			// 
			// tbCamelCaseSepActTbl
			// 
			this.tbCamelCaseSepActTbl.Location = new System.Drawing.Point(148, 132);
			this.tbCamelCaseSepActTbl.Name = "tbCamelCaseSepActTbl";
			this.tbCamelCaseSepActTbl.Size = new System.Drawing.Size(42, 20);
			this.tbCamelCaseSepActTbl.TabIndex = 10;
			this.tbCamelCaseSepActTbl.Text = "_";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(148, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(132, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Separador Actual / Nuevo";
			// 
			// tbCamelCaseSepNvoTbl
			// 
			this.tbCamelCaseSepNvoTbl.Location = new System.Drawing.Point(228, 132);
			this.tbCamelCaseSepNvoTbl.Name = "tbCamelCaseSepNvoTbl";
			this.tbCamelCaseSepNvoTbl.Size = new System.Drawing.Size(42, 20);
			this.tbCamelCaseSepNvoTbl.TabIndex = 11;
			// 
			// tbCamelCaseSepNvoCls
			// 
			this.tbCamelCaseSepNvoCls.Location = new System.Drawing.Point(228, 174);
			this.tbCamelCaseSepNvoCls.Name = "tbCamelCaseSepNvoCls";
			this.tbCamelCaseSepNvoCls.Size = new System.Drawing.Size(42, 20);
			this.tbCamelCaseSepNvoCls.TabIndex = 15;
			// 
			// tbCamelCaseSepActCls
			// 
			this.tbCamelCaseSepActCls.Location = new System.Drawing.Point(148, 174);
			this.tbCamelCaseSepActCls.Name = "tbCamelCaseSepActCls";
			this.tbCamelCaseSepActCls.Size = new System.Drawing.Size(42, 20);
			this.tbCamelCaseSepActCls.TabIndex = 14;
			this.tbCamelCaseSepActCls.Text = "_";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(148, 158);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(132, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Separador Actual / Nuevo";
			// 
			// chbCamelCaseClase
			// 
			this.chbCamelCaseClase.AutoSize = true;
			this.chbCamelCaseClase.Checked = true;
			this.chbCamelCaseClase.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbCamelCaseClase.Location = new System.Drawing.Point(6, 176);
			this.chbCamelCaseClase.Name = "chbCamelCaseClase";
			this.chbCamelCaseClase.Size = new System.Drawing.Size(114, 17);
			this.chbCamelCaseClase.TabIndex = 12;
			this.chbCamelCaseClase.Text = "CamelCase Clase?";
			this.chbCamelCaseClase.UseVisualStyleBackColor = true;
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
			this.tpMain.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
		private System.Windows.Forms.ToolStripMenuItem pestañaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarActualToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarOtrasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarALaDerechaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarALaIzquierdaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarTodasToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripComboBox toolStripCBTabs;
		private System.Windows.Forms.ToolStripMenuItem pLSQLToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbCamelCaseSepNvoCls;
		private System.Windows.Forms.TextBox tbCamelCaseSepActCls;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chbCamelCaseClase;
		private System.Windows.Forms.TextBox tbCamelCaseSepNvoTbl;
		private System.Windows.Forms.TextBox tbCamelCaseSepActTbl;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chbCamelCaseTabla;
		private System.Windows.Forms.TextBox tbTblStartAdd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbTblStartRm;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbClsStartAdd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbClsStartRm;
		private System.Windows.Forms.Label label1;
	}
}

