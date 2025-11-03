using Xunit;

namespace ejada.employees.EntityFrameworkCore;

[CollectionDefinition(employeesTestConsts.CollectionDefinitionName)]
public class employeesEntityFrameworkCoreCollection : ICollectionFixture<employeesEntityFrameworkCoreFixture>
{

}
