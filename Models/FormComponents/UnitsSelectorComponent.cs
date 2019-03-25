using Kentico.Forms.Web.Mvc;
using MedioClinic.Models.FormComponents;
using CMS.DataEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedioClinic.Models.FormComponents.FormComponentProperties;

[assembly: RegisterFormComponent(UnitsSelectorComponent.IDENTIFIER, typeof(UnitsSelectorComponent), "Unit selector", Description = "Allows to select units from the list", IconClass = "")]
namespace MedioClinic.Models.FormComponents
{
    public class UnitsSelectorComponent : SelectorFormComponent<UnitsSelectorComponentProperties>
    {
        public const string IDENTIFIER = "UnitsSelectorComponent";




        protected override IEnumerable<SelectListItem> GetItems()
        {


            SelectListItem kelvin = new SelectListItem();

            kelvin.Value = "default";
            kelvin.Text = "Kelvin";

            SelectListItem celsius = new SelectListItem();

            celsius.Value = "metric";
            celsius.Text = "Celsius";

            SelectListItem fahrenheit = new SelectListItem();

            fahrenheit.Value = "imperial";
            fahrenheit.Text = "Fahrenheit";

            List<SelectListItem> units = new List<SelectListItem>();
            units.Add(kelvin);
            units.Add(celsius);
            units.Add(fahrenheit);

            //units.Add(new SelectListItem
            //{
            //    Value = "default",
            //    Text = "Kelvin"
            //});

            

            return units;
        }
        
    }


}



