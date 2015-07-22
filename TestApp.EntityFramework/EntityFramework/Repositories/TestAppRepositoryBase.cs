using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TestApp.EntityFramework.Repositories
{
    public abstract class TestAppRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TestAppDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TestAppRepositoryBase(IDbContextProvider<TestAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TestAppRepositoryBase<TEntity> : TestAppRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TestAppRepositoryBase(IDbContextProvider<TestAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
