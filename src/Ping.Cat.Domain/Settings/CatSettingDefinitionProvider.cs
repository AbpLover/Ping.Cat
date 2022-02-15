using Volo.Abp.Settings;

namespace Ping.Cat.Settings;

public class CatSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CatSettings.MySetting1));
    }
}
