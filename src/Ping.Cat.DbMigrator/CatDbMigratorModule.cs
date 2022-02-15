using Ping.Cat.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Ping.Cat.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CatEntityFrameworkCoreModule),
    typeof(CatApplicationContractsModule)
    )]
public class CatDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
