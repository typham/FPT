using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Data.Infrastructure
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        T GetSingle(Expression<Func<T, bool>> expression);
        T Add(T entity);
        void Update(T entity);

        void Delete(object id);

        void Save();
    }
}
