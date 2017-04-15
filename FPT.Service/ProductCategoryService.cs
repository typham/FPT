using FPT.Data.Infrastructure;
using FPT.Data.Repositories;
using FPT.Model.Models;
using System.Collections.Generic;

namespace FPT.Service
{
    public interface IProductCategoryService
    {
        IEnumerable<ProductCategory> GetAll();
        ProductCategory GetById(int id);
        ProductCategory Add(ProductCategory entity);
        void Update(ProductCategory entity);
        void Delete(int id);
        void Save();
    }
    public class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryRepository _productCategoryRepository;
        private IUnitOfWork _uow;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._productCategoryRepository = productCategoryRepository;
            this._uow = unitOfWork;
        }
        public ProductCategory Add(ProductCategory entity)
        {
            return _productCategoryRepository.Add(entity);
        }

        public void Delete(int id)
        {
            _productCategoryRepository.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _productCategoryRepository.GetAll();
        }

        public ProductCategory GetById(int id)
        {
            return _productCategoryRepository.GetById(id);
        }

        public void Update(ProductCategory entity)
        {
            _productCategoryRepository.Update(entity);
        }

        public void Save()
        {
            _uow.Commit();
        }
    }
}
