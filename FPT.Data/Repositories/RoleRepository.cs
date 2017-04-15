using FPT.Data.Infrastructure;
using FPT.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Data.Repositories
{
    public interface IRoleRepository:IRepository<Role>
    {

    }
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }
    }
}
