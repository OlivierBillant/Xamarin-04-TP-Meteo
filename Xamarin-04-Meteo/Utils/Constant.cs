using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Shapes;
using Xamarin_04_Meteo.Models;

namespace Xamarin_04_Meteo.Utils
{
    class Constant
    {
        public static string endpoint = "https://api.openweathermap.org/data/2.5/";
        public static string apiParam = "weather?units=metric&lang=fr&q=";
        public static string apiKey = "&appid=482c64405fe5d26c4e8d70c161baaa0e";
        public static string iconCall = "https://openweathermap.org/img/wn/";
    }
}
