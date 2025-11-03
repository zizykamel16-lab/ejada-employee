using Microsoft.AspNetCore.Builder;
using ejada.employees;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("ejada.employees.Web.csproj"); 
await builder.RunAbpModuleAsync<employeesWebTestModule>(applicationName: "ejada.employees.Web");

public partial class Program
{
}
