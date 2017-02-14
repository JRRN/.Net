using System.Linq;

namespace Repository.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(object id);
        IQueryable<TEntity> QueryAll();
        void Update(TEntity entity);
        void Create(TEntity entity);
        void Remove(TEntity entity);
    }
}