using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using MedioClinic.Models.FormComponents;

namespace MEDIOClinic.Models.Widgets.CustomTableWidget
{
    public sealed class CustomTableWidgetProperties : IWidgetProperties
    {
        
        [EditingComponent(CustomTableSelectorComponent.IDENTIFIER, Order = 0, Label = "Table Name")]
        public string CustomTableCodeName { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Column Names", Tooltip = "Please enter the columns you would like to select separated by a comma(,) for example: Column1, Column2, Column3")]
        public string ColumnNames { get; set; }
    }
}