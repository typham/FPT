using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Data.Infrastructure
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private FPTDbcontext _dbContext;
        private IDbFactory _dbFactory;
        private DbSet<T> _dbSet;

        public FPTDbcontext DbContext {
            get {
                return _dbContext ?? (_dbContext = _dbFactory.Init());
            }
        }

        public RepositoryBase(IDbFactory DbFactory)
        {
            this._dbFactory = DbFactory;
            _dbSet = DbContext.Set<T>();
        }
        public T Add(T entity)
        {
            return _dbSet.Add(entity);
        }

        public void Delete(object id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public T GetSingle(Expression<Func<T, bool>> expression)
        {
            return _dbSet.SingleOrDefault(expression);
        }
    }
}
