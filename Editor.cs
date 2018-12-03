using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Derecho
{
	public partial class Editor : UserControl
	{
		public Editor()
		{
			InitializeComponent();
		}

		public override string Text { get => tbTexto.Text; set => tbTexto.Text = value; }

		private void bBuscar_Click(object sender, EventArgs e)
		{
			var i = Text.IndexOf(tbBuscar.Text, tbTexto.SelectionStart);
			if (i >= 0)
			{
				tbTexto.SelectionStart = i;
				tbTexto.SelectionLength = tbBuscar.Text.Length;
			}
				
		}

		private void bReemplazar_Click(object sender, EventArgs e)
		{
			Text = Text.Replace(tbBuscar.Text, tbReemplazar.Text);
		}
	}
}
