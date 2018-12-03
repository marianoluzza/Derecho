using Derecho.Modelo;
using Derecho.Transformadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
			if (open.ShowDialog() != DialogResult.OK)
				return;
			IList<Entidad> entidades = null;
			try
			{
				entidades = ERWinHelper.ConvertirXml(open.FileName);
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
	}
}
