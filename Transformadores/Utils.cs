using Derecho.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Derecho.Transformadores
{
	internal class Utils
	{
		public const char TAB = '\t';

		/// <summary>
		/// Convierte el string a Camel-Case teniendo en cuenta un separador de palabras
		/// </summary>
		/// <param name="nbre">Cadena a convertir</param>
		/// <param name="actSeparador">separador corriente de las palabras</param>
		/// <param name="nvoSeparador">nuevo separador. Opcional, se usa el mismo si no se brinda</param>
		/// <returns></returns>
		public static string CamelCase(string nbre, string actSeparador = null, string nvoSeparador = null)
		{
			nvoSeparador = String.IsNullOrWhiteSpace(nvoSeparador) ? actSeparador : nvoSeparador;
			Func<String, String> camelCase = x => x.Substring(0, 1).ToUpper() +
					 (x.Length > 1 ? x.Substring(1).ToLower() : "");
			if (!String.IsNullOrWhiteSpace(actSeparador) && nbre.Contains(actSeparador))
			{
				return String.Join(nvoSeparador,
					nbre.Split(new[] { actSeparador }, StringSplitOptions.RemoveEmptyEntries)
					.Select(camelCase)
				);
			}
			else
			{
				return camelCase(nbre);
			}
		}

		/// <summary>
		/// Hace CamelCase con _ de separador
		/// </summary>
		public static string Camel_Case(string nbre)
		{
			return CamelCase(nbre, "_");
		}

		/// <summary>
		/// Genera el contenido de una clase C# para cada entidad
		/// </summary>
		/// <param name="entidades">Lista de entidades</param>
		/// <param name="usingNS">Listado de espacios de nombres para hacer using</param>
		/// <param name="conversorNbreAttr">Función de conversión de nombre de atributo, usada para cambiar los nombres de las columnas a nombres de propiedades</param>
		/// <returns></returns>
		public static string[] GenerarClases(IList<Entidad> entidades, string[] usingNS = null, Func<string, string> conversorNbreAttr = null)
		{
			List<string> resultado = new List<string>();
			foreach (Entidad ent in entidades)
			{
				string nbreClase = String.IsNullOrWhiteSpace(ent.NombreClase) ? ent.NombreTabla : ent.NombreClase;
				StringBuilder sb = new StringBuilder();
				if (usingNS != null)
				{
					foreach (var ns in usingNS)
					{
						sb.AppendLine("using " + ns + ";");
					}
					sb.AppendLine("");
				}
				sb.AppendLine("namespace " + (String.IsNullOrWhiteSpace(ent.NombreNamespace) ? "MiEspacio" : ent.NombreNamespace));
				sb.AppendLine("{");
				{
					sb.AppendLine(TAB + "public class " + nbreClase);
					sb.AppendLine(TAB + "{");
					foreach (Atributo attr in ent.Atributos)
					{
						sb.Append(TAB, 2);
						string tipo = String.IsNullOrWhiteSpace(attr.TipoNet) ? ConvertirTipoSQL_NET(attr.TipoSQL, attr.Nombre) : attr.TipoNet;
						sb.AppendLine("public " + tipo + " " + (conversorNbreAttr != null ? conversorNbreAttr(attr.Nombre) : attr.Nombre) + " { get; set; }");
					}
					sb.AppendLine(TAB + "}");
				}
				sb.AppendLine("}");
				//System.IO.File.WriteAllText("C:\\Users\\Mariano\\Downloads\\REG\\src\\" + nbreClase + ".cs", sb.ToString());
				resultado.Add(sb.ToString());
			}
			return resultado.ToArray();
		}

		/// <summary>
		/// Convierte un tipo SQL a un tipo .Net
		/// </summary>
		/// <param name="tipoSQL"></param>
		/// <param name="nbre">si el tipo SQL es ambiguo se usa convenciones del nombre del atributo para inferir el tipo (null => object)</param>
		/// <returns></returns>
		public static string ConvertirTipoSQL_NET(string tipoSQL, string nbre = null)
		{
			string tipoEnLower = String.IsNullOrWhiteSpace(tipoSQL) ? "" : tipoSQL.ToLower();
			switch (tipoEnLower)
			{
				case "number(1,0)":
					return "bool";
				case var x when x.Contains("number"):
					int indiceComa = x.IndexOf(',');
					if (indiceComa > 0 && indiceComa + 1 < x.Length && x[indiceComa + 1] != '0')//number(X,Y) => Y > 0
						return "decimal";
					else
						return "int";
				case var x when x.Contains("date") || x.Contains("time"):
					return "DateTime";
				case var x when x.Contains("char"):
					return "string";
				default://SIN TIPO SQL o INDEFINIDO
					if (String.IsNullOrWhiteSpace(nbre))
						return "object";
					if (nbre.ToLower().StartsWith("id"))
						return "int";
					if (nbre.ToLower().StartsWith("fec"))
						return "DateTime";
					return "object";
			}
		}
	}
}