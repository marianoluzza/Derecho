using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derecho.Modelo
{
	public class Entidad
	{
		public string NombreTabla { get; set; }
		public string NombreClase { get; set; }
		public string NombreNamespace { get; set; }
		public IList<Atributo> Atributos { get; set; }

		public Entidad(IList<Atributo> attrs = null)
		{
			Atributos = attrs ?? new List<Atributo>();
		}
	}
}
