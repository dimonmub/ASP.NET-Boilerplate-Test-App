using System.Data.Entity.Migrations;

namespace TestApp.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<TestApp.EntityFramework.TestAppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TestApp";
        }

        protected override void Seed(TestApp.EntityFramework.TestAppDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
