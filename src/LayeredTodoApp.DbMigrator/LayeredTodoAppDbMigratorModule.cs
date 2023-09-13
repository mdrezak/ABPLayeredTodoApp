using LayeredTodoApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace LayeredTodoApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LayeredTodoAppEntityFrameworkCoreModule),
    typeof(LayeredTodoAppApplicationContractsModule)
    )]
public class LayeredTodoAppDbMigratorModule : AbpModule
{
}
