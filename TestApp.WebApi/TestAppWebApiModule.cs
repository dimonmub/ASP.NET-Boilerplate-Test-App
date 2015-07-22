using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace TestApp
{
    [DependsOn(typeof(AbpWebApiModule), typeof(TestAppApplicationModule))]
    public class TestAppWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(TestAppApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
