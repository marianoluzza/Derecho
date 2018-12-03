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
	public partial class Listado : UserControl
	{
		Dictionary<ListViewItem, Func<object, object>> callBacks = new Dictionary<ListViewItem, Func<object, object>>();

		public Listado()
		{
			InitializeComponent();
		}

		public void LimpiarLista()
		{
			lstMain.Items.Clear();
		}

		public void AgregarItem(string mainText, string desc, object itemObj, Func<object, object> clickCallback)
		{
			var item = lstMain.Items.Add(mainText);
			item.Tag = itemObj;
			callBacks.Add(item, clickCallback);
			item.SubItems.Add(desc);
		}

		private void lstMain_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			var x = lstMain.GetItemAt(e.X, e.Y);
			if (x == null)
				return;
			if (callBacks[x] != null)
				callBacks[x](x.Tag);
		}
	}
}
