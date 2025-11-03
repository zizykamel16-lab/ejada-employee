using Volo.Abp.Modularity;

namespace ejada.employees;

public abstract class employeesApplicationTestBase<TStartupModule> : employeesTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
