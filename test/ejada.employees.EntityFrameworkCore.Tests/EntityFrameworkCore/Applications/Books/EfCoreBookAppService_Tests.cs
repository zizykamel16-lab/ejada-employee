using ejada.employees.Books;
using Xunit;

namespace ejada.employees.EntityFrameworkCore.Applications.Books;

[Collection(employeesTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<employeesEntityFrameworkCoreTestModule>
{

}