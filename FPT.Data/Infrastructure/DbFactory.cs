using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {

        private FPTDbcontext _dbcontext;

        public FPTDbcontext Init()
        {
            return _dbcontext ?? (_dbcontext = new FPTDbcontext());
        }

        public override void DisposeBase()
        {
            _dbcontext.Dispose();
        }
    }
}
