using FPT.Data.Infrastructure;
using FPT.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Data.Repositories
{
    public interface IUserRepository:IRepository<User>
    {

    }
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }
    }
}
