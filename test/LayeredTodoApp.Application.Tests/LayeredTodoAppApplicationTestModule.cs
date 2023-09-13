using Volo.Abp.Modularity;

namespace LayeredTodoApp;

[DependsOn(
    typeof(LayeredTodoAppApplicationModule),
    typeof(LayeredTodoAppDomainTestModule)
    )]
public class LayeredTodoAppApplicationTestModule : AbpModule
{

}
