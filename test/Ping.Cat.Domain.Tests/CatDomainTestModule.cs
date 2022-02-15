using Ping.Cat.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Ping.Cat;

[DependsOn(
    typeof(CatEntityFrameworkCoreTestModule)
    )]
public class CatDomainTestModule : AbpModule
{

}
