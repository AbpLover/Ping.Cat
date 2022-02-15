using Volo.Abp.Modularity;

namespace Ping.Cat;

[DependsOn(
    typeof(CatApplicationModule),
    typeof(CatDomainTestModule)
    )]
public class CatApplicationTestModule : AbpModule
{

}
