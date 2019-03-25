using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using MedioClinic.Models.FormComponents;

namespace MEDIOClinic.Models.Widgets.WeatherWidget
{
    public sealed class WeatherWidgetProperties : IWidgetProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 0, Label = "City")]
        public string City { get; set; }

        [EditingComponent(UnitsSelectorComponent.IDENTIFIER, Order = 0, Label = "Units")]
        public string Units { get; set; }
    }
}