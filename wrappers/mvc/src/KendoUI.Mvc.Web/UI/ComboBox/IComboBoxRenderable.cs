namespace KendoUI.Mvc.UI
{
    using System.Collections.Generic;

    public interface IComboBoxRenderable : IDropDownRenderable
    {
        IDictionary<string, object> InputHtmlAttributes { get; }
    }
}
