using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ejada.employees.Data;

/* This is used if database provider does't define
 * IemployeesDbSchemaMigrator implementation.
 */
public class NullemployeesDbSchemaMigrator : IemployeesDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
