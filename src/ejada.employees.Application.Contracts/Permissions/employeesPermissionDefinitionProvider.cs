using ejada.employees.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace ejada.employees.Permissions;

public class employeesPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(employeesPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(employeesPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(employeesPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(employeesPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(employeesPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(employeesPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<employeesResource>(name);
    }
}
