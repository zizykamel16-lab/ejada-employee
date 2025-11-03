using ejada.employees.Samples;
using Xunit;

namespace ejada.employees.EntityFrameworkCore.Domains;

[Collection(employeesTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<employeesEntityFrameworkCoreTestModule>
{

}
