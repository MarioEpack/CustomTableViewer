using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CMS.CustomTables;
using CMS.DataEngine;
using Kentico.PageBuilder.Web.Mvc;
using MedioClinic.Controllers.Widgets;
using MEDIOClinic.Models.Widgets.CustomTableWidget;

// Assembly attribute to register the widget for the connected Kentico instance
[assembly: RegisterWidget("MedioClinic.Widgets.CustomTableWidget", typeof(CustomTableViewerController), "CustomTableViewer", IconClass = "icon-octothorpe")]
namespace MedioClinic.Controllers.Widgets
{
    /// <summary>
    /// A sample widget displaying a message customizable by a widget property.
    /// </summary>
    public class CustomTableViewerController : WidgetController<CustomTableWidgetProperties>
    {

        // Default GET action used to retrieve the widget markup
        public ActionResult Index()
        {
            // Retrieves the properties as a strongly typed object
            CustomTableWidgetProperties properties = GetProperties();


            // Creates a new model and sets its value
            var model = new CustomTableViewModel
            {
                Items = new List<CustomTableItem>(),
                ColumnNames = new List<string>()
            };

            if (String.IsNullOrEmpty(properties.CustomTableCodeName))
            {
                model.ErrorMessage = "Please select the custom table";
            } else
            {
                
                
                // Gets the custom table
                DataClassInfo customTable = DataClassInfoProvider.GetDataClassInfo(properties.CustomTableCodeName);

                if (customTable != null)
                {
                    model.CustomTableName = customTable.ClassDisplayName;
                    
                    // Prepare the object query
                    var query = CustomTableItemProvider.GetItems(properties.CustomTableCodeName);


                    // Check if the user input something in the Column property
                    if (!String.IsNullOrWhiteSpace(properties.ColumnNames))
                    {
                        // Check if user has entered valid column name
                        try
                        {
                            // Calls the query with the input Column names
                            model.Items = query.Columns(properties.ColumnNames).ToList();
                            model.ColumnNames = properties.ColumnNames.Split(',').ToList();
                        }
                        catch (Exception e)
                        {
                            model.ErrorMessage = "Something went wrong. " + e.Message;
                        }
         
                    }
                    else
                    {
                        model.Items =  query.ToList();

                        // If there is at least 1 item in the custom table, we retrieve the ColumnNames
                        if (model.Items.Count > 0)
                        {
                            model.ColumnNames = model.Items.First().ColumnNames;
                        }
                    }
                    
                } else
                {
                    model.ErrorMessage = "Looks like the selected table does not exist";
                }
            }

            return PartialView("Widgets/_CustomTableViewWidget", model);
        }

        
    }
}