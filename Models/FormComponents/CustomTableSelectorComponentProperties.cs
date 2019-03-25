using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kentico.Forms.Web.Mvc;

namespace MedioClinic.Models.FormComponents
{
    public class CustomTableSelectorComponentProperties : SelectorProperties
    {
        // Implement any required custom properties here
        public string Columns { get; set; }
    }
}