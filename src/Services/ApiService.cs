using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Sunshine.UWP.Models;

namespace Sunshine.UWP.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IReadOnlyCollection<Previsao>> ListarPrevisoes()
        {            
            var response = await _httpClient.GetStringAsync(Constantes.UrlApi);
            var json = await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<JsonObject>(response));

            return json.list
                .Select(c => new Previsao()
                {
                    Minima = c.temp.min,
                    VelocidadeVento = c.speed,
                    Pressao = c.pressure,
                    Status = c.weather.First().main,
                    PosicaoVento = c.deg,
                    Humidade = c.humidity,
                    Maxima = c.temp.max,
                    Descricao = c.weather.First().description,
                    Data = new DateTime(1970, 1,1).AddSeconds(c.dt)
                })
                .ToList();
        }        
    }
}
