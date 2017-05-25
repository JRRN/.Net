using System.Collections.Generic;

namespace Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAllEntities();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        bool InsertRange(IEnumerable<TEntity> collectionEntities);
        bool DeleteRange(IEnumerable<TEntity> collectionEntities);
    }
}