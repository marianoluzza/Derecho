﻿using Derecho.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Derecho.Transformadores
{
	class PlantillaDac : Plantilla
	{
		public override string Generar(Tabla tabla)
		{
			//table name sin el T_
			baseName = tabla.tableName.Substring(2);
			pckName = "PCK_" + baseName;

			//obtengo la plantilla
			string p = Plantilla();

			//reemplazo using
			p = p.Replace("{{USINGS}}", this.Usings);

			//reemplazo nombre del ns
			p = p.Replace("{{NAME_SPACE}}", this.NameSpace);

			//reemplazo nombre del pck
			p = p.Replace("{{PCK_NAME}}", pckName);

			//remplazo basename
			p = p.Replace("{{BASE_NAME}}", baseName);

			//remplazo nombre de la propiedad para pk
			p = p.Replace("{{PK_PROP_NAME}}", tabla.pkPropName);

			//remplazo nombre del parametro para pk
			p = p.Replace("{{PK_PARAM_NAME}}", tabla.pkParamName);

			//reemplazo la cantidad para el array de params en el insert
			p = p.Replace("{{CANT_PARAMS_INSERT}}", (tabla.mapeo.Count + 1).ToString()); //el +1 es porque la lista no incluye la pk

			//remplado el nombre de la clase de la entidad
			p = p.Replace("{{ENT_CLASS_NAME}}", tabla.className);

			//remplado el nombre de la clase dac
			p = p.Replace("{{CLASS_NAME}}", tabla.className + "Dac");

			//remplazo los oraparams para el insert
			string demasOraParams = GetOraParamsDemas(tabla);
			p = p.Replace("{{DEMAS_ORA_PARAMS}}", demasOraParams);

			//remplazo los parametros del método get de la clase incluyendo la pk
			string metodoGetParams = GetMethodParams(tabla, true);
			p = p.Replace("{{GET_METHOD_PARAMS}}", metodoGetParams);

			//remplazo los oraparams para el método get
			string metodoGetOraParams = GetMethodOraParamsGET(tabla, true);
			p = p.Replace("{{GET_METHOD_ORA_PARAMS}}", metodoGetOraParams);

			//remplazo las asignaciones para el metodo fill
			string metodoFillMap = GetFillMethodMap(tabla, true);
			p = p.Replace("{{FILL_METHOD_MAP}}", metodoFillMap);

			//null list
			string nullList = GetShowMethodNullList(tabla);
			p = p.Replace("{{NULL_LIST}}", nullList);


			return p;
		}

		private string Plantilla()
		{
			string plantilla =
@"{{USINGS}}

namespace {{NAME_SPACE}}
{

	public partial class {{CLASS_NAME}}
	{
		const string TABLA = ""{{BASE_NAME}}"";
		const string SP_PREFIX = ""PCK_"" + TABLA + "".PR_"" + TABLA + ""_"";

		#region Manipulacion de Registros
		public static Hashtable ABM({{ENT_CLASS_NAME}} obj, eABM op, out List<Exception> Ex)
		{
			Hashtable ret = new Hashtable();
			Ex = new List<Exception>();
			List<OracleParameter> oParam = new List<OracleParameter>({{CANT_PARAMS_INSERT}});

			try
			{
				oParam.Add(new OracleParameter(""{{PK_PARAM_NAME}}"", OracleDbType.Int32, 9, obj.{{PK_PROP_NAME}}, ParameterDirection.InputOutput));
				if (op != eABM.DELETE)
				{
					{{DEMAS_ORA_PARAMS}}
				}

				Data pData = new Data();
				string SP = SP_PREFIX + op.ToString();
				pData.EjecutarSP(SP, oParam.ToArray());

				if (op == eABM.INSERT)
					obj.{{PK_PROP_NAME}} = Convert.ToInt32(oParam[0].Value.ToString());
				ret.Add(""O_"" + nameof(obj.{{PK_PROP_NAME}}), obj.{{PK_PROP_NAME}});
			}
			catch (Exception ex)
			{
				Ex.Add(ex);
			}
			return ret;
		}
		#endregion

		#region Consultas
		/// <summary>
		/// Obtiene un listado de entidades aplicando filtros correspondientes
		/// Devuelve la estructura de la tabla
		/// </summary>
		public static List<{{ENT_CLASS_NAME}}> Get(Int32? id, out List<Exception> Ex)
		{

			Ex = new List<Exception>();
			List<{{ENT_CLASS_NAME}}> obj = new List<{{ENT_CLASS_NAME}}>();
			List<OracleParameter> oParam = new List<OracleParameter>({{CANT_PARAMS_INSERT}}+1);
			//
			DataSet ORADataSet = new DataSet();
			try
			{
				oParam.Add(new OracleParameter(""pId"", OracleDbType.Int32, 9, id ?? (object)DBNull.Value, ParameterDirection.Input));
				//oParam.Add(new OracleParameter(""pNombre"", OracleDbType.NVarchar2, 100, obj.N_{{ENT_CLASS_NAME}}, ParameterDirection.Input));
				//
				var paramCursor = new OracleParameter(""pCursor"", OracleDbType.RefCursor);
				paramCursor.Direction = ParameterDirection.Output;
				oParam.Add(paramCursor);
				//
				Data pData = new Data();
				//{{PCK_NAME}}.PR_{{BASE_NAME}}_GET
				string SP = SP_PREFIX + ""GET"";
				pData.EjecutarSP(SP, oParam.ToArray(), ORADataSet);
			}
			catch (Exception ex)
			{
				Ex.Add(ex);
			}
			finally
			{
				oParam = null;
			}
			DataTable dt = null;
			if (Ex.Count == 0 && ORADataSet.Tables.Count > 0)
			{
				dt = ORADataSet.Tables[0];
				if (dt.Rows.Count > 0)
					obj = Fill(dt);
			}
			return obj;
		}

		/// <summary>
		/// Obtiene todos las entidades existentes
		/// Devuelve la estructura de la tabla
		/// </summary>
		public static List<{{ENT_CLASS_NAME}}> GetAll(out List<Exception> Ex)
		{
			return Get(null, out Ex);
		}

		private static List<{{ENT_CLASS_NAME}}> Fill(DataTable tbl)
		{
			List<{{ENT_CLASS_NAME}}> pRet = new List<{{ENT_CLASS_NAME}}>();
			foreach (DataRow reader in tbl.Rows)
			{
				{{ENT_CLASS_NAME}} obj = new {{ENT_CLASS_NAME}}
				{
					//Campos de la tabla. Contemplar casos en que el valor a obtener pueda ser nulo
					{{FILL_METHOD_MAP}}
				};
				//
				pRet.Add(obj);
			}
			return pRet;
		}

		/// <summary>
		/// Obtiene los datos existentes aplicando filtros correspondientes
		/// Devuelve una vista extendida de la tabla
		/// </summary>
		/// <param name=""Ex""></param>
		/// <returns></returns>
		public static DataSet Show(Int32? pId, out List<Exception> Ex)
		{
			Ex = new List<Exception>();
			Ex.Add(new Exception(""No implementado.""));
			DataSet ORADataSet = new DataSet();
			//Copiar implementación de get pero llamando al procedure show en caso de ser necesario
			return ORADataSet;
		}
		#endregion
	}
}";
			//
			return plantilla;
		}

		public string GetConvertUtil(string attrName, string netType, bool esNullable)
		{
			string res = "";
			//Convert.IsDBNull(reader["attrName"]) ? 0 : (int)reader["attrName"];
			//o sea ver si es DBNull ? null : Convert CLASICO.
			switch (netType)
			{
				case "Int32":
					res = @" Convert.ToInt32(reader[nameof(obj." + attrName + @").ToUpper()]), ";
					break;
				case "Boolean":
					res = @" Convert.ToBoolean(reader[nameof(obj." + attrName + @").ToUpper()]), ";
					break;
				case "DateTime":
					res = @" Convert.ToDateTime(reader[nameof(obj." + attrName + @").ToUpper()]), ";
					break;
				case "String":
					res = @" reader[nameof(obj." + attrName + @").ToUpper()].ToString(), ";
					break;
			}
			if (esNullable)
			{
				res = "Convert.IsDBNull(reader[nameof(obj." + attrName + ").ToUpper()]) ? (" + netType + "?)null : " + res;
			}
			return res;
		}

		public string GetShowMethodNullList(Tabla tabla)
		{
			string res = "";
			int i = tabla.mapeo.Count + 1;
			res = string.Join(", ", Enumerable.Repeat("null", i));

			return res;
		}

		//Devuelve el mapeo para llenar un datatable en el metodo Fill
		public string GetFillMethodMap(Tabla tabla, bool incluirPK)
		{
			StringBuilder sb = new StringBuilder();

			string paramName = "";
			string attrName = "";
			string netType = "";
			string propName = "";
			int idx = 0;
			string pTemp = "";

			string pkType = tabla.pkNetType;
			
			if (incluirPK)
			{
				//obj.NEstadoTramite = reader[""N_ESTADO_TRAMITE""].ToString();
				pTemp = @"\t" + tabla.pkPropName + " = " + GetConvertUtil(tabla.pkPropName, tabla.pkNetType, false);
				idx++;
				sb.Append(pTemp + "\n");
			}
			foreach (KeyValuePair<string, string> kv in tabla.mapeo)
			{
				paramName = kv.Value;
				attrName = kv.Key;
				propName = Utils.CamelCase(kv.Key, "_");
				netType = tabla.netType[paramName]; 
				//string prop 

				 pTemp = pTemp = @"\t" + propName + " = " + GetConvertUtil(propName, netType, tabla.esNullable[paramName]);

				idx++;
				sb.Append(pTemp + "\n");
			}

			sb.Length = sb.Length - 2; //le quito el \n y la coma final
			sb.Append("\n");

			return sb.ToString();
		}

		//Devuelve la lista de parameteros que recibe el método get
		public string GetMethodParams(Tabla tabla, bool incluirPK)
		{
			StringBuilder sb = new StringBuilder();

			string paramName = "";
			string paramType = "";
			string nullable = "?";
			int idx = 0;
			string pTemp = "";

			string pkType = tabla.pkAdoType;

			if (incluirPK)
			{
				nullable = pkType != "String" ? "?" : "";

				pTemp = tabla.pkNetType + nullable + " " + tabla.pkParamName + ",";
				idx++;
				sb.Append(pTemp + "\n");
			}
			foreach (string param in tabla.mapeo.Values)
			{
				paramName = param;
				paramType = tabla.netType[param];
				nullable = paramType != "String" ? "?" : "";

				pTemp = paramType + nullable + " " + paramName + ",";

				idx++;
				sb.Append(pTemp + "\n");
			}

			sb.Length = sb.Length - 2; //le quito el \n y la coma final
			sb.Append("\n");

			return sb.ToString();
		}


		//Devuelve el código de los OracleParams para el método get 
		public string GetMethodOraParamsGET(Tabla tabla, bool incluirPK)
		{

			/*string plantillaParam = @"                
				oParam[{{IDX}}] = new OracleParameter(""{{PARAM_NAME}}"", OracleDbType.{{PARAM_ADO_TYPE}});
				oParam[{{IDX}}].Value = DBNull.Value;
				if ({{PARAM_NAME}} != null)
					oParam[{{IDX}}].Value = {{PARAM_NAME}};
			";*/
			string plantillaParam = 
				@"oParam.Add(new OracleParameter(nameof({{PARAM_NAME}}), OracleDbType.{{PARAM_ADO_TYPE}}, (object){{PARAM_NAME}} ?? DBNull.Value, ParameterDirection.Input));";

			StringBuilder sb = new StringBuilder();

			string paramName = "";
			string propName = "";
			string paramAdoType = "";
			int idx = 0;
			string pTemp = plantillaParam;

			string pkType = tabla.pkAdoType;

			if (incluirPK)
			{
				pTemp = pTemp.Replace("{{IDX}}", idx.ToString());
				pTemp = pTemp.Replace("{{PARAM_NAME}}", tabla.pkParamName);
				pTemp = pTemp.Replace("{{PARAM_ADO_TYPE}}", tabla.pkAdoType + ", 9");
				pTemp = pTemp.Replace("{{PROP_NAME}}", tabla.pkParamName.Substring(1));
				idx++;
				sb.Append(pTemp + "\n");
			}
			foreach (string param in tabla.mapeo.Values)
			{
				pTemp = plantillaParam;
				paramName = param;
				propName = param.Substring(1);
				paramAdoType = tabla.adoDbType[param];

				switch (paramAdoType)
				{
					case "Int32":
						paramAdoType += ", 9";
						break;
					case "NVarchar2":
						paramAdoType += ", 100";
						break;
				}

				pTemp = pTemp.Replace("{{IDX}}", idx.ToString());
				pTemp = pTemp.Replace("{{PARAM_NAME}}", paramName);
				pTemp = pTemp.Replace("{{PARAM_ADO_TYPE}}", paramAdoType);
				pTemp = pTemp.Replace("{{PROP_NAME}}", propName);

				idx++;
				sb.Append(pTemp + "\n");
			}

			return sb.ToString();
		}

		//Devuelve el código que crea los OracleParameters y les asigna su valor
		public string GetOraParamsDemas(Tabla tabla)
		{
			/*string plantillaParam = @"				
				oParam[{{IDX}}] = new OracleParameter(""{{PARAM_NAME}}"", OracleDbType.{{PARAM_ADO_TYPE}});
				oParam[{{IDX}}].Value = obj.{{PROP_NAME}};
			";*/
			string plantillaParam = 
				@"oParam.Add(new OracleParameter(""{{PARAM_NAME}}"", OracleDbType.{{PARAM_ADO_TYPE}}, (object)obj.{{PROP_NAME}} ?? DBNull.Value, ParameterDirection.Input));";
			StringBuilder sb = new StringBuilder();

			string paramName = "";
			string propName = "";
			string paramAdoType = "";
			int idx = 0;
			string pTemp = plantillaParam;

			string pkType = tabla.pkAdoType;
			
			foreach (KeyValuePair<string, string> kv in tabla.mapeo)
			{
				pTemp = plantillaParam;
				paramName = kv.Value;
				propName = Utils.CamelCase(kv.Key, "_");
				paramAdoType = tabla.adoDbType[paramName];

				switch (paramAdoType)
				{
					case "Int32":
						paramAdoType += ", 9";
						break;
					case "NVarchar2":
						paramAdoType += ", 100";
						break;
				}

				pTemp = pTemp.Replace("{{IDX}}", idx.ToString());
				pTemp = pTemp.Replace("{{PARAM_NAME}}", paramName);
				pTemp = pTemp.Replace("{{PARAM_ADO_TYPE}}", paramAdoType);
				pTemp = pTemp.Replace("{{PROP_NAME}}", propName);

				idx++;
				sb.Append(pTemp + "\n");
			}

			return sb.ToString();
		}
	}
}
