using Abp.Web.Mvc.Views;

namespace TestApp.Web.Views
{
    public abstract class TestAppWebViewPageBase : TestAppWebViewPageBase<dynamic>
    {

    }

    public abstract class TestAppWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TestAppWebViewPageBase()
        {
            LocalizationSourceName = TestAppConsts.LocalizationSourceName;
        }
    }
}