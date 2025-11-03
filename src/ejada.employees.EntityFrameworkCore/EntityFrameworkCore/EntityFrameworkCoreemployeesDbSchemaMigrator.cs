using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ejada.employees.Data;
using Volo.Abp.DependencyInjection;

namespace ejada.employees.EntityFrameworkCore;

public class EntityFrameworkCoreemployeesDbSchemaMigrator
    : IemployeesDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreemployeesDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the employeesDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<employeesDbContext>()
            .Database
            .MigrateAsync();
    }
}
