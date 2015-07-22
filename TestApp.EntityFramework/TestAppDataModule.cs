using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using TestApp.EntityFramework;

namespace TestApp
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(TestAppCoreModule))]
    public class TestAppDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<TestAppDbContext>(null);
        }
    }
}
