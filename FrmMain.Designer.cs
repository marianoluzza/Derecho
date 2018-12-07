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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radIdentidad = new System.Windows.Forms.RadioButton();
			this.radSingular = new System.Windows.Forms.RadioButton();
			this.radPlural = new System.Windows.Forms.RadioButton();
			this.tbCamelCaseSepNvo = new System.Windows.Forms.TextBox();
			this.tbCamelCaseSepAct = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.chbCamelCase = new System.Windows.Forms.CheckBox();
			this.tbEndAdd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbEndRemove = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbStartAdd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbStartRemove = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.erwinXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dLLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pLSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.tbNameSpace = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbUsings = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.statBarra.SuspendLayout();
			this.TABs.SuspendLayout();
			this.tpMain.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
			this.TABs.SelectedIndexChanged += new System.EventHandler(this.toolStripCBTabs_SelectedIndexChanged);
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbUsings);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.tbNameSpace);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.radIdentidad);
			this.groupBox1.Controls.Add(this.radSingular);
			this.groupBox1.Controls.Add(this.radPlural);
			this.groupBox1.Controls.Add(this.tbCamelCaseSepNvo);
			this.groupBox1.Controls.Add(this.tbCamelCaseSepAct);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.chbCamelCase);
			this.groupBox1.Controls.Add(this.tbEndAdd);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbEndRemove);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.tbStartAdd);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbStartRemove);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(287, 349);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Convención de Nombres para Transformaciones";
			// 
			// radIdentidad
			// 
			this.radIdentidad.AutoSize = true;
			this.radIdentidad.Checked = true;
			this.radIdentidad.Location = new System.Drawing.Point(148, 158);
			this.radIdentidad.Name = "radIdentidad";
			this.radIdentidad.Size = new System.Drawing.Size(69, 17);
			this.radIdentidad.TabIndex = 1;
			this.radIdentidad.TabStop = true;
			this.radIdentidad.Text = "Identidad";
			this.radIdentidad.UseVisualStyleBackColor = true;
			// 
			// radSingular
			// 
			this.radSingular.AutoSize = true;
			this.radSingular.Location = new System.Drawing.Point(65, 157);
			this.radSingular.Name = "radSingular";
			this.radSingular.Size = new System.Drawing.Size(63, 17);
			this.radSingular.TabIndex = 1;
			this.radSingular.Text = "Singular";
			this.radSingular.UseVisualStyleBackColor = true;
			// 
			// radPlural
			// 
			this.radPlural.AutoSize = true;
			this.radPlural.Location = new System.Drawing.Point(6, 157);
			this.radPlural.Name = "radPlural";
			this.radPlural.Size = new System.Drawing.Size(51, 17);
			this.radPlural.TabIndex = 1;
			this.radPlural.Text = "Plural";
			this.radPlural.UseVisualStyleBackColor = true;
			// 
			// tbCamelCaseSepNvo
			// 
			this.tbCamelCaseSepNvo.Location = new System.Drawing.Point(228, 132);
			this.tbCamelCaseSepNvo.Name = "tbCamelCaseSepNvo";
			this.tbCamelCaseSepNvo.Size = new System.Drawing.Size(42, 20);
			this.tbCamelCaseSepNvo.TabIndex = 11;
			// 
			// tbCamelCaseSepAct
			// 
			this.tbCamelCaseSepAct.Location = new System.Drawing.Point(148, 132);
			this.tbCamelCaseSepAct.Name = "tbCamelCaseSepAct";
			this.tbCamelCaseSepAct.Size = new System.Drawing.Size(42, 20);
			this.tbCamelCaseSepAct.TabIndex = 10;
			this.tbCamelCaseSepAct.Text = "_";
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
			// chbCamelCase
			// 
			this.chbCamelCase.AutoSize = true;
			this.chbCamelCase.Checked = true;
			this.chbCamelCase.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbCamelCase.Location = new System.Drawing.Point(6, 134);
			this.chbCamelCase.Name = "chbCamelCase";
			this.chbCamelCase.Size = new System.Drawing.Size(85, 17);
			this.chbCamelCase.TabIndex = 8;
			this.chbCamelCase.Text = "CamelCase?";
			this.chbCamelCase.UseVisualStyleBackColor = true;
			// 
			// tbEndAdd
			// 
			this.tbEndAdd.Location = new System.Drawing.Point(148, 89);
			this.tbEndAdd.Name = "tbEndAdd";
			this.tbEndAdd.Size = new System.Drawing.Size(122, 20);
			this.tbEndAdd.TabIndex = 7;
			this.tbEndAdd.Text = "View";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(148, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Añadir Final";
			// 
			// tbEndRemove
			// 
			this.tbEndRemove.Location = new System.Drawing.Point(6, 89);
			this.tbEndRemove.Name = "tbEndRemove";
			this.tbEndRemove.Size = new System.Drawing.Size(122, 20);
			this.tbEndRemove.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Remover Final";
			// 
			// tbStartAdd
			// 
			this.tbStartAdd.Location = new System.Drawing.Point(148, 46);
			this.tbStartAdd.Name = "tbStartAdd";
			this.tbStartAdd.Size = new System.Drawing.Size(122, 20);
			this.tbStartAdd.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(148, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Añadir Principio";
			// 
			// tbStartRemove
			// 
			this.tbStartRemove.Location = new System.Drawing.Point(6, 46);
			this.tbStartRemove.Name = "tbStartRemove";
			this.tbStartRemove.Size = new System.Drawing.Size(122, 20);
			this.tbStartRemove.TabIndex = 1;
			this.tbStartRemove.Text = "T_";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Remover Principio";
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
			// pLSQLToolStripMenuItem
			// 
			this.pLSQLToolStripMenuItem.Name = "pLSQLToolStripMenuItem";
			this.pLSQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.pLSQLToolStripMenuItem.Text = "PL-SQL";
			this.pLSQLToolStripMenuItem.Click += new System.EventHandler(this.pLSQLToolStripMenuItem_Click);
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
			this.toolStripCBTabs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripCBTabs.MaxDropDownItems = 12;
			this.toolStripCBTabs.Name = "toolStripCBTabs";
			this.toolStripCBTabs.Size = new System.Drawing.Size(121, 23);
			this.toolStripCBTabs.SelectedIndexChanged += new System.EventHandler(this.toolStripCBTabs_SelectedIndexChanged);
			// 
			// tbNameSpace
			// 
			this.tbNameSpace.Location = new System.Drawing.Point(6, 202);
			this.tbNameSpace.Name = "tbNameSpace";
			this.tbNameSpace.Size = new System.Drawing.Size(122, 20);
			this.tbNameSpace.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 186);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Espacio de Nombres";
			// 
			// tbUsings
			// 
			this.tbUsings.Location = new System.Drawing.Point(6, 241);
			this.tbUsings.Multiline = true;
			this.tbUsings.Name = "tbUsings";
			this.tbUsings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbUsings.Size = new System.Drawing.Size(264, 105);
			this.tbUsings.TabIndex = 15;
			this.tbUsings.Text = "using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 225);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(39, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Usings";
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
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
		private System.Windows.Forms.TextBox tbCamelCaseSepNvo;
		private System.Windows.Forms.TextBox tbCamelCaseSepAct;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chbCamelCase;
		private System.Windows.Forms.TextBox tbEndAdd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbEndRemove;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbStartAdd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbStartRemove;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radIdentidad;
		private System.Windows.Forms.RadioButton radSingular;
		private System.Windows.Forms.RadioButton radPlural;
		private System.Windows.Forms.TextBox tbUsings;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbNameSpace;
		private System.Windows.Forms.Label label6;
	}
}

