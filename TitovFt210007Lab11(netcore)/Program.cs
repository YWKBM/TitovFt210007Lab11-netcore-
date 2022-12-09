using System;
using System.Runtime.ExceptionServices;
using System.Text.Json;

namespace TitovFt210007Lab11_netcore_
{

    
    internal class Program
    {

        static void Main(string[] args)
        {
            //тестовый запрос
            GetRequest get = new GetRequest("https://restcountries.com/v2/all?fields=name,capital");
            get.Run();
            var resp = get.Response;

            Rootobject[] root = JsonSerializer.Deserialize<Rootobject[]>(resp);
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach(var r in root)
            {
                Console.WriteLine(r.name + " " + r.capital);
                result.Add(r.name, r.capital);
                
            }
        }
    }
}


