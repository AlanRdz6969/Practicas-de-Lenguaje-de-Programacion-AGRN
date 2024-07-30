using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;


namespace Conexion1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Cuenta> list = GithubApi();

            Console.WriteLine(list[0].message, list[1].documentation_url, list[2].status );

        }

        public static List<Cuenta> GithubApi()
        {
            try
            {
                using (RestClient client = new RestClient("https://api.github.com/users/%3CAlanRdz6969%3E"))
                {
                    RestRequest request = new RestRequest();
                    string respuesta;
                    var response = client.Get(request);
                    respuesta = response.Content;

                    List<Cuenta> salida = JsonConvert.DeserializeObject<List<Cuenta>>(respuesta);

                    return salida;
                }
            }
            catch
            {
                List<Cuenta> salida = new List<Cuenta>();
                return salida;
            }

        }
    }
}
