using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WodGenerator.Dominio.Helpers
{
    public static class HttpHelper
    {
        private static string urlBase = "https://my-json-server.typicode.com/leonardotostes90/wodgenerator/";

        public static async Task<T> Request<T>(string url)
        {
            var httpClient = new HttpClient();
            var httpResult = httpClient.GetAsync($"{urlBase}{url}");
            var result = httpResult.Result;
            var serializacao = await result.Content.ReadAsStringAsync();
            var retorno = JsonConvert.DeserializeObject<T>(serializacao);

            return retorno;
        }
    }
}
