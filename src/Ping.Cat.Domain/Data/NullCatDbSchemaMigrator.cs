using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Ping.Cat.Data;

/* This is used if database provider does't define
 * ICatDbSchemaMigrator implementation.
 */
public class NullCatDbSchemaMigrator : ICatDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
