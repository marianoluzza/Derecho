using System;
using System.Linq;

namespace Derecho.Transformadores
{
	internal class Utils
	{
		public static string CamelCase(string nbre, string actSeparador, string nvoSeparador = null)
		{
			nvoSeparador = nvoSeparador ?? actSeparador;
			Func<String, String> camelCase = x => x.Substring(0, 1).ToUpper() +
					 (x.Length > 1 ? x.Substring(1).ToLower() : "");
			if (nbre.Contains(actSeparador))
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
	}
}