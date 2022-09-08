using RestSharp;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin_04_Meteo.Models;

namespace Xamarin_04_Meteo.Utils
{
    public class MeteoService
    {
        private RestClient client;
        public MeteoService()
        {
            //On cree un instance de RestClient
            client = new RestClient(Constant.endpoint);
        }

        public Task<MeteoVille> CurrentWeather(string cityName) 
        {
            var apiQuery = $"{Constant.apiParam}{cityName}{Constant.apiKey}";
            var request = new RestRequest(apiQuery);

            return client.GetAsync<MeteoVille>(request);
        }
    }
}
