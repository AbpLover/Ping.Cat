using System;
using System.Collections.Generic;
using System.Text;
using Ping.Cat.Localization;
using Volo.Abp.Application.Services;

namespace Ping.Cat;

/* Inherit your application services from this class.
 */
public abstract class CatAppService : ApplicationService
{
    protected CatAppService()
    {
        LocalizationResource = typeof(CatResource);
    }
}
