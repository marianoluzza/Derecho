using Derecho.Modelo;
using Derecho.Transformadores;
using Ookii.Dialogs.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Derecho
{
	public partial class FrmMain : Form
	{


		public FrmMain()
		{
			InitializeComponent();
		}

		private void xToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (TABs.SelectedIndex == 0)
				Close();
			else
				TABs.TabPages.RemoveAt(TABs.SelectedIndex);
		}

		public void NuevaTab(Control ctrl, string titulo, string key = null, string keyImage = "Codigo")
		{
			TabPage tp = null;
			if (!String.IsNullOrEmpty(key) && TABs.TabPages.ContainsKey(key))
			{
				tp = TABs.TabPages[key];
			}
			else
			{
				if (!String.IsNullOrEmpty(key))
					TABs.TabPages.Add(key, titulo);
				else
				{
					TABs.TabPages.Add(titulo);
				}
				tp = TABs.TabPages[TABs.TabPages.Count - 1];
				if (!String.IsNullOrEmpty(keyImage))
					tp.ImageIndex = imgList.Images.IndexOfKey(keyImage);
				tp.Controls.Add(ctrl);
				ctrl.Dock = DockStyle.Fill;
			}
			//
			if (tp != null)
				TABs.SelectedTab = tp;
		}

		private void erwinXMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Title = "Abrir XML de ERWin";
			open.Filter = "Archivos XML (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
			open.FilterIndex = 1;
			if (open.ShowDialog() != DialogResult.OK)
				return;
			IList<Entidad> entidades = null;
			try
			{
				entidades = ERWinHelper.ConvertirXml(open.FileName);
				statMensaje.Text = "XML de ERWin leído!";
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Error al Leer XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				var codigo = ERWinHelper.GenerarClases(entidades);
				for (int i = 0; i < entidades.Count; i++)
				{
					NuevaTab(new Editor() { Text = codigo[i] }, entidades[i].Nombre + ".cs", entidades[i].Nombre + ".cs", "CSharp");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Error al Crear Código C#", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}



		private void dllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Title = "Abrir DLL de .Net";
			open.Filter = "Archivos DLL (*.dll, *.exe)|*.dll;*.exe|Todos los archivos (*.*)|*.*";
			open.FilterIndex = 1;
			if (open.ShowDialog() != DialogResult.OK)
				return;
			Dictionary<string, List<Type>> lista = null;
			try
			{
				lista = DllHelper.LeerNameSpaces(open.FileName);
				statMensaje.Text = "DLL leída!";
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Error al Leer DLL", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				Listado listado = new Listado();
				Func<object, object> generar = delegate (object o)
				{
					List<Type> tipos = o as List<Type>;
					string[] plantillasPCK, plantillasDAC;
					DllHelper.GenerarPlantillas(tipos, out plantillasPCK, out plantillasDAC);
					int i = 0;
					foreach (var t in tipos)
					{
						NuevaTab(new Editor() { Text = plantillasDAC[i] }, t.Namespace + "." + t.Name + ".cs", t.Namespace + "." + t.Name + ".cs", "CSharp");
						NuevaTab(new Editor() { Text = plantillasPCK[i] }, t.Namespace + "." + t.Name + ".sql", t.Namespace + "." + t.Name + ".sql", "Oracle");
						i++;
					}
					statMensaje.Text = "Clases y scripts generados!";
					return null;

				};
				foreach (var item in lista)
				{
					listado.AgregarItem(item.Key, String.Join(", ", item.Value.Select<Type, String>(t => t.Name).ToArray()), item.Value, generar);
				}
				NuevaTab(listado, open.FileName, open.FileName, "DLL");
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Error al Crear Código C#", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			VistaFolderBrowserDialog browserDialog = new VistaFolderBrowserDialog();
			browserDialog.Description = "Seleccione carpeta para los archivos";
			if (browserDialog.ShowDialog() != DialogResult.OK)
				return;
			int i = 0;
			foreach (TabPage tp in TABs.TabPages)
			{
				if (tp.Controls.Count > 0 && tp.Controls[0] is Editor)
				{
					File.WriteAllText(Path.Combine(browserDialog.SelectedPath, tp.Text), (tp.Controls[0] as Editor).Text);
					i++;
				}
			}
			switch (i)
			{
				case 0:
					MessageBox.Show("No se escribió ningún archivo", "Exportación a Archivos", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;
				case 1:
					MessageBox.Show("Se escribió un archivo", "Exportación a Archivos", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;
				default:
					MessageBox.Show("Se escribieron " + i.ToString() + " archivos", "Exportación a Archivos", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;
			}
		}

		private void archivoActualToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TabPage tp = TABs.SelectedTab;
			if (tp.Controls.Count > 0 && tp.Controls[0] is Editor)
			{
				SaveFileDialog save = new SaveFileDialog();
				string file = tp.Text;
				save.FileName = file;
				if (save.ShowDialog() != DialogResult.OK)
					return;
				File.WriteAllText(save.FileName, (tp.Controls[0] as Editor).Text);
				statMensaje.Text = save.FileName + " generado exitósamente!";
			}
			else
				MessageBox.Show("No se encontró un editor de texto", "Exportación a Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void portapapelesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			TabPage tp = TABs.SelectedTab;
			if (tp.Controls.Count > 0 && tp.Controls[0] is Editor)
			{
				Clipboard.SetText((tp.Controls[0] as Editor).Text);
				statMensaje.Text = "Texto copiado al portapapeles!";
			}
			else
				MessageBox.Show("No se encontró un editor de texto", "Copiar a Portapapeles", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
