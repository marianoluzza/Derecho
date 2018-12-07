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

		static XmlDocument LeerXml(string pathXML)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(pathXML);
			return doc;
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
