using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;
using MedioClinic.Models.FormComponents;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

[assembly: RegisterFormComponent("CustomTableSelectorComponent", typeof(CustomTableSelectorComponent), "Custom table selector", Description = "Allows to select a custom table from the list", IconClass = "")]

namespace MedioClinic.Models.FormComponents
{
    public class CustomTableSelectorComponent : SelectorFormComponent<CustomTableSelectorComponentProperties>
    {
        public const string IDENTIFIER = "CustomTableSelectorComponent";

        // Retrieves data to be displayed in the selector
        protected override IEnumerable<SelectListItem> GetItems()
        {
            var customTables = DataClassInfoProvider.GetClasses()
                            .WhereEquals("ClassIsCustomTable", 1)
                            .Columns("ClassDisplayName", "ClassName");

            // Iterates over retrieved data and transforms it into SelectListItems
            foreach (var table in customTables)
            {
                var listItem = new SelectListItem()
                {
                    Value = table.ClassName,
                    Text = table.ClassDisplayName
                };

                yield return listItem;
            }
        }


    }
}