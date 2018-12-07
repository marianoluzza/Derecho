using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derecho.Modelo
{
	public class Atributo
	{
		public string Id { get; set; }
		public string Nombre { get; set; }
		public string TipoSQL { get; set; }
		public string TipoNet { get; set; }
		public bool NotNull { get; set; } = true;
		public object Tag { get; set; }
		public string Descripcion { get; set; }
	}
}
