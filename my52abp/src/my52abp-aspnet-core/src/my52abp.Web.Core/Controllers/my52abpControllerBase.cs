using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace my52abp.Controllers
{
    public abstract class my52abpControllerBase: AbpController
    {
        protected my52abpControllerBase()
        {
            LocalizationSourceName = my52abpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
