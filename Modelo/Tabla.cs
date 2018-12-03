using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derecho.Modelo
{
    class Tabla
    {
        public string className { get; set; }
        public string tableName { get; set; }
        public string pkAttrName { get; set; }
        public string pkParamName { get; set; }
        public string pkPropName { get; set; }
        public string pkType { get; set; }
        public string pkNetType { get; set; }
        public string pkAdoType { get; set; }
        //diccionario para atributoTabla -> nombreparámetro
        public Dictionary<string, string> mapeo { get; set; }
        //diccionario para nombreparametro -> tipo oracle pck
        public Dictionary<string, string> paramType { get; set; }
        //diccionario para nombreparametro -> tipo ora param
        public Dictionary<string, string> adoDbType { get; set; }
        //diccionario para nombreparametro -> tipo en .NET
        public Dictionary<string, string> netType { get; set; }
    }
}
