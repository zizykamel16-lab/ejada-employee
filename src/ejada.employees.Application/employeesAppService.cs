using ejada.employees.Localization;
using Volo.Abp.Application.Services;

namespace ejada.employees;

/* Inherit your application services from this class.
 */
public abstract class employeesAppService : ApplicationService
{
    protected employeesAppService()
    {
        LocalizationResource = typeof(employeesResource);
    }
}
