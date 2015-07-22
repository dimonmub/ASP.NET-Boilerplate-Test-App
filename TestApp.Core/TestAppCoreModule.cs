using System.Reflection;
using Abp.Modules;

namespace TestApp
{
    public class TestAppCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
