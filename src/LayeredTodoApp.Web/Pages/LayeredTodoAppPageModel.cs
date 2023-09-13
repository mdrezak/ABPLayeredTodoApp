using LayeredTodoApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LayeredTodoApp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class LayeredTodoAppPageModel : AbpPageModel
{
    protected LayeredTodoAppPageModel()
    {
        LocalizationResourceType = typeof(LayeredTodoAppResource);
    }
}
