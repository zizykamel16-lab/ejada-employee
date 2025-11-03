using System.Threading.Tasks;

namespace ejada.employees.Data;

public interface IemployeesDbSchemaMigrator
{
    Task MigrateAsync();
}
