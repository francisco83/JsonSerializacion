using System;
using System.Collections.Generic;

namespace JsonSerializacion.Models
{
    public class consulta
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string[] Action { get; set; }
        public IList<string> Song { get; set; }
        public Dictionary<string, string> Dictionary { get; set; }
        public IList<Dictionary<string, string>> Parameters { get; set; }
        public Dictionary<string, string>[] Matriz { get; set; }
        public IList<parametros> ListaParametros { get; set; }
        public parametros[] Param { get; set; }
        public busqueda Buscar { get; set; }
    }
}
