using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace weatherApiApp.Models
{
    public class WeatherClass
    {
        public object GetCurrentWeather()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Detroit&APPID=f98f62d8d7b41b43e42d474c68c6bc8d&units=imperial";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<object>(content);

            return jsonContent;
        }
    }
}