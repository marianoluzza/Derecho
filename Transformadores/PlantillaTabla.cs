using Derecho.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derecho.Transformadores
{
	class PlantillaTabla : Plantilla
	{

		public override string Generar(Tabla tabla)
		{

			//obtengo la plantilla
			string p = Plantilla();

			//remplazo nombre del namespace / database
			p = p.Replace("{{NAMESPACE}}", NameSpace);

			//remplazo noombre de la entidad
			p = p.Replace("{{ENT_CLASS_NAME}}", tabla.className.ToUpper());

			//remplazo tablename
			p = p.Replace("{{TABLE_NAME}}", tabla.tableName);

			//obtengo la lista de asignación para la sentencia UPDATE
			string columnas = this.GetColumnas(tabla);
			p = p.Replace("{{COLUMNAS}}", columnas);


			//devuelvo la plantilla
			return p;
		}

		private string Plantilla()
		{
			string plantilla =
@"/* --------------------------------> {{TABLE_NAME}}S <---------------------------------- */
                
CREATE SEQUENCE ""{{NAMESPACE}}"".""SEQ_{{ENT_CLASS_NAME}}S""
	INCREMENT BY 1
	START WITH 10
	MAXVALUE 9999999999999999999999999999
	NOMINVALUE
	NOCYCLE
	NOCACHE
	NOORDER
GO
CREATE TABLE ""{{NAMESPACE}}"".""{{TABLE_NAME}}S""(
	{{COLUMNAS}}
	CONSTRAINT ""PK_{{ENT_CLASS_NAME}}"" PRIMARY KEY(""ID_{{ENT_CLASS_NAME}}"")
	NOT DEFERRABLE
	 VALIDATE
)
GO

CREATE UNIQUE INDEX ""{{NAMESPACE}}"".""PK_{{ENT_CLASS_NAME}}""
	ON ""{{NAMESPACE}}"".""T_{{ENT_CLASS_NAME}}S""(""ID_{{ENT_CLASS_NAME}}"")
GO
/* --------------------------------> FIN {{TABLE_NAME}} <---------------------------------- */";

			return plantilla;
		}

		public string GetColumnas(Tabla tabla)
		{
			StringBuilder sb = new StringBuilder();

			//string pkType = incluirTipos? " IN " + tabla.pkType : "";
			//	"ID_SEXO"      	NVARCHAR2(2) NOT NULL,
			sb.Append(tabla.pkAttrName + "\t" + tabla.pkType + "(10) NOT NULL,\n");

			foreach (string param in tabla.mapeo.Values)
			{
				string col = "";
				if (param == param.ToUpper())
				{
					col = param.Substring(1);
				}
				else
				{
					for (int i = 1; i < param.Length; i++)
					{
						string letra = param[i].ToString();
						if (letra == letra.ToUpper() && i > 1)
							col += "_";
						col += letra.ToUpper();
					}
				}
				//
				var tipo = tabla.paramType[param];
				if (col.Contains("OBSERVACION"))
					tipo = "VARCHAR2(4000)";
				else if (col.StartsWith("ID_"))
					tipo = "NUMBER(10,0)";
				else if (tabla.netType[param].ToLower().Contains("bool"))
					tipo = "NUMBER(1,0)";
				else if (tipo.ToUpper().Contains("VARCHAR"))
					tipo += "(30)";
				else if (tipo.ToUpper().Contains("NUMBER"))
					tipo += "(10)";
				else if (tabla.netType[param].ToLower().Contains("float") || tabla.netType[param].ToLower().Contains("double") || tabla.netType[param].ToLower().Contains("decimal"))
					tipo = "NUMBER(10,2)";
				//
				sb.Append("\"" + col.ToUpper() + "\"\t" + tipo.ToUpper() + " ,\n");
			}
			//sb.Length = sb.Length - 2;
			//sb.Append("\n");


			return sb.ToString();
		}

		public string GetAttrList(Tabla tabla, bool incluirPK)
		{
			StringBuilder sb = new StringBuilder();

			if (incluirPK)
				sb.Append(tabla.pkAttrName + ",\n");

			foreach (string attr in tabla.mapeo.Keys)
			{
				sb.Append(attr + ",\n");
			}
			sb.Length = sb.Length - 2;
			sb.Append("\n");


			return sb.ToString();
		}
	}
}
