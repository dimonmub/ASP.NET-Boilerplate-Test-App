using System.Reflection;
using Abp.Modules;

namespace TestApp
{
    [DependsOn(typeof(TestAppCoreModule))]
    public class TestAppApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
