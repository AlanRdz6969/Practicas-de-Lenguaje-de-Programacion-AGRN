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

            Console.WriteLine(list[0].login, list[1].id, list[2].node_id, list[3].avatar_url, list[4].gravatar_id, list[5].url, list[6].html_url, list[7].followers_url, list[8].following_url, list[9].gists_url, list[10].starred_url, list[11].subscriptions_url, list[12].organizations_url, list[13].repos_url, list[14].events_url, list[15].received_events_url, list[16].type, list[17].site_admin, list[18].name, list[19].company, list[20].blog, list[21].location, list[22].email, list[23].hireable, list[24].bio, list[25].twitter_username, list[26].public_repos, list[27].public_gists, list[28].followers, list[29].following, list[30].created_at, list[31].updated_at );

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
