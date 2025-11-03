using ejada.employees.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ejada.employees.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class employeesController : AbpControllerBase
{
    protected employeesController()
    {
        LocalizationResource = typeof(employeesResource);
    }
}
