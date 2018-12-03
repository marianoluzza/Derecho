using Derecho.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derecho.Transformadores
{
    class PlantillaPackage : Plantilla
    {

        public override string Generar(Tabla tabla)
        {
            //table name sin el T_
            baseName = tabla.tableName.Substring(2);
            pckName = "PCK_" + baseName;

            //obtengo la plantilla
            string p = Plantilla();

            //remplazo noombre del paquete
            p = p.Replace("{{PCK_NAME}}", pckName);

            //remplazo basename
            p = p.Replace("{{BASE_NAME}}", baseName);

            //remplazo tablename
            p = p.Replace("{{TABLE_NAME}}", tabla.tableName);

            //remplazo nombre del parametro para pk
            p = p.Replace("{{PK_PARAM_NAME}}", tabla.pkParamName);

            //remplazo nombre del atributo para pk
            p = p.Replace("{{PK_ATTR_NAME}}", tabla.pkAttrName);

            //remplazo tipo del atributo para pk
            p = p.Replace("{{PK_PARAM_TYPE}}", tabla.pkType);

            //obtengo lista de parametros con la pk
            string parametros = this.GetParamList(tabla, true, false); //no me los devuelve con su tipo, hay que hacer que devuelva la lista con el tipo de dato de la base
            p = p.Replace("{{PARAM_LIST_WPK}}", parametros);

            //obtengo lista de parametros SIN la pk para el insert asi le cambio la direcccion del parametro a out
            string parametrosSinPk = this.GetParamList(tabla, false, true); //no me los devuelve con su tipo, hay que hacer que devuelva la lista con el tipo de dato de la base
            p = p.Replace("{{PARAM_LIST}}", parametrosSinPk);

            //lista de params con tipo 
            string parametrosWT = this.GetParamList(tabla, true, true);
            p = p.Replace("{{PARAM_LIST_WPKT}}", parametrosWT);

            //obtengo la lista de atributos con la PK
            string attribs = this.GetAttrList(tabla, true);
            p = p.Replace("{{ATTR_LIST_WPK}}", attribs);

            //obtengo la lista de asignación para la sentencia UPDATE
            string updateList = this.GetUpdateList(tabla, true);
            p = p.Replace("{{UPDATE_LIST_WPK}}", updateList);


            //devuelvo la plantilla
            return p;
        }

        private string Plantilla() {
            string plantilla = @"
                /* --------------------------------> SPEC <---------------------------------- */
                
                CREATE OR REPLACE PACKAGE ""AGRO_REGISTRO"".""{{PCK_NAME}}""

                AS

                /* PROCEDIMIENTO QUE DEVUELVE LOS ESTADOS POSIBLES DE UN TRAMITE, PUEDO FILTRAR POR ID Y VIGENTE */
                PROCEDURE PR_{{BASE_NAME}}_GET 
                    (
                        {{PARAM_LIST_WPKT}},
    	                pCursor out types.cursorType
                    );

                /*PROCEDIMIENTO QUE INSERTA UN NUEVO ESTADO TRAMITE Y DEVUELVE EL NUEVO ID*/
                PROCEDURE PR_{{BASE_NAME}}_INSERT
                    (
                        {{PK_PARAM_NAME}} OUT {{PK_PARAM_TYPE}},
                        {{PARAM_LIST}}
                    );

                /*PROCEDIMIENTO QUE ACTUALIZA UN REGITRO DE ESTADOS TRAMITE*/
                PROCEDURE PR_{{BASE_NAME}}_UPDATE
                    (
                        {{PARAM_LIST_WPKT}}
                    );

                /*PROCEDIMIENTO QUE BORRA UN REGISTRO DE ESTADOS TRAMITE*/
                PROCEDURE PR_{{BASE_NAME}}_DELETE
                    (
                        {{PK_PARAM_NAME}} IN {{PK_PARAM_TYPE}}
                    );
                END;

                /* --------------------------------> BODY <---------------------------------- */
                CREATE OR REPLACE PACKAGE BODY ""AGRO_REGISTRO"".""{{PCK_NAME}}"" AS


                /* PROCEDIMIENTO QUE DEVUELVE LOS {{BASE_NAME}} Y APLICA UN FILTRO POR PK */
                PROCEDURE PR_{{BASE_NAME}}_GET
                    (
                        {{PARAM_LIST_WPKT}},
                        pCursor out types.cursorType
                    ) IS
                BEGIN

                    OPEN pCursor FOR
                        SELECT
                            {{ATTR_LIST_WPK}}
                        FROM   {{TABLE_NAME}}
                        WHERE
                            ({{PK_PARAM_NAME}} IS NULL OR {{PK_ATTR_NAME}} = {{PK_PARAM_NAME}});
 

                    END PR_{{BASE_NAME}}_GET;

                    /*PROCEDIMIENTO QUE INSERTA UN NUEVO EN {{BASE_NAME}} Y DEVUELVE EL NUEVO ID*/
                    PROCEDURE PR_{{BASE_NAME}}_INSERT
                        (
                            {{PK_PARAM_NAME}} OUT {{PK_PARAM_TYPE}},
                            {{PARAM_LIST}}
                        ) IS
                            pNextId NUMBER;
                    BEGIN
                        SELECT SEQ_{{BASE_NAME}}.NEXTVAL INTO pNextId FROM DUAL;
                        INSERT INTO {{TABLE_NAME}} ( {{ATTR_LIST_WPK}} ) VALUES( {{PARAM_LIST_WPK}} );
                        {{PK_PARAM_NAME}} := pNextId;
                            
                    END PR_{{BASE_NAME}}_INSERT;

                    /*PROCEDIMIENTO QUE ACTUALIZA UN REGITRO DE {{BASE_NAME}}*/
                    PROCEDURE PR_{{BASE_NAME}}_UPDATE
                        (
                            {{PARAM_LIST_WPKT}}
                        ) IS
                    BEGIN
                        UPDATE {{TABLE_NAME}} SET
                            {{UPDATE_LIST_WPK}}
                         WHERE
                            {{PK_ATTR_NAME}} = {{PK_PARAM_NAME}};

                    END PR_{{BASE_NAME}}_UPDATE;

                    /*PROCEDIMIENTO QUE BORRA UN REGISTRO DE {{BASE_NAME}} POR ID*/
                    PROCEDURE PR_{{BASE_NAME}}_DELETE
                        (
                            {{PK_PARAM_NAME}} IN {{PK_PARAM_TYPE}}
                        ) IS
                    BEGIN
                        DELETE FROM {{TABLE_NAME}} WHERE {{PK_ATTR_NAME}} = {{PK_PARAM_NAME}};

                    END PR_{{BASE_NAME}}_DELETE;

                    END {{PCK_NAME}};

                    ";

            return plantilla;
        }

        public string GetParamList(Tabla tabla, bool incluirPK, bool incluirTipos) {
            StringBuilder sb = new StringBuilder();
            
            string pkType = incluirTipos? " IN " + tabla.pkType : "";

            if (incluirPK)
                sb.Append(tabla.pkParamName + pkType + ",\n");

            foreach (string param in tabla.mapeo.Values) {
                string paramType = incluirTipos ? " IN " + tabla.paramType[param] : "";
                sb.Append(param + paramType + ",\n");
            }
            sb.Length = sb.Length - 2;
            sb.Append("\n");


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

        public string GetUpdateList(Tabla tabla, bool incluirPK)
        {
            StringBuilder sb = new StringBuilder();

            if (incluirPK)
                sb.Append(tabla.pkAttrName + " = " + tabla.pkParamName + ",\n");

            foreach (KeyValuePair<string, string> kv in tabla.mapeo)
            {
                sb.Append(kv.Key + " = " + kv.Value + ",\n");
            }
            sb.Length = sb.Length - 2;
            sb.Append("\n");


            return sb.ToString();
        }
    }
}
