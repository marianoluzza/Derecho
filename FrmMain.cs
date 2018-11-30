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

		private void erwinXMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Title = "Abrir XML de ERWin";
			if (open.ShowDialog() != DialogResult.OK)
				return;

		}
	}
}
