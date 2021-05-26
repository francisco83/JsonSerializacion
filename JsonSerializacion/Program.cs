using System;
using System.Text.Json;
using JsonSerializacion.Models;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/*

{
"user":"pagofacil",
"password":"pagofacil",
"utility":"90160330",
"tipo_operacion":"CashIn",
"terminal":"T50008",
"fecha":"20210513",
"hora":"121100",
"cod_operacion":"C",
"campos_busqueda":[
{
"campo1":"96",
"campo2":"null"
}
]
}
 
 */

namespace JsonSerializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba de Serializacion/Deserializacion");


            consulta consulta = new consulta();
            consulta.Name = "Francisco";
            consulta.LastName = "Flores";

            string[] acciones = new string[2];
            acciones[0] = "correr";
            acciones[1] = "saltar";
            consulta.Action = acciones;

            IList<string> song = new List<string>();
            song.Add("Prueba1");
            song.Add("Prueba2");
            song.Add("Prueba3");

            consulta.Song = song;

            Dictionary<string, string> diccionario = new Dictionary<string, string>();

            diccionario.Add("1", "valor1");
            diccionario.Add("2", "valor2");

            consulta.Dictionary = diccionario;


            IList<Dictionary<string, string>> Parameters = new List<Dictionary<string, string>>();
            Parameters.Add(diccionario);

            consulta.Parameters = Parameters;
            //Cargo el diccionario con parametros.
            //
            Dictionary<string, string>[] matrix = new Dictionary<string, string>[2];
            matrix[0] = new Dictionary<string, string>();          
            matrix[0].Add("uno", "first str");
            matrix[0].Add("dos", "second str");

            consulta.Matriz = matrix;

            //

            IList<parametros> ListaParametros = new List<parametros>();
            parametros param = new parametros();
            param.campos = "campo1";
            param.valor = "2356";

            parametros param1 = new parametros();
            param1.campos = "campo2";
            param1.valor = "..";

            ListaParametros.Add(param);
            ListaParametros.Add(param1);

            consulta.ListaParametros = ListaParametros;


            //
            parametros[] param_aux = new parametros[2];

            param_aux[0] = param;
            param_aux[1] = param1;

            consulta.Param = param_aux;

            //
            busqueda buscar_aux = new busqueda();
            string[][] arr = new string[2][];

            arr[0] = new string[2] { "campo1", "2356" };
            arr[1] = new string[2] { "campo2", "400" };

            buscar_aux.Busqueda = arr;

            consulta.Buscar = buscar_aux;


            string miJson = JsonSerializer.Serialize(consulta);

            Console.WriteLine(miJson);

            Console.ReadLine();
            
        }
    }
}
