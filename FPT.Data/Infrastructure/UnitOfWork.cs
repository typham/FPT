using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbFactory _dbFactory;

        private FPTDbcontext _dbContext;

        public FPTDbcontext DbContext {
            get {
                return _dbContext ?? (_dbContext = _dbFactory.Init());
            }
        }

        public UnitOfWork(IDbFactory DbFactory)
        {
            this._dbFactory = DbFactory;
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
