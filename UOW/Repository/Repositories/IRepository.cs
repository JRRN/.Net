using System.Data.Entity;
using System.Linq;

namespace Repository.Repositories
{
    public interface IRepository<TDbContext,TEntity> 
        where TEntity : class
        where TDbContext : DbContext
    {
        TEntity GetById(object id);
        IQueryable<TEntity> QueryAll();
        void Update(TEntity entity);
        void Create(TEntity entity);
        void Remove(TEntity entity);
    }
}