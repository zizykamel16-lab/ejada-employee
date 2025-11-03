using ejada.employees.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ejada.employees.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(employeesEntityFrameworkCoreModule),
    typeof(employeesApplicationContractsModule)
)]
public class employeesDbMigratorModule : AbpModule
{
}
