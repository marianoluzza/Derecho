using Derecho.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derecho.Transformadores
{
	public static class SQLHelper
	{
		public static List<Entidad> LeerPLSQL(string path)
		{
			List<Entidad> entidades = new List<Entidad>();
			bool enTabla = false;
			var lineas = File.ReadAllLines(path);
			Entidad entidad = null;
			foreach (var l in lineas)
			{
				var limpia = l.Replace('\t', ' ').Trim();
				int index1, index2;

				switch (limpia)
				{
					case var x when x.ToLower().StartsWith("create table")://CREATE TABLE
						int indicePunto = x.IndexOf('.');
						entidad = new Entidad();
						if (indicePunto > 0)
						{
							index1 = x.IndexOf('\"');
							if (index1 < 0)
								throw new FormatException("CREATE TABLE sin nombre de ns <" + x + ">");
							index2 = x.IndexOf('\"', index1 + 1);
							if (index2 < 0)
								throw new FormatException("CREATE TABLE sin comillas finales <" + x + ">");
							entidad.NombreNamespace = x.Substring(index1 + 1, index2 - index1 - 1);
							x = x.Substring(index2 + 1);
						}
						index1 = x.IndexOf('\"');
						if (index1 < 0)
							throw new FormatException("CREATE TABLE sin nombre de tabla <" + x + ">");
						index2 = x.IndexOf('\"', index1 + 1);
						if (index2 < 0)
							throw new FormatException("CREATE TABLE sin comillas finales <" + x + ">");
						entidad.NombreTabla = x.Substring(index1 + 1, index2 - index1 - 1);
						entidades.Add(entidad);
						enTabla = true;
						break;
					case var x when x.ToLower().StartsWith("go")://SEPARADOR GO
						enTabla = false;
						break;
					case var x when enTabla && x.ToLower().StartsWith("\"")://CASO "ATRIBUTO"
						index1 = x.IndexOf('\"');
						if (index1 < 0)
							throw new FormatException("Columna de tabla sin comillas <" + x + ">");
						index2 = x.IndexOf('\"', index1 + 1);
						if (index2 < 0)
							throw new FormatException("Columna de tabla sin comillas finales <" + x + ">");
						Atributo atributo = new Atributo();
						atributo.Nombre = x.Substring(index1 + 1, index2 - index1 - 1);
						var resto = x.Substring(index2 + 1).Trim();
						atributo.NotNull = resto.ToLower().Contains("not null");
						index2 = resto.IndexOf(' ');
						atributo.TipoSQL = resto.Substring(0, index2 > 0 ? index2 : resto.Length);
						atributo.Descripcion = resto;
						entidad.Atributos.Add(atributo);
						break;
					default:
						break;
				}
			}
			//
			return entidades;
		}


	}
}
