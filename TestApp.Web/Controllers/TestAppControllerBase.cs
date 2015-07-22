using Abp.Web.Mvc.Controllers;

namespace TestApp.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class TestAppControllerBase : AbpController
    {
        protected TestAppControllerBase()
        {
            LocalizationSourceName = TestAppConsts.LocalizationSourceName;
        }
    }
}