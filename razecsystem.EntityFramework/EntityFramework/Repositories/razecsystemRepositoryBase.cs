using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace razecsystem.EntityFramework.Repositories
{
    public abstract class razecsystemRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<razecsystemDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected razecsystemRepositoryBase(IDbContextProvider<razecsystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class razecsystemRepositoryBase<TEntity> : razecsystemRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected razecsystemRepositoryBase(IDbContextProvider<razecsystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
