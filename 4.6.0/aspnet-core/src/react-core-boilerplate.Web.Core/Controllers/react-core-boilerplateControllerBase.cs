using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace react-core-boilerplate.Controllers
{
    public abstract class react-core-boilerplateControllerBase: AbpController
    {
        protected react-core-boilerplateControllerBase()
        {
            LocalizationSourceName = react-core-boilerplateConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
