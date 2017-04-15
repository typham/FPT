using FPT.Data.Infrastructure;
using FPT.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT.Data.Repositories
{
    public interface IProductCategoryRepository:IRepository<ProductCategory>
    {

    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }
    }
}
