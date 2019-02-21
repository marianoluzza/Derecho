using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derecho.Transformadores
{
	public static class DataRowExtensions
	{
		public static T GetValueOrDefault<T>(this DataRow row, string key)
		{
			return row.GetValueOrDefault(key, default(T));
		}

		public static T GetValueOrDefault<T>(this DataRow row, string key, T defaultValue)
		{
			if (row.IsNull(key))
			{
				return defaultValue;
			}
			else
			{
				Type t = typeof(T);
				if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>))
					return (T)Convert.ChangeType(row[key], Nullable.GetUnderlyingType(t));
				else
					return (T)Convert.ChangeType(row[key], t);
			}
		}
	}
}
