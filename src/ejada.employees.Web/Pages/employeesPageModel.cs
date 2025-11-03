using ejada.employees.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ejada.employees.Web.Pages;

public abstract class employeesPageModel : AbpPageModel
{
    protected employeesPageModel()
    {
        LocalizationResourceType = typeof(employeesResource);
    }
}
