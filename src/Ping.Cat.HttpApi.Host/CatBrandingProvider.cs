using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Ping.Cat;

[Dependency(ReplaceServices = true)]
public class CatBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Cat";
}
