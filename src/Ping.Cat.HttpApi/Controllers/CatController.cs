using Ping.Cat.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Ping.Cat.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CatController : AbpControllerBase
{
    protected CatController()
    {
        LocalizationResource = typeof(CatResource);
    }
}
