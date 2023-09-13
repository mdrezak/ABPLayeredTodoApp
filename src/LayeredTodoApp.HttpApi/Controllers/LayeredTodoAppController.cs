using LayeredTodoApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LayeredTodoApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LayeredTodoAppController : AbpControllerBase
{
    protected LayeredTodoAppController()
    {
        LocalizationResource = typeof(LayeredTodoAppResource);
    }
}
