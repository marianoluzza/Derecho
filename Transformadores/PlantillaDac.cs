using Derecho.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            p = p.Replace("{{CLASS_NAME}}", tabla.className+"Dac");

            //remplazo los oraparams para el insert
            string insertOraParams = GetOraParamsInsert(tabla, true);
            p = p.Replace("{{INSERT_ORA_PARAMS}}", insertOraParams);

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
            string plantilla = @"
    public partial class {{CLASS_NAME}}
    {
        #region Manipulacion de Registros
        public static Hashtable insert({{ENT_CLASS_NAME}} obj, out List<Exception> Ex)
        {
            Hashtable ret = new Hashtable();
            Ex = new List<Exception>();
            OracleParameter[] oParam = new OracleParameter[{{CANT_PARAMS_INSERT}}];
			
            try
            {
                {{INSERT_ORA_PARAMS}}

                Data pData = new Data();

                pData.EjecutarSP(""AGRO_REGISTRO.{{PCK_NAME}}.PR_{{BASE_NAME}}_INSERT"", oParam);
                obj.{{PK_PROP_NAME}} = Convert.ToInt32(oParam[0].Value.ToString());
                
                ret.Add(""O_{{PK_PROP_NAME}}"", obj.{{PK_PROP_NAME}});
            }
            catch (Exception ex)
            {
                Ex.Add(ex);
            }
            return ret;
        }

        public static Hashtable update({{ENT_CLASS_NAME}} obj, out List<Exception> Ex)
        {
            Hashtable ret = new Hashtable();
            Ex = new List<Exception>();
            OracleParameter[] oParam = new OracleParameter[{{CANT_PARAMS_INSERT}}];

            try
            {
                //Lista de parametro igual a la del método insert
				{{INSERT_ORA_PARAMS}}

                Data pData = new Data();

                pData.EjecutarSP(""AGRO_REGISTRO.{{PCK_NAME}}.PR_{{BASE_NAME}}_UPDATE"", oParam);
                ret.Add(""O_{{PK_PROP_NAME}}"", obj.{{PK_PROP_NAME}});


            }
            catch (Exception ex)
            {
                Ex.Add(ex);
            }
            return ret;
        }

        public static Hashtable delete(int {{PK_PARAM_NAME}}, out List<Exception> Ex)
        {
            Hashtable ret = new Hashtable();
            Ex = new List<Exception>();
            OracleParameter[] oParam = new OracleParameter[1];

            try
            {
                oParam[0] = new OracleParameter(""{{PK_PARAM_NAME}}"", OracleDbType.Int32, 9);
                oParam[0].Value = {{PK_PARAM_NAME}};

                Data pData = new Data();

                pData.EjecutarSP(""AGRO_REGISTRO.{{PCK_NAME}}.PR_{{BASE_NAME}}_DELETE"", oParam);
                ret.Add(""O_{{PK_PROP_NAME}}"", {{PK_PARAM_NAME}});

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
        /// Obtiene los  de actividades existentes aplicando filtros correspondientes
        /// Devuelve la estructura de la tabla
        /// </summary>
        /// <param name=""Ex""></param>
        /// <returns></returns>
        public static List<{{ENT_CLASS_NAME}}> Get(
                        {{GET_METHOD_PARAMS}}, 
						out List<Exception> Ex)
        {

            Ex = new List<Exception>();
            List<{{ENT_CLASS_NAME}}> obj = new List<{{ENT_CLASS_NAME}}>();

            OracleParameter[] oParam = new OracleParameter[{{CANT_PARAMS_INSERT}}];

            DataSet ORADataSet = new DataSet();
            Data objData = new Data();

            try
            {
                {{GET_METHOD_ORA_PARAMS}}

                objData.EjecutarSP(""AGRO_REGISTRO.{{PCK_NAME}}.PR_{{BASE_NAME}}_GET"", oParam, ORADataSet);
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
        /// Obtiene todos los  de actividades existentes
        /// Devuelve la estructura de la tabla
        /// </summary>
        /// <param name=""Ex""></param>
        /// <returns></returns>
        public static List<{{ENT_CLASS_NAME}}> GetAll(out List<Exception> Ex)
        {
        return Get({{NULL_LIST}},out Ex);
        }

        private static List<{{ENT_CLASS_NAME}}> Fill(DataTable tbl)
        {
            List<{{ENT_CLASS_NAME}}> pRet = new List<{{ENT_CLASS_NAME}}>();

            foreach (DataRow reader in tbl.Rows)
            {
                {{ENT_CLASS_NAME}} obj = new {{ENT_CLASS_NAME}}();
                //Campos de la tabla. Contemplar casos en que el valor a obtener pueda ser nulo
				{{FILL_METHOD_MAP}}
                
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
        public static DataSet Show(
                        {{GET_METHOD_PARAMS}},
						out List<Exception> Ex)
        {
            Ex = new List<Exception>();

			Ex.Add(new Exception(""No implementado.""));
            DataSet ORADataSet = new DataSet();
			//Copiar implementación de get pero llamando al procedure show en caso de ser necesario
            return ORADataSet;
        }

		#endregion
	}
";

            return plantilla;
        }

        public string GetConvertUtil(string attrName, string netType) {
            string res = "";

            switch (netType) {
                case "Int32":
                    res = @" Convert.ToInt32(reader[""" + attrName + @"""]); ";
                    break;
                case "Boolean":
                    res = @" Convert.ToBoolean(reader[""" + attrName + @"""]); ";
                    break;
                case "DateTime":
                    res = @" Convert.ToDateTime(reader[""" + attrName + @"""]); ";
                    break;
                case "String":
                    res = @" reader[""" + attrName + @"""].ToString(); ";
                    break;
            }

            return res;
        }

        public string GetShowMethodNullList(Tabla tabla) {
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
                pTemp = @"obj." + tabla.pkPropName + " = " + GetConvertUtil(tabla.pkAttrName, tabla.pkNetType); ;
                idx++;
                sb.Append(pTemp + "\n");
            }
            foreach (KeyValuePair<string, string> kv in tabla.mapeo)
            {
                paramName = kv.Value;
                attrName = kv.Key;
                propName = Utils.CamelCase(kv.Key, "_");
                netType = tabla.netType[paramName];

                pTemp = pTemp = @"obj." + propName + " = " + GetConvertUtil(attrName, netType); 

                idx++;
                sb.Append(pTemp + "\n");
            }

            sb.Length = sb.Length - 2; //le quito el \n y la coma final
            sb.Append("\n");

            return sb.ToString();
        }

        //Devuelve la lista de parameteros que recibe el método get
        public string GetMethodParams(Tabla tabla, bool incluirPK) {
            StringBuilder sb = new StringBuilder();

            string paramName = "";
            string paramType = "";
            string nullable = "?";
            int idx = 0;
            string pTemp = "" ;

            string pkType = tabla.pkAdoType;

            if (incluirPK)
            {
                nullable = pkType != "String" ? "?" : "";

                pTemp = tabla.pkNetType + nullable + " " + tabla.pkParamName + "," ;
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

            string plantillaParam = @"                
                oParam[{{IDX}}] = new OracleParameter(""{{PARAM_NAME}}"", OracleDbType.{{PARAM_ADO_TYPE}});
                oParam[{{IDX}}].Value = DBNull.Value;
                if ({{PARAM_NAME}} != null)
                    oParam[{{IDX}}].Value = {{PARAM_NAME}};
            ";

            StringBuilder sb = new StringBuilder();

            string paramName = "";
            string propName = "";
            string paramAdoType = "";
            int idx = 0;
            string pTemp = plantillaParam; ;

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
        public string GetOraParamsInsert(Tabla tabla, bool incluirPK)
        {
            string plantillaParam = @"				
                oParam[{{IDX}}] = new OracleParameter(""{{PARAM_NAME}}"", OracleDbType.{{PARAM_ADO_TYPE}});
				oParam[{{IDX}}].Value = obj.{{PROP_NAME}};
            ";

            StringBuilder sb = new StringBuilder();
            
            string paramName = "";
            string propName = "";
            string paramAdoType = "";
            int idx = 0;
            string pTemp = plantillaParam; 

            string pkType = tabla.pkAdoType;

            if (incluirPK) {
                pTemp = pTemp.Replace("{{IDX}}", idx.ToString());
                pTemp = pTemp.Replace("{{PARAM_NAME}}", tabla.pkParamName);
                pTemp = pTemp.Replace("{{PARAM_ADO_TYPE}}", tabla.pkAdoType + ", 9");
                pTemp = pTemp.Replace("{{PROP_NAME}}", tabla.pkPropName);
                idx++;
                sb.Append(pTemp + "\n");
            }
            foreach (KeyValuePair<string, string> kv in tabla.mapeo)
            {
                pTemp = plantillaParam;
                paramName = kv.Value;
                propName = Utils.CamelCase(kv.Key, "_");
                paramAdoType = tabla.adoDbType[paramName];

                switch (paramAdoType) {
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
