using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Derecho.Transformadores
{
	public class XmlHelper
	{
		const char TAB = '\t';

		public static string Recorrer(XmlDocument doc)
		{
			return PrintNode(doc.DocumentElement, 0);
		}

		static string PrintNode(XmlNode ele, int profundidad)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(TAB, profundidad);
			switch (ele.NodeType)
			{
				case XmlNodeType.Attribute:
					break;
				case XmlNodeType.Element:
					sb.Append(TAB + "ELEMENTO: " + ele.Name);
					break;
				case XmlNodeType.Text:
					sb.Append(TAB + ele.Name);
					break;
			}
			foreach (XmlNode hijo in ele.ChildNodes)
			{
				sb.Append(PrintNode(hijo, profundidad + 1));
			}
			return sb.ToString();
		}
	}
}
