using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace LayeredTodoApp.Web;

[Dependency(ReplaceServices = true)]
public class LayeredTodoAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "LayeredTodoApp";
}
