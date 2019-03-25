using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedioClinic.Models.Widgets.WeatherWidget
{
    public class WeatherWidgetViewModel
    {
        public string City { get; set; }
        public string Units { get; set; }
        public bool IsCitySelected { get; set; }
        public int Temp { get; set; }
        public string Pressure { get; set; }
        public string Humidity { get; set; }
        public int Temp_min { get; set; }
        public int Temp_max { get; set; }
        public string Weather_Icon { get; set; }
        public string Unit_Type { get; set; }
        public string Error_msg { get; set; }
    }
}