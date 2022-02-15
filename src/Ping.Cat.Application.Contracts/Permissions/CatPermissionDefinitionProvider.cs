using Ping.Cat.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Ping.Cat.Permissions;

public class CatPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CatPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CatPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CatResource>(name);
    }
}
