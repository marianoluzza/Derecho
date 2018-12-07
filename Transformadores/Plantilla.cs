using Derecho.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derecho.Transformadores
{
	abstract class Plantilla
	{
		protected string pckName = "";
		protected string baseName = "";

		public string NameSpace { get; set; }
		public string Usings { get; set; }

		public abstract string Generar(Tabla tabla);
		
	}
}
