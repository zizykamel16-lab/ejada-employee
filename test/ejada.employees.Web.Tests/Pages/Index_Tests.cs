using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ejada.employees.Pages;

[Collection(employeesTestConsts.CollectionDefinitionName)]
public class Index_Tests : employeesWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
