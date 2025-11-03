using Volo.Abp.Modularity;

namespace ejada.employees;

[DependsOn(
    typeof(employeesApplicationModule),
    typeof(employeesDomainTestModule)
)]
public class employeesApplicationTestModule : AbpModule
{

}
