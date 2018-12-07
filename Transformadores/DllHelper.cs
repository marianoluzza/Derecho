using Derecho.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Derecho.Transformadores
{
	public class DllHelper
	{
		public static XmlDocument LeerDll(string path)
		{
			var dll = Assembly.LoadFile(path);
			Dictionary<string, List<Type>> ns_tipos = new Dictionary<string, List<Type>>();
			XmlDocument doc = new XmlDocument();
			/*doc.AppendChild(XmlElement.
			foreach (var item in dll.GetTypes())
			{
				if (!ns_tipos.ContainsKey(item.Namespace))
					ns_tipos.Add(item.Namespace, new List<Type>());
				ns_tipos[item.Namespace].Add(item);
			}
			foreach (var item in ns_tipos)
			{
				item
			}
			*/
			return doc;
		}

		public static Dictionary<string, List<Type>> LeerNameSpaces(string path)
		{
			var dll = Assembly.LoadFile(path);
			Dictionary<string, List<Type>> ns_tipos = new Dictionary<string, List<Type>>();
			foreach (var item in dll.GetTypes())
			{
				if (!ns_tipos.ContainsKey(item.Namespace))
					ns_tipos.Add(item.Namespace, new List<Type>());
				ns_tipos[item.Namespace].Add(item);
			}
			return ns_tipos;
		}

		public static void GenerarPlantillas(IEnumerable<Type> lstTipos, out string[] plantillasPCK, out string[] plantillasDAC, string nameSpace, string usings)
		{
			List<Tabla> tablas = new List<Tabla>();
			/*var consulta = AppDomain.CurrentDomain.GetAssemblies()
					   .SelectMany(t => t.GetTypes())
					   .Where(t => t.IsClass && t.Namespace == "MagBpa.Ent");*/
			var consulta = lstTipos;

			foreach (var item in consulta)
			{
				//Console.WriteLine(item.Name);
				string tableName = "T_" + item.Name.ToUpper();
				string pkAttrName = "";
				string pkParamName = "";
				string pkType = "";
				string pkNetType = "";
				string pkAdoType = "";
				string pkPropName = "";
				string className = item.Name;

				Dictionary<string, string> mapeo = new Dictionary<string, string>();
				Dictionary<string, string> mapeoType = new Dictionary<string, string>();
				Dictionary<string, string> adoDbType = new Dictionary<string, string>();
				Dictionary<string, string> netType = new Dictionary<string, string>();

				//trato de poner en singular el nombre de la tabla
				string singular = "";
				if (item.Name.Contains("Tramites"))
					singular = item.Name.Replace("Tramites", "Tramite");
				else if (item.Name.EndsWith("res"))
					singular = item.Name.Remove(item.Name.Length - 2);
				else if (item.Name.EndsWith("as") || item.Name.EndsWith("es") || item.Name.EndsWith("os"))
					singular = item.Name.Remove(item.Name.Length - 1);
				else if (item.Name.Contains("es_"))
					singular = item.Name.Replace("es_", "_");
				else if (item.Name.Contains("s_"))
					singular = item.Name.Replace("s_", "_");
				else
					singular = item.Name;

				string paramTypeName = "";
				string propAdoDbType = "";

				foreach (var p in item.GetProperties())
				{
					string tipoProp = p.PropertyType.Name;
					if (p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
						tipoProp = Nullable.GetUnderlyingType(p.PropertyType).Name;
					switch (tipoProp.ToLower())
					{
						case "datetime":
							paramTypeName = "DATE";
							propAdoDbType = "Date";
							break;
						case "boolean":
							paramTypeName = "NUMBER";
							propAdoDbType = "Int32";
							break;
						case "int32":
							paramTypeName = "NUMBER";
							propAdoDbType = "Int32";
							break;
						case "string":
							paramTypeName = "VARCHAR2";
							propAdoDbType = "NVarchar2";
							break;
						default:
							paramTypeName = "NUMBER";
							propAdoDbType = "Int32";
							break;

					}

					if ("Id_" + singular == p.Name)
					{
						pkParamName = "p" + p.Name.Replace("_", "");
						pkAttrName = p.Name.ToUpper();
						pkPropName = p.Name;
						pkType = paramTypeName;
						pkNetType = p.PropertyType.Name;
						pkAdoType = propAdoDbType;

					}
					else
					{
						string propName = p.Name.ToUpper();
						string paramName = "p" + p.Name.Replace("_", "");
						mapeo.Add(propName, paramName);
						mapeoType.Add(paramName, paramTypeName);
						adoDbType.Add(paramName, propAdoDbType);
						if (p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
							netType.Add(paramName, Nullable.GetUnderlyingType(p.PropertyType).Name);
						else
							netType.Add(paramName, p.PropertyType.Name);
					}
				}
				tablas.Add(new Tabla
				{
					tableName = tableName,
					pkAttrName = pkAttrName,
					pkParamName = pkParamName,
					pkPropName = pkPropName,
					pkType = pkType,
					pkNetType = pkNetType,
					pkAdoType = pkAdoType,
					className = className,
					mapeo = mapeo,
					paramType = mapeoType,
					adoDbType = adoDbType,
					netType = netType
				});
			}

			//Muestra por consola lo que parsea al principio
			/*
			foreach (Tabla t in tablas)
			{
				Console.WriteLine("Nombre: \t" + t.tableName);
				Console.WriteLine("PK Att: \t" + t.pkAttrName);
				Console.WriteLine("PK Param: \t" + t.pkParamName);
				foreach (KeyValuePair<string, string> kv in t.mapeo)
				{
					Console.WriteLine("\t\t Atributo: " + kv.Key + "\t\t Param: " + kv.Value);
				}
			}
			*/

			//generar los pkg completos
			PlantillaPackage pPck = new PlantillaPackage();
			PlantillaDac pDac = new PlantillaDac();
			pDac.NameSpace = nameSpace;
			pDac.Usings = usings;

			List<string> lstStrPCK = new List<string>();
			List<string> lstStrDAC = new List<string>();
			foreach (Tabla t in tablas)
			{
				//CrearArchivo("PCK_" + t.tableName.ToUpper() + ".txt", pPck.Generar(t));
				//CrearArchivo("DAC_" + t.tableName.ToUpper() + ".txt", pDac.Generar(t));
				try
				{
					lstStrPCK.Add(pPck.Generar(t));
				}
				catch (Exception ex)
				{
					lstStrPCK.Add(ex.Message);
					Console.Error.WriteLine("Error al generar package para " + t.tableName + ": " + ex.Message);
				}
				try
				{
					lstStrDAC.Add(pDac.Generar(t));
				}
				catch (Exception ex)
				{
					lstStrDAC.Add(ex.Message);
					Console.Error.WriteLine("Error al generar DAC para " + t.tableName + ": " + ex.Message);
				}
			}
			plantillasPCK = lstStrPCK.ToArray();
			plantillasDAC = lstStrDAC.ToArray();
		}
	}
}
