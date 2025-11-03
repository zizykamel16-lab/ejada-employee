using Volo.Abp.Modularity;

namespace ejada.employees;

/* Inherit from this class for your domain layer tests. */
public abstract class employeesDomainTestBase<TStartupModule> : employeesTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
