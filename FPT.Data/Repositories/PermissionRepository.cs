using FPT.Data.Infrastructure;
using FPT.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Data.Repositories
{
    public interface IPermissionRepository:IRepository<Permission>
    {

    }
    public class PermissionRepository : RepositoryBase<Permission>, IPermissionRepository
    {
        public PermissionRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }
    }
}
