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


            // Initializes a the view model and sets its value
            var model = new CustomTableViewModel
            {
                Items = new List<WidgetTableItem>(),
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

                    var customTableItems = new List<CustomTableItem>();
                    // Check if the user input something in the Column property
                    if (!String.IsNullOrWhiteSpace(properties.ColumnNames))
                    {
                        // Check if user has entered valid column name
                        try
                        {
                            // Calls the query with the input Column names
                            customTableItems = query.Columns(properties.ColumnNames).ToList();
                            model.ColumnNames = properties.ColumnNames.Split(',').ToList();
                        }
                        catch (Exception e)
                        {
                            model.ErrorMessage = "Something went wrong. " + e.Message;
                        }
         
                    }
                    else
                    {
                        customTableItems = query.ToList();           
                        // If there is at least 1 item in the custom table, we retrieve the ColumnNames
                        if (customTableItems.Count > 0)
                        {
                            model.ColumnNames = customTableItems.First().ColumnNames;
                        }
                    }
                    foreach(CustomTableItem item in customTableItems)
                    {
                        List<string> values = new List<string>();

                        foreach(string column in model.ColumnNames) 
                        {
                            var value = item.GetValue(column.Trim());
                            values.Add(value == null ? "" : value.ToString());
                            
                        }

                        model.Items.Add(new WidgetTableItem
                        {
                            ColumnValues = values
                        }); 
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