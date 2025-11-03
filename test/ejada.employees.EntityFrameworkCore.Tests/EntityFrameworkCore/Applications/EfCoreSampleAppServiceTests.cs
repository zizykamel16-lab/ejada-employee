using ejada.employees.Samples;
using Xunit;

namespace ejada.employees.EntityFrameworkCore.Applications;

[Collection(employeesTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<employeesEntityFrameworkCoreTestModule>
{

}
