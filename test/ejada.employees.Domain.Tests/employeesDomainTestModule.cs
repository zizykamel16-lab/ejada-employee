using Volo.Abp.Modularity;

namespace ejada.employees;

[DependsOn(
    typeof(employeesDomainModule),
    typeof(employeesTestBaseModule)
)]
public class employeesDomainTestModule : AbpModule
{

}
