using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LayeredTodoApp.Data;

/* This is used if database provider does't define
 * ILayeredTodoAppDbSchemaMigrator implementation.
 */
public class NullLayeredTodoAppDbSchemaMigrator : ILayeredTodoAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
