using System.Threading.Tasks;

namespace Ping.Cat.Data;

public interface ICatDbSchemaMigrator
{
    Task MigrateAsync();
}
