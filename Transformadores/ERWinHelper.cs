using Derecho.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Derecho.Transformadores
{
	public class ERWinHelper
	{
		const char TAB = '\t';

		static XmlDocument LeerXml(string pathXML)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(pathXML);
			return doc;
		}

		private static string[] GenerarClases(IList<Entidad> entidades)
		{
			List<string> resultado = new List<string>();
			foreach (Entidad ent in entidades)
			{
				string nbreClase = Utils.CamelCase(String.IsNullOrWhiteSpace(ent.NombreClase) ? ent.NombreTabla : ent.NombreClase, "_");//CAMEL CASE
				nbreClase = nbreClase.StartsWith("T_") ? nbreClase.Substring(2) : nbreClase;//SACAR T_
				nbreClase += "View";
				StringBuilder sb = new StringBuilder();
				sb.AppendLine("using System;");
				sb.AppendLine("");
				sb.AppendLine("namespace Test");
				sb.AppendLine("{");
				{
					sb.AppendLine(TAB + "public class " + nbreClase);
					sb.AppendLine(TAB + "{");
					foreach (Atributo attr in ent.Atributos)
					{
						sb.Append(TAB, 2);
						attr.TipoNet = Utils.ConvertirTipoSQL_NET(attr.TipoSQL, attr.Nombre);
						sb.AppendLine("public " + attr.TipoNet + " " + Utils.CamelCase(attr.Nombre, "_") + " { get; set; }");
					}
					sb.AppendLine(TAB + "}");
				}
				sb.AppendLine("}");
				//System.IO.File.WriteAllText("C:\\Users\\Mariano\\Downloads\\REG\\src\\" + nbreClase + ".cs", sb.ToString());
				resultado.Add(sb.ToString());
			}
			return resultado.ToArray();
		}

		public static IList<Entidad> ConvertirXml(string pathXML)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(pathXML);
			XmlNode nodoEntidades = doc.DocumentElement["EMX:Model"]["Entity_Groups"];
			IList<Entidad> res = new List<Entidad>(nodoEntidades.ChildNodes.Count);
			//
			foreach (XmlNode nodoEnt in nodoEntidades.ChildNodes)
			{
				Entidad entidad = new Entidad();
				res.Add(entidad);
				entidad.NombreTabla = nodoEnt.Attributes["name"].Value;

				//entityprops -> orden
				string[] orden = new string[nodoEnt["EntityProps"]["Attribute_Order_List_Array"].ChildNodes.Count];
				SortedList<string, Atributo> key_attr = new SortedList<string, Atributo>(orden.Length);
				foreach (XmlNode nodoOrden in nodoEnt["EntityProps"]["Attribute_Order_List_Array"].ChildNodes)
				{
					orden[int.Parse(nodoOrden.Attributes["index"].Value)] = nodoOrden.InnerText;
				}
				foreach (XmlNode nodoAttr in nodoEnt["Attribute_Groups"].ChildNodes)
				{
					Atributo attr = new Atributo();
					attr.Id = nodoAttr.Attributes["id"].Value;
					attr.Nombre = nodoAttr.Attributes["name"].Value;
					attr.TipoSQL = nodoAttr["AttributeProps"]["Logical_Datatype"]?.InnerText;
					key_attr.Add(attr.Id, attr);
				}
				foreach (string s in orden)
				{
					entidad.Atributos.Add(key_attr[s]);
				}
			}
			//
			return res;
		}
	}
}
