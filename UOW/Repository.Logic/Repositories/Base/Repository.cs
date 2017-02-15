using System.Data.Entity;
using System.Linq;
using Repository.Repositories;

namespace Repository.Logic.Repositories.Base
{
    public class Repository<TDbContext, TEntity> : IRepository<TDbContext, TEntity>
        where TEntity : class
        where TDbContext : DbContext
    {
        private readonly TDbContext _context;
        protected DbSet<TEntity> dbSet;

        public Repository(TDbContext context)
        {
            _context = context;
            dbSet = _context.Set<TEntity>();
        }

        public TEntity GetById(object id)
        {
            return dbSet.Find(id);
        }

        public IQueryable<TEntity> QueryAll()
        {
            return dbSet;
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Create(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Remove(TEntity entity)
        {
            dbSet.Remove(entity);
            _context.Entry(entity).State = EntityState.Deleted;
        }
    }
}