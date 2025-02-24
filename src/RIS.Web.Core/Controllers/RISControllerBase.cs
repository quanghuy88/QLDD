using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace RIS.Controllers
{
    public abstract class RISControllerBase: AbpController
    {
        protected RISControllerBase()
        {
            LocalizationSourceName = RISConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
