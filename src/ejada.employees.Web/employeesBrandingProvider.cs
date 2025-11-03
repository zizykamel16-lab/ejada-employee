using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using ejada.employees.Localization;

namespace ejada.employees.Web;

[Dependency(ReplaceServices = true)]
public class employeesBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<employeesResource> _localizer;

    public employeesBrandingProvider(IStringLocalizer<employeesResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
