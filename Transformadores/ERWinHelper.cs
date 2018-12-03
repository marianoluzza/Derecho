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

		public static string[] GenerarClases(IList<Entidad> entidades)
		{
			List<string> resultado = new List<string>();
			foreach (Entidad ent in entidades)
			{
				string nbreClase = Utils.CamelCase(ent.Nombre, "_");//CAMEL CASE
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
						sb.AppendLine("public " + ConvertirTipo(attr.Tipo, attr.Nombre) + " " + Utils.CamelCase(attr.Nombre, "_") + " { get; set; }");
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
				entidad.Nombre = nodoEnt.Attributes["name"].Value;
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
					attr.Tipo = nodoAttr["AttributeProps"]["Logical_Datatype"]?.InnerText;
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

		public static string ConvertirTipo(string tipoSQL, string nbre)
		{
			if (String.IsNullOrWhiteSpace(tipoSQL))
			{
				if (String.IsNullOrWhiteSpace(nbre))
					return "object";
				if (nbre.ToLower().StartsWith("id"))
					return "int";
				if (nbre.ToLower().StartsWith("fec"))
					return "DateTime";
				return "object";
			}
			switch (tipoSQL.ToLower())
			{
				case "number(1,0)":
					return "bool";
				case var x when x.Contains("number"):
					return "int";
				case var x when x.Contains("date"):
					return "DateTime";
				case var x when x.Contains("char"):
					return "string";
			}
			return "object";
		}
	}
}
