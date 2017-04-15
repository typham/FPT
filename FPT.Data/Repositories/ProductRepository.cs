using FPT.Data.Infrastructure;
using FPT.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Data.Repositories
{
    public interface IProductRepository:IRepository<Product>
    {

    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }
    }
}
