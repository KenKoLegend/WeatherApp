using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication
{
    class ApiConf 
{
        private readonly string apiKey = "684b3903b621507cf6e2016b0dd57429";
        private string requestURL = "https://api.openweathermap.org/data/2.5/weather";
        public WeatherMapResponse ApiCall(string city)
        {
            //neues Objekt erstellen
            HttpClient httpClient = new HttpClient();
            //Url zusammensetzen
            var finalUri = requestURL + "?q=" + city + "&appid=" + apiKey + "&units=metric";
            //Anfrage senden und asyncron warten (.Result)
            HttpResponseMessage httpResponse = httpClient.GetAsync(finalUri).Result;
            string response = httpResponse.Content.ReadAsStringAsync().Result;
            WeatherMapResponse weatherMapResponse = JsonConvert.DeserializeObject<WeatherMapResponse>(response);
            return weatherMapResponse;
        }



    }
}