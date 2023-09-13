using LayeredTodoApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LayeredTodoApp;

[DependsOn(
    typeof(LayeredTodoAppEntityFrameworkCoreTestModule)
    )]
public class LayeredTodoAppDomainTestModule : AbpModule
{

}
