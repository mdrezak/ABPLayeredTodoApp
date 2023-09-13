using System;
using System.Collections.Generic;
using System.Text;
using LayeredTodoApp.Localization;
using Volo.Abp.Application.Services;

namespace LayeredTodoApp;

/* Inherit your application services from this class.
 */
public abstract class LayeredTodoAppAppService : ApplicationService
{
    protected LayeredTodoAppAppService()
    {
        LocalizationResource = typeof(LayeredTodoAppResource);
    }
}
