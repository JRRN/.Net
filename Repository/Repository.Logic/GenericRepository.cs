using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Logic
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal DbContext _context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            dbSet = context.Set<TEntity>();
        }
        public IEnumerable<TEntity> GetAllEntities()
        {
            return _context.Set<TEntity>().AsEnumerable();
        }
        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        public void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
