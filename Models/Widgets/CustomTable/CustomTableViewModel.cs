using CMS.CustomTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MEDIOClinic.Models.Widgets.CustomTableWidget
{
    public class CustomTableViewModel
    {
        public string CustomTableName { get; set; }
        // public List<CustomTableItem> Items { get; set; }
        public List<string> ColumnNames { get; set; }
        public string ErrorMessage { get; set; }
        public List<WidgetTableItem> Items { get; set; }
    }


    public class WidgetTableItem
    {
        public List<string> ColumnValues { get; set; }
    }
}