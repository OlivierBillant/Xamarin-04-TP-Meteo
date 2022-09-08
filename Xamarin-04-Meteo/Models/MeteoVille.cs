using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_04_Meteo.Models
{
    public class MeteoVille
    {
        public string Name { get; set; }
        public int Cod { get; set; }
        public string Message { get; set; }
        public Main Main { get; set; }
        public List<Weather> Weather { get; set; }
    }
}
