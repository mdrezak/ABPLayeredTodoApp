using LayeredTodoApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LayeredTodoApp.Permissions;

public class LayeredTodoAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LayeredTodoAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(LayeredTodoAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LayeredTodoAppResource>(name);
    }
}
