using Kentico.PageBuilder.Web.Mvc;
using MedioClinic.Controllers.Widgets;
using MedioClinic.Models.FormComponents.FormComponentProperties;
using MedioClinic.Models.Widgets.WeatherWidget;
using MEDIOClinic.Models.Widgets.CustomTableWidget;
using MEDIOClinic.Models.Widgets.WeatherWidget;
using Newtonsoft.Json;
using NuGet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

[assembly: RegisterWidget("MedioClinic.Widgets.WeatherWidget", typeof(WeatherWidgetController), "Weather Widget", IconClass = "icon-octothorpe")]

namespace MedioClinic.Controllers.Widgets
{
    public class WeatherWidgetController : WidgetController<WeatherWidgetProperties>
    {
      
        private const string API_ID = "df471b564b37f8fee8cc3cedde8e95b3";
        public ActionResult Index()
        {
            WeatherWidgetProperties properties = GetProperties();
            var model = new WeatherWidgetViewModel();


            if (String.IsNullOrEmpty(properties.City))
            {
                
                model.IsCitySelected = false;
                model.Error_msg = "Please select the City";
            }
            else
            {

                try 
                {
                    
                    model.IsCitySelected = true;
                    model.Units = properties.Units;
                    model.City = properties.City;
                    string URL = String.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units={1}&APPID={2}", model.City, model.Units, API_ID);

                    
                    var client = new WebClient();
                    client.Encoding = Encoding.UTF8;
                    string jsonData = client.DownloadString(URL);
         
                    WeatherResponse response = JsonConvert.DeserializeObject<WeatherResponse>(jsonData);

                    model.City = response.name;
                    model.Temp = (int)Math.Round(response.main.temp);
                    model.Pressure = "Pressure: " + response.main.pressure.ToString() + " kPa";
                    model.Humidity = "Humidity: " + response.main.humidity.ToString() + " %";
                    model.Temp_max = (int)Math.Round(response.main.temp_max);
                    model.Temp_min = (int)Math.Round(response.main.temp_min);
                    model.Weather_Icon = response.weather[0].icon + ".png";

                    // private method -> Gets unitType string and sets model to (°C / °K / °F)
                    model.Unit_Type = Get_Unit_Type(properties.Units);
                    
                }
                catch (Exception e) // in case of wrong input (non-existing city)
                {
                    model.IsCitySelected = false;
                    model.Error_msg = e.Message;
                    
                }
            }
            

            return PartialView("Widgets/_WeatherWidget", model);
        }

        // Gets unitType string and sets model to(°C / °K / °F)
        private string Get_Unit_Type(string properties_UnitType)
        {
            if (properties_UnitType.Equals("metric"))
            {
                return "°C";
            }
            else if (properties_UnitType.Equals("default"))
            {
                return "°K";
            }
            else if (properties_UnitType.Equals("imperial"))
            {
                return "°F";
            }
            else
            {
                return "Something went wrong(private method Get_Unit_Type in WeatherWidgetController";
            }
        }


        
        


    }
}