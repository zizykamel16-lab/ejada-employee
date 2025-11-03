using Volo.Abp.Settings;

namespace ejada.employees.Settings;

public class employeesSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(employeesSettings.MySetting1));
    }
}
