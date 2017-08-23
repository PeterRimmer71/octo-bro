using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Cato
{
    class WeatherApiClient
    {
        public static void GetWeatherForcast()
        {
            var url = "http://samples.openweathermap.org/data/2.5/forecast?id=524901&appid=b1b15e88fa797225412429c1c50c122a1";

            // Synconious Consumption
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);

            // Create the JSON serializer and parse the response
            /*
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(WeatherData));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                var weatherData = (WeatherData)serializer.ReadObject(ms);
            }  */
            WeatherData deserializedProduct = JsonConvert.DeserializeObject<WeatherData>(content);

            var weatherList = deserializedProduct
                .List
                .SelectMany(list => list.Weather)
                .ToList();

            var myCity = deserializedProduct.City;
        }
    }
}
