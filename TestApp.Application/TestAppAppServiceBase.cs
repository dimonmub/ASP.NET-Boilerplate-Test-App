using Abp.Application.Services;

namespace TestApp
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class TestAppAppServiceBase : ApplicationService
    {
        protected TestAppAppServiceBase()
        {
            LocalizationSourceName = TestAppConsts.LocalizationSourceName;
        }
    }
}