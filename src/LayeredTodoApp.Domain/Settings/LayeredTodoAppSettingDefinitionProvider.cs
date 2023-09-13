using Volo.Abp.Settings;

namespace LayeredTodoApp.Settings;

public class LayeredTodoAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LayeredTodoAppSettings.MySetting1));
    }
}
